using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using SeeSharpTools.JY.ArrayUtility;
using SeeSharpTools.JY.File;
using JYPCI69524;
using System.IO;

namespace MACOs.JY.JYPCI69524
{
    public class MACOsJYPCI69524
    {
        private AnalogInput _ai;
        private AnalogOutput _ao;
        private List<MotorControl> _motor=new List<JYPCI69524.MotorControl>();
        private List<EncoderInput> _enc;
        private DigitalInput _di;
        private DigitalOutput _do;

        public MACOsJYPCI69524()
        {

        }
        public void EngineStart(int boardNum)
        {
            _ai = new AnalogInput(boardNum);
            _ao = new AnalogOutput(boardNum);
            _di = new DigitalInput(boardNum);
            _do = new DigitalOutput(boardNum);
        }

        public void EngineStop()
        {
            if (_ai!=null)
            {
                _ai.Stop();
            }
            if (_ao!=null)
            {
                _ao.Stop();
            }
            if(_di!=null)
            {
                _di.Stop();
            }
            if(_do!=null)
            {
                _do.Stop();
            }

        }

        public List<MotorControl> MotorControl
        {
            get { return _motor; }
            set { _motor = value; }
        }
        public List<EncoderInput> EncoderInput
        {
            get { return _enc; }
            set { _enc = value; }
        }

        public DigitalOutput DigitalOutput
        {
            get { return _do; }
            set { _do = value; }
        }

        public DigitalInput DigitalInput
        {
            get { return _di; }
            set { _di = value; }
        }

        public AnalogOutput AnalogOutput
        {
            get { return _ao; }
            set { _ao = value; }
        }

        public AnalogInput AnalogInput
        {
            get { return _ai; }
            set { _ai = value; }
        }
    }

    public enum Function
    {
        AnalogOutput,
        AnalogInput,
        MotionControl,
        EncoderInput,
        DigitalInput,
        DigitalOutput,
    }
    public enum MotorControlMode
    {
        Position_Relative = 0,
        Position_Absolute = 1,
        Velocity = 2
    }
    public enum MotorCommandMode
    {
        /// <summary>
        /// CW/CCW mode
        /// </summary>
        CWCCW = 0,
        StepDir = 1
    }

    public class AnalogOutput
    {
        //2017.06.02 需要stop -> config -> start才能更新电压
        //2017.06.02 stop之后,电平维持原本设定

        private JYPCI69524AOTask aotask;
        private double[] writeValue = new double[2] { 0, 0 };

        public AnalogOutput(int boardNum, double defaultOutputValue= 0)
        {
            aotask = new JYPCI69524AOTask(boardNum);
            aotask.AddChannel(new int[2] { 0, 1 }, -10, 10);
            for (int i = 0; i < writeValue.Length; i++)
            {
                writeValue[i] = defaultOutputValue;
            }
            aotask.WriteSinglePoint(writeValue);
            aotask.Start();
        }
        public void WriteValue(int channelNum, double value)
        {
            if (Math.Abs(value) <= 10 )
            {
                writeValue[channelNum] = value;
                aotask.WriteSinglePoint(writeValue);
            }
        }
        public void Stop()
        {
            aotask.Stop();
            aotask.Channels.Clear();
        }

    }
    public class AnalogInput
    {
        #region Private Data
        private JYPCI69524AITask aiTask;
        private AIApplicationMode aiAppMode=AIApplicationMode.AquireOnly;
        private int[,] feedbackData;
        private SamplingRateList sampleRate = SamplingRateList.Rate15000;
        private int samplesToRead = 1000;
        private AIChannelGroup channelMode = AIChannelGroup.General;
        private int boardNum = 0;
        private AIMode acquisitionMode = AIMode.Continuous;
        private bool autoZero = true;
        private AIExcitationVoltage excitationVoltage = AIExcitationVoltage.Range_2R5V;
        private double[,] measuredData;
        private List<MTChannels> aiChannels;
        private bool sensorNulling;
        private bool isRunning = false;


        /// <summary>
        /// 用来查找AI通道的index
        /// </summary>
        private int _aiChLookUp;
        private volatile bool _threadStop = true;
        private Task[] processTasks;
        /// <summary>
        /// 计算线程Task
        /// </summary>
        private Thread _calulcationThread;
        private volatile bool _readyToFetch;
        private int bufferSize = 15000;
        private bool bufferMode = true;
        private DateTime timeStamp = DateTime.Now;
        private string[] timeData;

        #endregion

        #region Constructor
        /// <summary>
        /// MaterialTest 构造函数
        /// </summary>
        public AnalogInput(int brdID)
        {
            boardNum = brdID;
            aiTask = new JYPCI69524AITask(boardNum);
            aiTask.ApplicationMode = AIAppMode;
            aiTask.Mode = AcqMode ;
            aiChannels = new List<MTChannels>();
            _threadStop = true;
        }

        #endregion

        #region Public Properties

        public AIApplicationMode AIAppMode
        {
            get { return aiAppMode; }
            set
            {
                aiAppMode = value;
                aiTask.ApplicationMode = aiAppMode;
            }
        }

        /// <summary>
        /// AI采样率
        /// </summary>
        public SamplingRateList SampleRate
        {
            get { return sampleRate; }
            set
            {
                sampleRate = value;                
                double rate = (double)SamplingRate.GetValue((int)sampleRate);
                aiTask.SampleRate = rate;
            }
        }

