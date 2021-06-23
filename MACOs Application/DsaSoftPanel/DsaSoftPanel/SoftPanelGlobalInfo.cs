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
            BoardConnected = false;
            _runStatus = 1;
            EnableRange = true;
            this._dispBuf = new List<double>(Constants.DefaultDisplayBufSize);
            AdaptDispBuf(Constants.DefaultDisplayBufSize);
        }

        public delegate void PlotDataMethod(IList<double> data, double start, double increment, int sampleSize);
        public delegate void WaveformPlotMethod(double[,] data, double start, double increment, int sampleSize);
        public WaveformPlotMethod WaveformPlot;
        public PlotDataMethod FunctionPlot;
        public Action<double[], double[]> ShowRange;

        private static SoftPanelGlobalInfo _instance = null;

        public static SoftPanelGlobalInfo GetInstance()
        {
            return _instance ?? (_instance = new SoftPanelGlobalInfo());
        }

        public AITask.AITask AITask { get; set; }

        public int SamplesPerView { get; set; }

        public int SampleRate => (int)(AITask?.GetSampleRate() ?? 0);

        public int EnableChannelCount => AITask.GetChannelCount();

        public bool BoardConnected { get; set; }

        public BoardType BoardType { get; set; }

        public int BoardId { get; set; }

        private int _samplesInChart = 0;
        public int SamplesInChart
        {
            get { return this._samplesInChart;}
            set
            {
                if (value == _samplesInChart)
                {
                    return;
                }
                Thread.VolatileWrite(ref _samplesInChart, value);
            }
        }

//        public FunctionStatus FuncStatus;

        public DsaSoftPanelForm MainForm { get; set; }

        public ReaderWriterLockSlim BufferLock = new ReaderWriterLockSlim();

        public List<ChannelConfig> Channels = new List<ChannelConfig>(Constants.MaxChannelCount);

        private int _status = (int) TaskStatus.Idle;
        public TaskStatus Status
        {
            get { return (TaskStatus) _status;}
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

        public Action ApplyConfigInRunTime { get; set; }

        // 0时暂停，1时运行
        private int _runStatus;
        public bool IsRunning
        {
            get { return _runStatus == 1;}
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