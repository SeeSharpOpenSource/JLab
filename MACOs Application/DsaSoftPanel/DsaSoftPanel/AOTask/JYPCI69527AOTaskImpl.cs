using JYPCI69527;

namespace OscilloscopeSoftPanel.AOTask
{
    public class JYPCI69527AOTaskImpl : AOTask
    {
        public JYPCI69527AOTask AOTask { get; private set; }

        public JYPCI69527AOTaskImpl(int boardId)
        {
            AOTask = new JYPCI69527AOTask(boardId);
            AOTask.Mode = AOMode.Finite;
            AOTask.Trigger.Type = AOTriggerType.Immediate;
        }

        public TriggerType TrigType
        {
            get
            {
                if (AOTriggerType.Digital == AOTask.Trigger.Type)
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
                        AOTask.Trigger.Type = AOTriggerType.Digital;
                        break;
                    case TriggerType.Immediate:
                        AOTask.Trigger.Type = AOTriggerType.Immediate;
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
                    return AOTask.Trigger.Digital.Edge == AODigitalTriggerEdge.Rising
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
                AOTask.Trigger.Digital.Edge = TriggerCondition.Rising == value
                    ? AODigitalTriggerEdge.Rising
                    : AODigitalTriggerEdge.Falling;
            }
        }

        public int GetChannelCount()
        {
            return 2;
        }

        public void SetUpdateRate(double updateRate)
        {
            AOTask.UpdateRate = updateRate / 2;
        }

        public double GetUpdateRate()
        {
            return AOTask.UpdateRate;
        }

        public void SetSamplesToUpdate(int samplesToUpdate)
        {
            AOTask.SamplesToUpdate = samplesToUpdate;
        }

        public int GetSamplesToUpdate()
        {
            return AOTask.SamplesToUpdate;
        }

        public void AddChannel(int channelId, double rangeLow, double rangeHigh)
        {
            AOTask.AddChannel(channelId, rangeLow, rangeHigh);
        }

        public void Start()
        {
            AOTask.Start();
        }

        public void WriteData(double[] buf, int timeOut)
        {
            AOTask.WriteData(buf, timeOut);
        }

        public void WriteData(double[,] buf, int timeOut)
        {
            AOTask.WriteData(buf, timeOut);
        }


        public void Stop()
        {
            AOTask.Stop();
            AOTask.Channels.Clear();
        }
    }
}