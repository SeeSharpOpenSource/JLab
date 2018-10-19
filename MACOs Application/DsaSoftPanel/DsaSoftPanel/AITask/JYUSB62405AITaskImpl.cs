using System;
using JYUSB62405;
using Coupling = DsaSoftPanel.Enumeration.Coupling;

namespace DsaSoftPanel.AITask
{
    public class JYUSB62405AITaskImpl : AITask
    {
        public JYUSB62405AITask AITask { get; private set; }

        public JYUSB62405AITaskImpl(int boardId)
        {
            AITask = new JYUSB62405AITask(boardId);
            AITask.Mode = AIMode.Continuous;
            AITask.Trigger.Type = AITriggerType.Immediate;
        }

        public double MaxSampleRate => 128000;

        public int GetChannelCount()
        {
            return 4;
        }

        public void SetSampleRate(double sampleRate)
        {
            AITask.SampleRate = sampleRate;
        }

        public double GetSampleRate()
        {
            return AITask.SampleRate;
        }

        public void SetSamplesToAcquire(int samplesToAcquire)
        {
            AITask.SamplesToAcquire = samplesToAcquire;
        }

        public int GetSamplesToAcquire()
        {
            return AITask.SamplesToAcquire;
        }

        public void AddChannel(int channelId, double range, Enumeration.Coupling coupling)
        {
            JYUSB62405.Coupling realCoupling = Enumeration.Coupling.AC == coupling ? JYUSB62405.Coupling.AC : JYUSB62405.Coupling.DC;
            AITask.AddChannel(channelId, -1 * range, range, realCoupling);
        }

        public void Start()
        {
            AITask.Start();
        }

        public void ReadData(ref double[] buf, int timeOut)
        {
            AITask.ReadData(ref buf, timeOut);
        }

        public void ReadData(ref double[] buf, int samplesPerChannel, int timeOut)
        {
            AITask.ReadData(ref buf, samplesPerChannel, timeOut);
        }

        public void ReadData(ref double[,] buf, int timeOut = -1)
        {
            AITask.ReadData(ref buf, timeOut);
        }

        public void ReadData(ref double[,] buf, int samplesPerChannel, int timeOut)
        {
            AITask.ReadData(ref buf, samplesPerChannel, timeOut);
        }

        public void Stop()
        {
            AITask.Stop();
        }

        public void ClearChannels()
        {
            AITask.Channels.Clear();
        }

        public bool IsBoardDisconnected(int errorCode)
        {
            throw new System.NotImplementedException();
        }

        public bool TriggerEnabled => AITask.Trigger.Type != AITriggerType.Immediate;

        public string TriggerMode
        {
            get { return AITask.Trigger.Mode.ToString(); }
            set { return; }
        }

        public string TriggerType
        {
            get { return AITask.Trigger.Type.ToString(); }
            set { AITask.Trigger.Type = (AITriggerType)Enum.Parse(typeof(AITriggerType), value); }
        }

        public string AnalogTriggerSource
        {
            get { return AITask.Trigger.Analog.Source.ToString(); }
            set { AITask.Trigger.Analog.Source = (AIAnalogTriggerSource)Enum.Parse(typeof(AIAnalogTriggerSource), value); }
        }

        public string AnalogTriggerCondition
        {
            get { return AITask.Trigger.Analog.Edge.ToString(); }
            set { AITask.Trigger.Analog.Edge = (AITriggerEdge)Enum.Parse(typeof(AITriggerEdge), value); }
        }

        public double AnalogTriggerThreshold
        {
            get { return AITask.Trigger.Analog.Threshold; }
            set { AITask.Trigger.Analog.Threshold = value; }
        }

        public string DigitalTriggerSource
        {
            get { return AITask.Trigger.Digital.Source.ToString(); }
            set { return; }
        }

        public string DigitalTriggerEdge
        {
            get { return AITask.Trigger.Digital.Edge.ToString(); }
            set
            {
                AITask.Trigger.Digital.Edge = (AITriggerEdge)Enum.Parse(typeof(AITriggerEdge), value);
            }
        }

        public string[] GetTriggerModes()
        {
            return Enum.GetNames(typeof(AITriggerMode));
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
            return Enum.GetNames(typeof(AITriggerEdge));
        }

        public string[] GetDigitalTriggerSources()
        {
            return Enum.GetNames(typeof(AIDigitalTriggerSource));
        }

        public string[] GetDigitalTriggerEdge()
        {
            return Enum.GetNames(typeof(AITriggerEdge));
        }
    }
}