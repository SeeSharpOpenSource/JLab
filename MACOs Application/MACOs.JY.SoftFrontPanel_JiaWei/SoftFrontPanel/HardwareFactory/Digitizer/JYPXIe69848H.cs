using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using JYPXIe69848H;

namespace MACOs.JY.SoftFrontPanel
{
    class JYPXIe69848H : SoftFrontPanel.AnalogInputDevices, IDigitizer
    {
        #region Private Fields
        private JYPXIe69848HAITask aiTask;

        #endregion

        #region Constructor
        public JYPXIe69848H(int boardNum)
        {
            aiTask = new JYPXIe69848HAITask(boardNum);
            DigitizerInfo info = new DigitizerInfo()
            {
                MaxChannels = 8,
                MaxSampleRate = 100000000,
                Ranges = new string[] { "0.2", "2" },
                Couplings = Enum.GetNames(typeof(AICoupling)),
                Impedances = Enum.GetNames(typeof(AIImpedance)),
            };
            DigitizerInformation = info;
            TriggerSetting = new Trigger();
        }

        #endregion

        #region Override Methods
        public override int[] SelectedChannels
        {
            get
            {
                int[] chList = new int[aiTask.Channels.Count];
                for (int i = 0; i < aiTask.Channels.Count; i++)
                {
                    chList[i] = aiTask.Channels[i].ChannelID;
                }

                return chList;
            }
        }

        public override bool ReadyToFetch
        {
            get
            {
                if (aiTask != null)
                {
                    return aiTask.AvailableSamples >= aiTask.SamplesToAcquire;
                }
                else
                {
                    return true;
                }
            }
        }

        public DigitizerInfo DigitizerInformation { get; set; }

        public override void ConfigChannel(object chObject)
        {
            DigitizerInfo.ChannelConfig ch = (DigitizerInfo.ChannelConfig)chObject;
            if (ch.EnableCh)
            {
                if (aiTask.Channels.Exists(x => x.ChannelID == ch.ChNum))
                {
                    aiTask.Channels.Find(x => x.ChannelID == ch.ChNum).RangeHigh = double.Parse(ch.Range);
                    aiTask.Channels.Find(x => x.ChannelID == ch.ChNum).RangeLow = double.Parse(ch.Range) * (-1);
                    aiTask.Channels.Find(x => x.ChannelID == ch.ChNum).Coupling = (AICoupling)Enum.Parse(typeof(AICoupling), ch.Coupling);
                    aiTask.Channels.Find(x => x.ChannelID == ch.ChNum).Impedance = (AIImpedance)Enum.Parse(typeof(AIImpedance), ch.Impedance);

                }
                else
                {
                    aiTask.AddChannel(
                    ch.ChNum,
                    double.Parse(ch.Range) * (-1),
                    double.Parse(ch.Range),
                    (AICoupling)Enum.Parse(typeof(AICoupling), ch.Coupling),
                    (AIImpedance)Enum.Parse(typeof(AIImpedance), ch.Impedance)
                    );
                }

            }
            else
            {
                aiTask.RemoveChannel(ch.ChNum);
            }

        }
        public override void RemoveChannel(int chID)
        {
            aiTask.RemoveChannel(chID);
        }
        public override void ConfigTiming(double samplingRate, int samplesToRead)
        {
            aiTask.Mode = AIMode.Finite;
            SamplesToRead = samplesToRead;
            SampleRate = samplingRate;
            aiTask.SampleRate = samplingRate;
            aiTask.SamplesToAcquire = samplesToRead;

        }
        public override void ConfigTrigger(object param)
        {
            var trgParam = (Trigger)param;

            aiTask.Trigger.Type = trgParam.TriggerType;

            switch (aiTask.Trigger.Type)
            {
                case AITriggerType.Immediate:
                    break;
                case AITriggerType.Software:
                    break;
                case AITriggerType.Digital:
                    aiTask.Trigger.Digital.Source = trgParam.TriggerDigitalSrc;
                    aiTask.Trigger.Digital.Edge = trgParam.TriggerEdge;
                    aiTask.Trigger.Mode = trgParam.TriggerMode;
                    aiTask.Trigger.Delay = trgParam.TriggerDelay;
                    aiTask.Trigger.PreTriggerSamples = trgParam.PreTriggerSamples;

                    break;
                case AITriggerType.Analog:
                    aiTask.Trigger.Analog.Source = trgParam.TriggerAnalogSrc;
                    aiTask.Trigger.Analog.Edge = trgParam.TriggerEdge;
                    aiTask.Trigger.Mode = trgParam.TriggerMode;
                    aiTask.Trigger.Delay = trgParam.TriggerDelay;
                    aiTask.Trigger.Analog.Level = trgParam.TriggerAnalogLevel;
                    aiTask.Trigger.PreTriggerSamples = trgParam.PreTriggerSamples;

                    break;
                default:
                    break;

            }
        }
        public override void Start()
        {
            aiTask.Start();
        }
        public override void Fetch(ref double[,] fetchData)
        {
            aiTask.ReadData(ref fetchData, aiTask.SamplesToAcquire, -1);
        }
        public override void Stop()
        {
            aiTask.Stop();
        }
        public override BindingList<object> GetChannelMap()
        {
            BindingList<object> list = new BindingList<object>();

            for (int i = 0; i < DigitizerInformation.MaxChannels; i++)
            {
                DigitizerInfo.ChannelConfig ch = new DigitizerInfo.ChannelConfig();
                ch.ConfigureLUT("Range", DigitizerInformation.Ranges);
                ch.ConfigureLUT("Impedance", DigitizerInformation.Impedances);
                ch.ConfigureLUT("Coupling", DigitizerInformation.Couplings);
                ch.EnableCh = false;
                ch.ChNum = i;
                ch.Range = DigitizerInformation.Ranges[0];
                ch.Impedance = DigitizerInformation.Impedances[0];
                ch.Coupling = DigitizerInformation.Couplings[0];

                list.Add(ch);
            }
            return list;
        }

