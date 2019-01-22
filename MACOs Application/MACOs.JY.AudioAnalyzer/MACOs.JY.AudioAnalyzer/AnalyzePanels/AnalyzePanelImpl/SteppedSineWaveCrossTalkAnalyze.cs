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
using SeeSharpTools.JY.Audio.Common;
using SeeSharpTools.JY.Audio.Waveform;

namespace MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelImpl
{
    public partial class SteppedSineWaveCrossTalkAnalyze : Form, AnalyzePanelBase
    {

        private const string AnalyzerName = "SteppedSineWaveCrossTalkAnalyze";
        private GlobalInfo _globalInfo = GlobalInfo.GetInstance();

        private SteppedSineCrosstalkAnalyzer _analyzer = new SteppedSineCrosstalkAnalyzer();
        private uint _analyzeSize = 0;
        private double[] _testData;
        private SteppedSineWaveform _refWaveform;
        private double[] _refData;

        public SteppedSineWaveCrossTalkAnalyze()
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
            Generator waveGenerator = tableLayoutPanel_waveConfig.Controls[0] as Generator;
            double sampleRate = (double) numericUpDown_sampleRate.Value;

            AITask.AITask input = _globalInfo.AITask;
            AOTask.AOTask output = _globalInfo.AOTask;
            output.SetUpdateRate(sampleRate);
            input.SetSampleRate(sampleRate);

            double[] outData = waveGenerator.GetWaveform().GetWaveData();

            double channelRange = (double)(waveGenerator.GetAmplitude());
            output.AddChannel(comboBox_aoChannel.SelectedIndex, -1 * channelRange, channelRange);
            input.AddChannel(comboBox_refChannel.SelectedIndex, -1 * channelRange, channelRange);
            input.AddChannel(comboBox_testChannel.SelectedIndex, -1 * channelRange, channelRange);
            
            output.SetSamplesToUpdate(outData.Length);
            double outTime = outData.Length/output.GetUpdateRate();
            input.SetSamplesToAcquire((int) (outTime * input.GetSampleRate() * GlobalInfo.ExtraReadTime));
            output.WriteData(outData, -1);
            input.Start();
            output.Start();
            double[,] readData = new double[input.GetSamplesToAcquire(), 2];
            input.ReadData(ref readData, input.GetSamplesToAcquire(), GlobalInfo.ReadTimeOut);
            _refData = new double[readData.GetLength(0)];
            _testData = new double[readData.GetLength(0)];
            for (int i = 0; i < readData.GetLength(0); i++)
            {
                _refData[i] = readData[i, 0];
                _testData[i] = readData[i, 1];
            }
            double[,] plotData = new double[2, readData.GetLength(0)];
            Buffer.BlockCopy(_refData, 0, plotData, 0, _refData.Length * sizeof(double));
            Buffer.BlockCopy(_testData, 0, plotData, _refData.Length*sizeof (double),
                _testData.Length*sizeof (double));
//            easyChart_data.Plot(plotData);
            _globalInfo.Mainform.Invoke(new Action<double[,], double, double>(easyChart_data.Plot), plotData, 0, 1);
            _refWaveform = waveGenerator.GetRefWaveform() as SteppedSineWaveform;
//            ArrayPair<double, double> crossTalk = SeeSharpTools.JY.Audio.AudioAnalyzer.AnalyzeSteppedSineCrosstalk(
//                refWaveForm, testWaveForm, _globalInfo.AITask.GetSampleRate(), frequencyMax, frequencyMin, steps, minCycle, minDuration, amplitude);

            _analyzeSize = _refWaveform.GetTotalPoints();
            
        }

        public void Analyze()
        {
            _analyzer.SetAnalyzeParam(_refWaveform, _refData, _globalInfo.AITask.GetSampleRate(),
                            _globalInfo.DelaySamples, _analyzeSize);
            _analyzer.Analyze(_testData, _globalInfo.DelaySamples, _analyzeSize);
        }

        public void ShowResult()
        {
            ArrayPair<double, double> crossTalk = _analyzer.GetCrossTalk();
            easyChart_corssTalk.Plot(crossTalk.XData, crossTalk.YData);
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

        ~SteppedSineWaveCrossTalkAnalyze()
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

            tableLayoutPanel_waveConfig.Controls.Clear();
            Form generator = GeneratorPanelFactory.GetGenerator("SteppedSineWaveform");
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
