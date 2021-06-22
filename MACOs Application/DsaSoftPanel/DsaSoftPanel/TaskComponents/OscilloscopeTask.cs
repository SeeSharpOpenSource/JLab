using System;
using System.Collections.Generic;
using System.Threading;
using DsaSoftPanel.Enumeration;
using SeeSharpTools.JY.ArrayUtility;

namespace DsaSoftPanel
{
    public class OscilloscopeTask
    {
        private delegate void ShowErrMethod(string text, string caption);

        private ShowErrMethod _showErrMethod;

        private SoftPanelGlobalInfo _globalInfo;
        private DsaSoftPanelForm _parentForm;
        private Thread _taskThread;
        private AutoResetEvent _waitEvent = new AutoResetEvent(false);
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
            _taskThread = new Thread(TaskWork);
            _taskThread.IsBackground = true;
            this._parentForm = parentForm;
            _taskThread.Start();
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
                    _globalInfo.AITask.Start();
                }
                finally
                {
                    _statusLock.Exit();
                }
                TaskRunning = true;
                _waitEvent.Set();
            }
            catch (Exception ex)
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
                _aiData = new double[_samplesPerView, _channelCount];
                _globalInfo.AdaptDispBuf(_plotSize);
            }
            _timeOut = GetTimeOut();
        }

        public void Stop()
        {
            if (null == _globalInfo?.AITask)
            {
                return;
            }
            bool getLock = false;
            try
            {
                TaskRunning = false;
                // 如果使能Trigger，且没有被触发必须直接stop，因为此时ReadData仍然有_stautsLock，申请时会导致死锁。
                if (!_globalInfo.AITask.TriggerEnabled || _globalInfo.Status != TaskStatus.Trigger)
                {
                    _statusLock.Enter(ref getLock);
                }
                _globalInfo.AITask.Stop();
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
            while (true)
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
                    // not need
//                    if (ex is ThreadAbortException)
//                    {
//                        break;
//                    }
                }
            }
        }

        private void ReadAndPlot()
        {
            bool viewChanged = false;
            bool getLock = false;
            try
            {
                _statusLock.Enter(ref getLock);
                if (!TaskRunning)
                {
                    _statusLock.Exit();
                    _waitEvent.WaitOne();
                    getLock = false;
                    _statusLock.Enter(ref getLock);
                    _globalInfo.Status = _globalInfo.AITask.TriggerEnabled ? TaskStatus.Trigger : TaskStatus.Running;
                }
                if (_samplesPerView != _globalInfo.SamplesPerView)
                {
                    RefreshRunTimeParameters();
                    viewChanged = true;
                }
                _globalInfo.AITask.ReadData(ref _aiData, _samplesPerView, _timeOut);
                _globalInfo.Status = TaskStatus.Running;
            }
            finally
            {
                if (getLock)
                {
                    _statusLock.Exit();
                }
            }

            if (_globalInfo.RunStatus)
            {
                if (_globalInfo.EnableChannelCount == 1)
                {
                    //ignore
                }
                getLock = false;
                try
                {
                    _globalInfo.DispBufLock.Enter(ref getLock);
                    TransposeWithFunc();
                    _globalInfo.SamplesInChart = _samplesPerView;
                }
                finally
                {
                    if (getLock)
                    {
                        _globalInfo.DispBufLock.Exit();
                    }
                }
                _parentForm.Invoke(_globalInfo.ChartViewPlot, _globalInfo.DispBuf.GetRange(0, _plotSize), 
                    _xStart, _xIncrement, _globalInfo.SamplesInChart);
                
            }
            if (viewChanged)
            {
                _parentForm.Invoke(new Action(_parentForm.RefreshStatusLabel));
            }
        }

        private void TransposeWithFunc()
        {
            int dataGain;
            int pointIndex = 0;
            for (int i = 0; i < _aiData.GetLength(1); i++)
            {
                dataGain = (int)_globalInfo.Channels[i].Probe * (int)_globalInfo.Channels[i].Unit;
                // for performance
                if (1 == dataGain)
                {
                    for (int j = 0; j < _aiData.GetLength(0); j++)
                    {
                        _globalInfo.DispBuf[pointIndex++] = _aiData[j, i];
                    }
                }
                else
                {
                    for (int j = 0; j < _aiData.GetLength(0); j++)
                    {
                        _globalInfo.DispBuf[pointIndex++] = _aiData[j, i] * dataGain;
                    }
                }
            }
        }

        private int GetTimeOut()
        {
            // TODO 暂时统一配置为-1
//            return (int)(_samplesPerView / _globalInfo.AITask.GetSampleRate() * Constants.TimeOutRatio * 1000) + 100;
            return -1;
        }
    }
}