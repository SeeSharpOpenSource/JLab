using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MACOs.JY.AudioAnalyzer.GeneratorPanel;
using SeeSharpTools.JY.Audio;
using SeeSharpTools.JY.Audio.Analyzer;
using SeeSharpTools.JY.DSP.Fundamental;

namespace MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelImpl
{
    public partial class DualToneAnalyze : Form, AnalyzePanelBase
    {
        private const string AnalyzerName = "DualToneAnalyze";
        private GlobalInfo _globalInfo = GlobalInfo.GetInstance();
        private DualToneAnalyzer _analyzer = new DualToneAnalyzer();
        private uint _analyzeSize = 0;
        private double[] _testData;
        
        public DualToneAnalyze()
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
//            easyChart_testWaveform.Plot(_testData);

            _globalInfo.Mainform.Invoke(new Action<double[], double, double>(easyChart_testWaveform.Plot), _testData, 0 ,1);

            double[] spectrum = new double[_testData.Length / 2];
            double df;
            Spectrum.PowerSpectrum(_testData, input.GetSampleRate(), ref spectrum, out df);
//            easyChart_spectrum.Plot(spectrum, 0, df);
            _globalInfo.Mainform.Invoke(new Action<double[], double, double>(easyChart_spectrum.Plot), spectrum, 0, df);

            _analyzeSize = (uint)Math.Ceiling(outTime * _globalInfo.AITask.GetSampleRate());
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Analyze()
        {
            IMDType imdType = (IMDType)Enum.Parse(typeof(IMDType), comboBox_imdType.Text);
            //            double frequency1, frequency2, amplitudeRatio, imd;
            //            SeeSharpTools.JY.Audio.AudioAnalyzer.AnalyzeDualToneWave(readWaveform, sampleRate, imdType, out frequency1, out frequency2, out amplitudeRatio, out imd);
            _analyzer.SetAnalyzeParam(_globalInfo.AITask.GetSampleRate(), imdType);
            _analyzer.Analyze(_testData, _globalInfo.DelaySamples, _analyzeSize);
        }

        public void ShowResult()
        {
            StringBuilder dispResult = new StringBuilder();
            string newLine = System.Environment.NewLine;
            dispResult.Append("Frequency 1(Hz):").Append(newLine).Append(_analyzer.GetFrequency1()).Append(newLine);
            dispResult.Append("Frequency 2(Hz):").Append(newLine).Append(_analyzer.GetFrequency2()).Append(newLine);
            dispResult.Append("Amplitude Ratio:").Append(newLine).Append(_analyzer.GetAmplitudeRatio()).Append(newLine);
            dispResult.Append("IMD:").Append(newLine).Append(_analyzer.GetIMDInDb());
            textBox_result.Text = dispResult.ToString();
        }

        public void ClosePanel()
        {
            _analyzer?.Dispose();
            base.Close();
        }

        ~DualToneAnalyze()
        {
            ClosePanel();
        }

        private void DualToneAnalyze_Load(object sender, EventArgs e)
        {
            InitComboBoxValue(comboBox_aoChannel, _globalInfo.AOTask.GetChannelCount());
            InitComboBoxValue(comboBox_testChannel, _globalInfo.AITask.GetChannelCount());
            comboBox_aoChannel.SelectedIndex = 0;
            comboBox_testChannel.SelectedIndex = 0;

            tableLayoutPanel_waveConfig.Controls.Clear();
            Form generator = GeneratorPanelFactory.GetGenerator("DualToneWaveForm");
            tableLayoutPanel_waveConfig.Controls.Add(generator);
            generator.Show();

            comboBox_imdType.Items.AddRange(Enum.GetNames(typeof (IMDType)));
            comboBox_imdType.SelectedIndex = 0;
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
