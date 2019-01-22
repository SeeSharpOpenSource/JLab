using System;
using System.Collections.Generic;
using System.ComponentModel;
using SeeSharpTools.JY.DSP.Fundamental;
using System.Windows.Forms;

namespace EasyDAQ
{
    public partial class EasyDAQ61902AO : Component
    {
        public enum waveformType
        {
            SineWave, SquareWave, UniformWhiteNoise, CustomerWave
        }

        public enum channelID
        {
            CH0, CH1,CH2, CH3, CH4, CH5, CH6, CH7
        }
        channelID ch;
        #region Private Fields
        private AnalogOutputEngine aoTask;
        private int boardID = 0;
        private double updateRate = 10000;
        private int samplesToUpdate = 1000;
        private string waveType = "SineWave";
        double[] waveData;

        private double highRange = 10;
        private double lowRange = -10;
        private bool isRunning = false;
        private bool continuousRun = false;
        public static List<string> waveformList = new List<string>(Enum.GetNames(typeof(waveformType)));
        private static List<string> channelIDList = new List<string>(Enum.GetNames(typeof(channelID)));
        private bool isConnected = false;
     
        private double dutyCycle = 50;
        private double sineWaveFrequency = 100;
        private double squareWaveFrequency = 100;
        private double phase = 0;


        private double sineWaveAmplitude = 1;
        private double squareWaveAmplitude = 1;
        private double whiteNoiseAmplitude = 1;

        #endregion

        #region Constructor
        public EasyDAQ61902AO()
        {
            InitializeComponent();
            aoTask = new AnalogOutputEngine();
        }

        public EasyDAQ61902AO(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            aoTask = new AnalogOutputEngine();
        }
        ~EasyDAQ61902AO()
        {
            isRunning = false;
            aoTask?.Stop();

        }
        #endregion

        #region Public Properties
        [Category("DAQ Setting")]
        [Description("板卡号")]
        public int BoardID
        {
            get
            {   return boardID;   }

            set
            {   boardID = value;  }
        }

        [Category("DAQ Setting")]
        [Description("通道选择")]
        public channelID ChannelID
        {
            get
            { return ch; }

            set
            { ch = value; }
        }

        [Category("DAQ Setting")]
        [Description("更新率(Samples/second)")]
        public double UpdateRate
        {
            get
            {   return updateRate;    }

            set
            {   updateRate = value;   }
        }
        [Category("DAQ Setting")]
        [Description("更新点数(Samples)")]
        public int SamplesToUpdate
        {
            get
            {   return samplesToUpdate;    }

            set
            {   samplesToUpdate = value;   }
        }
     

        [Category("DAQ Setting")]
        [Description("高量程")]
        public double HighRange
        {
            get
            { return highRange; }

            set
            { highRange = value; }

        }
        [Category("DAQ Setting")]
        [Description("低量程")]
        public double LowRange
        {
            get
            { return lowRange; }

            set
            { lowRange = value; }
        }
        [Category("DAQ Setting")]
        [Description("连续输出模式")]
        public bool ContinuousRun
        {
            get
            { return continuousRun; }

            set
            { continuousRun = value; }
        }
      
       
        [Category("DAQ Setting")]
        [Browsable(true)]
        [TypeConverter(typeof(waveformTypeConverter))]
        [Description("输出波形类型")]
        public string WaveType
        {
            get
            { return waveType; }

            set
            { waveType = value; }
        }

     

        [Category("SquareWave Setting")]
        [Description("方波占空比")]
        public double DutyCycle
        {
            get
            { return dutyCycle; }

            set
            { dutyCycle = value; }
        }


        [Category("DAQ Status")]
        [Description("驱动安装成功")]
        [DefaultValue(false)]
        [Browsable(true)]
        public bool IsDriverExisted
        {
            get
            { return aoTask.IsDriverExisted; }
        }

        [Category("DAQ Status")]
        [Description("板卡初始化成功")]
        [DefaultValue(false)]
        [Browsable(false)]
        public bool IsConnected
        {
            get
            { return isConnected; }
        }


