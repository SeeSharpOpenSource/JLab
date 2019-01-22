using System;
using SeeSharpTools.JY.Audio.Waveform;

namespace MACOs.JY.AudioAnalyzer.GeneratorPanel
{
    public interface Generator
    {
        double[] Generate();
        uint GetChannelCount();
        double GetAmplitude();
        WaveformBase GetWaveform();
        WaveformBase GetRefWaveform();
    }
}