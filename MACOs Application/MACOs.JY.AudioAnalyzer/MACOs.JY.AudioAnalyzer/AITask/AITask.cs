using System;
using MACOs.JY.AudioAnalyzer.StateMachine;

namespace MACOs.JY.AudioAnalyzer.AITask
{
    public interface AITask
    {
        TriggerType TrigType { get; set; }
        TriggerCondition TrigCondition { get; set; }

        int GetChannelCount();
        void SetSampleRate(double sampleRate);
        double GetSampleRate();
        void SetSamplesToAcquire(int samplesToAcquire);
        int GetSamplesToAcquire();
        void AddChannel(int channelId, double ranglow, double rangeHigh);
        void Start();
        void ReadData(ref double[] buf, int timeOut);
        void ReadData(ref double[] buf, int samplesPerChannel, int timeOut);
        void ReadData(ref double[,] buf, int timeOut);
        void ReadData(ref double[,] buf, int samplesPerChannel, int timeOut);
        void Stop();

    }
}