using System;
using DsaSoftPanel.Enumeration;

namespace DsaSoftPanel.AITask
{
    public interface AITask : ITriggerable
    {
        double MaxSampleRate { get; }
        int GetChannelCount();
        void SetSampleRate(double sampleRate);
        double GetSampleRate();
        void AddChannel(int channelId, double range, Coupling coupling);
        void Start();
        void ReadData(ref double[] buf, int timeOut);
        void ReadData(ref double[] buf, int samplesPerChannel, int timeOut);
        void ReadData(ref double[,] buf, int timeOut);
        void ReadData(ref double[,] buf, int samplesPerChannel, int timeOut);
        void Stop();

        void ClearChannels();

        bool IsBoardDisconnected(int errorCode);
    }
}