        /// <summary>
        /// AI采样点数
        /// </summary>
        public int SamplesToAcquire
        {
            get { return samplesToRead; }
            set
            {
                samplesToRead = value;
                aiTask.SamplesToAcquire = samplesToRead;
            }
        }

        /// <summary>
        /// 通道类型
        /// </summary>
        public AIChannelGroup ChannelGroup
        {
            get { return channelMode; }
            set
            {
                channelMode = value;
                aiTask.AIChannelGroup = channelMode;
            }
        }

        /// <summary>
        /// AI采集模式 (Continuous or Finite)
        /// </summary>
        public AIMode AcqMode
        {
            get { return acquisitionMode; }
            set
            {
                acquisitionMode = value;
                aiTask.Mode = acquisitionMode;               
            }
        }

        /// <summary>
        /// AutoZero模式
        /// </summary>
        public bool AutoZero
        {
            get { return autoZero; }
            set
            {
                autoZero = value;
                aiTask.LoadCell.EnableAutoZero = autoZero;
            }
        }

        public bool GeneralChNulling
        {
            get { return sensorNulling; }
            set
            {
                sensorNulling = value;
                if (aiChannels.Count != 0)
                {
                    aiChannels.ForEach(x => x.SensorNulling = sensorNulling);
                }
            }
        }

        /// <summary>
        /// AI通道参数(Excitation Voltage)
        /// </summary>
        public AIExcitationVoltage Excitation
        {
            get { return excitationVoltage; }
            set
            {
                excitationVoltage = value;
                aiTask.LoadCell.AIExcitationVoltage = excitationVoltage;
            }
        }


        /// <summary>
        /// AI通道采集旗标
        /// </summary>
        public bool ReadyToFetch
        {
            get { return _readyToFetch; }

        }

        /// <summary>
        /// 连续缓冲区长度
        /// </summary>
        public int RecordLength
        {
            get { return (int)(bufferSize / (double)SamplingRate.GetValue((int)sampleRate)); }
            set
            {
                bufferSize = (int)(value * (double)SamplingRate.GetValue((int)sampleRate));
                if (aiChannels.Count != 0)
                {
                    aiChannels.ForEach(x => x.ResetBuffer(bufferMode, bufferSize));
                }
            }
        }

        /// <summary>
        /// 开启连续量测缓冲模式
        /// </summary>
        public bool BufferMode
        {
            get { return bufferMode; }
            set
            {
                bufferMode = value;
                if (aiChannels.Count != 0)
                {
                    aiChannels.ForEach(x => x.ResetBuffer(bufferMode, bufferSize));
                }
            }
        }

        public List<MTChannels> AIChannels
        {
            get
            {
                return aiChannels;
            }

        }

        public double ActualSampleRate
        {
            get { return aiTask.SampleRate; }
        }


        #endregion

        #region Methods
        /// <summary>
        /// 设定通道类型(CH0~3 LoadCell, CH4~7 General)
        /// </summary>
        public void ConfigChannelGroup(AIChannelGroup group)
        {
            if (isRunning)
            {
                throw new Exception("Please stop the AITask first!");
            }
            else
            {
                ChannelGroup = group;

                aiChannels.Clear();
                aiTask.ChannelsGeneral.Clear();
                aiTask.ChannelsLoadCell.Clear();

                switch (channelMode)
                {
                    case AIChannelGroup.LoadCell:
                                                
                        Excitation = excitationVoltage;
                        AutoZero = autoZero;
                        break;

                    case AIChannelGroup.General:
                        break;

                    default:
                        break;
                }
            }
        }

        public void ConfigLoadCellChannel(int chID, AISpikeRejecterMode loadCellRejecterMode, ushort digitalFilterStage, uint spikeRejecterThreshold)
        {
            if (isRunning)
            {
                throw new Exception("Please stop the AITask first!");
            }
            else
            {
                _aiChLookUp = chID;

                if (chID < 4)
                {
                    if (!aiChannels.Exists(x => x.ChannelNum == chID))
                    {

                        aiTask.AddChannel(chID, loadCellRejecterMode, digitalFilterStage, spikeRejecterThreshold);

                        aiChannels.Add(new MTChannels(chID, AIChannelGroup.LoadCell, bufferMode, bufferSize)
                        {
                            RejecterMode = loadCellRejecterMode,
                            RejecterThreshold = spikeRejecterThreshold,
                            DigitalFilterStage = digitalFilterStage,
                        });
                        
                        aiChannels = aiChannels.OrderBy(s => s.ChannelNum).ToList();

                    }
                    else
                    {
                        aiTask.ChannelsLoadCell.Find(x => x.ChannelID == _aiChLookUp).SpikeRejecterMode = loadCellRejecterMode;
                        aiTask.ChannelsLoadCell.Find(x => x.ChannelID == _aiChLookUp).DigitalFilterStage = digitalFilterStage;
                        aiTask.ChannelsLoadCell.Find(x => x.ChannelID == _aiChLookUp).SpikeRejecterThreshold = spikeRejecterThreshold;

                        aiChannels.Find(x => x.ChannelNum == _aiChLookUp).RejecterMode = loadCellRejecterMode;
                        aiChannels.Find(x => x.ChannelNum == _aiChLookUp).DigitalFilterStage = digitalFilterStage;
                        aiChannels.Find(x => x.ChannelNum == _aiChLookUp).RejecterThreshold = spikeRejecterThreshold;
                        aiChannels.Find(x => x.ChannelNum == _aiChLookUp).ResetBuffer(bufferMode, bufferSize);

                    }
                }
                else
                {
                    throw new Exception("The channel number is not match the channel group, please choose CH0~3 for Loadcell group");
                }
            }
        }

