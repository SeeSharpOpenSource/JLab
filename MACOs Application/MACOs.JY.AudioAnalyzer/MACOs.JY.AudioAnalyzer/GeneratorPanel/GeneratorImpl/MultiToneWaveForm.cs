using System.Windows.Forms;
using SeeSharpTools.JY.Audio;
using SeeSharpTools.JY.Audio.Waveform;

namespace MACOs.JY.AudioAnalyzer.GeneratorPanel.GeneratorImpl
{
    public partial class MultiToneWaveForm : Form, Generator
    {
        public MultiToneWaveForm()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        public double[] Generate()
        {
            double amplitude = (double) numericUpDown_amplitude1.Value;
            double frequencyMin = (double) numericUpDown_freq1.Value;
            ushort points = (ushort) numericUpDown_points.Value;
            double frequencyMax = (double) numericUpDown_freq2.Value;
            double duration = (double) numericUpDown_duration.Value / 1000;

            GlobalInfo globalInfo = GlobalInfo.GetInstance();

            double updateRate = globalInfo.AOTask.GetUpdateRate();
            double[] outData = AudioGenerator.MultiToneWaveform(updateRate, (uint) (updateRate*duration), amplitude, frequencyMin, frequencyMax,points);
            return outData;
        }

        public uint GetChannelCount()
        {
            return 1;
        }

        public double GetAmplitude()
        {
            double amplitude1 = (double)numericUpDown_amplitude1.Value;
            double points = (double)numericUpDown_points.Value;
            return amplitude1* points;
        }

        public WaveformBase GetWaveform()
        {
            double amplitude = (double)numericUpDown_amplitude1.Value;
            double frequencyMin = (double)numericUpDown_freq1.Value;
            ushort points = (ushort)numericUpDown_points.Value;
            double frequencyMax = (double)numericUpDown_freq2.Value;
            double duration = (double)numericUpDown_duration.Value / 1000;

            GlobalInfo globalInfo = GlobalInfo.GetInstance();

            double updateRate = globalInfo.AOTask.GetUpdateRate();
            return new MultiToneWaveform(frequencyMin, frequencyMax, amplitude, 
                points, updateRate, (uint) (updateRate * duration));
        }

        public WaveformBase GetRefWaveform()
        {
            double amplitude = (double)numericUpDown_amplitude1.Value;
            double frequencyMin = (double)numericUpDown_freq1.Value;
            ushort points = (ushort)numericUpDown_points.Value;
            double frequencyMax = (double)numericUpDown_freq2.Value;
            double duration = (double)numericUpDown_duration.Value / 1000;

            GlobalInfo globalInfo = GlobalInfo.GetInstance();

            double sampleRate = globalInfo.AITask.GetSampleRate();
            return new MultiToneWaveform(frequencyMin, frequencyMax, amplitude,
                points, sampleRate, (uint)(sampleRate * duration));
        }
    }
}
