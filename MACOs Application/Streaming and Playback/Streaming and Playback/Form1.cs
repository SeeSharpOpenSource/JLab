using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SeeSharpTools.JY.ArrayUtility;
using SeeSharpTools.JY.DSP.Fundamental;
using MACOs.JY.Streaming;
using MACOs.JY.Playback;

namespace StreamingAndPlaybackDemo
{
    public partial class Form1 : Form
    {
        #region Construct
        public Form1()
        {
            InitializeComponent();
            playback = new PlaybackTask();
            trackBar1.Enabled = false;
            button_stopPlay.Enabled = false;
            button_startPlay.Enabled = false;
            button_pausePlay.Enabled = false;
            tabControl1.SelectedIndex = 0;
            comboBox_boardType.Items.AddRange(Enum.GetNames(typeof(BoardType)));
            comboBox_boardType.SelectedIndex = 0;
        }
        #endregion

        #region Streaming
        #region Private Fields
        /// <summary>
        /// 新建数据流盘类的对象
        /// </summary>
        StreamingTask dstask;                 
        List<int> channelNumbers = new List<int>();//通道数
        /// <summary>
        /// 每通道采样率
        /// </summary>
        double sampleRate;
        /// <summary>
        /// 每次读取最新数据的点数
        /// </summary>
        int samplesToPreview;
        /// <summary>
        /// 流盘时间，以秒为单位
        /// </summary>
        double recordLength;
        /// <summary>
        /// 流盘结束标志位
        /// </summary>
        bool stop;
        /// <summary>
        /// 预览数据
        /// </summary>
        double[,] priewData;
        /// <summary>
        /// 转置后数据
        /// </summary>
        double[,] transposedData;
        /// <summary>
        /// 转置后的预览频域数据
        /// </summary>
        double[,] previewSpectrumBufferTransposed;
        /// <summary>
        /// 单通道预览数据
        /// </summary>
        double[] singleChannelPriewData;
        /// <summary>
        /// 单通道频域数据
        /// </summary>
        double[] singleChannelSpectrumData;
        /// <summary>
        /// 频域数据间隔
        /// </summary>
        double[] spectrumInterval;
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
                textBox_path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        /// <summary>
        /// Start按钮按下，开启流盘任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBox_path.Text == string.Empty)
            {
                MessageBox.Show("请指定文件保存路径！");
                return;
            }
            if (channelNumbers.Count == 0)
            {
                MessageBox.Show("请指定采集通道！");
                return;
            }
            button_start.Enabled = false;
            button_stop.Enabled = true;
            stop = false;
            sampleRate = double.Parse(textBox_sampleRate.Text);
            recordLength = double.Parse(textBox_recordLength.Text);
            
            // 步骤1：根据板卡型号和编号新建流盘任务
            dstask = TaskCreater.CreateDAQTask(0, (BoardType)Enum.Parse(typeof(BoardType),comboBox_boardType.Text));
            // 步骤2：添加流盘通道，指定采样率和流盘时间

            dstask.TerminalCfg = (AITerminalCfg)Enum.Parse(typeof(AITerminalCfg), comboBox_terminalType.Text);
            dstask.InputImpedance = AIInputImpedance.ImpedanceHigh;

            dstask.Record(channelNumbers.ToArray(), sampleRate, recordLength,double.Parse(textBox_inputLow.Text),
                double.Parse(textBox_inputHigh.Text));
            samplesToPreview = int.Parse(textBox_previewSamples.Text);
            priewData = new double[samplesToPreview, channelNumbers.Count];
            transposedData = new double[channelNumbers.Count, samplesToPreview];
            previewSpectrumBufferTransposed = new double[channelNumbers.Count, samplesToPreview / 2];
            singleChannelPriewData = new double[samplesToPreview];
            singleChannelSpectrumData = new double[samplesToPreview / 2];
            spectrumInterval = new double[channelNumbers.Count];

