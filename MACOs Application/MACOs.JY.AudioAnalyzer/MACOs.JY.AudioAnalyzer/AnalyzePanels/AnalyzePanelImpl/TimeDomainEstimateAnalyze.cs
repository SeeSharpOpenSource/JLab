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
using SeeSharpTools.JY.DSP.Fundamental;

namespace MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelImpl
{
    public partial class TimeDomainEstimateAnalyze : Form, AnalyzePanelBase
    {
        private const string AnalyzerName = "TimeDomainEstimateAnalyze";
        private GlobalInfo _globalInfo = GlobalInfo.GetInstance();

        private TimeDomainEstimate _analyzer = new TimeDomainEstimate();
        private uint _analyzeSize = 0;
        private double[] _testData;
        
        public TimeDomainEstimateAnalyze()
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

//            easyChart_data.Plot(_testData);
            _globalInfo.Mainform.Invoke(new Action<double[], double, double>(easyChart_data.Plot), _testData, 0, 1);

            double[] spectrum = new double[_testData.Length / 2];
            double df;
            Spectrum.PowerSpectrum(_testData, input.GetSampleRate(), ref spectrum, out df);
//            easyChart_spectrum.Plot(spectrum.Take(1000).ToArray(), 0, df);
            _globalInfo.Mainform.Invoke(new Action<double[], double, double>(easyChart_spectrum.Plot), spectrum, 0, 1);

            
            _analyzeSize = (uint)Math.Ceiling(outTime * input.GetSampleRate());
        }

        public void Analyze()
        {
            _analyzer.SetAnalyzeParam();
            _analyzer.Analyze(_testData, _globalInfo.DelaySamples, _analyzeSize);
        }

        public void ShowResult()
        {
            StringBuilder dispResult = new StringBuilder();
            string newLine = System.Environment.NewLine;
            dispResult.Append("Peak To Peak(V):").Append(newLine).Append(_analyzer.GetPeakToPeak()).Append(newLine);
            dispResult.Append("RMS(V):").Append(newLine).Append(_analyzer.GetRms()).Append(newLine);
            dispResult.Append("DC(V):").Append(newLine).Append(_analyzer.GetDCRms()).Append(newLine);
            dispResult.Append("RMS Of AC(V):").Append(newLine).Append(_analyzer.GetACRms()).Append(newLine);
            dispResult.Append("Max(V):").Append(newLine).Append(_analyzer.GetMax()).Append(newLine);
            dispResult.Append("Min(V):").Append(newLine).Append(_analyzer.GetMin()).Append(newLine);
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

        ~TimeDomainEstimateAnalyze()
        {
            ClosePanel();
        }

        private void SteppedSineWaveCrossTalkAnalyze_Load(object sender, EventArgs e)
        {
            InitComboBoxValue(comboBox_aoChannel, _globalInfo.AOTask.GetChannelCount());
            InitComboBoxValue(comboBox_testChannel, _globalInfo.AITask.GetChannelCount());
            comboBox_aoChannel.SelectedIndex = 0;
            comboBox_testChannel.SelectedIndex = 1;
            // TODO add invalid type
            GeneratorPanelFactory.GetInstance().InitGeneratorSelector(comboBox_waveType, tableLayoutPanel_waveConfig);

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
