using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SeeSharpTools.JY.Audio;
using SeeSharpTools.JY.Audio.Analyzer;
using SeeSharpTools.JY.Audio.Common;
using SeeSharpTools.JY.DSP.Fundamental;

namespace MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelImpl
{
    public partial class SingleToneAnalyze : Form, AnalyzePanelBase
    {
        private const string AnalyzerName = "SingleToneAnalyze";
        private GlobalInfo _globalInfo = GlobalInfo.GetInstance();

        private SingleToneAnalyzer _analyzer = new SingleToneAnalyzer();
        private uint _analyzeSize = 0;
        private double[] _testData;
        
        public SingleToneAnalyze()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        public string GetAnalyzerName()
        {
            return AnalyzerName;
        }

        public void Start()
        {
            double sampleRate = (double) numericUpDown_sampleRate.Value;
            double amplitude = (double) numericUpDown_amplitude.Value;
            double targetFrequency = (double) numericUpDown_targetFreq.Value;
            double duration = (double) numericUpDown_Duration.Value / 1000;

            AITask.AITask input = _globalInfo.AITask;
            AOTask.AOTask output = _globalInfo.AOTask;
            
            output.SetUpdateRate(sampleRate);
            input.SetSampleRate(sampleRate);
            double channelRange = (double)(numericUpDown_amplitude.Value);
            output.AddChannel(comboBox_aoChannel.SelectedIndex, -1 * channelRange, channelRange);
            input.AddChannel(comboBox_testChannel.SelectedIndex, -1 * channelRange, channelRange);

            double[] outData = AudioGenerator.SingleToneWaveform(output.GetUpdateRate(), 
                (uint) (output.GetUpdateRate() * duration), amplitude, targetFrequency, 0);
            output.SetSamplesToUpdate(outData.Length);
            double outTime = outData.Length/output.GetUpdateRate();
            input.SetSamplesToAcquire((int) (outTime * input.GetSampleRate() * GlobalInfo.ExtraReadTime));
            output.WriteData(outData, -1);

            input.Start();
            output.Start();

            _testData = new double[input.GetSamplesToAcquire()];
            input.ReadData(ref _testData, _testData.Length, GlobalInfo.ReadTimeOut);
            //Added by Way
            output.Stop();
            input.Stop();
//            easyChart_data.Plot(_testData);
            _globalInfo.Mainform.Invoke(new Action<double[], double, double>(easyChart_data.Plot), _testData, 0, 1);

            double[] spectrum = new double[_testData.Length / 2];
            double df;
            //Change unit to dBm            
            Spectrum.PowerSpectrum(_testData, input.GetSampleRate(), ref spectrum, out df,SpectrumUnits.V2);
            _globalInfo.Mainform.Invoke(new Action<double[], double, double>(easyChart_spectrum.Plot), spectrum, 0, df);

//            double amp, thd, nr, thdPlusNRatio;
//            double[] harmonicPower;
//            SeeSharpTools.JY.Audio.AudioAnalyzer.AnalyzeSingleToneWave(readWaveform, 
//                targetFrequency, sampleRate, out amp, out thd, out nr, out thdPlusNRatio, 
//                out harmonicPower);
            _analyzeSize = (uint)Math.Ceiling(outTime * input.GetSampleRate());
            
        }

        public void Analyze()
        {
            _analyzer.SetAnalyzeParam(_globalInfo.AITask.GetSampleRate());
            _analyzer.Analyze(_testData, _globalInfo.DelaySamples, _analyzeSize);
        }

        public void ShowResult()
        {
            StringBuilder dispResult = new StringBuilder();
            string newLine = Environment.NewLine;
            const string delim = ",";
            dispResult.Append("PeakToPeak(V):").Append(newLine).Append(_analyzer.GetPeakToPeak()).Append(newLine);
            dispResult.Append("THD(db):").Append(newLine).Append(_analyzer.GetTHDInDb()).Append(newLine);
            dispResult.Append("Noise Ratio(db):").Append(newLine).Append(_analyzer.GetNoiseRatioInDb()).Append(newLine);
            dispResult.Append("Thd Plus Noise Ratio(dB):")
                .Append(newLine)
                .Append(_analyzer.GetNoiseRatioInDb())
                .Append(newLine);
            ArrayPair<double, double> harmonicPower = _analyzer.GetHarmonicPower();
            dispResult.Append("Harmoic Power:").Append(newLine).Append(harmonicPower.YData[0]).Append(delim)
                .Append(harmonicPower.YData[1]).Append(delim).Append(harmonicPower.YData[2]).Append(delim).
                Append(harmonicPower.YData[3]).Append(delim).Append(harmonicPower.YData[4]).Append(delim).
                Append(harmonicPower.YData[5]);
            textBox_result.Text = dispResult.ToString();
        }


        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void ClosePanel()
        {
            _analyzer?.Dispose();
            base.Close();
        }

        ~SingleToneAnalyze()
        {
            ClosePanel();
        }

        private void SteppedSineWaveCrossTalkAnalyze_Load(object sender, EventArgs e)
        {
            InitComboBoxValue(comboBox_aoChannel, _globalInfo.AOTask.GetChannelCount());
            InitComboBoxValue(comboBox_testChannel, _globalInfo.AITask.GetChannelCount());
            comboBox_aoChannel.SelectedIndex = 0;
            comboBox_testChannel.SelectedIndex = 0;
        }

        private void InitComboBoxValue(ComboBox comboBox, int channelCount)
        {
            for (int i = 0; i < channelCount; i++)
            {
                comboBox.Items.Add(i);
            }
        }

        //        public void InitComponentTag()
        //        {
        //            comboBox_aoChannel.Tag = "AOChannel"
        //        }
    }
}
