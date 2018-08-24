using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using JYUSB62405;

namespace MACOs.JY.SoftFrontPanel
{
    internal class JYUSB62405 : AnalogInputDevices, IDsa
    {
        #region Private Fields

        private JYUSB62405AITask aiTask;

        #endregion Private Fields

        #region Constructor

        public JYUSB62405(int boardNum)
        {
            aiTask = new JYUSB62405AITask(boardNum);
            DSAInfo info = new DSAInfo()
            {
                MaxChannels = 4,
                MaxSampleRate = 128000,
                Ranges = new string[] { "10" },
                Couplings = Enum.GetNames(typeof(Coupling)),
                Terminals = Enum.GetNames(typeof(AITerminal)),
            };
            DSAInformation = info;
            TriggerSetting = new Trigger();
        }

        #endregion Constructor

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

        public DSAInfo DSAInformation { get; set; }

        public override void ConfigChannel(int chID, double range)
        {
            //if channel exists, only reconfig the channel
            if (aiTask.Channels.Exists(x => x.ChannelID == chID))
            {
                AIChannel channel = aiTask.Channels.Find(x => x.ChannelID == chID);
                channel.RangeLow = range * (-1.0);
                channel.RangeHigh = range;
            }
            else
            {
                aiTask.AddChannel(chID, range * (-1.0), range);
            }
        }

        public override void ConfigChannel(object chObject)
        {
            DSAInfo.ChannelConfig ch = (DSAInfo.ChannelConfig)chObject;
            if (ch.EnableCh)
            {
                if (aiTask.Channels.Exists(x => x.ChannelID == ch.ChNum))
                {
                    aiTask.Channels.Find(x => x.ChannelID == ch.ChNum).RangeHigh = double.Parse(ch.Range);
                    aiTask.Channels.Find(x => x.ChannelID == ch.ChNum).RangeLow = double.Parse(ch.Range) * (-1);
                    aiTask.Channels.Find(x => x.ChannelID == ch.ChNum).Coupling = (Coupling)Enum.Parse(typeof(Coupling), ch.Coupling);
                    aiTask.Channels.Find(x => x.ChannelID == ch.ChNum).Terminal = (AITerminal)Enum.Parse(typeof(AITerminal), ch.Terminal);
                    aiTask.Channels.Find(x => x.ChannelID == ch.ChNum).EnableIEPE = ch.EnableIEPE;
                }
                else
                {
                    aiTask.AddChannel(
                    ch.ChNum,
                    double.Parse(ch.Range) * (-1),
                    double.Parse(ch.Range),
                    (Coupling)Enum.Parse(typeof(Coupling), ch.Coupling),
                    (AITerminal)Enum.Parse(typeof(AITerminal), ch.Terminal),
                    ch.EnableIEPE
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

        public override void ConfigTrigger(object triggerParam)
        {
            var trigParam = (Trigger)triggerParam;
            aiTask.Trigger.Type = trigParam.TrigType;

            switch (aiTask.Trigger.Type)
            {
                case AITriggerType.Immediate:
                    break;

                case AITriggerType.Digital:

                    aiTask.Trigger.Digital.Edge = trigParam.TrigEdge;
                    aiTask.Trigger.Delay = trigParam.TriggerDelay;
                    break;

                case AITriggerType.Analog:

                    aiTask.Trigger.Analog.Source = trigParam.AnaTrigSrc;
                    aiTask.Trigger.Delay = trigParam.TriggerDelay;
                    aiTask.Trigger.Analog.Threshold = trigParam.AnaTrigLevel;
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

            for (int i = 0; i < DSAInformation.MaxChannels; i++)
            {
                DSAInfo.ChannelConfig ch = new DSAInfo.ChannelConfig();
                ch.ConfigureLUT("Range", DSAInformation.Ranges);
                ch.ConfigureLUT("Terminal", DSAInformation.Terminals);
                ch.ConfigureLUT("Coupling", DSAInformation.Couplings);

                ch.EnableCh = false;
                ch.ChNum = i;
                ch.Range = DSAInformation.Ranges[0];
                ch.Terminal = DSAInformation.Terminals[0];
                ch.Coupling = DSAInformation.Couplings[0];

                list.Add(ch);
            }
            return list;
        }

        #endregion Override Methods

        internal class Trigger
        {
            private AIAnalogTriggerSource _trigAnaSrc = AIAnalogTriggerSource.CH0;
            private AIDigitalTriggerSource _trigDigSrc = AIDigitalTriggerSource.GPIO0;
            private AITriggerEdge _trigEdge = AITriggerEdge.Rising;
            private AITriggerType _triggerType = AITriggerType.Immediate;
            private AITriggerMode _triggerMode = AITriggerMode.Start;
            private uint _trigDelay = 0;
            private double _trigAnaLevel = 0.5;
            private int _reTrigCnt = 0;

            [CategoryAttribute("AnalogTrigger")]
            public AIAnalogTriggerSource AnaTrigSrc
            {
                get { return _trigAnaSrc; }
                set { _trigAnaSrc = value; }
            }

            [CategoryAttribute("AnalogTrigger")]
            public double AnaTrigLevel
            {
                get { return _trigAnaLevel; }
                set { _trigAnaLevel = value; }
            }

            [CategoryAttribute("DigitalTrigger")]
            public AIDigitalTriggerSource DigTrigSrc
            {
                get { return _trigDigSrc; }
                set { _trigDigSrc = value; }
            }

            [CategoryAttribute("General")]
            public AITriggerEdge TrigEdge
            {
                get { return _trigEdge; }
                set { _trigEdge = value; }
            }

            [CategoryAttribute("General")]
            public AITriggerType TrigType
            {
                get { return _triggerType; }
                set { _triggerType = value; }
            }

            [CategoryAttribute("General")]
            public AITriggerMode TrigMode
            {
                get { return _triggerMode; }
                set { _triggerMode = value; }
            }

            [CategoryAttribute("General")]
            public uint TriggerDelay
            {
                get { return _trigDelay; }
                set { _trigDelay = value; }
            }

            [CategoryAttribute("General")]
            public int RetriggerCount
            {
                get { return _reTrigCnt; }
                set { _reTrigCnt = value; }
            }
        }
    }
}