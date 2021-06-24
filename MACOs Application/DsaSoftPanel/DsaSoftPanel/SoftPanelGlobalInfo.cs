using System;
using System.Collections.Generic;
using System.Threading;
using DsaSoftPanel.Data;
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
            this.ReadDataBuffer = new ReadDataBuffer();
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

        private int _channelCount;

        public int EnableChannelCount
        {
            get { return this._channelCount; }
            set { Thread.VolatileWrite(ref this._channelCount, value);}
        }

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

        /// <summary>
        /// 数据读取缓存
        /// </summary>
        public ReadDataBuffer ReadDataBuffer { get; }

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
    }
}