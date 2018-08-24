using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using JYUSB101;

namespace MACOs.JY.SoftFrontPanel
{
    internal class JYUSB101 : AnalogInputDevices, IDaq
    {
        #region Private Fields

        private JYUSB101AITask aiTask;

        #endregion Private Fields

        #region Constructor

        public JYUSB101(int boardNum)
        {
            aiTask = new JYUSB101AITask(boardNum);
            DAQInfo info = new DAQInfo()
            {
                MaxChannels = 2,
                MaxSampleRate = 100000,
                Ranges = new string[] { "5" },
                Terminals = Enum.GetNames(typeof(AITerminal))
            };
            DaqInfomation = info;

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

        public DAQInfo DaqInfomation { get; set; }

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
                aiTask.AddChannel(chID);
            }
        }

        public override void ConfigChannel(object chObject)
        {
            DAQInfo.ChannelConfig ch = chObject as DAQInfo.ChannelConfig;
            if (ch.EnableCh)
            {
                if (aiTask.Channels.Exists(x => x.ChannelID == ch.ChNum))
                {
                    aiTask.Channels.Find(x => x.ChannelID == ch.ChNum).RangeHigh = double.Parse(ch.Range);
                    aiTask.Channels.Find(x => x.ChannelID == ch.ChNum).RangeLow = double.Parse(ch.Range) * (-1);
                    aiTask.Channels.Find(x => x.ChannelID == ch.ChNum).Terminal = (AITerminal)Enum.Parse(typeof(AITerminal), ch.Terminal);
                }
                else
                {
                    aiTask.AddChannel(ch.ChNum);
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
                    aiTask.Trigger.Digital.Edge = trigParam.DigTrigEdge;
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

            for (int i = 0; i < DaqInfomation.MaxChannels; i++)
            {
                DAQInfo.ChannelConfig ch = new DAQInfo.ChannelConfig();
                ch.ConfigureLUT("Range", DaqInfomation.Ranges);
                ch.ConfigureLUT("Terminal", DaqInfomation.Terminals);
                ch.EnableCh = false;
                ch.ChNum = i;
                ch.Range = DaqInfomation.Ranges[0];
                ch.Terminal = DaqInfomation.Terminals[0];

                list.Add(ch);
            }
            return list;
        }

        #endregion Override Methods

        internal class Trigger
        {
            private AIDigitalTriggerSource _trigDigSrc = AIDigitalTriggerSource.AI_TRIG;
            private AIDigitalTriggerEdge _trigDigEdge = AIDigitalTriggerEdge.Rising;
            private AITriggerType _triggerType = AITriggerType.Immediate;
            private uint _trigDelay = 0;
            private double _trigAnaLevel = 0.5;

            [CategoryAttribute("DigitalTrigger")]
            public AIDigitalTriggerSource DigTrigSrc
            {
                get { return _trigDigSrc; }
                set { _trigDigSrc = value; }
            }

            [CategoryAttribute("DigitalTrigger")]
            public AIDigitalTriggerEdge DigTrigEdge
            {
                get { return _trigDigEdge; }
                set { _trigDigEdge = value; }
            }

            [CategoryAttribute("General")]
            public AITriggerType TrigType
            {
                get { return _triggerType; }
                set { _triggerType = value; }
            }

            [CategoryAttribute("General")]
            public uint TriggerDelay
            {
                get { return _trigDelay; }
                set { _trigDelay = value; }
            }

            [CategoryAttribute("General")]
            public double AnaTrigLevel
            {
                get { return _trigAnaLevel; }
                set { _trigAnaLevel = value; }
            }
        }
    }
}