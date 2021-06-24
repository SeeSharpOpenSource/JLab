using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SeeSharpTools.JY.ArrayUtility;
using TaskStatus = DsaSoftPanel.Enumeration.TaskStatus;

namespace DsaSoftPanel
{
    public class OscilloscopeTask
    {
        private delegate void ShowErrMethod(string text, string caption);

        private ShowErrMethod _showErrMethod;

        private SoftPanelGlobalInfo _globalInfo;
        private DsaSoftPanelForm _parentForm;
        private Task _readAndPlotTask;
        private int _plotSize;

        private SpinLock _statusLock = new SpinLock(false);
        // 0：运行；1：暂停
        private int _taskRunning = 0;

        private double[,] _aiData;
        private int _samplesPerView;
        private int _channelCount;
        private int _timeOut;

        private double _xStart;
        private double _xIncrement;

        public bool TaskRunning {
            get
            {
                return _taskRunning == 1;
            }
            set
            {
                Thread.VolatileWrite(ref _taskRunning, value ? 1 : 0);
            }
        }

        public OscilloscopeTask(DsaSoftPanelForm parentForm)
        {
            _globalInfo = SoftPanelGlobalInfo.GetInstance();
            _showErrMethod = parentForm.ShowErrorMsg;
            this._parentForm = parentForm;
        }

        public void Start()
        {
            try
            {
                bool getLock = false;
                try
                {
                    _statusLock.Enter(ref getLock);
                    RefreshRunTimeParameters();
                    this._globalInfo.ReadDataBuffer.Reset(this._globalInfo.SampleRate, this._globalInfo.EnableChannelCount);
                    _globalInfo.AITask.Start();
                }
                finally
                {
                    _statusLock.Exit();
                }
                TaskRunning = true;
                Thread.MemoryBarrier();
                this._readAndPlotTask = new Task(TaskWork);
                this._readAndPlotTask.Start();
            }
            catch (Exception)
            {
                TaskRunning = false;
                throw;
            }
        }

        private void RefreshRunTimeParameters()
        {
            _xIncrement = 1000/_globalInfo.AITask.GetSampleRate();
            _samplesPerView = _globalInfo.SamplesPerView;
            _xStart = 0;
            _channelCount = _globalInfo.EnableChannelCount;
            if (null == _aiData || _aiData.GetLength(0) != _samplesPerView || _aiData.GetLength(1) != _channelCount)
            {
                _plotSize = _samplesPerView*_channelCount;
                if (this._plotSize > Constants.MaxPointsPerView)
                {
                    this._plotSize = Constants.MaxPointsPerView/this._channelCount*this._channelCount;
                    this._samplesPerView = this._plotSize/this._channelCount;
                }
                _aiData = new double[_samplesPerView, _channelCount];
            }
            _timeOut = GetTimeOut();
        }

        public async Task Stop()
        {
            if (null == _globalInfo?.AITask)
            {
                return;
            }
            bool getLock = false;
            try
            {
                TaskRunning = false;
                if (null != this._readAndPlotTask)
                {
                    await this._readAndPlotTask;
                    _globalInfo.AITask.Stop();
                }
                // 如果使能Trigger，且没有被触发必须直接stop，因为此时ReadData仍然有_stautsLock，申请时会导致死锁。
                if (!_globalInfo.AITask.TriggerEnabled || _globalInfo.Status != TaskStatus.Trigger)
                {
                    _statusLock.Enter(ref getLock);
                }
                _globalInfo.Status = TaskStatus.Idle;
            }
            finally
            {
                if (getLock)
                {
                    _statusLock.Exit();
                }
            }
        }

        private void TaskWork()
        {
            while (TaskRunning)
            {
                try
                {
                    ReadAndPlot();
                }
                catch (Exception ex)
                {
                    if (TaskRunning)
                    {
                        Stop();
                        _globalInfo.Status = TaskStatus.Error;
                        _parentForm.Invoke(_showErrMethod, ex.Message, "Task Error");
                    }
                }
            }
        }

        private void TransposeDataToCache()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            bool getLock = false;
            try
            {
                getLock = _globalInfo.BufferLock.TryEnterWriteLock(Constants.BufferWriteTimeout);
                if (!getLock)
                {
                    return;
                }
                this._globalInfo.ReadDataBuffer.UpdateDataBuffer(this._aiData);
            }
            finally
            {
                if (getLock)
                {
                    _globalInfo.BufferLock.ExitWriteLock();
                }
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }

        private async void ReadAndPlot()
        {
            bool viewChanged = false;
            bool getLock = false;
            try
            {
                _statusLock.Enter(ref getLock);
                if (_samplesPerView != _globalInfo.SamplesPerView)
                {
                    RefreshRunTimeParameters();
                    viewChanged = true;
                }

                _globalInfo.AITask.ReadData(ref _aiData, _samplesPerView, _timeOut);
                _globalInfo.Status = TaskStatus.Running;
            }
            catch (Exception ex)
            {
                // 如果是超时错误则继续执行
                if (ex.Message.Contains("TimeOut"))
                {
                    return;
                }
                throw;
            }
            finally
            {
                if (getLock)
                {
                    _statusLock.Exit();
                }
            }
            Task transposeTask = null;
            transposeTask = Task.Run((Action)TransposeDataToCache);
            _globalInfo.SamplesInChart = _samplesPerView;
            _parentForm.Invoke(_globalInfo.WaveformPlot, this._aiData, _xStart, _xIncrement, _globalInfo.SamplesInChart);
            if (viewChanged)
            {
                _parentForm.Invoke(new Action(_parentForm.RefreshStatusLabel));
            }
            await transposeTask;
        }
        

        private int GetTimeOut()
        {
            // TODO 暂时统一配置为1000
//            return (int)(_samplesPerView / _globalInfo.AITask.GetSampleRate() * Constants.TimeOutRatio * 1000) + 100;
            return 1500;
        }
    }
}