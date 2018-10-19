using System;
using System.Collections.Generic;
using System.Threading;
using DsaSoftPanel.Enumeration;
using DsaSoftPanel.ScopeComponents;
using DsaSoftPanel.TaskComponents;

namespace DsaSoftPanel
{
    public class SoftPanelGlobalInfo
    {
        private SoftPanelGlobalInfo()
        {
            AITask = null;
            SamplesPerView = 1000;
            EnableChannelCount = 1;
            BoardConnected = false;
            _runStatus = 1;
            EnableRange = true;
            this._dispBuf = new List<double>(Constants.DefaultDisplayBufSize);
            AdaptDispBuf(Constants.DefaultDisplayBufSize);
        }

        public delegate void PlotDataMethod(IList<double> data, double start, double increment, int sampleSize);
        public PlotDataMethod ChartViewPlot;
        public PlotDataMethod FunctionPlot;
        public Action<double[], double[]> ShowRange;

        private static SoftPanelGlobalInfo _instance = null;

        public static SoftPanelGlobalInfo GetInstance()
        {
            if (null == _instance)
            {
                _instance = new SoftPanelGlobalInfo();
            }
            return _instance;
        }

        public AITask.AITask AITask { get; set; }

        public int SamplesPerView { get; set; }

        public int SampleRate
        {
            get
            {
                return (int)(AITask?.GetSampleRate() ?? 0);
            }
        }

        public int EnableChannelCount { get; set; }

        public bool BoardConnected { get; set; }

        public BoardType BoardType { get; set; }

        public int BoardId { get; set; }

        private int _samplesInChart = 0;
        public int SamplesInChart
        {
            get {return _samplesInChart;}
            set
            {
                if (value == _samplesInChart)
                {
                    return;
                }
                Interlocked.Exchange(ref _samplesInChart, value);
            }
        }

//        public FunctionStatus FuncStatus;

        public DsaSoftPanelForm MainForm { get; set; }

        public SpinLock DispBufLock = new SpinLock(false);

        public List<ChannelConfig> Channels = new List<ChannelConfig>(Constants.MaxChannelCount);

        private int _status = (int) TaskStatus.Idle;
        public TaskStatus Status
        {
            get { return (TaskStatus) _status; }
            set
            {
                int statusValue = (int) value;
                if (statusValue == _status)
                {
                    return;
                }
                Thread.VolatileWrite(ref _status, statusValue);
            }
        }

        private List<double> _dispBuf;
        public List<double> DispBuf
        {
            get
            {
                return _dispBuf;
            }
            set
            {
                _dispBuf = value;
            }
        }

        public Action ApplyConfigInRunTime { get; set; }

        // 0时暂停，1时运行
        private int _runStatus;
        public bool RunStatus 
        {
            get
            {
                return _runStatus == 1;
            }
            set
            {
                Thread.VolatileWrite(ref _runStatus, value ? 1 : 0);
            }
        }

        public bool EnableRange { get; set; }

        public void AdaptDispBuf(int bufCount)
        {
            // 如果需要的数据小于默认大小，buffer又大于8倍，需要重新匹配buffer大小
            if (bufCount > _dispBuf.Capacity || _dispBuf.Capacity > 8*bufCount)
            {
                _dispBuf.Clear();
                _dispBuf.Capacity = bufCount*2;
            }
            // 如果buffer太小则自动填充到目标大小
            if (bufCount > _dispBuf.Count)
            {
                _dispBuf.AddRange(new double[bufCount - _dispBuf.Count]);
            }
        }

    }
}