        public void ConfigGeneralChannel(int chID, double rangeLow, double rangeHigh)
        {
            //if (isRunning)
            //{
            //    throw new Exception("Please stop the AITask first!");
            //}
            //else
            //{

            //}
            _aiChLookUp = chID;

            if (chID >= 4)
            {
                if (!aiChannels.Exists(x => x.ChannelNum == chID))
                {

                    aiTask.AddChannel(chID, rangeLow, rangeHigh);

                    aiChannels.Add(new MTChannels(chID, AIChannelGroup.General, bufferMode, bufferSize)
                    {
                        RangeHigh = rangeHigh,
                        RangeLow = rangeLow,
                        SensorNulling = sensorNulling,
                    });
                    aiChannels = aiChannels.OrderBy(s => s.ChannelNum).ToList();
                }
                else
                {
                    aiTask.ChannelsGeneral.Find(x => x.ChannelID == _aiChLookUp).RangeLow = rangeLow;
                    aiTask.ChannelsGeneral.Find(x => x.ChannelID == _aiChLookUp).RangeHigh = rangeHigh;
                    aiChannels.Find(x => x.ChannelNum == _aiChLookUp).RangeLow = rangeLow;
                    aiChannels.Find(x => x.ChannelNum == _aiChLookUp).RangeHigh = rangeHigh;
                    aiChannels.Find(x => x.ChannelNum == _aiChLookUp).ResetBuffer(bufferMode, bufferSize);
                    aiChannels.Find(x => x.ChannelNum == _aiChLookUp).SensorNulling = sensorNulling;
                }
            }
            else
            {
                throw new Exception("The channel number is not match the channel group, please choose CH0~3 for Loadcell group");
            }

        }

