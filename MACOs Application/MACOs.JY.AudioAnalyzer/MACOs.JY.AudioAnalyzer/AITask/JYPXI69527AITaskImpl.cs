using JYPXI69527;
using MACOs.JY.AudioAnalyzer.StateMachine;

namespace MACOs.JY.AudioAnalyzer.AITask
{
    public class JYPXI69527AITaskImpl : AITask
    {
        public JYPXI69527AITask AITask { get; private set; }

        public JYPXI69527AITaskImpl(int boardId)
        {
            AITask = new JYPXI69527AITask(boardId);
            AITask.Mode = JYPXI69527.AIMode.Finite;
            AITask.Trigger.Type = AITriggerType.Immediate;
            //AITask.Trigger.Type = JYPXI69527.AITriggerType.Analog;
            //AITask.Trigger.Analog.Source = JYPXI69527.AIAnalogTriggerSource.CH0;
            //AITask.Trigger.Analog.Threshold = 0.1;        
        }

        public TriggerType TrigType
        {
            get
            {
                if (JYPXI69527.AITriggerType.Digital == AITask.Trigger.Type)
                {
                    return TriggerType.Digital;
                }
                return TriggerType.Immediate;
            }
            set
            {
                switch (value)
                {
                    case TriggerType.Digital:
                        AITask.Trigger.Type = AITriggerType.Digital;
                        break;
                    case TriggerType.Immediate:
                        AITask.Trigger.Type = AITriggerType.Immediate;
                        break;
                }
            }
        }

        public TriggerCondition TrigCondition
        {
            get
            {
                if (TriggerType.Digital == TrigType)
                {
                    return AITask.Trigger.Digital.Edge == AIDigitalTriggerEdge.Rising
                        ? TriggerCondition.Rising
                        : TriggerCondition.Falling;
                }
                return TriggerCondition.Rising;
            }
            set
            {
                if (TriggerType.Immediate == TrigType)
                {
                    return;
                }
                AITask.Trigger.Digital.Edge = TriggerCondition.Rising == value
                    ? AIDigitalTriggerEdge.Rising
                    : AIDigitalTriggerEdge.Falling;
            }
        }

        public int GetChannelCount()
        {
            return 2;
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

        public void AddChannel(int channelId, double ranglow, double rangeHigh)
        {
            AITask.AddChannel(channelId, ranglow, rangeHigh);
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
            AITask.Channels.Clear();
        }
    }
}