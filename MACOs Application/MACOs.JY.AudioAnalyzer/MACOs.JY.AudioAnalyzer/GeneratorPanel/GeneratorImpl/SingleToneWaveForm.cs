using System.Windows.Forms;
using SeeSharpTools.JY.Audio;
using SeeSharpTools.JY.Audio.Waveform;

namespace MACOs.JY.AudioAnalyzer.GeneratorPanel.GeneratorImpl
{
    public partial class SingleToneWaveForm : Form, Generator
    {
        public SingleToneWaveForm()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        public double[] Generate()
        {
            double amplitude = (double) numericUpDown_amplitude.Value;
            double frequency = (double) numericUpDown_freq.Value;
            double duration = (double) numericUpDown_duration.Value/1000;

            GlobalInfo globalInfo = GlobalInfo.GetInstance();

            double updateRate = globalInfo.AOTask.GetUpdateRate();
            double[] outData = AudioGenerator.SingleToneWaveform(updateRate, (uint) (updateRate*duration), 
                amplitude, frequency, 0);
            return outData;
        }

        public uint GetChannelCount()
        {
            return 1;
        }

        public double GetAmplitude()
        {
            return (double)numericUpDown_amplitude.Value;
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
