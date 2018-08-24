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
            this.metroButton_stopPlay = new MetroFramework.Controls.MetroButton();
            this.metroButton_open = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton_browse = new MetroFramework.Controls.MetroButton();
            this.metroButton_stop = new MetroFramework.Controls.MetroButton();
            this.checkListBox_channelSelect = new System.Windows.Forms.CheckedListBox();
            this.metroButton_start = new MetroFramework.Controls.MetroButton();
            this.metroTextBox_previewSamples = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_inputLowLimit = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_inputHighLimit = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_samleRate = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_path = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_recordLength = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox_selectAll = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.easyChart_signal = new SeeSharpTools.JY.GUI.EasyChart();
            this.easyChart_spectrum = new SeeSharpTools.JY.GUI.EasyChart();
            this.metroComboBox_boardType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelStripStatus = new MetroFramework.Controls.MetroLabel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.easyChartReplayer = new SeeSharpTools.JY.GUI.EasyChart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.metroButton_startPlay = new MetroFramework.Controls.MetroButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.metroButton_pausePlay = new MetroFramework.Controls.MetroButton();
            this.metroTextBox_totalSamples = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel_frameTimeStamp = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_frameLength = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelTotalSamples = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton_stopPlay
            // 
            this.metroButton_stopPlay.Location = new System.Drawing.Point(770, 82);
            this.metroButton_stopPlay.Name = "metroButton_stopPlay";
            this.metroButton_stopPlay.Size = new System.Drawing.Size(90, 36);
            this.metroButton_stopPlay.TabIndex = 13;
            this.metroButton_stopPlay.Text = "停止回放";
            this.metroButton_stopPlay.Click += new System.EventHandler(this.metroButtonStopPlay_Click);
            // 
            // metroButton_open
            // 
            this.metroButton_open.Location = new System.Drawing.Point(392, 82);
            this.metroButton_open.Name = "metroButton_open";
            this.metroButton_open.Size = new System.Drawing.Size(90, 36);
            this.metroButton_open.TabIndex = 13;
            this.metroButton_open.Text = "打开文件";
            this.metroButton_open.Click += new System.EventHandler(this.metroButtonOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "输出频率（Hz）";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(18, 189);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(465, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.metroButton_browse);
            this.groupBox1.Controls.Add(this.metroButton_stop);
            this.groupBox1.Controls.Add(this.checkListBox_channelSelect);
            this.groupBox1.Controls.Add(this.metroButton_start);
            this.groupBox1.Controls.Add(this.metroTextBox_previewSamples);
            this.groupBox1.Controls.Add(this.metroTextBox_inputLowLimit);
            this.groupBox1.Controls.Add(this.metroTextBox_inputHighLimit);
            this.groupBox1.Controls.Add(this.metroTextBox_samleRate);
            this.groupBox1.Controls.Add(this.metroTextBox_path);
            this.groupBox1.Controls.Add(this.metroTextBox_recordLength);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroCheckBox_selectAll);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(18, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 358);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通道参数";
            // 
            // metroButton_browse
            // 
            this.metroButton_browse.Location = new System.Drawing.Point(287, 282);
            this.metroButton_browse.Name = "metroButton_browse";
            this.metroButton_browse.Size = new System.Drawing.Size(33, 23);
            this.metroButton_browse.TabIndex = 14;
            this.metroButton_browse.Text = "...";
            this.metroButton_browse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // metroButton_stop
            // 
            this.metroButton_stop.Location = new System.Drawing.Point(351, 293);
            this.metroButton_stop.Name = "metroButton_stop";
            this.metroButton_stop.Size = new System.Drawing.Size(90, 36);
            this.metroButton_stop.TabIndex = 13;
            this.metroButton_stop.Text = "停止";
            this.metroButton_stop.Click += new System.EventHandler(this.metroButtonStop_Click);
            // 
            // checkListBox_channelSelect
            // 
            this.checkListBox_channelSelect.CheckOnClick = true;
            this.checkListBox_channelSelect.ColumnWidth = 60;
            this.checkListBox_channelSelect.FormattingEnabled = true;
            this.checkListBox_channelSelect.Items.AddRange(new object[] {
            "CH0",
            "CH1",
            "CH2",
            "CH3"});
            this.checkListBox_channelSelect.Location = new System.Drawing.Point(126, 87);
            this.checkListBox_channelSelect.MultiColumn = true;
            this.checkListBox_channelSelect.Name = "checkListBox_channelSelect";
            this.checkListBox_channelSelect.Size = new System.Drawing.Size(133, 40);
            this.checkListBox_channelSelect.TabIndex = 15;
            this.checkListBox_channelSelect.SelectedValueChanged += new System.EventHandler(this.checkListBoxChannelSelect_SelectedValueChanged);
            // 
            // metroButton_start
            // 
            this.metroButton_start.Location = new System.Drawing.Point(351, 229);
            this.metroButton_start.Name = "metroButton_start";
            this.metroButton_start.Size = new System.Drawing.Size(90, 36);
            this.metroButton_start.TabIndex = 12;
            this.metroButton_start.Text = "开始";
            this.metroButton_start.Click += new System.EventHandler(this.metroButtonStart_Click);
            // 
            // metroTextBox_previewSamples
            // 
            this.metroTextBox_previewSamples.Location = new System.Drawing.Point(126, 244);
            this.metroTextBox_previewSamples.Name = "metroTextBox_previewSamples";
            this.metroTextBox_previewSamples.Size = new System.Drawing.Size(194, 23);
            this.metroTextBox_previewSamples.TabIndex = 11;
            this.metroTextBox_previewSamples.Text = "5000";
            // 
            // metroTextBox_inputLowLimit
            // 
            this.metroTextBox_inputLowLimit.Location = new System.Drawing.Point(127, 173);
            this.metroTextBox_inputLowLimit.Name = "metroTextBox_inputLowLimit";
            this.metroTextBox_inputLowLimit.Size = new System.Drawing.Size(194, 23);
            this.metroTextBox_inputLowLimit.TabIndex = 11;
            this.metroTextBox_inputLowLimit.Text = "-2";
            // 
            // metroTextBox_inputHighLimit
            // 
            this.metroTextBox_inputHighLimit.BackColor = System.Drawing.Color.White;
            this.metroTextBox_inputHighLimit.Location = new System.Drawing.Point(127, 141);
            this.metroTextBox_inputHighLimit.Name = "metroTextBox_inputHighLimit";
            this.metroTextBox_inputHighLimit.Size = new System.Drawing.Size(194, 23);
            this.metroTextBox_inputHighLimit.TabIndex = 11;
            this.metroTextBox_inputHighLimit.Text = "2";
            // 
            // metroTextBox_samleRate
            // 
            this.metroTextBox_samleRate.Location = new System.Drawing.Point(126, 207);
            this.metroTextBox_samleRate.Name = "metroTextBox_samleRate";
            this.metroTextBox_samleRate.Size = new System.Drawing.Size(194, 23);
            this.metroTextBox_samleRate.TabIndex = 11;
            this.metroTextBox_samleRate.Text = "100000";
            // 
            // metroTextBox_path
            // 
            this.metroTextBox_path.Location = new System.Drawing.Point(126, 282);
            this.metroTextBox_path.Name = "metroTextBox_path";
            this.metroTextBox_path.Size = new System.Drawing.Size(155, 23);
            this.metroTextBox_path.TabIndex = 10;
            // 
            // metroTextBox_recordLength
            // 
            this.metroTextBox_recordLength.Location = new System.Drawing.Point(126, 315);
            this.metroTextBox_recordLength.Name = "metroTextBox_recordLength";
            this.metroTextBox_recordLength.Size = new System.Drawing.Size(194, 23);
            this.metroTextBox_recordLength.TabIndex = 8;
            this.metroTextBox_recordLength.Text = "10";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(27, 319);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "保存时间（s）";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(27, 246);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(65, 19);
            this.metroLabel10.TabIndex = 6;
            this.metroLabel10.Text = "预览点数";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(27, 282);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "保存路径";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(27, 173);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(101, 19);
            this.metroLabel9.TabIndex = 4;
            this.metroLabel9.Text = "最小输入（V）";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(27, 141);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(101, 19);
            this.metroLabel8.TabIndex = 4;
            this.metroLabel8.Text = "最大输入（V）";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 207);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "采样率（Hz）";
            // 
            // metroCheckBox_selectAll
            // 
            this.metroCheckBox_selectAll.AutoSize = true;
            this.metroCheckBox_selectAll.Location = new System.Drawing.Point(26, 111);
            this.metroCheckBox_selectAll.Name = "metroCheckBox_selectAll";
            this.metroCheckBox_selectAll.Size = new System.Drawing.Size(47, 15);
            this.metroCheckBox_selectAll.TabIndex = 1;
            this.metroCheckBox_selectAll.Text = "全选";
            this.metroCheckBox_selectAll.UseVisualStyleBackColor = true;
            this.metroCheckBox_selectAll.CheckedChanged += new System.EventHandler(this.metroCheckBoxSelectAll_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "通道选择";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(335, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "数据流盘与回放";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.metroComboBox_boardType);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel7);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer1.Size = new System.Drawing.Size(932, 593);
            this.splitContainer1.SplitterDistance = 441;
            this.splitContainer1.TabIndex = 11;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.easyChart_signal);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.easyChart_spectrum);
            this.splitContainer2.Size = new System.Drawing.Size(441, 593);
            this.splitContainer2.SplitterDistance = 303;
            this.splitContainer2.TabIndex = 0;
            // 
            // easyChart_signal
            // 
            this.easyChart_signal.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_signal.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChart_signal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easyChart_signal.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChart_signal.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_signal.LegendVisible = true;
            this.easyChart_signal.Location = new System.Drawing.Point(0, 0);
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
            this.easyChart_signal.Size = new System.Drawing.Size(441, 303);
            this.easyChart_signal.TabIndex = 7;
            this.easyChart_signal.XAxisLogarithmic = false;
            this.easyChart_signal.YAutoEnable = true;
            this.easyChart_signal.YAxisLogarithmic = false;
            // 
            // easyChart_spectrum
            // 
            this.easyChart_spectrum.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_spectrum.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChart_spectrum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easyChart_spectrum.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChart_spectrum.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_spectrum.LegendVisible = true;
            this.easyChart_spectrum.Location = new System.Drawing.Point(0, 0);
            this.easyChart_spectrum.Margin = new System.Windows.Forms.Padding(2);
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
            this.easyChart_spectrum.Size = new System.Drawing.Size(441, 286);
            this.easyChart_spectrum.TabIndex = 8;
            this.easyChart_spectrum.XAxisLogarithmic = false;
            this.easyChart_spectrum.YAutoEnable = true;
            this.easyChart_spectrum.YAxisLogarithmic = false;
            // 
            // metroComboBox_boardType
            // 
            this.metroComboBox_boardType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroComboBox_boardType.FormattingEnabled = true;
            this.metroComboBox_boardType.ItemHeight = 23;
            this.metroComboBox_boardType.Location = new System.Drawing.Point(112, 144);
            this.metroComboBox_boardType.Margin = new System.Windows.Forms.Padding(2);
            this.metroComboBox_boardType.Name = "metroComboBox_boardType";
            this.metroComboBox_boardType.Size = new System.Drawing.Size(134, 29);
            this.metroComboBox_boardType.TabIndex = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(18, 150);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "板卡类型";
            // 
            // metroLabelStripStatus
            // 
            this.metroLabelStripStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabelStripStatus.AutoSize = true;
            this.metroLabelStripStatus.Location = new System.Drawing.Point(3, 170);
            this.metroLabelStripStatus.Name = "metroLabelStripStatus";
            this.metroLabelStripStatus.Size = new System.Drawing.Size(51, 19);
            this.metroLabelStripStatus.TabIndex = 30;
            this.metroLabelStripStatus.Text = "未启动";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer3.Panel2.Controls.Add(this.trackBar1);
            this.splitContainer3.Panel2.Controls.Add(this.metroButton_open);
            this.splitContainer3.Panel2.Controls.Add(this.metroLabelStripStatus);
            this.splitContainer3.Panel2.Controls.Add(this.metroButton_startPlay);
            this.splitContainer3.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer3.Panel2.Controls.Add(this.metroButton_pausePlay);
            this.splitContainer3.Panel2.Controls.Add(this.metroButton_stopPlay);
            this.splitContainer3.Panel2.Controls.Add(this.metroTextBox_totalSamples);
            this.splitContainer3.Panel2.Controls.Add(this.metroLabel_frameTimeStamp);
            this.splitContainer3.Panel2.Controls.Add(this.metroTextBox_frameLength);
            this.splitContainer3.Panel2.Controls.Add(this.metroLabelTotalSamples);
            this.splitContainer3.Panel2.Controls.Add(this.metroLabel4);
            this.splitContainer3.Panel2.Controls.Add(this.metroLabel6);
            this.splitContainer3.Size = new System.Drawing.Size(932, 593);
            this.splitContainer3.SplitterDistance = 397;
            this.splitContainer3.TabIndex = 35;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.easyChartReplayer);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer4.Size = new System.Drawing.Size(932, 397);
            this.splitContainer4.SplitterDistance = 477;
            this.splitContainer4.TabIndex = 0;
            // 
            // easyChartReplayer
            // 
            this.easyChartReplayer.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChartReplayer.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChartReplayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easyChartReplayer.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChartReplayer.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartReplayer.LegendVisible = true;
            this.easyChartReplayer.Location = new System.Drawing.Point(0, 0);
            this.easyChartReplayer.Margin = new System.Windows.Forms.Padding(2);
            this.easyChartReplayer.Name = "easyChartReplayer";
            this.easyChartReplayer.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChartReplayer.SeriesNames = new string[] {
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
            this.easyChartReplayer.Size = new System.Drawing.Size(477, 397);
            this.easyChartReplayer.TabIndex = 21;
            this.easyChartReplayer.XAxisLogarithmic = false;
            this.easyChartReplayer.YAutoEnable = true;
            this.easyChartReplayer.YAxisLogarithmic = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(451, 397);
            this.dataGridView1.TabIndex = 32;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(932, 45);
            this.trackBar1.TabIndex = 31;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // metroButton_startPlay
            // 
            this.metroButton_startPlay.Location = new System.Drawing.Point(518, 82);
            this.metroButton_startPlay.Name = "metroButton_startPlay";
            this.metroButton_startPlay.Size = new System.Drawing.Size(90, 36);
            this.metroButton_startPlay.TabIndex = 13;
            this.metroButton_startPlay.Text = "开始回放";
            this.metroButton_startPlay.Click += new System.EventHandler(this.metroButtonStartPlay_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Location = new System.Drawing.Point(0, 170);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(932, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // metroButton_pausePlay
            // 
            this.metroButton_pausePlay.Location = new System.Drawing.Point(644, 82);
            this.metroButton_pausePlay.Name = "metroButton_pausePlay";
            this.metroButton_pausePlay.Size = new System.Drawing.Size(90, 36);
            this.metroButton_pausePlay.TabIndex = 13;
            this.metroButton_pausePlay.Text = "暂停回放";
            this.metroButton_pausePlay.Click += new System.EventHandler(this.metroButtonPausePlay_Click);
            // 
            // metroTextBox_totalSamples
            // 
            this.metroTextBox_totalSamples.Location = new System.Drawing.Point(156, 51);
            this.metroTextBox_totalSamples.Name = "metroTextBox_totalSamples";
            this.metroTextBox_totalSamples.Size = new System.Drawing.Size(160, 23);
            this.metroTextBox_totalSamples.TabIndex = 23;
            // 
            // metroLabel_frameTimeStamp
            // 
            this.metroLabel_frameTimeStamp.AutoSize = true;
            this.metroLabel_frameTimeStamp.Location = new System.Drawing.Point(156, 82);
            this.metroLabel_frameTimeStamp.Name = "metroLabel_frameTimeStamp";
            this.metroLabel_frameTimeStamp.Size = new System.Drawing.Size(109, 19);
            this.metroLabel_frameTimeStamp.TabIndex = 24;
            this.metroLabel_frameTimeStamp.Text = "00:00:00.0000000";
            // 
            // metroTextBox_frameLength
            // 
            this.metroTextBox_frameLength.Location = new System.Drawing.Point(156, 112);
            this.metroTextBox_frameLength.Name = "metroTextBox_frameLength";
            this.metroTextBox_frameLength.Size = new System.Drawing.Size(160, 23);
            this.metroTextBox_frameLength.TabIndex = 25;
            this.metroTextBox_frameLength.Text = "5000";
            // 
            // metroLabelTotalSamples
            // 
            this.metroLabelTotalSamples.AutoSize = true;
            this.metroLabelTotalSamples.Location = new System.Drawing.Point(59, 51);
            this.metroLabelTotalSamples.Name = "metroLabelTotalSamples";
            this.metroLabelTotalSamples.Size = new System.Drawing.Size(79, 19);
            this.metroLabelTotalSamples.TabIndex = 28;
            this.metroLabelTotalSamples.Text = "总样本点数";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(59, 82);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 19);
            this.metroLabel4.TabIndex = 27;
            this.metroLabel4.Text = "当前位置时刻";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(59, 116);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(93, 19);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "每帧数据长度";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(28, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("SimSun", 12F);
            this.tabControl1.Location = new System.Drawing.Point(20, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(946, 629);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(938, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "流盘";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer3);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(938, 599);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "回放";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 709);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton_stopPlay;
        private MetroFramework.Controls.MetroButton metroButton_open;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metroButton_browse;
        private MetroFramework.Controls.MetroButton metroButton_stop;
        private MetroFramework.Controls.MetroButton metroButton_start;
        private MetroFramework.Controls.MetroTextBox metroTextBox_samleRate;
        private MetroFramework.Controls.MetroTextBox metroTextBox_path;
        private MetroFramework.Controls.MetroTextBox metroTextBox_recordLength;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox_selectAll;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private SeeSharpTools.JY.GUI.EasyChart easyChart_spectrum;
        private SeeSharpTools.JY.GUI.EasyChart easyChart_signal;
        private SeeSharpTools.JY.GUI.EasyChart easyChartReplayer;
        private MetroFramework.Controls.MetroTextBox metroTextBox_previewSamples;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton metroButton_startPlay;
        private MetroFramework.Controls.MetroLabel metroLabelTotalSamples;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox_frameLength;
        private MetroFramework.Controls.MetroLabel metroLabel_frameTimeStamp;
        private MetroFramework.Controls.MetroTextBox metroTextBox_totalSamples;
        private MetroFramework.Controls.MetroButton metroButton_pausePlay;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private MetroFramework.Controls.MetroLabel metroLabelStripStatus;
        private System.Windows.Forms.CheckedListBox checkListBox_channelSelect;
        private System.Windows.Forms.TrackBar trackBar1;
        private MetroFramework.Controls.MetroComboBox metroComboBox_boardType;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBox_inputLowLimit;
        private MetroFramework.Controls.MetroTextBox metroTextBox_inputHighLimit;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

