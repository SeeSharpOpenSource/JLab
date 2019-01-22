using MACOs.JY.AudioAnalyzer.StateMachine;

namespace MACOs.JY.AudioAnalyzer.AOTask
{
    public interface AOTask
    {
        TriggerType TrigType { get; set; }
        TriggerCondition TrigCondition { get; set; }

        int GetChannelCount();
        void SetUpdateRate(double updateRate);
        double GetUpdateRate();
        void SetSamplesToUpdate(int samplesToUpdate);
        int GetSamplesToUpdate();
        void AddChannel(int channelId, double rangeLow, double rangeHigh);
        void Start();
        void WriteData(double[] buf, int timeOut);
        void WriteData(double[,] buf, int timeOut);
        void Stop();
    }
}