using System;
using System.Threading;
using System.Windows.Forms;
using SeeSharpTools.JY.Audio;
using SeeSharpTools.JY.Audio.Waveform;

namespace MACOs.JY.AudioAnalyzer.GeneratorPanel.GeneratorImpl
{
    public partial class DualToneWaveForm : Form, Generator
    {
        public DualToneWaveForm()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        private DualToneWaveForm _waveform = null;

        public double[] Generate()
        {
            double amplitude1 = (double) numericUpDown_amplitude1.Value;
            double frequency1 = (double) numericUpDown_freq1.Value;
            double amplitude2 = (double) numericUpDown_amplitude2.Value;
            double frequency2 = (double) numericUpDown_freq2.Value;
            double duration = (double) numericUpDown_duration.Value / 1000;

            GlobalInfo globalInfo = GlobalInfo.GetInstance();

            double updateRate = globalInfo.AOTask.GetUpdateRate();
            double[] outData = AudioGenerator.DualToneWaveform(updateRate, frequency1, frequency2, amplitude1,
                amplitude2, (uint) (updateRate*duration));
            return outData;
        }

        public uint GetChannelCount()
        {
            return 1;
        }

        public double GetAmplitude()
        {
            double amplitude1 = (double)numericUpDown_amplitude1.Value;
            double amplitude2 = (double)numericUpDown_amplitude2.Value;
            return amplitude1 + amplitude2;
        }

        public WaveformBase GetWaveform()
        {
            throw new System.NotImplementedException();
        }

        public WaveformBase GetRefWaveform()
        {
            throw new System.NotImplementedException();
        }
    }
}
