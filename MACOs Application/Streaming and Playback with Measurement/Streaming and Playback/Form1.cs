using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using SeeSharpTools.JY.ArrayUtility;
using SeeSharpTools.JY.DSP.Fundamental;
using MACOs.JY.Streaming;
using MACOs.JY.Playback;
using JYPXIE69848H;
using System.Reflection;
using SeeSharpTools.JY.File;

namespace StreamingAndPlaybackDemo
{
    public partial class Form1 : MetroForm
    {
        #region Construct
        public Form1()
        {
            InitializeComponent();
            playback = new PlaybackTask();
            trackBar1.Enabled = false;
            metroButton_stopPlay.Enabled = false;
            metroButton_startPlay.Enabled = false;
            metroButton_pausePlay.Enabled = false;
            metroComboBox_boardType.Items.AddRange(Enum.GetNames(typeof(BoardType)));
            metroComboBox_boardType.SelectedIndex = 8;
            metroComboBox_boardType.Enabled = false;
            Type t = typeof(SquareWaveResult);
            fields = t.GetFields(BindingFlags.Public | BindingFlags.Instance);
        }
        #endregion

        #region Streaming
        #region Private Fields
        StreamingTask dstask;  //新建数据流盘类的对象     
        readonly List<int> channelNumbers = new List<int>();
        double sampleRate;  //每通道采样率
        int samplesToPreview; //每次读取最新数据的点数
        double recordLength;  //流盘时间，以秒为单位
        bool stop;  //流盘结束标志位
        #endregion

        #region Events
        /// <summary>
        /// 指定流盘数据本地保存路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            //弹出对话框，手动选择保存路径
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                metroTextBox_path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        /// <summary>
        /// Start按钮按下，开启流盘任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButtonStart_Click(object sender, EventArgs e)
        {
            if (metroTextBox_path.Text == string.Empty)
            {
                MessageBox.Show("请指定文件保存路径！");
                return;
            }
            if (channelNumbers.Count == 0)
            {
                MessageBox.Show("请指定采集通道！");
                return;
            }
            metroButton_start.Enabled = false;
            metroButton_stop.Enabled = true;
            stop = false;
            sampleRate = double.Parse(metroTextBox_samleRate.Text);
            recordLength = double.Parse(metroTextBox_recordLength.Text);
            
            // 步骤1：根据板卡型号和编号新建流盘任务
            dstask = TaskCreater.CreateDAQTask(0, (BoardType)Enum.Parse(typeof(BoardType),metroComboBox_boardType.Text));
            // 步骤2：添加流盘通道，指定采样率和流盘时间

            //dstask.TerminalCfg = AITerminalCfg.RSE;
            dstask.TerminalCfg = AITerminalCfg.Differential;
            dstask.InputImpedance = AIInputImpedance.ImpedanceHigh;

            dstask.Record(channelNumbers.ToArray(), sampleRate, recordLength,double.Parse(metroTextBox_inputLowLimit.Text),
                double.Parse(metroTextBox_inputHighLimit.Text));

            // 步骤3 : 流盘文件的本地路径
            dstask.FilePath = metroTextBox_path.Text;
            // 步骤4：开始流盘任务
            dstask.Start();

            timer1.Enabled = true;
        }

        /// <summary>
        /// 停止流盘任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButtonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            stop = true;
            if (dstask != null) dstask.Stop();
            metroButton_start.Enabled = true;
            metroButton_stop.Enabled = false;
        }

        /// <summary>
        /// 每隔10ms刷新用户界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            samplesToPreview = int.Parse(metroTextBox_previewSamples.Text);
            double length = 0;
            bool recordDone = false;
            double[,] data = new double[samplesToPreview, channelNumbers.Count];
            double[,] transposedData = new double[channelNumbers.Count, samplesToPreview];

