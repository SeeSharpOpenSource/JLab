namespace StreamingAndPlaybackDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.easyChart_spectrum = new SeeSharpTools.JY.GUI.EasyChart();
            this.easyChart_signal = new SeeSharpTools.JY.GUI.EasyChart();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_terminalType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button_browse = new System.Windows.Forms.Button();
            this.textBox_recordLength = new System.Windows.Forms.TextBox();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.textBox_previewSamples = new System.Windows.Forms.TextBox();
            this.textBox_sampleRate = new System.Windows.Forms.TextBox();
            this.textBox_inputLow = new System.Windows.Forms.TextBox();
            this.textBox_inputHigh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox_channels = new System.Windows.Forms.CheckedListBox();
            this.checkBox_selectAll = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox_boardType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.easyChart_replayer = new SeeSharpTools.JY.GUI.EasyChart();
            this.lable_frameTimeStamp = new System.Windows.Forms.Label();
            this.lable_stripStatus = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textBox_frameLength = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_totalSamples = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_stopPlay = new System.Windows.Forms.Button();
            this.button_pausePlay = new System.Windows.Forms.Button();
            this.button_startPlay = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(-4, 82);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1095, 585);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.easyChart_spectrum);
            this.tabPage2.Controls.Add(this.easyChart_signal);
            this.tabPage2.Controls.Add(this.button_stop);
            this.tabPage2.Controls.Add(this.button_start);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.comboBox_boardType);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(27, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1064, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Streaming";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // easyChart_spectrum
            // 
            this.easyChart_spectrum.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_spectrum.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChart_spectrum.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChart_spectrum.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_spectrum.LegendVisible = false;
            this.easyChart_spectrum.Location = new System.Drawing.Point(0, 293);
            this.easyChart_spectrum.Margin = new System.Windows.Forms.Padding(4);
            this.easyChart_spectrum.Name = "easyChart_spectrum";
            this.easyChart_spectrum.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart_spectrum.SeriesNames = new string[] {
        "Series1",
        "Series2",
        "Series3",
        "Series4",
        "Series5",
        "Series6",
        "Series7",
        "Series8",
        "Series9",
        "Series10",
        "Series11",
        "Series12",
        "Series13",
        "Series14",
        "Series15",
        "Series16",
        "Series17",
        "Series18",
        "Series19",
        "Series20",
        "Series21",
        "Series22",
        "Series23",
        "Series24",
        "Series25",
        "Series26",
        "Series27",
        "Series28",
        "Series29",
        "Series30",
        "Series31",
        "Series32"};
            this.easyChart_spectrum.Size = new System.Drawing.Size(536, 284);
            this.easyChart_spectrum.TabIndex = 8;
            this.easyChart_spectrum.XAxisLogarithmic = false;
            this.easyChart_spectrum.YAutoEnable = true;
            this.easyChart_spectrum.YAxisLogarithmic = false;
            // 
            // easyChart_signal
            // 
            this.easyChart_signal.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_signal.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChart_signal.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChart_signal.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_signal.LegendVisible = false;
            this.easyChart_signal.Location = new System.Drawing.Point(0, 3);
            this.easyChart_signal.Margin = new System.Windows.Forms.Padding(2);
            this.easyChart_signal.Name = "easyChart_signal";
            this.easyChart_signal.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart_signal.SeriesNames = new string[] {
        "Series1",
        "Series2",
        "Series3",
        "Series4",
        "Series5",
        "Series6",
        "Series7",
        "Series8",
        "Series9",
        "Series10",
        "Series11",
        "Series12",
        "Series13",
        "Series14",
        "Series15",
        "Series16",
        "Series17",
        "Series18",
        "Series19",
        "Series20",
        "Series21",
        "Series22",
        "Series23",
        "Series24",
        "Series25",
        "Series26",
        "Series27",
        "Series28",
        "Series29",
        "Series30",
        "Series31",
        "Series32"};
            this.easyChart_signal.Size = new System.Drawing.Size(536, 284);
            this.easyChart_signal.TabIndex = 8;
            this.easyChart_signal.XAxisLogarithmic = false;
            this.easyChart_signal.YAutoEnable = true;
            this.easyChart_signal.YAxisLogarithmic = false;
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(709, 528);
            this.button_stop.Margin = new System.Windows.Forms.Padding(2);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(82, 28);
            this.button_stop.TabIndex = 7;
            this.button_stop.Text = "停止";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(592, 528);
            this.button_start.Margin = new System.Windows.Forms.Padding(2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(82, 28);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_terminalType);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.button_browse);
            this.groupBox1.Controls.Add(this.textBox_recordLength);
            this.groupBox1.Controls.Add(this.textBox_path);
            this.groupBox1.Controls.Add(this.textBox_previewSamples);
            this.groupBox1.Controls.Add(this.textBox_sampleRate);
            this.groupBox1.Controls.Add(this.textBox_inputLow);
            this.groupBox1.Controls.Add(this.textBox_inputHigh);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkedListBox_channels);
            this.groupBox1.Controls.Add(this.checkBox_selectAll);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(592, 137);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(369, 375);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通道配置";
            // 
            // comboBox_terminalType
            // 
            this.comboBox_terminalType.FormattingEnabled = true;
            this.comboBox_terminalType.Location = new System.Drawing.Point(143, 265);
            this.comboBox_terminalType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_terminalType.Name = "comboBox_terminalType";
            this.comboBox_terminalType.Size = new System.Drawing.Size(208, 25);
            this.comboBox_terminalType.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 265);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 18);
            this.label13.TabIndex = 15;
            this.label13.Text = "接线端方式";
            // 
            // button_browse
            // 
            this.button_browse.BackColor = System.Drawing.Color.White;
            this.button_browse.Font = new System.Drawing.Font("宋体", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_browse.Location = new System.Drawing.Point(323, 302);
            this.button_browse.Margin = new System.Windows.Forms.Padding(2);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(28, 30);
            this.button_browse.TabIndex = 8;
            this.button_browse.Text = "...";
            this.button_browse.UseVisualStyleBackColor = false;
            this.button_browse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBox_recordLength
            // 
            this.textBox_recordLength.Location = new System.Drawing.Point(143, 339);
            this.textBox_recordLength.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_recordLength.Name = "textBox_recordLength";
            this.textBox_recordLength.Size = new System.Drawing.Size(208, 27);
            this.textBox_recordLength.TabIndex = 14;
            this.textBox_recordLength.Text = "10";
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(143, 302);
            this.textBox_path.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(176, 27);
            this.textBox_path.TabIndex = 13;
            // 
            // textBox_previewSamples
            // 
            this.textBox_previewSamples.Location = new System.Drawing.Point(144, 229);
            this.textBox_previewSamples.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_previewSamples.Name = "textBox_previewSamples";
            this.textBox_previewSamples.Size = new System.Drawing.Size(208, 27);
            this.textBox_previewSamples.TabIndex = 12;
            this.textBox_previewSamples.Text = "10000";
            // 
            // textBox_sampleRate
            // 
            this.textBox_sampleRate.Location = new System.Drawing.Point(144, 185);
            this.textBox_sampleRate.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_sampleRate.Name = "textBox_sampleRate";
            this.textBox_sampleRate.Size = new System.Drawing.Size(208, 27);
            this.textBox_sampleRate.TabIndex = 11;
            this.textBox_sampleRate.Text = "128000";
            // 
            // textBox_inputLow
            // 
            this.textBox_inputLow.Location = new System.Drawing.Point(144, 145);
            this.textBox_inputLow.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_inputLow.Name = "textBox_inputLow";
            this.textBox_inputLow.Size = new System.Drawing.Size(208, 27);
            this.textBox_inputLow.TabIndex = 10;
            this.textBox_inputLow.Text = "-2";
            // 
            // textBox_inputHigh
            // 
            this.textBox_inputHigh.Location = new System.Drawing.Point(144, 103);
            this.textBox_inputHigh.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_inputHigh.Name = "textBox_inputHigh";
            this.textBox_inputHigh.Size = new System.Drawing.Size(208, 27);
            this.textBox_inputHigh.TabIndex = 9;
            this.textBox_inputHigh.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 342);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "保存时间（s）";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 305);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "保存路径";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "预览点数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "采样率（Hz）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "最小输入（V）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "最大输入（V）";
            // 
            // checkedListBox_channels
            // 
            this.checkedListBox_channels.CheckOnClick = true;
            this.checkedListBox_channels.ColumnWidth = 60;
            this.checkedListBox_channels.FormattingEnabled = true;
            this.checkedListBox_channels.Items.AddRange(new object[] {
            "CH0",
            "CH1",
            "CH2",
            "CH3"});
            this.checkedListBox_channels.Location = new System.Drawing.Point(144, 24);
            this.checkedListBox_channels.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_channels.MultiColumn = true;
            this.checkedListBox_channels.Name = "checkedListBox_channels";
            this.checkedListBox_channels.Size = new System.Drawing.Size(207, 48);
            this.checkedListBox_channels.TabIndex = 2;
            this.checkedListBox_channels.SelectedValueChanged += new System.EventHandler(this.checkListBoxChannelSelect_SelectedValueChanged);
            // 
            // checkBox_selectAll
            // 
            this.checkBox_selectAll.AutoSize = true;
            this.checkBox_selectAll.Location = new System.Drawing.Point(13, 56);
            this.checkBox_selectAll.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_selectAll.Name = "checkBox_selectAll";
            this.checkBox_selectAll.Size = new System.Drawing.Size(63, 22);
            this.checkBox_selectAll.TabIndex = 1;
            this.checkBox_selectAll.Text = "全选";
            this.checkBox_selectAll.UseVisualStyleBackColor = true;
            this.checkBox_selectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "通道选择";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(592, 94);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(369, 20);
            this.progressBar1.TabIndex = 4;
            // 
            // comboBox_boardType
            // 
            this.comboBox_boardType.Font = new System.Drawing.Font("宋体", 13F);
            this.comboBox_boardType.FormattingEnabled = true;
            this.comboBox_boardType.Location = new System.Drawing.Point(728, 51);
            this.comboBox_boardType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_boardType.Name = "comboBox_boardType";
            this.comboBox_boardType.Size = new System.Drawing.Size(216, 25);
            this.comboBox_boardType.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "板卡类型";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.easyChart_replayer);
            this.tabPage1.Controls.Add(this.lable_frameTimeStamp);
            this.tabPage1.Controls.Add(this.lable_stripStatus);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.textBox_frameLength);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.textBox_totalSamples);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.button_stopPlay);
            this.tabPage1.Controls.Add(this.button_pausePlay);
            this.tabPage1.Controls.Add(this.button_startPlay);
            this.tabPage1.Controls.Add(this.button_open);
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Location = new System.Drawing.Point(27, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1060, 577);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Playback";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // easyChart_replayer
            // 
            this.easyChart_replayer.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_replayer.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChart_replayer.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChart_replayer.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_replayer.LegendVisible = false;
            this.easyChart_replayer.Location = new System.Drawing.Point(0, 0);
            this.easyChart_replayer.Margin = new System.Windows.Forms.Padding(2);
            this.easyChart_replayer.Name = "easyChart_replayer";
            this.easyChart_replayer.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart_replayer.SeriesNames = new string[] {
        "Series1",
        "Series2",
        "Series3",
        "Series4",
        "Series5",
        "Series6",
        "Series7",
        "Series8",
        "Series9",
        "Series10",
        "Series11",
        "Series12",
        "Series13",
        "Series14",
        "Series15",
        "Series16",
        "Series17",
        "Series18",
        "Series19",
        "Series20",
        "Series21",
        "Series22",
        "Series23",
        "Series24",
        "Series25",
        "Series26",
        "Series27",
        "Series28",
        "Series29",
        "Series30",
        "Series31",
        "Series32"};
            this.easyChart_replayer.Size = new System.Drawing.Size(1059, 319);
            this.easyChart_replayer.TabIndex = 48;
            this.easyChart_replayer.XAxisLogarithmic = false;
            this.easyChart_replayer.YAutoEnable = true;
            this.easyChart_replayer.YAxisLogarithmic = false;
            // 
            // lable_frameTimeStamp
            // 
            this.lable_frameTimeStamp.AutoSize = true;
            this.lable_frameTimeStamp.Location = new System.Drawing.Point(294, 440);
            this.lable_frameTimeStamp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable_frameTimeStamp.Name = "lable_frameTimeStamp";
            this.lable_frameTimeStamp.Size = new System.Drawing.Size(152, 18);
            this.lable_frameTimeStamp.TabIndex = 47;
            this.lable_frameTimeStamp.Text = "00:00:00.0000000";
            // 
            // lable_stripStatus
            // 
            this.lable_stripStatus.AutoSize = true;
            this.lable_stripStatus.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable_stripStatus.Location = new System.Drawing.Point(4, 558);
            this.lable_stripStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable_stripStatus.Name = "lable_stripStatus";
            this.lable_stripStatus.Size = new System.Drawing.Size(41, 12);
            this.lable_stripStatus.TabIndex = 46;
            this.lable_stripStatus.Text = "未启动";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Location = new System.Drawing.Point(2, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1056, 22);
            this.statusStrip1.TabIndex = 45;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textBox_frameLength
            // 
            this.textBox_frameLength.Location = new System.Drawing.Point(298, 475);
            this.textBox_frameLength.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_frameLength.Name = "textBox_frameLength";
            this.textBox_frameLength.Size = new System.Drawing.Size(160, 27);
            this.textBox_frameLength.TabIndex = 44;
            this.textBox_frameLength.Text = "1000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(158, 475);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 18);
            this.label12.TabIndex = 43;
            this.label12.Text = "每帧数据长度";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 440);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 18);
            this.label11.TabIndex = 41;
            this.label11.Text = "当前位置时刻";
            // 
            // textBox_totalSamples
            // 
            this.textBox_totalSamples.Location = new System.Drawing.Point(298, 398);
            this.textBox_totalSamples.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_totalSamples.Name = "textBox_totalSamples";
            this.textBox_totalSamples.Size = new System.Drawing.Size(160, 27);
            this.textBox_totalSamples.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 401);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 39;
            this.label10.Text = "总样本点数";
            // 
            // button_stopPlay
            // 
            this.button_stopPlay.Location = new System.Drawing.Point(854, 421);
            this.button_stopPlay.Margin = new System.Windows.Forms.Padding(2);
            this.button_stopPlay.Name = "button_stopPlay";
            this.button_stopPlay.Size = new System.Drawing.Size(115, 28);
            this.button_stopPlay.TabIndex = 38;
            this.button_stopPlay.Text = "停止回放";
            this.button_stopPlay.UseVisualStyleBackColor = true;
            this.button_stopPlay.Click += new System.EventHandler(this.buttonStopPlay_Click);
            // 
            // button_pausePlay
            // 
            this.button_pausePlay.Location = new System.Drawing.Point(735, 421);
            this.button_pausePlay.Margin = new System.Windows.Forms.Padding(2);
            this.button_pausePlay.Name = "button_pausePlay";
            this.button_pausePlay.Size = new System.Drawing.Size(115, 28);
            this.button_pausePlay.TabIndex = 37;
            this.button_pausePlay.Text = "暂停回放";
            this.button_pausePlay.UseVisualStyleBackColor = true;
            this.button_pausePlay.Click += new System.EventHandler(this.buttonPausePlay_Click);
            // 
            // button_startPlay
            // 
            this.button_startPlay.Location = new System.Drawing.Point(616, 421);
            this.button_startPlay.Margin = new System.Windows.Forms.Padding(2);
            this.button_startPlay.Name = "button_startPlay";
            this.button_startPlay.Size = new System.Drawing.Size(115, 28);
            this.button_startPlay.TabIndex = 36;
            this.button_startPlay.Text = "开始回放";
            this.button_startPlay.UseVisualStyleBackColor = true;
            this.button_startPlay.Click += new System.EventHandler(this.buttonStartPlay_Click);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(497, 421);
            this.button_open.Margin = new System.Windows.Forms.Padding(2);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(115, 28);
            this.button_open.TabIndex = 35;
            this.button_open.Text = "打开文件";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(0, 333);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1062, 45);
            this.trackBar1.TabIndex = 34;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label8.Font = new System.Drawing.Font("宋体", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(310, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(457, 38);
            this.label8.TabIndex = 96;
            this.label8.Text = "Streaming and Playback";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1091, 83);
            this.splitter1.TabIndex = 97;
            this.splitter1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1091, 669);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Streaming and Playback";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ComboBox comboBox_boardType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_selectAll;
        private System.Windows.Forms.CheckedListBox checkedListBox_channels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_sampleRate;
        private System.Windows.Forms.TextBox textBox_inputLow;
        private System.Windows.Forms.TextBox textBox_inputHigh;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.TextBox textBox_previewSamples;
        private System.Windows.Forms.TextBox textBox_recordLength;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_stopPlay;
        private System.Windows.Forms.Button button_pausePlay;
        private System.Windows.Forms.Button button_startPlay;
        private System.Windows.Forms.TextBox textBox_totalSamples;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_frameLength;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lable_stripStatus;
        private System.Windows.Forms.Label lable_frameTimeStamp;
        private SeeSharpTools.JY.GUI.EasyChart easyChart_spectrum;
        private SeeSharpTools.JY.GUI.EasyChart easyChart_signal;
        private SeeSharpTools.JY.GUI.EasyChart easyChart_replayer;
        private System.Windows.Forms.ComboBox comboBox_terminalType;
        private System.Windows.Forms.Label label13;
    }
}