        [Category("SquareWave Setting")]
        [Description("方波频率")]
        public double SquareWaveFrequency
        {
            get
            { return squareWaveFrequency; }

            set
            { squareWaveFrequency = value; }
        }
        [Category("SineWave Setting")]
        [Description("正弦波初始相位")]
        public double Phase
        {
            get
            { return phase; }

            set
            { phase = value; }
        }


        [Category("SineWave Setting")]
        [Description("正弦波幅度")]
        public double SineWaveAmplitude
        {
            get
            {    return sineWaveAmplitude;    }

            set
            {    sineWaveAmplitude = value;   }
        }

        [Category("SquareWave Setting")]
        [Description("方波幅度")]
        public double SquareWaveAmplitude
        {
            get
            {
                return squareWaveAmplitude;
            }

            set
            {
                squareWaveAmplitude = value;
            }
        }
        [Category("WhiteNoise Setting")]
        [Description("白噪声幅度")]
        public double WhiteNoiseAmplitude
        {
            get
            {
                return whiteNoiseAmplitude;
            }

            set
            {
                whiteNoiseAmplitude = value;
            }
        }
        [Category("SineWave Setting")]
        [Description("正弦波频率")]
        public double SineWaveFrequency
        {
            get
            { return sineWaveFrequency; }

            set
            { sineWaveFrequency = value; }
        }

       


        #endregion

        #region Public Methods
        public double[] WriteData()
        {
           
                if (IsDriverExisted)
                {
                    if (isRunning == true)
                    {
                        isRunning = false;
                        aoTask.Stop();
                    }
                    isConnected = aoTask.Initialize();
                    if (isConnected)
                    {
                        aoTask.SamplesToUpdate = samplesToUpdate;
                        aoTask.UpdateRate = updateRate;
                        aoTask.ContinuousMode = continuousRun;
                        aoTask.ConfigureChannel((int)ch, lowRange, highRange);

                        if (waveData == null || samplesToUpdate != waveData.GetLength(0))
                        {
                            waveData = new double[samplesToUpdate];
                        }
                        switch (waveType.ToString())
                        {

                            case "SineWave":
                                Generation.SineWave(ref waveData, SineWaveAmplitude, Phase, SineWaveFrequency, updateRate);//正弦波
                                break;
                            case "SquareWave":
                                Generation.SquareWave(ref waveData, SquareWaveAmplitude, DutyCycle, SquareWaveFrequency, updateRate);//方波
                                break;
                            case "UniformWhiteNoise":
                                Generation.UniformWhiteNoise(ref waveData, WhiteNoiseAmplitude);//白噪声
                                break;
                            case "CustomerWave":
                                MessageBox.Show("请输入自定义输出波形");
                                return null;


                            default:
                                return null;
                        }


                        aoTask.WriteData(waveData);
                        aoTask.Start();
                        isRunning = true;
                        return waveData;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
        


        }

        public double[] WriteData(double[] waveData)
        {
            if (IsDriverExisted)
            {
                if (isRunning == true)
                {
                    isRunning = false;
                    aoTask.Stop();
                }
                isConnected = aoTask.Initialize();
                if (isConnected)
                {
                    aoTask.SamplesToUpdate = samplesToUpdate;
                    aoTask.UpdateRate = updateRate;
                    aoTask.ContinuousMode = continuousRun;
                    aoTask.ConfigureChannel((int)ch, lowRange, highRange);

                    aoTask.WriteData(waveData);
                    aoTask.Start();
                    isRunning = true;
                    return waveData;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }
        public void Stop()
        {
            if (isRunning)
            {
                isRunning = false;
                aoTask.Stop();
            }

        }
        #endregion

        #region UI Utilities (Editor, Convertor)


     

        private class waveformTypeConverter : StringConverter
        {

            public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
            {
                return true;
            }

            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                return new StandardValuesCollection(EasyDAQ61902AO.waveformList);
            }

            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
            {
                return true;
            }
        }

    
        #endregion UI Utilities (Editor, Convertor)

    }
}
