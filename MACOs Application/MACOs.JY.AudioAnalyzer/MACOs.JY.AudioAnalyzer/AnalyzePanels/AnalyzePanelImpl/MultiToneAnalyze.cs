using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MACOs.JY.AudioAnalyzer.GeneratorPanel;
using SeeSharpTools.JY.ArrayUtility;
using SeeSharpTools.JY.Audio;
using SeeSharpTools.JY.Audio.Analyzer;
using SeeSharpTools.JY.Audio.Common;
using SeeSharpTools.JY.Audio.Waveform;
using SeeSharpTools.JY.DSP.Fundamental;

namespace MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelImpl
{
    public partial class MultiToneAnalyze : Form, AnalyzePanelBase
    {
        private const string AnalyzerName = "MultiToneAnalyze";
        private GlobalInfo _globalInfo = GlobalInfo.GetInstance();

        private MultiToneAnalyzer _analyzer = new MultiToneAnalyzer();
        private uint _analyzeSize = 0;
        private double[] _testData;
        private MultiToneWaveform _refWaveform;


        public MultiToneAnalyze()
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
            if (null == tableLayoutPanel_waveConfig.Controls[0])
            {
                return;
            }
            double sampleRate = (double) numericUpDown_sampleRate.Value;
            Generator waveGenerator = tableLayoutPanel_waveConfig.Controls[0] as Generator;

            AITask.AITask input = _globalInfo.AITask;
            AOTask.AOTask output = _globalInfo.AOTask;
            output.SetUpdateRate(sampleRate);
            input.SetSampleRate(sampleRate);
            double channelRange = waveGenerator.GetAmplitude();
            output.AddChannel(comboBox_aoChannel.SelectedIndex, -1 * channelRange, channelRange);
            input.AddChannel(comboBox_testChannel.SelectedIndex, -1 * channelRange, channelRange);

            double[] outData = waveGenerator.Generate();

            output.SetSamplesToUpdate(outData.Length);
            double outTime = outData.Length/output.GetUpdateRate();
            input.SetSamplesToAcquire((int) (outTime * input.GetSampleRate() * GlobalInfo.ExtraReadTime));
            output.WriteData(outData, -1);

            input.Start();
            output.Start();

            _testData = new double[input.GetSamplesToAcquire()];
            input.ReadData(ref _testData, _testData.Length, GlobalInfo.ReadTimeOut);

//            easyChart_waveform.Plot(_testData);
            _globalInfo.Mainform.Invoke(new Action<double[], double, double>(easyChart_waveform.Plot), _testData, 0, 1);

            input.Stop();
            output.Stop();
            _refWaveform = waveGenerator.GetRefWaveform() as MultiToneWaveform;
//            double peakToPeak, acRms, dcRms, max, min, tdPlusN;
//            double[] acPart, powerSpectrum, phaseSpectrum;
//            SeeSharpTools.JY.Audio.AudioAnalyzer.AnalyzeMultiToneWaveform(readWaveform, _refWaveform, _globalInfo.AITask.GetSampleRate(),
//                out peakToPeak, out acRms, out dcRms, out max, out min, out tdPlusN, out acPart, out powerSpectrum, out phaseSpectrum);
            _analyzeSize = _refWaveform.GetTotalPoints();
            
        }

        public void Analyze()
        {
            _analyzer.SetAnalyzeParam(_refWaveform);
            _analyzer.Analyze(_testData, _globalInfo.DelaySamples, _analyzeSize);
        }

        public void ShowResult()
        {
            //            easyChart_power.Plot(frequency, powerSpectrum);
            ArrayPair<double, double> powerSpectrum = _analyzer.GetPowerSpectrum();
            easyChart_power.Plot(powerSpectrum.XData, powerSpectrum.YData);
            //            easyChart_phase.Plot(frequency, phaseSpectrum);
            ArrayPair<double, double> phaseSpectrum = _analyzer.GetPhaseSpectrum();
            easyChart_phase.Plot(phaseSpectrum.XData, phaseSpectrum.YData);

            StringBuilder dispResult = new StringBuilder();
            string newLine = System.Environment.NewLine;
            dispResult.Append("Amplitude(V):").Append(newLine).Append(_analyzer.GetPeakToPeak()).Append(newLine);
            dispResult.Append("AC RMS(V):").Append(newLine).Append(_analyzer.GetACRms()).Append(newLine);
            dispResult.Append("DC RMS(V):").Append(newLine).Append(_analyzer.GetDCRms()).Append(newLine);
            dispResult.Append("Max(V):").Append(newLine).Append(_analyzer.GetMax()).Append(newLine);
            dispResult.Append("Min(V):").Append(newLine).Append(_analyzer.GetMin()).Append(newLine);
            dispResult.Append("TD+N(dB):").Append(newLine).Append(_analyzer.GetTDPlusN()).Append(newLine);
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

        ~MultiToneAnalyze()
        {
            ClosePanel();
        }

        private void DualToneAnalyze_Load(object sender, EventArgs e)
        {
            InitComboBoxValue(comboBox_aoChannel, _globalInfo.AOTask.GetChannelCount());
            InitComboBoxValue(comboBox_testChannel, _globalInfo.AITask.GetChannelCount());
            comboBox_aoChannel.SelectedIndex = 0;
            comboBox_testChannel.SelectedIndex = 1;

            tableLayoutPanel_waveConfig.Controls.Clear();
            Form generator = GeneratorPanelFactory.GetGenerator("MultiToneWaveform");
            tableLayoutPanel_waveConfig.Controls.Add(generator);
            generator.Show();
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