            //步骤5：获取流盘状态，包括已流盘长度和流盘是否结束标志位
            dstask.GetRecordStatus(out length, out recordDone);
            if (recordDone)
            {
                //流盘已结束
                metroButtonStop_Click(null, null);
                progressBar1.Value = progressBar1.Maximum;
            }
            else
            {
                //步骤6：流盘仍在进行中，预览最新流盘数据并显示
                dstask.ReadLatestData(ref data);
                ArrayManipulation.Transpose(data, ref transposedData);
                easyChart_signal.Plot(transposedData);

                double[,] PreviewSpectrumBufferTransposed = new double[channelNumbers.Count, samplesToPreview / 2];
                double[] SignalData = new double[samplesToPreview];
                double[] SpectrumData = new double[samplesToPreview / 2];
                double[] SpectrumInterval = new double[channelNumbers.Count];
                for (int i = 0; i < channelNumbers.Count; i++)
                {
                    ArrayManipulation.GetArraySubset(transposedData, i, ref SignalData, ArrayManipulation.IndexType.row);
                    Spectrum.PowerSpectrum(SignalData, double.Parse(metroTextBox_samleRate.Text), ref SpectrumData, out SpectrumInterval[i], SpectrumUnits.V2);
                    ArrayManipulation.ReplaceArraySubset(SpectrumData, ref PreviewSpectrumBufferTransposed, i, ArrayManipulation.IndexType.row);
                }
                easyChart_spectrum.Plot(PreviewSpectrumBufferTransposed, 0, SpectrumInterval[0]);
                progressBar1.Value = (int)(length / double.Parse(metroTextBox_recordLength.Text) * progressBar1.Maximum);

                timer1.Enabled = true;
            }
        }

        /// <summary>
        /// 通道是否全部选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroCheckBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            //全选
            if (metroCheckBox_selectAll.CheckState == CheckState.Checked)
            {
                for (int j = 0; j < checkListBox_channelSelect.Items.Count; j++)
                    checkListBox_channelSelect.SetItemChecked(j, true);
            }
            //全反选
            else if (metroCheckBox_selectAll.CheckState == CheckState.Unchecked)
            {
                for (int j = 0; j < checkListBox_channelSelect.Items.Count; j++)
                    checkListBox_channelSelect.SetItemChecked(j, false);
            }
            UpdateChannels(checkListBox_channelSelect, channelNumbers);
        }

        /// <summary>
        /// 选中某个通道
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkListBoxChannelSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectCount = 0;
            channelNumbers.Clear();
            for (int i = 0; i < checkListBox_channelSelect.Items.Count; i++)
            {
                if (checkListBox_channelSelect.GetItemChecked(i))
                {
                    selectCount++;
                    string itemText = checkListBox_channelSelect.GetItemText(checkListBox_channelSelect.Items[i]);
                    ;
                    channelNumbers.Add(int.Parse(itemText.Substring(2)));
                }
            }
            if (selectCount == checkListBox_channelSelect.Items.Count)
            {
                metroCheckBox_selectAll.Checked = true;
                metroCheckBox_selectAll.CheckState = CheckState.Checked;
                ;
            }
            else if (selectCount == 0)
            {
                metroCheckBox_selectAll.Checked = false;
            }
            else
            {
                metroCheckBox_selectAll.CheckState = CheckState.Indeterminate;
            }
        }

        /// <summary>
        /// 窗口关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!stop)
            {
                metroButtonStop_Click(null, null);
            }
            if (!playing)
            {
                metroButtonStopPlay_Click(null, null);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// 更新通道
        /// </summary>
        private void UpdateChannels(CheckedListBox clb, List<int> chn)
        {
            chn.Clear();
            //读取被选中的通道
            for (int i = 0; i < clb.Items.Count; i++)
            {
                if (clb.GetItemChecked(i))
                {
                    string itemText = clb.GetItemText(clb.Items[i]); ;
                    chn.Add(int.Parse(itemText.Substring(2)));
                }
            }
        }
        #endregion
        #endregion

        #region Playback
        #region Private Fields
        private PlaybackTask playback;
        private StreamingInfo streamingInfo;
        private int channelCount;
        private int[] channels;
        private double[,] playbackBuffer;
        private double[] measurementBuffer;
        private bool playing;
        int trackBarValue;
        private readonly List<int> playbackChannel = new List<int>();
        JYPXIE69848HAITask aitask;
        SquareWaveResult measurementResult;
        bool timer2FistRun = true;
        int rowNumber = 0;
        FieldInfo[] fields;
        string csvFilePath;
        string[,] csvData;
        List<int> checkedMeasureItems = new List<int>();
        int[] checkedMeasureItemsArray;
        #endregion

        #region Events
        private void metroButtonOpen_Click(object sender, EventArgs e)
        {
            var fileBrowser = new OpenFileDialog { Filter = @"(*.bin)|*.bin" };
            if (fileBrowser.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            streamingInfo = new StreamingInfo();
            playback.OpenFile(fileBrowser.FileName, ref streamingInfo);
            metroTextBox_totalSamples.Text = streamingInfo.SamplesPerChannel.ToString();
            channels = streamingInfo.Channels;
            channelCount = channels.Length;
            string fmt = "采样率：{0}   流盘总时间：{1}ms    流盘文件时间长度：{2}ms";
            metroLabelStripStatus.Text = string.Format(fmt, streamingInfo.SampleRate,
                    TimeSpan.FromMilliseconds(streamingInfo.StreamingTime), TimeSpan.FromMilliseconds(streamingInfo.AcquisitionTime));

            playback.FrameLength = int.Parse(metroTextBox_frameLength.Text);
            playbackBuffer = new double[channelCount, playback.FrameLength];
            measurementBuffer = new double[playback.FrameLength];

            metroButton_stopPlay.Enabled = true;
            metroButton_startPlay.Enabled = true;
            metroButton_open.Enabled = false;
            trackBar1.Enabled = true;
            metroTextBox_frameLength.Enabled = false;

            //设置tarckBar最大值为文件长度总时间，以毫秒为单位
            trackBar1.Maximum = streamingInfo.AcquisitionTime;
            trackBar1.Value = 0;
            metroLabel_frameTimeStamp.Text = @"00:00:00:000000";

            if (aitask == null)
            {
                aitask = new JYPXIE69848HAITask(0);
            }
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            timer2FistRun = true;
            rowNumber = 0;
        }

        private void metroButtonStartPlay_Click(object sender, EventArgs e)
        {

            playing = true;
            if (timer2FistRun)
            {
                csvFilePath = Environment.CurrentDirectory + @"\" + DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + @".csv";
                FormMeasurementItemsSelect FormMeasure = new FormMeasurementItemsSelect(fields, ref checkedMeasureItems, ref timer2);
                FormMeasure.Show();
            }
            else
            {
                trackBar1.Enabled = false;
                metroButton_startPlay.Enabled = false;
                metroButton_pausePlay.Enabled = true;
            }

        }

        private void metroButtonPausePlay_Click(object sender, EventArgs e)
        {
            trackBar1.Enabled = true;
            metroButton_startPlay.Enabled = true;
            metroButton_pausePlay.Enabled = false;
            playing = false;
        }

        private void metroButtonStopPlay_Click(object sender, EventArgs e)
        {
            Stop();
            
        }
        private void Stop()
        {
            metroButton_startPlay.Enabled = false;
            metroButton_stopPlay.Enabled = false;
            metroButton_pausePlay.Enabled = false;
            metroButton_open.Enabled = true;
            trackBar1.Enabled = false;
            metroTextBox_frameLength.Enabled = true;
            playing = false;
            timer2.Enabled = false; //You must first disable timer and then close the file
            playback.CloseFile();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            //根据当前鼠标的拖曳更新trackBar
            playback.UpdateTrackBar(trackBar1.Value, ref trackBarValue);
            trackBar1.Value = trackBarValue;
            metroLabel_frameTimeStamp.Text = TimeSpan.FromMilliseconds(trackBar1.Value).ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;

            //从文件中读取当前帧数据显示并更新trackBar
            playback.ReadFrame(playing, trackBar1.Value, ref playbackBuffer, out trackBarValue);
            if (trackBarValue<trackBar1.Maximum&&playing)
            {
                easyChartReplayer.Plot(playbackBuffer);
                trackBar1.Value = trackBarValue;
                if (timer2FistRun)
                {
                    trackBar1.Enabled = false;
                    metroButton_startPlay.Enabled = false;
                    metroButton_pausePlay.Enabled = true;
                    DataGridViewColumn column = new DataGridViewColumn();
                    column.Name = "Time";
                    column.HeaderText = "Time";
                    column.CellTemplate = new DataGridViewTextBoxCell();
                    dataGridView1.Columns.Add(column);

                    if (checkedMeasureItems.Count == 0)
                    {
                        MessageBox.Show("Please pick one Measurement Item at least");
                        return;
                    }
                    else
                    {
                        checkedMeasureItemsArray =  checkedMeasureItems.ToArray();
                    }
                    csvData = new string[(int.Parse(metroTextBox_totalSamples.Text) / int.Parse(metroTextBox_frameLength.Text) + 1) * channelCount + 1, checkedMeasureItemsArray.Length + 4];
                    csvData[0, 0] = "CH Number";
                    csvData[0, 1] = column.Name;
                    for (int j = 0; j < checkedMeasureItemsArray.Length; j++)
                    {
                        string fieldNames = fields[checkedMeasureItemsArray[j]].Name;
                        column = new DataGridViewColumn();
                        column.Name = fields[checkedMeasureItemsArray[j]].Name;
                        column.HeaderText = fields[checkedMeasureItemsArray[j]].Name;
                        column.CellTemplate = new DataGridViewTextBoxCell();
                        dataGridView1.Columns.Add(column);
                        csvData[0, j + 2] = column.Name;
                    }
                    csvData[0, checkedMeasureItemsArray.Length + 2] = "SampleRate = " + streamingInfo.SampleRate.ToString();
                    csvData[0, checkedMeasureItemsArray.Length + 3] = "SampleToAcquire = " + playbackBuffer.GetLength(1).ToString();
                    timer2FistRun = false;
                }
                for (int i = 0; i < playbackBuffer.GetLength(0); i++)
                {

                    Buffer.BlockCopy(playbackBuffer, i * measurementBuffer.Length * sizeof(double), measurementBuffer, 0, measurementBuffer.Length * sizeof(double));
                    measurementResult = aitask.MeasureSquareWave(measurementBuffer, streamingInfo.SampleRate);
                    DataGridViewRow row = new DataGridViewRow();
                    row.HeaderCell.Value = "CH" + i.ToString() + "_" + rowNumber.ToString();
                    dataGridView1.Rows.Add(row);
                    dataGridView1.Rows[rowNumber * playbackBuffer.GetLength(0) + i].Cells[0].Value =
                         metroLabel_frameTimeStamp.Text;
                    csvData[rowNumber*channelCount+i+1,0] = row.HeaderCell.Value.ToString();
                    csvData[rowNumber * channelCount + i + 1, 1] = metroLabel_frameTimeStamp.Text;
                    for (int k = 0; k < checkedMeasureItemsArray.Length; k++)
                    {
                        dataGridView1.Rows[rowNumber * playbackBuffer.GetLength(0) + i].Cells[k+1].Value =
                            fields[checkedMeasureItemsArray[k]].GetValue(measurementResult);
                        csvData[rowNumber * channelCount + i + 1, k + 2] = fields[checkedMeasureItemsArray[k]].GetValue(measurementResult).ToString();
                    }

                }
                rowNumber++;

                timer2.Enabled = true;
            }
            else if(trackBarValue >= trackBar1.Maximum)
            {
                csvData[csvData.GetLength(0) - 1, csvData.GetLength(1) - 1] = DateTime.Now.ToString("yyyy-MM-dd-HHmmss");
                CsvHandler.WriteData(csvFilePath, csvData);
                Stop();

            }
            else
            {
                timer2.Enabled = true;
            }

        }
        #endregion

        #region Methods
        #endregion

        #endregion

    }
}
