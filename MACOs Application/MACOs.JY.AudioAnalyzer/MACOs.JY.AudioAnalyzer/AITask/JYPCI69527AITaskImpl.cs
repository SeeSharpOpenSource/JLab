using JYPCI69527;
using MACOs.JY.AudioAnalyzer.StateMachine;

namespace MACOs.JY.AudioAnalyzer.AITask
{
    public class JYPCI69527AITaskImpl : AITask
    {
        public JYPCI69527AITask AITask { get; private set; }

        public JYPCI69527AITaskImpl(int boardId)
        {
            AITask = new JYPCI69527AITask(boardId);
            AITask.Mode = AIMode.Finite;
            AITask.Trigger.Type = AITriggerType.Immediate;
        }

        public TriggerType TrigType
        {
            get
            {
                if (AITriggerType.Digital == AITask.Trigger.Type)
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