            // 步骤3 : 流盘文件的本地路径
            dstask.FilePath = textBox_path.Text;
            // 步骤4：开始流盘任务
            dstask.Start();

            timer1.Enabled = true;
        }

        /// <summary>
        /// 停止流盘任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            stop = true;
            if (dstask != null) dstask.Stop();
            button_start.Enabled = true;
            button_stop.Enabled = false;
        }

        /// <summary>
        /// 每隔10ms刷新用户界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            samplesToPreview = int.Parse(textBox_previewSamples.Text);
            double length = 0;
            bool recordDone = false;

            //步骤5：获取流盘状态，包括已流盘长度和流盘是否结束标志位
            dstask.GetRecordStatus(out length, out recordDone);
            if (recordDone)
            {
                //流盘已结束
                buttonStop_Click(null, null);
                progressBar1.Value = progressBar1.Maximum;
            }
            else
            {
                //步骤6：流盘仍在进行中，预览最新流盘数据并显示
                dstask.ReadLatestData(ref priewData);
                ArrayManipulation.Transpose(priewData, ref transposedData);
                easyChart_signal.Plot(transposedData);

                for (int i = 0; i < channelNumbers.Count; i++)
                {
                    ArrayManipulation.GetArraySubset(transposedData, i, ref singleChannelPriewData, ArrayManipulation.IndexType.row);
                    Spectrum.PowerSpectrum(singleChannelPriewData, double.Parse(textBox_sampleRate.Text), ref singleChannelSpectrumData, out spectrumInterval[i], SpectrumUnits.V2);
                    ArrayManipulation.ReplaceArraySubset(singleChannelSpectrumData, ref previewSpectrumBufferTransposed, i, ArrayManipulation.IndexType.row);
                }
                easyChart_spectrum.Plot(previewSpectrumBufferTransposed, 0, spectrumInterval[0]);
                progressBar1.Value = (int)(length / double.Parse(textBox_recordLength.Text) * progressBar1.Maximum);

                timer1.Enabled = true;
            }
        }

        /// <summary>
        /// 通道是否全部选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            //全选
            if (checkBox_selectAll.CheckState == CheckState.Checked)
            {
                for (int j = 0; j < checkedListBox_channels.Items.Count; j++)
                    checkedListBox_channels.SetItemChecked(j, true);
            }
            //全反选
            else if (checkBox_selectAll.CheckState == CheckState.Unchecked)
            {
                for (int j = 0; j < checkedListBox_channels.Items.Count; j++)
                    checkedListBox_channels.SetItemChecked(j, false);
            }
            UpdateChannels(checkedListBox_channels, channelNumbers);
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
            for (int i = 0; i < checkedListBox_channels.Items.Count; i++)
            {
                if (checkedListBox_channels.GetItemChecked(i))
                {
                    selectCount++;
                    string itemText = checkedListBox_channels.GetItemText(checkedListBox_channels.Items[i]);
                    ;
                    channelNumbers.Add(int.Parse(itemText.Substring(2)));
                }
            }
            if (selectCount == checkedListBox_channels.Items.Count)
            {
                checkBox_selectAll.Checked = true;
                checkBox_selectAll.CheckState = CheckState.Checked;
                ;
            }
            else if (selectCount == 0)
            {
                checkBox_selectAll.Checked = false;
            }
            else
            {
                checkBox_selectAll.CheckState = CheckState.Indeterminate;
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
                buttonStop_Click(null, null);
            }
            //if (!playing)
            //{
            //    buttonStopPlay_Click(null, null);
            //}
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_terminalType.Items.AddRange(Enum.GetNames(typeof(AITerminalCfg)));
            comboBox_terminalType.SelectedIndex = 0;
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
        //private bool playing;
        bool readyForNext;
        private readonly List<int> playbackChannel = new List<int>();
        #endregion

        #region Events
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var fileBrowser = new OpenFileDialog { Filter = @"(*.bin)|*.bin" };
            if (fileBrowser.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            streamingInfo = new StreamingInfo();
            playback.OpenFile(fileBrowser.FileName, ref streamingInfo);
            textBox_totalSamples.Text = streamingInfo.SamplesPerChannel.ToString();
            channels = streamingInfo.Channels;
            channelCount = channels.Length;
            string fmt = "采样率：{0}   流盘总时间：{1}ms    流盘文件时间长度：{2}ms";
            lable_stripStatus.Text = string.Format(fmt, streamingInfo.SampleRate,
                    TimeSpan.FromMilliseconds(streamingInfo.StreamingTime), TimeSpan.FromMilliseconds(streamingInfo.AcquisitionTime));

            playback.FrameLength = int.Parse(textBox_frameLength.Text);
            playbackBuffer = new double[channelCount, playback.FrameLength];

            button_stopPlay.Enabled = true;
            button_startPlay.Enabled = true;
            button_open.Enabled = false;
            trackBar1.Enabled = true;
            textBox_frameLength.Enabled = false;

            trackBar1.Maximum = 10000;
            trackBar1.Value = 0;
            lable_frameTimeStamp.Text = @"00:00:00:000000";
            if (playback.FrameLength < playback.TotalLength)
            {
                readyForNext = true;
            }
            else
            {
                readyForNext = false;
                MessageBox.Show("Playback frame length is long than total sample length.");
            }
        }

        private void buttonStartPlay_Click(object sender, EventArgs e)
        {
            button_startPlay.Enabled = false;
            button_pausePlay.Enabled = true;
            timer2.Enabled = true;
        }

        private void buttonPausePlay_Click(object sender, EventArgs e)
        {
            button_startPlay.Enabled = true;
            button_pausePlay.Enabled = false;
            timer2.Enabled = false;
        }

        private void buttonStopPlay_Click(object sender, EventArgs e)
        {
            button_startPlay.Enabled = false;
            button_stopPlay.Enabled = false;
            button_pausePlay.Enabled = false;
            button_open.Enabled = true;
            trackBar1.Enabled = false;
            textBox_frameLength.Enabled = true;
            timer2.Enabled = false; //You must first disable timer and then close the file
            playback.CloseFile();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (((double)trackBar1.Value / trackBar1.Maximum + (double)playback.FrameLength / playback.TotalLength) <= 1)
            {
                playback.PlayBackPosition = (long)((double)trackBar1.Value / trackBar1.Maximum * playback.TotalLength);
                playback.ReadPlayBackData(ref playbackBuffer, ref readyForNext);
                lable_frameTimeStamp.Text = TimeSpan.FromMilliseconds((double)playback.PlayBackPosition * 1000 / playback.SampleRate).ToString();
                easyChart_replayer.Plot(playbackBuffer);
            }
            else
            {
                MessageBox.Show("Not enough samples for playback.");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;

            //从文件中读取当前帧数据显示并更新trackBar
            if (readyForNext)
            {
                lable_frameTimeStamp.Text = TimeSpan.FromMilliseconds((double)playback.PlayBackPosition * 1000 / playback.SampleRate).ToString();
                trackBar1.Value = (int)((double)playback.PlayBackPosition / playback.TotalLength * trackBar1.Maximum);
                playback.ReadPlayBackData(ref playbackBuffer, ref readyForNext);
                easyChart_replayer.Plot(playbackBuffer);                              
                timer2.Enabled = true;
            }
            else
            {
                button_startPlay.Enabled = false;
                button_stopPlay.Enabled = false;
                button_pausePlay.Enabled = false;
                button_open.Enabled = true;
                trackBar1.Enabled = false;
                textBox_frameLength.Enabled = true;
                timer2.Enabled = false; //You must first disable timer and then close the file
                playback.CloseFile();
            }

            
        }
        #endregion

        #region Methods
        #endregion

        #endregion


    }
}
