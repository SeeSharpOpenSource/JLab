using SeeSharpTools.JY.Audio.Equilizer;

namespace MACOs.JY.AudioAnalyzer.GeneratorPanel.Equilizer
{
    public interface IEquilizer
    {
        EqualizerBase GetEqualizer();
        double GetTargetAmplitude();
    }
}