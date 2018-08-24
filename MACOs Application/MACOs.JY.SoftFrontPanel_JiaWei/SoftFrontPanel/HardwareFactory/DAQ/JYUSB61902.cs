using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using JYUSB61902;

namespace MACOs.JY.SoftFrontPanel
{
    class JYUSB61902 : AnalogInputDevices,IDaq
    {
        #region Private Fields
        private JYUSB61902AITask aiTask;

        #endregion

        #region Constructor
        public JYUSB61902(int boardNum)
        {
            aiTask = new JYUSB61902AITask(boardNum);
            DAQInfo info = new DAQInfo() {
                MaxChannels = 16,
                MaxSampleRate = 250000,
                Ranges = new string[] { "0.2", "1", "2", "10" },
                Terminals = Enum.GetNames(typeof(AITerminal))
            };
            DaqInfomation = info;

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
                aiTask.AddChannel(chID, range * (-1.0), range);
            }
        }

        public override void ConfigChannel(object chObject)
        {
            DAQInfo.ChannelConfig ch = chObject as DAQInfo.ChannelConfig;
            if (ch.EnableCh)
            {
                if (aiTask.Channels.Exists(x=>x.ChannelID==ch.ChNum))
                {
                    aiTask.Channels.Find(x => x.ChannelID == ch.ChNum).RangeHigh = double.Parse(ch.Range);
                    aiTask.Channels.Find(x => x.ChannelID == ch.ChNum).RangeLow = double.Parse(ch.Range)*(-1);
                    aiTask.Channels.Find(x => x.ChannelID == ch.ChNum).Terminal = (AITerminal)Enum.Parse(typeof(AITerminal), ch.Terminal);
                    
                }
                else
                {
                    aiTask.AddChannel(
                    ch.ChNum,
                    double.Parse(ch.Range) * (-1),
                    double.Parse(ch.Range),
                    (AITerminal)Enum.Parse(typeof(AITerminal), ch.Terminal)
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

                    aiTask.Trigger.Digital.Edge = trigParam.DigTrigEdge;
                    aiTask.Trigger.Delay = trigParam.TriggerDelay;
                    break;

                case AITriggerType.Analog:

                    aiTask.Trigger.Analog.Source = trigParam.AnaTrigSrc;
                    aiTask.Trigger.Delay = trigParam.TriggerDelay;
                    aiTask.Trigger.Analog.Condition = trigParam.AnaTrigCond;
                    aiTask.Trigger.Analog.Level = trigParam.AnaTrigLevel;
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
                ch.Range = DaqInfomation.Ranges[3];
                ch.Terminal = DaqInfomation.Terminals[0];                
                
                list.Add(ch);
            }
            return list;
        }

        #endregion

        internal class Trigger
        {
            private AIAnalogTriggerSource _trigAnaSrc = AIAnalogTriggerSource.CH0;
            private AIDigitalTriggerSource _trigDigSrc = AIDigitalTriggerSource.AITG;
            private AIDigitalTriggerEdge _trigDigEdge = AIDigitalTriggerEdge.Rising;
            private AITriggerType _triggerType = AITriggerType.Immediate;
            private AIAnalogTriggerCondition _anaTrigCond = AIAnalogTriggerCondition.AboveLevel;
            private uint _trigDelay = 0;
            private double _trigAnaLevel = 0.5;

            [CategoryAttribute("AnalogTrigger")]
            public AIAnalogTriggerSource AnaTrigSrc
            {
                get { return _trigAnaSrc; }
                set { _trigAnaSrc = value; }
            }
            [CategoryAttribute("AnalogTrigger")]
            public AIAnalogTriggerCondition AnaTrigCond
            {
                get { return _anaTrigCond; }
                set { _anaTrigCond = value; }
            }
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
