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
    public partial class MismatchAnalyze : Form, AnalyzePanelBase
    {
        private const string AnalyzerName = "MismatchAnalyze";
        private GlobalInfo _globalInfo = GlobalInfo.GetInstance();
        private MismatchAnalyzer _analyzer = new MismatchAnalyzer();
        private uint _analyzeSize = 0;
        private double[] _testData;
        private double[] _refData;
        
        public MismatchAnalyze()
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
            input.AddChannel(comboBox_refChannel.SelectedIndex, -1 * channelRange, channelRange);
            input.AddChannel(comboBox_testChannel.SelectedIndex, -1 * channelRange, channelRange);

            double[] outData = waveGenerator.Generate();

            output.SetSamplesToUpdate(outData.Length);
            double outTime = outData.Length/output.GetUpdateRate();
            input.SetSamplesToAcquire((int) (outTime * input.GetSampleRate() * GlobalInfo.ExtraReadTime));
            output.WriteData(outData, -1);

            input.Start();
            output.Start();

            double[,] readWaveform = new double[input.GetSamplesToAcquire(), 2];
            input.ReadData(ref readWaveform, readWaveform.GetLength(0), GlobalInfo.ReadTimeOut);

            double[,] plotData = new double[readWaveform.GetLength(1), readWaveform.GetLength(0)];
            ArrayManipulation.Transpose(readWaveform, ref plotData);
//            easyChart_data.Plot(plotData);

            _globalInfo.Mainform.Invoke(new Action<double[,], double, double>(easyChart_data.Plot), plotData, 0, 1);

            _refData = new double[plotData.GetLength(1)];
            _testData = new double[plotData.GetLength(1)];
            Buffer.BlockCopy(plotData, 0, _refData, 0, _refData.Length * sizeof(double));
            Buffer.BlockCopy(plotData, _testData.Length * sizeof(double), _testData, 0, 
                _testData.Length * sizeof(double));

            double[] spectrum = new double[_testData.Length / 2];
            double df;
            Spectrum.PowerSpectrum(_testData, input.GetSampleRate(), ref spectrum, out df);
//            easyChart_spectrum.Plot(spectrum.Take(1000).ToArray(), 0, df);
            _globalInfo.Mainform.Invoke(new Action<double[], double, double>(easyChart_spectrum.Plot), spectrum, 0, df);
            _analyzeSize = (uint) Math.Ceiling(outTime * _globalInfo.AITask.GetSampleRate());
        }

        public void Analyze()
        {
            _analyzer.SetAnalyzeParam(_refData, _globalInfo.DelaySamples, _analyzeSize);
            _analyzer.Analyze(_testData, _globalInfo.DelaySamples, _analyzeSize);
        }

        public void ShowResult()
        {
            StringBuilder dispResult = new StringBuilder();
            string newLine = System.Environment.NewLine;
            dispResult.Append("Gain Mismatch:").Append(newLine).Append(_analyzer.GetGainMismatch()).Append(newLine);
            dispResult.Append("Phase Mismatch:").Append(newLine).Append(_analyzer.GetPhaseMismatch());
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

        ~MismatchAnalyze()
        {
            ClosePanel();
        }

        private void SteppedSineWaveCrossTalkAnalyze_Load(object sender, EventArgs e)
        {
            InitComboBoxValue(comboBox_aoChannel, _globalInfo.AOTask.GetChannelCount());
            InitComboBoxValue(comboBox_refChannel, _globalInfo.AITask.GetChannelCount());
            InitComboBoxValue(comboBox_testChannel, _globalInfo.AITask.GetChannelCount());
            comboBox_aoChannel.SelectedIndex = 0;
            comboBox_refChannel.SelectedIndex = 0;
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
