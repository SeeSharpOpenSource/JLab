using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DsaSoftPanel.Enumeration;
using DsaSoftPanel.FunctionUtility;

namespace DsaSoftPanel.TaskComponents
{
    public class FunctionTask : TaskBase
    {
        private Task _functionTask;
        private readonly DsaSoftPanelForm _parentForm;
        private CancellationTokenSource _cancellation;

        private int _functionType;

        public FunctionType FunctionType
        {
            get { return (FunctionType) _functionType; }
            set
            {
                Thread.VolatileWrite(ref _functionType, (int) value);
            }
        }

        private volatile FunctionBase _function;

        public FunctionTask(DsaSoftPanelForm parentForm)
        {
            this._parentForm = parentForm;
            this.FunctionType = FunctionType.None;
        }

        public void Start()
        {
            _function?.RefreshConfigForm();
            this.InitialDataBufferCache();
            _cancellation = new CancellationTokenSource();
            this._functionTask = new Task(FunctionExecutionTask, this._cancellation.Token);
            this._functionTask.Start();
            _channelRangeHigh = new double[8];
            _channelRangeLow = new double[8];
        }

        public async Task Stop()
        {
            if (null == this._functionTask || this._functionTask.IsCanceled)
            {
                return;
            }
            try
            {
                this._cancellation.Cancel();
                if (null != this._functionTask)
                {
                    await this._functionTask;
                }
                this._functionTask = null;
            }
            catch (Exception ex)
            {
                Task.Run(async() =>
                {
                    await this._parentForm.StopTask();
                    this._parentForm.ShowErrorMsg(ex.Message);
                });
            }
        }

        public void RefreshFunctionConfigArea()
        {
            _function?.RefreshConfigForm();
        }

        private void FunctionExecutionTask()
        {
            Thread.Sleep(2*(_globalInfo.SamplesPerView/_globalInfo.SampleRate));
            try
            {
                while (!this._cancellation.IsCancellationRequested)
                {
                    Thread.Sleep(Constants.FuncWaitTime);
                    // function变更时联动修改主界面的配置
                    UpdateFunctionViewIfNecessary();
                    // 清空数据buffer并拷贝最新的数据
                    bool isUpdateSuccess = UpdateDataCache();
                    if (!isUpdateSuccess)
                    {
                        continue;
                    }
                    if (_globalInfo.EnableRange)
                    {
                        ShowDataRange();
                    }
                    _function?.ExecuteAndShow();
                }
            }
            catch (ThreadAbortException)
            {
                // ignore
            }
            catch (Exception ex)
            {
                Task.Run(async () =>
                {
                    await this._parentForm.StopTask();
                    this._parentForm.ShowErrorMsg(ex.Message);
                });
            }
        }

        private void UpdateFunctionViewIfNecessary()
        {
            // 如果当前函数类型不匹配则重新创建新的function
            if ((null == this._function && FunctionType != FunctionType.None) ||
                (null != this._function && !this._function.IsTypeFit(FunctionType)))
            {
                this._globalInfo.MainForm.Invoke(new Action(() =>
                {
                    this._function = FunctionBase.CreateFunction(FunctionType, this.DataCache);
                    this._parentForm.InitFunctionResultArea(this._function);
                    this._parentForm.InitFunctionConfigArea(this._function);
                    RefreshFunctionConfigArea();
                }));
            }
        }

        private double[] _channelRangeHigh;
        private double[] _channelRangeLow;

        private void ShowDataRange()
        {
            for (int i = 0; i < this.DataCache.Count; i++)
            {
                double[] readData = this.DataCache[i];
                double max = readData[0];
                double min = readData[0];
                foreach (double element in readData)
                {
                    if (element > max)
                    {
                        max = element;
                    }
                    else if (element < min)
                    {
                        min = element;
                    }
                }
                this._channelRangeHigh[i] = max;
                this._channelRangeLow[i] = min;
            }
            _parentForm.BeginInvoke(_globalInfo.ShowRange, _channelRangeHigh, _channelRangeLow);
        }
    }
}
