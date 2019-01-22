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
using SeeSharpTools.JY.Audio.Waveform;
using SeeSharpTools.JY.DSP.Fundamental;
using SeeSharpTools.JY.ArrayUtility;
using SeeSharpTools.JY.Audio.Analyzer;
using SeeSharpTools.JY.Audio.Common;

namespace MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelImpl
{
    public partial class LogChripAnalyze : Form, AnalyzePanelBase
    {
        private const string AnalyzerName = "LogChripAnalyze";
        private GlobalInfo _globalInfo = GlobalInfo.GetInstance();
        private LogChirpAnalyzer _analyzer = new LogChirpAnalyzer();
        private uint _analyzeSize = 0;
        private double[] _testData;
        private LogChirpWaveform _refWaveform = null;
        
        public LogChripAnalyze()
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

            input.ReadData(ref _testData, input.GetSamplesToAcquire(), GlobalInfo.ReadTimeOut);
            
            _globalInfo.Mainform.Invoke(new Action<double[], double, double>(easyChart_testWaveform.Plot), _testData,
                0, 1);

            //            double[] responseX, responseY, thdX, thdY;
            //            SeeSharpTools.JY.Audio.AudioAnalyzer.AnalyzeLogChripWave(readWaveform, 
            //                (LogChirpWaveform) waveGenerator.GetRefWaveform(), input.GetSampleRate(), out responseX, 
            //                out responseY, out thdX, out thdY);
            _refWaveform = (LogChirpWaveform)waveGenerator.GetRefWaveform();
            _analyzeSize = _refWaveform.GetTotalPoints();
            
        }

        public void Analyze()
        {
            _analyzer.SetAnalyzeParam(_refWaveform, _globalInfo.AITask.GetSampleRate());
            _analyzer.Analyze(_testData, _globalInfo.DelaySamples, _analyzeSize);
        }

        public void ShowResult()
        {
            ArrayPair<double, double> responses = _analyzer.GetResponse();
            easyChart_response.Plot(responses.XData, responses.YData);
            ArrayPair<double, double> thds = _analyzer.GetTHD();
            easyChart_thd.Plot(thds.XData, thds.YData);
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

        ~LogChripAnalyze()
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
            Form generator = GeneratorPanelFactory.GetGenerator("LogChirpWaveform");
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
