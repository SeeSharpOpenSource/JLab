using System.Windows.Forms;
using SeeSharpTools.JY.Audio;
using SeeSharpTools.JY.Audio.Waveform;

namespace MACOs.JY.AudioAnalyzer.GeneratorPanel.GeneratorImpl
{
    public partial class SteppedLevelSineWaveform : Form, Generator
    {
        public SteppedLevelSineWaveform()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        public double[] Generate()
        {
            return GetWaveform().GetWaveData();
        }

        public uint GetChannelCount()
        {
            return 1;
        }

        public double GetAmplitude()
        {
            return (double)numericUpDown_amplitudeMax.Value;
        }

        public WaveformBase GetWaveform()
        {
            ushort steps = (ushort)numericUpDown_steps.Value;
            double amplitudeMax = (double)numericUpDown_amplitudeMax.Value;
            double amplitudeMin = (double)numericUpDown_amplitudeMin.Value;
            double frequency = (double)numericUpDown_freq.Value;
            ushort minCycle = (ushort)numericUpDown_minCycle.Value;
            double minDuration = (double)numericUpDown_duration.Value / 1000;

            GlobalInfo globalInfo = GlobalInfo.GetInstance();
            double updateRate = globalInfo.AOTask.GetUpdateRate();
            return new SeeSharpTools.JY.Audio.Waveform.SteppedLevelSineWaveform(updateRate, 
                amplitudeMin, amplitudeMax, frequency, steps, minCycle, minDuration);
        }

        public WaveformBase GetRefWaveform()
        {
            ushort steps = (ushort)numericUpDown_steps.Value;
            double amplitudeMax = (double)numericUpDown_amplitudeMax.Value;
            double amplitudeMin = (double)numericUpDown_amplitudeMin.Value;
            double frequency = (double)numericUpDown_freq.Value;
            ushort minCycle = (ushort)numericUpDown_minCycle.Value;
            double minDuration = (double)numericUpDown_duration.Value / 1000;

            GlobalInfo globalInfo = GlobalInfo.GetInstance();
            double updateRate = globalInfo.AITask.GetSampleRate();
            return new SeeSharpTools.JY.Audio.Waveform.SteppedLevelSineWaveform(updateRate,
                amplitudeMin, amplitudeMax, frequency, steps, minCycle, minDuration);
        }
    }
}