        private void ValidataChannelList()
        {
            int chCnt = aiTask.ApplicationMode == AIApplicationMode.AquireWithEncoder ? 3 : 4;

            if (aiTask.AIChannelGroup==AIChannelGroup.LoadCell)
            {
                if (aiTask.ChannelsLoadCell.Count>1)
                {
                    for (int i = 0; i < chCnt; i++)
                    {
                        if (aiTask.ChannelsLoadCell.Exists(x=>x.ChannelID==i))
                        { }
                        else
                        {
                            ConfigLoadCellChannel(i, AISpikeRejecterMode.Enable, 2, 16);
                        }
                    }
                }
            }
            else
            {
                if (aiTask.ChannelsGeneral.Count>1)
                {
                    for (int i = 0; i < chCnt; i++)
                    {
                        if (aiTask.ChannelsLoadCell.Exists(x => x.ChannelID == (i+4)))
                        { }
                        else
                        {
                            ConfigGeneralChannel(i, -10,10);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 开始量测
        /// </summary>
        public void Start()
        {
            if (isRunning)
            {
                throw new Exception("The Analog Input engine has already started, please stop the AI task before configuring the channels");
            }
            else
            {
                foreach (MTChannels CH in aiChannels)
                {
                    CH.ClearBuffer();
                }


                if (channelMode == AIChannelGroup.LoadCell)
                {
                    measuredData = new double[samplesToRead, aiTask.ChannelsLoadCell.Count];
                    feedbackData = new int[samplesToRead, aiTask.ChannelsLoadCell.Count];
                    timeData = new string[SamplesToAcquire];
                }
                else
                {
                    measuredData = new double[samplesToRead, aiTask.ChannelsGeneral.Count];
                    feedbackData = new int[samplesToRead, aiTask.ChannelsGeneral.Count];
                    timeData = new string[SamplesToAcquire];
                }
                aiTask.Start();
                _threadStop = false;
                _calulcationThread = new Thread(Processing);
                _calulcationThread.Start();
                isRunning = true;
            }                     

        }

        /// <summary>
        /// 停止量测
        /// </summary>
        public void Stop()
        {

            _threadStop = true;
            _calulcationThread?.Join();
            aiTask.Stop();
            isRunning = false;

        }

        /// <summary>
        /// 数据处理线程
        /// </summary>
        private void Processing()
        {
            while (!_threadStop)
            {
                _readyToFetch = false;
                if (AIAppMode==AIApplicationMode.AquireOnly)
                {
                    aiTask.ReadData(ref measuredData);
                    timeStamp = DateTime.Now;
                    for (int i = 0; i < timeData.Length; i++)
                    {
                        timeData[i] = timeStamp.AddSeconds(i * (1.0 / aiTask.SamplesToAcquire)).ToString("HH:mm:ss:ffff");
                    }
                               
                }
                else
                {
                    aiTask.ReadDataWithEncoder(ref measuredData, ref feedbackData);
                    timeStamp = DateTime.Now;
                    for (int i = 0; i < timeData.Length; i++)
                    {
                        timeData[i] = timeStamp.AddSeconds(i * (1.0 / aiTask.SamplesToAcquire)).ToString("HH:mm:ss:ffff");
                    }

                }

                processTasks = new Task[AIChannels.Count];
                for (int i = 0; i < aiChannels.Count; i++)
                {
                    processTasks[i] = aiChannels[i].Extraction(measuredData, feedbackData, timeStamp,timeData);
                }
                
                Task.WaitAll(processTasks);
                _readyToFetch = true;

                Thread.Sleep(20);
            }
        }

        public double[] GetChannelData(int channelID)
        {
            if (aiChannels.Exists((x => x.ChannelNum == channelID)))
            {
                return aiChannels.Find(x => x.ChannelNum == channelID).ChData;
            }
            else
            {
                throw new Exception("Cannot find the assigned channel, please choose the correct channelID");
            }
            
        }

        public double[] GetEncoderData(int channelID)
        {

            if (aiChannels.Exists((x => x.ChannelNum == channelID)))
            {
                return aiChannels.Find(x => x.ChannelNum == channelID).EncoderData;
            }
            else
            {
                throw new Exception("Cannot find the assigned channel, please choose the correct channelID");
            }

        }
        /// <summary>
        /// 存储通道资料
        /// </summary>
        public void SaveChannelData(string folderPath)
        {
            DateTime now = DateTime.Now;

            string Time = now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + "_" + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString();
            foreach (MTChannels CH in aiChannels)
            {
                string filePath = folderPath + @"\" + Time + "_" + "CH" + CH.ChannelNum + "_aiDATA.csv";
                CsvHandler.WriteData(filePath, CH.ChData);
                string filePath2 = folderPath + @"\" + Time + "_" + "CH" + CH.ChannelNum + "_encoderDATA.csv";
                CsvHandler.WriteData(filePath2, CH.EncoderData);
            }

        }
        #endregion

        public enum SamplingRateList
        {
            Rate30000 = 0,
            Rate15000 = 1,
            Rate07500 = 2,
            Rate03750 = 3,
            Rate02000 = 4,
            Rate01000 = 5,
            Rate00500 = 6,
            Rate00100 = 7,
            Rate00060 = 8,
            Rate00050 = 9,
            Rate00030 = 10,
            Rate00025 = 11,
            Rate00015 = 12,
            Rate00010 = 13,
            Rate00005 = 14,
            Rate00002_5 = 15,

        }
        private double[] SamplingRate = { 30000, 15000, 7500, 3750, 2000, 1000, 500, 100, 60, 50, 30, 25, 15, 10, 5, 2.5 };
        public class MTChannels
        {

            #region Private Field
            private double unitPitch = 1;
            private int chNum = 0;
            private AIChannelGroup sensorMode;
            private double[] rawAIData;
            private int[] rawEncoderData;
            private double[] channelData;
            private double[] encoderData;
            private double sensorOffset = 0;
            private double sensorGain = 1;
            private bool isResampled = false;
            private DataManipulation _buffer;
            private Task _calculationTask;
            private double encoderOffset = 0;
            private bool sensorNulling = false;
            private Nulling _nullCal;
            private double rangeHigh = 10;
            private double rangeLow = -10;
            private AISpikeRejecterMode loadCellRejecterMode = AISpikeRejecterMode.Enable;
            private ushort digitalFilterStage = 2;
            private uint spikeRejecterThreshold = 16;
            private bool saveDisk = false;
            private WriteMode writeMode = WriteMode.Append;
            private string folderPath = @"C:\";
            private string filePath = "";
            private double counts = 0;
            private bool isCounting = false;
            private double countThres = 0;
            double lastPrevData = 0;

            #endregion

            #region Constructor
            public MTChannels(int channel, AIChannelGroup channelType, bool recordMode, int bufferLength)
            {
                _buffer = new DataManipulation(bufferLength);
                _nullCal = new Nulling();

                ResetBuffer(recordMode, bufferLength);
                sensorMode = channelType;
                SensorScaling = 1;
                SensorOffset = 0;
                EncoderUnitPitch = 1;
                EncoderUnitOffset = 0;
                ResampleMode = false;
                ChannelNum = channel;

            }

            #endregion

            #region Public Properties

            public int ChannelNum
            {
                get
                {
                    return sensorMode == AIChannelGroup.General ? chNum + 4 : chNum;
                }

                set
                {
                    chNum = sensorMode == AIChannelGroup.General ? value - 4 : value;
                }
            }
            public AIChannelGroup ChannelType
            {
                get
                {
                    return sensorMode;
                }

                set
                {
                    sensorMode = value;
                    if (sensorMode == AIChannelGroup.LoadCell)
                    {
                        SensorNulling = false;
                    }

                    else
                    {
                        SensorNulling = true;
                    }
                }
            }
            public double RangeLow
            {
                get { return rangeLow; }
                set
                {
                    rangeLow = value;
                }
            }
            public double RangeHigh
            {
                get { return rangeHigh; }
                set
                {
                    rangeHigh = value;

                }
            }
            public AISpikeRejecterMode RejecterMode
            {
                get { return loadCellRejecterMode; }
                set { loadCellRejecterMode = value; }
            }
            public ushort DigitalFilterStage
            {
                get { return digitalFilterStage; }
                set { digitalFilterStage = value; }
            }
            public uint RejecterThreshold
            {
                get { return spikeRejecterThreshold; }
                set { spikeRejecterThreshold = value; }
            }
            public bool SensorNulling
            {
                get { return sensorNulling; }
                set
                {
                    sensorNulling = value;
                    _nullCal.EnableNulling = sensorNulling;

                }
            }
            public double SensorOffset
            {
                get { return sensorOffset; }
                set { sensorOffset = value; }
            }
            public double SensorScaling
            {
                get { return sensorGain; }
                set { sensorGain = value; }
            }
            public bool ResampleMode
            {
                get
                {
                    return isResampled;
                }

                set
                {
                    isResampled = value;
                }
            }
            public double EncoderUnitPitch
            {
                get
                {
                    return unitPitch;
                }

                set
                {
                    unitPitch = value;
                }
            }
            public double EncoderUnitOffset
            {
                get { return encoderOffset; }
                set { encoderOffset = value; }
            }
            public bool SaveDisk
            {
                get { return saveDisk; }
                set { saveDisk = value; }
            }
            public bool IsCounting
            {
                get { return isCounting; }
                set { isCounting = value; }
            }
            public double CountThreshold
            {
                get { return countThres; }
                set { countThres = value; }
            }
            public double Counts
            {
                get { return counts; }
                set { counts = value; }
            }
            public WriteMode WriteMode
            {
                get { return writeMode; }
                set { writeMode = value; }
            }
            public string FolderPath
            {
                get { return folderPath; }
                set { folderPath = value; }
            }
            public string FilePath
            {
                get { return filePath; }
                set { filePath = value; }
            }
            public double[] ChData
            {
                get
                {
                    return channelData;
                }

            }
            public double[] EncoderData
            {
                get
                {
                    return encoderData;
                }
            }
            private Task CalTask
            {
                get
                {
                    return _calculationTask;
                }


            }

            #endregion

            #region Methods

            public Task Extraction(double[,] aidata, int[,] cidata, DateTime timeStamp,string[] timeData)
            {
                _calculationTask = Task.Run(() =>
                {
                    rawAIData = new double[aidata.GetLength(0)];
                    rawEncoderData = new int[cidata.GetLength(0)];
                    double[] resXData;
                    double[] resYData;
                    double[] nullXData;
                    double[] nullYData;

                    ArrayManipulation.GetArraySubset(aidata, chNum, ref rawAIData, ArrayManipulation.IndexType.column);
                    ArrayManipulation.GetArraySubset(cidata, chNum, ref rawEncoderData, ArrayManipulation.IndexType.column);
                    encoderData = Array.ConvertAll<int, double>(rawEncoderData, Convert.ToDouble);
                    channelData = rawAIData;

                    //scaling of the encoder data and AI data
                    for (int i = 0; i < encoderData.Length; i++)
                    {
                        encoderData[i] = encoderData[i] * unitPitch + encoderOffset;
                        channelData[i] = rawAIData[i] * sensorGain + sensorOffset;
                    }

                    //resample process (output resXData and resYData)
                    Resample(encoderData, channelData, out resXData, out resYData);


                    //nulling
                    _nullCal.Process(resXData, resYData, out nullXData, out nullYData);

                    //save to disk
                    if (saveDisk)  
                    {
                        string[,] data = new string[nullXData.Length, 3];
                        double[] counting = new double[nullXData.Length];
                        string path = folderPath+filePath;
                        #region Counting algorithm
                        if (isCounting)
                        {
                            double a;
                            double b;
                            a = lastPrevData - countThres;
                            b = nullYData[0] - countThres;
                            if (a * b < 0 && b > 0)
                            {
                                counts++;
                            }
                            counting[0] = counts;

                            for (int i = 0; i < nullYData.Length - 1; i++)
                            {
                                a = nullYData[i] - countThres;
                                b = nullYData[i + 1] - countThres;
                                if (a * b < 0 && b > 0)
                                {
                                    counts++;
                                }
                                counting[i + 1] = counts;
                            }
                            lastPrevData = nullYData[nullYData.Length - 1];
                        }

                        #endregion

                        try
                        {
                            //CSV template: column0=timeData, column1=EncoderData, column2=ForceData
                            //var time = timeData.Take(nullXData.Length).ToArray();
                            ArrayManipulation.ReplaceArraySubset(timeData, ref data, 0, ArrayManipulation.IndexType.column);
                            var xData = Array.ConvertAll<double, string>(nullXData, Convert.ToString);
                            ArrayManipulation.ReplaceArraySubset(xData, ref data, 1, ArrayManipulation.IndexType.column);
                            var yData = Array.ConvertAll<double, string>(nullYData, Convert.ToString);
                            ArrayManipulation.ReplaceArraySubset(yData, ref data, 2, ArrayManipulation.IndexType.column);

                            //Check if file exists
                            DirectoryInfo di = new DirectoryInfo(folderPath);
                            string[] pat = filePath.Split('.');
                            FileInfo[] fi = di.GetFiles(pat[0] + "_*." + pat[1]);

                            if (fi.Length!=0)
                            {
                                double idx = double.Parse(fi[fi.Length - 1].Name.Split('_')[1].Split('.')[0]);
                                if (fi[fi.Length - 1].Length >= 10000000)
                                {
                                    idx++;
                                    
                                }
                                path = FolderPath + pat[0] + "_" + idx + "."+pat[1];
                            }
                            else
                            {
                                path = FolderPath + pat[0] + "_0." + pat[1];
                            }



                            CsvHandler.WriteData(path, data, writeMode);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }

                    //buffer append process
                    _buffer.Append(nullXData, nullYData);

                    encoderData = _buffer.ReadEncoderBuf.ToArray();
                    channelData = _buffer.ReadDataBuf.ToArray();

                });

                return _calculationTask;
            }

            public void ClearBuffer()
            {
                _buffer.ResetBuffer();
                _nullCal.ResetCount();

            }

            public void ResetBuffer(bool recordMode, int bufferLength)
            {
                _buffer.EnableBufferMode = recordMode;
                _buffer.BufferSize = bufferLength;
                _nullCal.BufferEnabled = recordMode;

            }

            private int Resample(double[] xData, double[] yData, out double[] resXData, out double[] resYData)
            {
                List<double> xLData = new List<double>(10);
                List<double> yLData = new List<double>(10);
                double sum = 0;
                int count = 0;
                int index = 0;
                int length = 0;

                if (isResampled)
                {
                    for (int i = 0; i < xData.Length - 1; i++)
                    {
                        if (xData[i] == xData[i + 1])
                        {
                            sum += yData[i];
                            count++;
                        }
                        else
                        {
                            //resXData[index] = xData[i];
                            //resYData[index] = sum / count;
                            xLData.Add(xData[i]);
                            if (count == 0)
                                yLData.Add(yData[i]);
                            else
                            {
                                sum += yData[i];
                                yLData.Add(sum / ++count);
                            }


                            count = 0;
                            sum = 0;
                            index++;
                            length++;
                        }
                    }
                    resXData = xLData.ToArray<double>();
                    resYData = yLData.ToArray<double>();

                }
                else
                {
                    resXData = xData;
                    resYData = yData;
                }
                return length;
            }

            #endregion
        }
        internal class DataManipulation
        {
            List<double> _xBuffer = new List<double>();
            List<double> _yBuffer = new List<double>();
            private int bufferSize;
            bool enableBuff;

            public DataManipulation(int size)
            {
                BufferSize = size;
            }

            public bool EnableBufferMode
            {
                get
                {
                    return enableBuff; ;
                }

                set
                {
                    enableBuff = value;
                }
            }

            public int BufferSize
            {
                get
                {
                    return bufferSize;
                }

                set
                {
                    bufferSize = value;
                    ResetBuffer();
                }
            }

            public List<double> ReadDataBuf
            {
                get
                {
                    return _yBuffer;
                }
            }

            public List<double> ReadEncoderBuf
            {
                get
                {
                    return _xBuffer;
                }
            }

            public void ResetBuffer()
            {
                _xBuffer.Clear();
                _yBuffer.Clear();
            }

            public void Append(double[] encoderData, double[] aiData)
            {

                if (enableBuff)
                {
                    if (_xBuffer.Count > bufferSize - encoderData.Length)
                    {
                        _xBuffer.RemoveRange(0, _xBuffer.Count + encoderData.Length - bufferSize);
                        _yBuffer.RemoveRange(0, _yBuffer.Count + aiData.Length - bufferSize);
                    }

                    _xBuffer.AddRange(encoderData);
                    _yBuffer.AddRange(aiData);
                }
                else
                {
                    _xBuffer = encoderData.ToList();
                    _yBuffer = aiData.ToList();
                }

            }

        }
        internal class Nulling
        {
            private bool enable;
            private int loopCount;
            private double xNullOffset;
            private double yNullOffset;
            private bool bufferEnable;


            public bool EnableNulling
            {
                get { return enable; }
                set
                {
                    enable = value;
                    loopCount = 0;
                }
            }

            public bool BufferEnabled
            {
                get { return bufferEnable; }
                set
                {
                    bufferEnable = value;
                    loopCount = 0;
                }
            }

            public void ResetCount()
            {
                loopCount = 0;
            }

            public void Process(double[] xData, double[] yData, out double[] xNullData, out double[] yNullData)
            {
                xNullData = new double[xData.Length];
                yNullData = new double[yData.Length];

                if (enable)
                {
                    if (loopCount == 0)
                    {
                        xNullOffset = xData[0];
                        yNullOffset = yData[0];
                    }
                    for (int i = 0; i < xData.Length; i++)
                    {
                        xNullData[i] = xData[i] - xNullOffset;
                        yNullData[i] = yData[i] - yNullOffset;
                    }

                    if (bufferEnable)
                    {
                        loopCount++;
                    }
                    else
                    {
                        loopCount = 0;
                    }
                }
                else
                {
                    xNullData = xData;
                    yNullData = yData;
                }
            }

        }
    }
    public class MotorControl
    {
        #region Private Field
        private MotorCommandMode _cmdMode;
        private int _countPerRev;
        private int _currentPos;
        private JYPCI69524COTask _motionTask;
        private int _motionBrdNum;
        private int _motionChNum;
        private int _distance;
        private double _speed;
        private COMode _counterMode;
        private int _startPos;
        private volatile bool _isMovingDone;
        private Thread _motionThread;
        private volatile bool _closeThread;
        private MotorControlMode _ctrlMode;
        private double _countPerUnit;

        #endregion
        #region Constructor
        public MotorControl(int boardNum, int channelNum)
        {
            _motionBrdNum = boardNum;
            _motionChNum = channelNum;
            _cmdMode = MotorCommandMode.CWCCW;
            _countPerRev = 1;
            _currentPos = 0;
            _motionBrdNum = 0;
            _distance = 0;
            _speed = 0;
            _ctrlMode = MotorControlMode.Position_Relative;
            _startPos = 0;
            _isMovingDone = false;
            _closeThread = true;
            _motionTask = new JYPCI69524COTask(boardNum, channelNum);

        }
        #endregion
        #region PublicProperty

        public int BoardNum
        {
            get { return _motionBrdNum; }
        }
        public int ChannelNum
        {
            get { return _motionChNum; }
            set { _motionChNum = value; }
        }
        public MotorControlMode ControlMode
        {
            get { return _ctrlMode; }
            set { _ctrlMode = value; }
        }
        public MotorCommandMode CommandMode
        {
            get { return _cmdMode; }
            set { _cmdMode = value; }
        }
        public int CountPerRev
        {
            get { return _countPerRev; }
            set { _countPerRev = value; }
        }
        public double CountPerUnit
        {
            get { return _countPerUnit; }
            set { _countPerUnit = value; }
        }
        public int CurrentPosition
        {
            get { return _currentPos; }
        }
        public bool MoveCompleted
        {
            get { return _isMovingDone; }
        }

        #endregion
        #region Method
        public void MoveInPos(double targetPosInUnit, double speed)
        {
            double targetPosInCounts = targetPosInUnit * _countPerUnit;
            _startPos = _currentPos;

            if (_ctrlMode != MotorControlMode.Velocity && !PositionCheck((int)targetPosInCounts, speed))
            {
                _motionTask.Mode = _counterMode;

                _motionTask.PulseNumber = (uint)Math.Abs(_distance);

                //_motionTask.PulseParams.PulseParamType = COPulseType.HighLowTime;
                //double period1 = 60 / ((Math.Abs(speed)) * _countPerRev);
                //_motionTask.PulseParams.Time.PulseHighTime = period1 / 2;
                //_motionTask.PulseParams.Time.PulseLowTime = period1 / 2;

                _motionTask.PulseParams.PulseParamType = COPulseType.DutyCycleFrequency;
                _motionTask.PulseParams.DutyCycleFrequency.DutyCycle = 0.5;
                _motionTask.PulseParams.DutyCycleFrequency.Frequency = ((Math.Abs(speed)) * _countPerRev) / 60.0;

                //_motionTask.PulseParams.PulseParamType = COPulseType.HighLowTick;
                //_motionTask.PulseParams.Tick.PulseHighTick = 80000000 * 0.5 / (((Math.Abs(speed)) * _countPerRev) / 60);
                //_motionTask.PulseParams.Tick.PulseLowTick = 80000000 * 0.5 / (((Math.Abs(speed)) * _countPerRev) / 60);

                _isMovingDone = false;
                _closeThread = false;
                _motionThread = new Thread(CheckMoveComplete);

                _motionTask.Start();
                _motionThread.Start();


            }
        }
        public void MoveInSpeed(double speed)
        {
            _speed = speed;

            if (_ctrlMode == MotorControlMode.Velocity && !SpeedCheck(speed))
            {
                _motionTask.Mode = _counterMode;
                _motionTask.PulseNumber = 0;

                //_motionTask.PulseParams.PulseParamType = COPulseType.HighLowTime;
                //double period1 = 1 / (speed / 60 * _countPerRev);
                //_motionTask.PulseParams.Time.PulseHighTime = period1 / 2;
                //_motionTask.PulseParams.Time.PulseLowTime = period1 / 2;

                _motionTask.PulseParams.PulseParamType = COPulseType.DutyCycleFrequency;
                _motionTask.PulseParams.DutyCycleFrequency.DutyCycle = 0.5;
                //_motionTask.PulseParams.DutyCycleFrequency.Frequency = ((Math.Abs(speed)) * _countPerRev) / 60;

                _motionTask.PulseParams.DutyCycleFrequency.Frequency = ((Math.Abs(speed)) * _countPerUnit) / 60;
                
                //_motionTask.PulseParams.PulseParamType = COPulseType.HighLowTick;
                //_motionTask.PulseParams.Tick.PulseHighTick = 80000000 * 0.5 / (((Math.Abs(speed)) * _countPerRev) / 60);
                //_motionTask.PulseParams.Tick.PulseLowTick = 80000000 * 0.5 / (((Math.Abs(speed)) * _countPerRev) / 60);

            }
            _motionTask.Start();

        }
        public void Stop()
        {
            _motionTask.Stop();
            _closeThread = true;
            _motionThread?.Join();
            _isMovingDone = true;

        }
        public void ResetPosition(int pos)
        {
            if (_closeThread)
            {
                _currentPos = pos;
            }
        }
        private bool PositionCheck(int pos, double speed)
        {
            //update the _movingDistance, _ctrCommandMode, and _speed variables


            //-movingDistance will depend on the Relative/Absolute/Velocity mode
            switch (_ctrlMode)
            {
                case MotorControlMode.Position_Relative:
                    _distance = pos;
                    break;
                case MotorControlMode.Position_Absolute:
                    _distance = pos - _startPos;
                    break;
                case MotorControlMode.Velocity:
                    return true;
                default:
                    break;
            }

            //determine _ctrCommndMode due to the _movingDistance and _controlMode
            //if user assing 0 as the movingDistance, turn the speed to 0 (not moving)
            if (_distance == 0)
            {
                return true;
            }
            else
            {
                if (_distance < 0 && _cmdMode == MotorCommandMode.CWCCW)
                {
                    _counterMode = COMode.PulseGen_CCW;
                }
                if (_distance > 0 && _cmdMode == MotorCommandMode.CWCCW)
                {
                    _counterMode = COMode.PulseGen_CW;
                }
                if (_distance < 0 && _cmdMode == MotorCommandMode.StepDir)
                {
                    _counterMode = COMode.PulseGen_OUTDIR_R;
                }
                if (_distance > 0 && _cmdMode == MotorCommandMode.StepDir)
                {
                    _counterMode = COMode.PulseGen_OUTDIR_N;
                }

                return false;


            }

        }
        private bool SpeedCheck(double speed)
        {
            //update the _movingDistance, _ctrCommandMode, and _speed variables

            //-movingDistance will depend on the Relative/Absolute/Velocity mode
            switch (_ctrlMode)
            {
                case MotorControlMode.Position_Relative:
                    return true;
                case MotorControlMode.Position_Absolute:
                    return true;
                case MotorControlMode.Velocity:
                    break;
                default:
                    return true;

            }

            //determine _ctrCommndMode due to the _movingDistance and _controlMode
            //if user assing 0 as the movingDistance, turn the speed to 0 (not moving)

            if (_speed < 0 && _cmdMode == MotorCommandMode.CWCCW)
            {
                _counterMode = COMode.PulseGen_CCW;
            }
            if (_speed > 0 && _cmdMode == MotorCommandMode.CWCCW)
            {
                _counterMode = COMode.PulseGen_CW;
            }
            if (_speed < 0 && _cmdMode == MotorCommandMode.StepDir)
            {
                _counterMode = COMode.PulseGen_OUTDIR_R;
            }
            if (_speed > 0 && _cmdMode == MotorCommandMode.StepDir)
            {
                _counterMode = COMode.PulseGen_OUTDIR_N;
            }
            return false;
        }
        private void CheckMoveComplete()
        {

            while (_motionTask.CounterValue != 0 && !_closeThread)
            {
                _currentPos = ReadPosition();
                _isMovingDone = false;
                Thread.Sleep(2);
            }

            _currentPos = ReadPosition();
            _closeThread = true;
            _isMovingDone = true;

        }
        public int ReadPosition()
        {
            int pos;

            pos = _startPos + _distance + (_distance > 0 ? -1 : 1) * (int)_motionTask.CounterValue;

            return pos;
        }
        public void ChangeSpeed(double newSpeed)
        {
            _motionTask.PulseParams.DutyCycleFrequency.Frequency = ((Math.Abs(newSpeed)) * _countPerRev * 6.0 ) / 60.0;
            _motionTask.ApplyParam();
        }
        #endregion
    }
    public class EncoderInput
    {
        private JYPCI69524CITask citask;
        private int counterValue = 0;
        private double countPerRev = 1.0;
        private double unitPerRev = 1.0;

        public double CountPerRevolution
        {
            get { return countPerRev; }
            set { countPerRev = value; }
        }
        public double UnitPerRevolution
        {
            get { return unitPerRev; }
            set { unitPerRev = value; }
        }

        public EncoderInput(int boardNum, int counterNo)
        {
            try 
            {                
                citask = new JYPCI69524CITask(boardNum, counterNo);                
                citask.Mode = CIMode.X4ABPhaseDecoder;
                citask.Start();
            }
            catch (Exception ex)
            {
                throw new Exception("板卡初始化失败"+"\r\n"+ex.Message);
            }
        }
        public int ReadPositionInCount()
        {
            citask.ReadCounter(ref counterValue);
            return counterValue;
        }
        public double ReadPositionInUnit()
        {
            citask.ReadCounter(ref counterValue);
            return (double)counterValue / countPerRev * unitPerRev;
        }
        public void Stop()
        {
            citask.Stop();
        }

    }
    public class DigitalInput
    {
        // 2017.06.02 sourcing input
        private JYPCI69524DITask ditask;
        private bool[] readValue = new bool[] { false, false, false, false, false, false, false, false };

        public DigitalInput(int boardNum)
        {
            ditask = new JYPCI69524DITask(boardNum);
            ditask.AddChannel(0, new int[] { });
        }
        public bool ReadValue(int channelNum)
        {
            ditask.ReadSinglePoint(ref readValue);
            return readValue[channelNum];
        }
        public bool[] ReadValues()
        {
            ditask.ReadSinglePoint(ref readValue);
            return readValue;
        }
        public void Stop()
        {
            ditask.Channels.Clear();
        }
    }
    public class DigitalOutput
    {
        //2017.06.02 Sinking output
        private JYPCI69524DOTask dotask;
        private bool[] writeValue = new bool[] { false, false, false, false, false, false, false, false };


        public DigitalOutput(int boardNum)
        {
            dotask = new JYPCI69524DOTask(boardNum);
            dotask.AddChannel(0, new int[] { });
        }
        public bool[] WriteValue(int channelNum,bool value)
        {
            writeValue[channelNum] = value;
            dotask.WriteSinglePoint(writeValue);
            return writeValue;
        }
        public bool[] WriteValues(bool[] values)
        {
            writeValue = values;
            dotask.WriteSinglePoint(writeValue);
            return writeValue;
        }
        public void Stop()
        {
            dotask.Channels.Clear();
        }
    }

}
