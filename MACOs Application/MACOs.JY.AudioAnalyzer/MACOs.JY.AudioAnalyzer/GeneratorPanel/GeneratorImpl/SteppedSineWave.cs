using System.Windows.Forms;
using MACOs.JY.AudioAnalyzer.GeneratorPanel.Equilizer.EquilizerImpl;
using SeeSharpTools.JY.Audio;
using SeeSharpTools.JY.Audio.Equilizer;
using SeeSharpTools.JY.Audio.Waveform;

namespace MACOs.JY.AudioAnalyzer.GeneratorPanel.GeneratorImpl
{
    public partial class SteppedSineWave : Form, Generator
    {
        public SteppedSineWave()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        private SteppedSineEqualizer _equalizer;

        public double[] Generate()
        {
            return GetWaveform().GetWaveData();
        }

        public uint GetChannelCount()
        {
            return 1;
        }

        private double _amplitude = 0;
        public double GetAmplitude()
        {
            return _amplitude;
        }

        public void SetEqualizerValue(EqualizerBase equalizer)
        {
            this._equalizer = equalizer as SteppedSineEqualizer;
        }

        public WaveformBase GetWaveform()
        {
            ushort steps = (ushort)numericUpDown_steps.Value;
            double amplitude = (double)numericUpDown_amplitude.Value;
            double frequencyMin = (double)numericUpDown_startFreq.Value;
            double frequencyMax = (double)numericUpDown_stopFreq.Value;
            ushort minCycle = (ushort)numericUpDown_minCycle.Value;
            double minDuration = (double)numericUpDown_duration.Value / 1000;

            GlobalInfo globalInfo = GlobalInfo.GetInstance();

            //            double[] outData = AudioGenerator.SteppedSineWaveform(globalInfo.AOTask.GetUpdateRate(), 
            //                amplitude, frequencyMin, frequencyMax, steps, minCycle, minDuration);
            SteppedSineWaveform waveform = new SteppedSineWaveform(globalInfo.AOTask.GetUpdateRate(),
                amplitude, frequencyMin, frequencyMax, steps, minCycle, minDuration);
            if (null != _equalizer)
            {
                waveform = new SteppedSineWaveform(waveform, _equalizer);
            }
            _amplitude = waveform.GetAmplitude();
            return waveform;
        }

        public WaveformBase GetRefWaveform()
        {
            ushort steps = (ushort)numericUpDown_steps.Value;
            double amplitude = (double)numericUpDown_amplitude.Value;
            double frequencyMin = (double)numericUpDown_startFreq.Value;
            double frequencyMax = (double)numericUpDown_stopFreq.Value;
            ushort minCycle = (ushort)numericUpDown_minCycle.Value;
            double minDuration = (double)numericUpDown_duration.Value / 1000;

            GlobalInfo globalInfo = GlobalInfo.GetInstance();

            //            double[] outData = AudioGenerator.SteppedSineWaveform(globalInfo.AOTask.GetUpdateRate(), 
            //                amplitude, frequencyMin, frequencyMax, steps, minCycle, minDuration);
            SteppedSineWaveform waveform = new SteppedSineWaveform(globalInfo.AITask.GetSampleRate(),
                amplitude, frequencyMin, frequencyMax, steps, minCycle, minDuration);
            if (null != _equalizer)
            {
                waveform = new SteppedSineWaveform(waveform, _equalizer);
            }
            return waveform;
        }

        private void button_AddEquilizer_Click(object sender, System.EventArgs e)
        {
            SteppedSineEquilizer equilizer = new SteppedSineEquilizer(this,
                (uint) numericUpDown_steps.Value, (double) numericUpDown_amplitude.Value, _equalizer);
            equilizer.ShowDialog(this);
        }

    }
}
