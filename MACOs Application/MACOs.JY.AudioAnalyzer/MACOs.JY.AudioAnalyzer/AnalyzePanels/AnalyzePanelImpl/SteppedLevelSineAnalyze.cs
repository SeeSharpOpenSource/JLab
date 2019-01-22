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
using SeeSharpTools.JY.Audio.Waveform;
using SeeSharpTools.JY.DSP.Fundamental;

namespace MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelImpl
{
    public partial class SteppedLevelSineAnalyze : Form, AnalyzePanelBase
    {
        private const string AnalyzerName = "SteppedLevelSineAnalyze";
        private GlobalInfo _globalInfo = GlobalInfo.GetInstance();

        private SteppedLevelSineAnalyzer _analyzer = new SteppedLevelSineAnalyzer();
        private uint _analyzeSize = 0;
        private double[] _testData;
        private SteppedLevelSineWaveform _refWaveform;

        public SteppedLevelSineAnalyze()
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

            dataGridView_result.Rows.Clear();

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
            _globalInfo.Mainform.Invoke(new Action<double[,], double, double>(easyChart_waveform.Plot), plotData, 0, 1);

            _testData = new double[plotData.GetLength(1)];
            Buffer.BlockCopy(plotData, 0, _testData, 0, _testData.Length*sizeof (double));
            _refWaveform = waveGenerator.GetRefWaveform() as SteppedLevelSineWaveform;
//            double[] peakToPeak, thd, nr, thdPlusNr, rms;
//            SeeSharpTools.JY.Audio.AudioAnalyzer.AnalyzeSteppedLevelSineWaveform(testWaveData, refWaveform,
//                out peakToPeak, out thd, out nr, out thdPlusNr, out rms);

            _analyzeSize = _refWaveform.GetTotalPoints();
            
        }

        public void Analyze()
        {
            _analyzer.SetAnalyzeParam(_refWaveform);
            _analyzer.Analyze(_testData, _globalInfo.DelaySamples, _analyzeSize);
        }

        public void ShowResult()
        {
            double[] peakToPeak = _analyzer.GetPeakToPeak();
            double[] thd = _analyzer.GetTHDInDb();
            double[] nr = _analyzer.GetNoiseRatioInDb();
            double[] thdPlusNr = _analyzer.GetTHDPlusNoiseInDb();
            double[] rms = _analyzer.GetRms();
            for (int i = 0; i < peakToPeak.Length; i++)
            {
                int rowIndex = dataGridView_result.Rows.Add();
                dataGridView_result.Rows[rowIndex].Cells[0].Value = peakToPeak[i];
                dataGridView_result.Rows[rowIndex].Cells[1].Value = thd[i];
                dataGridView_result.Rows[rowIndex].Cells[2].Value = nr[i];
                dataGridView_result.Rows[rowIndex].Cells[3].Value = thdPlusNr[i];
                dataGridView_result.Rows[rowIndex].Cells[4].Value = rms[i];
            }
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

        ~SteppedLevelSineAnalyze()
        {
            ClosePanel();
        }

        private void DualToneAnalyze_Load(object sender, EventArgs e)
        {
            InitComboBoxValue(comboBox_aoChannel, _globalInfo.AOTask.GetChannelCount());
            InitComboBoxValue(comboBox_refChannel, _globalInfo.AITask.GetChannelCount());
            InitComboBoxValue(comboBox_testChannel, _globalInfo.AITask.GetChannelCount());
            comboBox_aoChannel.SelectedIndex = 0;
            comboBox_refChannel.SelectedIndex = 0;
            comboBox_testChannel.SelectedIndex = 1;

            tableLayoutPanel_waveConfig.Controls.Clear();
            Form generator = GeneratorPanelFactory.GetGenerator("SteppedLevelSineWaveform");
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