        #endregion

        internal class Trigger
        {
            private double _trigAnaLevel = 0.5;
            private AIAnalogTriggerSource _trigAnaSrc = AIAnalogTriggerSource.CH0;
            private double _trigDelay = 0.0;
            private AIDigitalTriggerSource _trigDigSrc = AIDigitalTriggerSource.TRG;
            private AITriggerEdge _trigEdge = AITriggerEdge.Rising;
            private AITriggerMode _trigMode = AITriggerMode.Start;
            private AITriggerType _trigType = AITriggerType.Immediate;
            private uint _preTrigSamples = 0;

            [CategoryAttribute("AnalogTrigger")]
            public double TriggerAnalogLevel
            {
                get { return _trigAnaLevel; }
                set { _trigAnaLevel = value; }

            }
            [CategoryAttribute("AnalogTrigger")]
            public AIAnalogTriggerSource TriggerAnalogSrc
            {
                get { return _trigAnaSrc; }
                set { _trigAnaSrc = value; }
            }
            [CategoryAttribute("Digital")]
            public AIDigitalTriggerSource TriggerDigitalSrc
            {
                get { return _trigDigSrc; }
                set { _trigDigSrc = value; }
            }
            [CategoryAttribute("General")]
            public AITriggerEdge TriggerEdge
            {
                get { return _trigEdge; }
                set { _trigEdge = value; }
            }
            [CategoryAttribute("General")]
            public AITriggerMode TriggerMode
            {
                get { return _trigMode; }
                set { _trigMode = value; }
            }
            [CategoryAttribute("General")]
            public AITriggerType TriggerType
            {
                get { return _trigType; }
                set { _trigType = value; }
            }
            [CategoryAttribute("General")]
            public uint PreTriggerSamples
            {
                get { return _preTrigSamples; }
                set { _preTrigSamples = value; }
            }
            [CategoryAttribute("General")]
            public double TriggerDelay
            {
                get { return _trigDelay; }
                set { _trigDelay = value; }
            }


        }
    }


}
