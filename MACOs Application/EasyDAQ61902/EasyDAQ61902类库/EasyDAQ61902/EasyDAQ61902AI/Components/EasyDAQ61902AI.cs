using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Threading;

namespace EasyDAQ
{
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(EasyDAQ61902AI), "Components.EasyAI.bmp")]
    [DefaultEvent("DataReceived")] //双击组件生成的默认事件                                                                                                                                                                                                                                                                                                         
    public partial class EasyDAQ61902AI : Component
    {
        #region Private Fields
        private AnalogInputEngine _aiTask;
        private int _boardNum = 0;
        private double _sampleRate = 10000;
        private int _samplesToAcquire = 1000;
        private List<int> _selectedChannels = new List<int>() { 0 };
        private double _highRange = 10;
        private double _lowRange = -10;
        private string _aiTerminal = "RSE";
        private bool _continuousMode = false;
        private double[,] _data = new double[,] { };
        private double[,] _tData = new double[,] { };
        private double[] _chData = new double[] { };
        private Thread _fetchThread;
        private bool _isRunning = false;
        private int _availableSamples = 0;
        private bool _isConnected = false;

        #endregion Private Fields

        #region Constructor

        public EasyDAQ61902AI()
        {
            InitializeComponent();
            _aiTask = new AnalogInputEngine();
        }

        public EasyDAQ61902AI(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            _aiTask = new AnalogInputEngine();
        }


        ~EasyDAQ61902AI()
        {
            _isRunning = false;
            DataReceived = null;
            _aiTask?.Stop();
        }


        #endregion Constructor

        #region Public Properties

        [Category("DAQ Setting")]
        [Description("板卡号")]
        public int BoardID
        {
            get { return _boardNum; }
            set { _boardNum = value; }
        }

        [Category("DAQ Setting")]
        [Description("采样率(Samples/second)")]
        public double SampleRate
        {
            get { return _sampleRate; }
            set { _sampleRate = value; }
        }

        [Editor(typeof(ChannelEditor), typeof(UITypeEditor))]
        [Category("DAQ Setting")]
        [Description("通道选择")]
        public List<int> Channels
        {
            get { return _selectedChannels; }
            set { _selectedChannels = value; }
        }

        [Category("DAQ Setting")]
        [Description("采样点数(Samples)")]
        public int SamplesToRead
        {
            get { return _samplesToAcquire; }
            set { _samplesToAcquire = value; }
        }

        [Category("DAQ Setting")]
        [Description("高量程")]
        [DefaultValue(10)]
        public double RangeHigh
        {
            get { return _highRange; }
            set { _highRange = value; }
        }

        [Category("DAQ Setting")]
        [Description("低量程")]
        [DefaultValue(-10)]
        public double RangeLow
        {
            get { return _lowRange; }
            set { _lowRange = value; }
        }

        [TypeConverter(typeof(TerminalConverter))]
        [Category("DAQ Setting")]
        [Description("连接方式")]
        public string Terminal
        {
            get { return _aiTerminal; }
            set { _aiTerminal = value; }
        }

        [Category("DAQ Setting")]
        [Description("连续采样模式")]
        [DefaultValue(false)]
        public bool ContinuousRun
        {
            get { return _continuousMode; }
            set { _continuousMode = value; }
        }

        [Category("DAQ Status")]
        [Description("驱动安装成功")]
        [DefaultValue(false)]
        [Browsable(true)]
        public bool IsDriverExisted
        {
            get { return _aiTask.IsDriverExisted; }
        }

        [Category("DAQ Status")]
        [Description("板卡初始化成功")]
        [DefaultValue(false)]
        [Browsable(false)]
        private bool IsConnected
        {
            get { return _aiTask.IsConnected; }
        }

        [Category("DAQ Status")]
        [Description("板卡缓存的采样点数")]
        [DefaultValue(false)]
        [Browsable(false)]
        public int AvailableSamples
        {
            get
            {
                if (_aiTask!=null)
                {
                    _availableSamples = _aiTask.AvailableSamples;
                }
                return _availableSamples;
            }
        }

        #endregion Public Properties

        #region Events

        public event EventHandler<EventArgs> DataReceived;
        protected virtual void OnDataReceived(EventArgs e)
        {
            DataReceived?.Invoke(this, e);
        }
        private void RemoveAllEventRegistration()
        {
            if (DataReceived!=null)
            {
                Delegate[] invokeList = DataReceived.GetInvocationList();

                if (invokeList != null)
                {
                    foreach (var item in invokeList)
                    {
                        this.Events.RemoveHandler(this, item);
                    }
                }
            }
            
        }

        #endregion Events

        #region Public Methods

        public void Start()
        {
            try
            {
                if (IsDriverExisted)
                {
                    if (_isRunning == true)
                    {
                        _isRunning = false;
                        _aiTask.Stop();
                        Thread.Sleep(100);
                    }
                    _isConnected = _aiTask.Initialize();
                    if (_isConnected)
                    {
                        for (int i = 0; i < _selectedChannels.Count; i++)
                        {
                            _aiTask.ConfigureChannel(_selectedChannels[i], _lowRange, _highRange, _aiTerminal);
                        }
                        _aiTask.SampleRate = SampleRate;
                        _aiTask.SamplesToRead = SamplesToRead;
                        _aiTask.ContinuousRun = ContinuousRun;
                        _aiTask.Start();
                        _isRunning = true;
                        _fetchThread = new Thread(FetchLoop);
                        _fetchThread.IsBackground = true;
                        _fetchThread.Start();
                    }
                    else
                    {
                        throw new Exception("Can not find the device.");
                    }
                }
            }
            catch (Exception ex)
            {
                _aiTask.Stop();
                throw new Exception(ex.Message);
            }
        }
        
        public void Stop()
        {
            try
            {
                if (IsDriverExisted)
                {
                    _fetchThread?.Abort();

                    RemoveAllEventRegistration();
                }
            }
            catch (Exception ex)
            {
                _aiTask.Stop();
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Read the data for assigned channel(task will stop after the execution when "stopAfterFinished" sets fo true)
        /// </summary>
        /// <param name="channelIndex"></param>
        /// <param name="stopAfterFinished"></param>
        /// <returns></returns>
        public double[] ReadData(int channelIndex)
        {
            try
            {
                if (_isRunning)
                {
                    _tData = _aiTask.Fetch();
                    _chData = new double[_tData.GetLength(1)];
                    for (int i = 0; i < _chData.Length; i++)
                    {
                        _chData[i] = _tData[channelIndex, i];
                    }
                    return _chData;
                }
                else
                {
                    Start();
                    _tData = _aiTask.Fetch();
                    _chData = new double[_tData.GetLength(1)];

                    for (int i = 0; i < _chData.Length; i++)
                    {
                        _chData[i] = _tData[channelIndex, i];
                    }
                    return _chData;
                }
            }
            catch (Exception ex)
            {
                //_aiTask.Stop();
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Read the data for all channels(task will stop after the execution when "stopAfterFinished" sets fo true)
        /// </summary>
        /// <param name="stopAfterFinished"></param>
        /// <returns></returns>
        public double[,] ReadData()
        {
            try
            {
                if (_isRunning)
                {
                    _tData = _aiTask.Fetch();
                    return _tData;
                }
                else
                {
                    Start();
                    _tData = _aiTask.Fetch();
                    return _tData;
                }
            }
            catch (Exception ex)
            {
                _aiTask.Stop();
                throw new Exception(ex.Message);
            }
        }

        #endregion Public Methods

        #region Private Methods

        private void FetchLoop()
        {
            try
            {
                while (_isRunning)
                {
                    if (_aiTask.AvailableSamples >= _samplesToAcquire)
                    {
                        if (_isRunning)
                        {
                            OnDataReceived(new EventArgs());
                        }
                        if (!_continuousMode) //Finite Acquisition mode
                        {
                            _isRunning = false;
                        }
                    }
                    if (_isRunning)
                    {
                        Thread.Sleep(10);
                    }
                }
            }
            catch (ThreadAbortException )
            {
                _isRunning = false;
                _aiTask.Stop();
            }
            catch (Exception ex)
            {
                _aiTask.Stop();
                //Remove the throw in case that Form closed before Error Happened
                throw new Exception("Fetch Thread internal Error\r\n" + ex.Message);
            }
        }

        #endregion Private Methods

        #region UI Utilities (Editor, Convertor)

        /// <summary>
        /// Change the Terminal enum to string array for user to configure
        /// </summary>
        private class TerminalConverter : StringConverter
        {
            private string driverClassName = AnalogInputEngine.driverClassName;

            public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
            {
                return true;
            }

            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                return new StandardValuesCollection(AnalogInputEngine.aiTerminal);
            }

            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
            {
                return true;
            }
        }

        /// <summary>
        /// Open a popup window to confiure the AIChannels
        /// </summary>
        private class ChannelEditor : UITypeEditor
        {
            public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
            {
                //指定为模式窗体属性编辑器类型
                return UITypeEditorEditStyle.Modal;
            }

            public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
            {                
                return ChannelSelector.EditValue(value, AnalogInputEngine.channelCount);
            }
        }
        #endregion UI Utilities (Editor, Convertor)
    }
}