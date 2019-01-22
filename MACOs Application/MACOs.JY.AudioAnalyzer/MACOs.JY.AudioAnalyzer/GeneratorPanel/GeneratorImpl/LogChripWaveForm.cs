using System.Windows.Forms;
using SeeSharpTools.JY.Audio;
using SeeSharpTools.JY.Audio.Waveform;

namespace MACOs.JY.AudioAnalyzer.GeneratorPanel.GeneratorImpl
{
    public partial class LogChripWaveForm : Form, Generator
    {
        public LogChripWaveForm()
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
            return (double)numericUpDown_amplitude1.Value;
        }

        public WaveformBase GetWaveform()
        {
            double amplitude = (double)numericUpDown_amplitude1.Value;
            double frequencyMin = (double)numericUpDown_freqMin.Value;
            double frequencyMax = (double)numericUpDown_freqMax.Value;
            double preSweepRatio = (double)numericUpDown_preSweepRatio.Value;
            double postSweepRatio = (double)numericUpDown_postSweepRatio.Value;
            double duration = (double)numericUpDown_duration.Value / 1000;

            GlobalInfo globalInfo = GlobalInfo.GetInstance();

            double updateRate = globalInfo.AOTask.GetUpdateRate();
            return new LogChirpWaveform(frequencyMin, frequencyMax, amplitude, preSweepRatio, postSweepRatio, updateRate,
                (uint) (duration*updateRate));
        }

        public WaveformBase GetRefWaveform()
        {
            double amplitude = (double)numericUpDown_amplitude1.Value;
            double frequencyMin = (double)numericUpDown_freqMin.Value;
            double frequencyMax = (double)numericUpDown_freqMax.Value;
            double preSweepRatio = (double)numericUpDown_preSweepRatio.Value;
            double postSweepRatio = (double)numericUpDown_postSweepRatio.Value;
            double duration = (double)numericUpDown_duration.Value / 1000;

            GlobalInfo globalInfo = GlobalInfo.GetInstance();

            double updateRate = globalInfo.AITask.GetSampleRate();
            return new LogChirpWaveform(frequencyMin, frequencyMax, amplitude, preSweepRatio, postSweepRatio, updateRate,
                (uint)(duration * updateRate));
        }
    }
}
