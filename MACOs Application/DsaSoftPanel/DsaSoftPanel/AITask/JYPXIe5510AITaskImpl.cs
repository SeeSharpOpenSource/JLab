using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DsaSoftPanel.Enumeration;
using JYPXIe5510;

namespace DsaSoftPanel.AITask
{
    public class JYPXIe5510AITaskImpl : AITask
    {
        private readonly JYPXIe5510AITask _aitask;

        public JYPXIe5510AITaskImpl(int boardId)
        {
            _aitask = new JYPXIe5510AITask(boardId);
        }

        public bool TriggerEnabled => _aitask.Trigger.Type != AITriggerType.Immediate;
        public string TriggerMode
        {
            get { return _aitask.Trigger.Mode.ToString(); }
            set { _aitask.Trigger.Mode = (AITriggerMode)Enum.Parse(typeof(AITriggerMode), value); }
        }
        public string TriggerType
        {
            get { return _aitask.Trigger.Type.ToString(); }
            set { _aitask.Trigger.Type = (AITriggerType)Enum.Parse(typeof(AITriggerType), value); }
        }
        public string AnalogTriggerSource
        {
            get { return _aitask.Trigger.Analog.Source.ToString(); }
            set { _aitask.Trigger.Analog.Source = (AIAnalogTriggerSource)Enum.Parse(typeof(AIAnalogTriggerSource), value); }
        }
        public string AnalogTriggerCondition
        {
            get { return _aitask.Trigger.Analog.Condition.ToString(); }
            set { _aitask.Trigger.Analog.Condition = (AIAnalogTriggerCondition)Enum.Parse(typeof(AIAnalogTriggerCondition), value); }
        }

        public double AnalogTriggerThreshold
        {
            get { return _aitask.Trigger.Analog.HighLevel; }
            set
            {
                _aitask.Trigger.Analog.HighLevel = value;
                _aitask.Trigger.Analog.LowLevel = value;
            }
        }
        public string DigitalTriggerSource
        {
            get { return _aitask.Trigger.Digital.Source.ToString(); }
            set { _aitask.Trigger.Digital.Source = (AIDigitalTriggerSource)Enum.Parse(typeof(AIDigitalTriggerSource), value); }
        }
        public string DigitalTriggerEdge
        {
            get { return _aitask.Trigger.Digital.Edge.ToString(); }
            set { _aitask.Trigger.Digital.Edge = (AIDigitalTriggerEdge)Enum.Parse(typeof(AIDigitalTriggerEdge), value); }
        }
        public string[] GetTriggerModes()
        {
            return new string[] { AITriggerMode.Start.ToString() };
        }

        public string[] GetTriggerTypes()
        {
            return Enum.GetNames(typeof(AITriggerType));
        }

        public string[] GetAnalogTriggerSources()
        {
            return Enum.GetNames(typeof(AIAnalogTriggerSource));
        }

        public string[] GetAnalogTriggerConditions()
        {
            return new string[]
            {
                AIAnalogTriggerCondition.FallingHysteresis.ToString(), AIAnalogTriggerCondition.RisingHysteresis.ToString()
            };
        }

        public string[] GetDigitalTriggerSources()
        {
            return Enum.GetNames(typeof(AIDigitalTriggerSource));
        }

        public string[] GetDigitalTriggerEdge()
        {
            return Enum.GetNames(typeof(AIDigitalTriggerEdge));
        }

        public void SendSoftTrigger()
        {
            this._aitask.SendSoftwareTrigger(this._aitask.Trigger.Mode);
        }

        public double MaxSampleRate => 1E6 / GetChannelCount();
        public int GetChannelCount()
        {
            return 4;
        }

        public void SetSampleRate(double sampleRate)
        {
            _aitask.SampleRate = sampleRate;
        }

        public double GetSampleRate()
        {
            return _aitask.SampleRate;
        }

        public void AddChannel(int channelId, double range, Coupling coupling)
        {
            _aitask.AddChannel(channelId, range * -1, range);
        }

        public void Start()
        {
            _aitask.Start();
        }

        public void ReadData(ref double[] buf, int timeOut)
        {
            _aitask.ReadData(ref buf, timeOut);
        }

        public void ReadData(ref double[] buf, int samplesPerChannel, int timeOut)
        {
            _aitask.ReadData(ref buf, samplesPerChannel, timeOut);
        }

        public void ReadData(ref double[,] buf, int timeOut)
        {
            _aitask.ReadData(ref buf, timeOut);
        }

        public void ReadData(ref double[,] buf, int samplesPerChannel, int timeOut)
        {
            _aitask.ReadData(ref buf, samplesPerChannel, timeOut);
        }

        public void Stop()
        {
            _aitask.Stop();
        }

        public void ClearChannels()
        {
            _aitask.RemoveChannel(-1);
        }

        public bool IsBoardDisconnected(int errorCode)
        {
            return false;
        }
    }
}
