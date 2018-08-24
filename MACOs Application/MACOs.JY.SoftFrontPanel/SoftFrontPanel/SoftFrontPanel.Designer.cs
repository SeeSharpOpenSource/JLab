namespace MACOs.JY.SoftFrontPanel
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
            this.timer_measure = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.easyButton_start = new SeeSharpTools.JY.GUI.EasyButton();
            this.easyButton_stop = new SeeSharpTools.JY.GUI.EasyButton();
            this.easyButton_contStart = new SeeSharpTools.JY.GUI.EasyButton();
            this.easyChart1 = new SeeSharpTools.JY.GUI.EasyChart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_chConfig = new System.Windows.Forms.TabPage();
            this.dgv_ChannelsConfig = new System.Windows.Forms.DataGridView();
            this.tabPage_timing = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_samples = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_sampleRate = new System.Windows.Forms.NumericUpDown();
            this.checkBox_timeDisplay = new System.Windows.Forms.CheckBox();
            this.tabPage_Trigger = new System.Windows.Forms.TabPage();
            this.propertyGrid_trigProp = new System.Windows.Forms.PropertyGrid();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_attRatio = new System.Windows.Forms.ComboBox();
            this.dgv_mathEngine = new System.Windows.Forms.DataGridView();
            this.splitContainer_Panel = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_instr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_aiDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_graphs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_time = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_freq = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_help = new System.Windows.Forms.ToolStripMenuItem();
            this.v102ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer_bg = new System.Windows.Forms.SplitContainer();
            this.splitContainer_cfg = new System.Windows.Forms.SplitContainer();
            this.splitContainer_ctrl = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl1.SuspendLayout();
            this.tabPage_chConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChannelsConfig)).BeginInit();
            this.tabPage_timing.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_samples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            this.tabPage_Trigger.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mathEngine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Panel)).BeginInit();
            this.splitContainer_Panel.Panel1.SuspendLayout();
            this.splitContainer_Panel.Panel2.SuspendLayout();
            this.splitContainer_Panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_bg)).BeginInit();
            this.splitContainer_bg.Panel1.SuspendLayout();
            this.splitContainer_bg.Panel2.SuspendLayout();
            this.splitContainer_bg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_cfg)).BeginInit();
            this.splitContainer_cfg.Panel1.SuspendLayout();
            this.splitContainer_cfg.Panel2.SuspendLayout();
            this.splitContainer_cfg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_ctrl)).BeginInit();
            this.splitContainer_ctrl.Panel1.SuspendLayout();
            this.splitContainer_ctrl.Panel2.SuspendLayout();
            this.splitContainer_ctrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_measure
            // 
            this.timer_measure.Tick += new System.EventHandler(this.timer_measure_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // easyButton_start
            // 
            this.easyButton_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.easyButton_start.BackColor = System.Drawing.SystemColors.Control;
            this.easyButton_start.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.easyButton_start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.easyButton_start.Image = ((System.Drawing.Image)(resources.GetObject("easyButton_start.Image")));
            this.easyButton_start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.easyButton_start.Location = new System.Drawing.Point(100, 12);
            this.easyButton_start.Name = "easyButton_start";
            this.easyButton_start.PreSetImage = SeeSharpTools.JY.GUI.EasyButton.ButtonPresetImage.Go;
            this.easyButton_start.Size = new System.Drawing.Size(80, 32);
            this.easyButton_start.TabIndex = 11;
            this.easyButton_start.Text = "Single";
            this.easyButton_start.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.easyButton_start.UseVisualStyleBackColor = false;
            this.easyButton_start.Click += new System.EventHandler(this.easyButton_start_Click);
            // 
            // easyButton_stop
            // 
            this.easyButton_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.easyButton_stop.BackColor = System.Drawing.SystemColors.Control;
            this.easyButton_stop.Image = ((System.Drawing.Image)(resources.GetObject("easyButton_stop.Image")));
            this.easyButton_stop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.easyButton_stop.Location = new System.Drawing.Point(187, 12);
            this.easyButton_stop.Name = "easyButton_stop";
            this.easyButton_stop.PreSetImage = SeeSharpTools.JY.GUI.EasyButton.ButtonPresetImage.Close;
            this.easyButton_stop.Size = new System.Drawing.Size(80, 32);
            this.easyButton_stop.TabIndex = 12;
            this.easyButton_stop.Text = "Stop";
            this.easyButton_stop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.easyButton_stop.UseVisualStyleBackColor = false;
            this.easyButton_stop.Click += new System.EventHandler(this.easyButton_stop_Click);
            // 
            // easyButton_contStart
            // 
            this.easyButton_contStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.easyButton_contStart.BackColor = System.Drawing.SystemColors.Control;
            this.easyButton_contStart.Image = ((System.Drawing.Image)(resources.GetObject("easyButton_contStart.Image")));
            this.easyButton_contStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.easyButton_contStart.Location = new System.Drawing.Point(273, 12);
            this.easyButton_contStart.Name = "easyButton_contStart";
            this.easyButton_contStart.PreSetImage = SeeSharpTools.JY.GUI.EasyButton.ButtonPresetImage.Refresh;
            this.easyButton_contStart.Size = new System.Drawing.Size(80, 32);
            this.easyButton_contStart.TabIndex = 13;
            this.easyButton_contStart.Text = "Cont.";
            this.easyButton_contStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.easyButton_contStart.UseVisualStyleBackColor = false;
            this.easyButton_contStart.Click += new System.EventHandler(this.easyButton_contStart_Click);
            // 
            // easyChart1
            // 
            this.easyChart1.AxisYMax = double.NaN;
            this.easyChart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.easyChart1.ChartAreaBackColor = System.Drawing.Color.Gainsboro;
            this.easyChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easyChart1.EasyChartBackColor = System.Drawing.SystemColors.Control;
            this.easyChart1.FixAxisX = false;
            this.easyChart1.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart1.LegendVisible = true;
            this.easyChart1.Location = new System.Drawing.Point(0, 0);
            this.easyChart1.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart1.MajorGridEnabled = true;
            this.easyChart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.easyChart1.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart1.MinorGridEnabled = false;
            this.easyChart1.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChart1.Name = "easyChart1";
            this.easyChart1.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart1.SeriesNames = new string[] {
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
            this.easyChart1.Size = new System.Drawing.Size(834, 561);
            this.easyChart1.TabIndex = 1;
            this.easyChart1.XAxisLogarithmic = false;
            this.easyChart1.YAutoEnable = true;
            this.easyChart1.YAxisLogarithmic = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_chConfig);
            this.tabControl1.Controls.Add(this.tabPage_timing);
            this.tabControl1.Controls.Add(this.tabPage_Trigger);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(358, 346);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage_chConfig
            // 
            this.tabPage_chConfig.Controls.Add(this.dgv_ChannelsConfig);
            this.tabPage_chConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPage_chConfig.Name = "tabPage_chConfig";
            this.tabPage_chConfig.Size = new System.Drawing.Size(350, 320);
            this.tabPage_chConfig.TabIndex = 2;
            this.tabPage_chConfig.Text = "ChannelConfig";
            this.tabPage_chConfig.UseVisualStyleBackColor = true;
            // 
            // dgv_ChannelsConfig
            // 
            this.dgv_ChannelsConfig.AllowUserToAddRows = false;
            this.dgv_ChannelsConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChannelsConfig.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ChannelsConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChannelsConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ChannelsConfig.Location = new System.Drawing.Point(0, 0);
            this.dgv_ChannelsConfig.Name = "dgv_ChannelsConfig";
            this.dgv_ChannelsConfig.Size = new System.Drawing.Size(350, 320);
            this.dgv_ChannelsConfig.TabIndex = 3;
            // 
            // tabPage_timing
            // 
            this.tabPage_timing.Controls.Add(this.flowLayoutPanel2);
            this.tabPage_timing.Location = new System.Drawing.Point(4, 22);
            this.tabPage_timing.Name = "tabPage_timing";
            this.tabPage_timing.Size = new System.Drawing.Size(297, 326);
            this.tabPage_timing.TabIndex = 3;
            this.tabPage_timing.Text = "Timing";
            this.tabPage_timing.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.groupBox2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(297, 326);
            this.flowLayoutPanel2.TabIndex = 17;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numericUpDown_samples);
            this.groupBox2.Controls.Add(this.numericUpDown_sampleRate);
            this.groupBox2.Controls.Add(this.checkBox_timeDisplay);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 128);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "采样设定";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "Samples to Read (samples)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "Sample Rate (samples/ sec)";
            // 
            // numericUpDown_samples
            // 
            this.numericUpDown_samples.Location = new System.Drawing.Point(172, 85);
            this.numericUpDown_samples.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_samples.Name = "numericUpDown_samples";
            this.numericUpDown_samples.Size = new System.Drawing.Size(108, 21);
            this.numericUpDown_samples.TabIndex = 9;
            this.numericUpDown_samples.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_samples.ValueChanged += new System.EventHandler(this.numericUpDown_samples_ValueChanged);
            // 
            // numericUpDown_sampleRate
            // 
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(172, 57);
            this.numericUpDown_sampleRate.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_sampleRate.Name = "numericUpDown_sampleRate";
            this.numericUpDown_sampleRate.Size = new System.Drawing.Size(108, 21);
            this.numericUpDown_sampleRate.TabIndex = 8;
            this.numericUpDown_sampleRate.Value = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.ValueChanged += new System.EventHandler(this.numericUpDown_sampleRate_ValueChanged);
            // 
            // checkBox_timeDisplay
            // 
            this.checkBox_timeDisplay.AutoSize = true;
            this.checkBox_timeDisplay.Location = new System.Drawing.Point(28, 26);
            this.checkBox_timeDisplay.Name = "checkBox_timeDisplay";
            this.checkBox_timeDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_timeDisplay.Size = new System.Drawing.Size(156, 16);
            this.checkBox_timeDisplay.TabIndex = 14;
            this.checkBox_timeDisplay.Text = "Display in Time format";
            this.checkBox_timeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_timeDisplay.UseVisualStyleBackColor = true;
            // 
            // tabPage_Trigger
            // 
            this.tabPage_Trigger.Controls.Add(this.propertyGrid_trigProp);
            this.tabPage_Trigger.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Trigger.Name = "tabPage_Trigger";
            this.tabPage_Trigger.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage_Trigger.Size = new System.Drawing.Size(297, 326);
            this.tabPage_Trigger.TabIndex = 0;
            this.tabPage_Trigger.Text = "Trigger";
            this.tabPage_Trigger.UseVisualStyleBackColor = true;
            // 
            // propertyGrid_trigProp
            // 
            this.propertyGrid_trigProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid_trigProp.HelpVisible = false;
            this.propertyGrid_trigProp.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyGrid_trigProp.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid_trigProp.Name = "propertyGrid_trigProp";
            this.propertyGrid_trigProp.Size = new System.Drawing.Size(291, 320);
            this.propertyGrid_trigProp.TabIndex = 21;
            this.propertyGrid_trigProp.ToolbarVisible = false;
            this.propertyGrid_trigProp.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid_trigProp_PropertyValueChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.comboBox_attRatio);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(297, 326);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Misc";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "Attenuation Ratio (N:1)";
            // 
            // comboBox_attRatio
            // 
            this.comboBox_attRatio.FormattingEnabled = true;
            this.comboBox_attRatio.Items.AddRange(new object[] {
            "1",
            "15",
            "50"});
            this.comboBox_attRatio.Location = new System.Drawing.Point(17, 30);
            this.comboBox_attRatio.Name = "comboBox_attRatio";
            this.comboBox_attRatio.Size = new System.Drawing.Size(78, 20);
            this.comboBox_attRatio.TabIndex = 1;
            this.comboBox_attRatio.SelectedIndexChanged += new System.EventHandler(this.comboBox_attRatio_SelectedIndexChanged);
            // 
            // dgv_mathEngine
            // 
            this.dgv_mathEngine.AllowUserToAddRows = false;
            this.dgv_mathEngine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mathEngine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mathEngine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_mathEngine.Location = new System.Drawing.Point(0, 0);
            this.dgv_mathEngine.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_mathEngine.Name = "dgv_mathEngine";
            this.dgv_mathEngine.RowTemplate.Height = 23;
            this.dgv_mathEngine.Size = new System.Drawing.Size(358, 150);
            this.dgv_mathEngine.TabIndex = 0;
            this.dgv_mathEngine.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_mathEngine_CellMouseUp);
            this.dgv_mathEngine.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mathEngine_CellValueChanged);
            this.dgv_mathEngine.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_mathEngine_CurrentCellDirtyStateChanged);
            this.dgv_mathEngine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgv_mathEngine_MouseUp);
            // 
            // splitContainer_Panel
            // 
            this.splitContainer_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Panel.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_Panel.IsSplitterFixed = true;
            this.splitContainer_Panel.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Panel.Name = "splitContainer_Panel";
            this.splitContainer_Panel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Panel.Panel1
            // 
            this.splitContainer_Panel.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer_Panel.Panel2
            // 
            this.splitContainer_Panel.Panel2.Controls.Add(this.splitContainer_bg);
            this.splitContainer_Panel.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer_Panel.Panel2.Controls.Add(this.label1);
            this.splitContainer_Panel.Panel2.Controls.Add(this.splitter1);
            this.splitContainer_Panel.Size = new System.Drawing.Size(1196, 692);
            this.splitContainer_Panel.SplitterDistance = 25;
            this.splitContainer_Panel.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_instr,
            this.toolStripMenuItem_graphs,
            this.toolStripMenuItem_help});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1196, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_instr
            // 
            this.toolStripMenuItem_instr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_aiDevice});
            this.toolStripMenuItem_instr.Name = "toolStripMenuItem_instr";
            this.toolStripMenuItem_instr.Size = new System.Drawing.Size(88, 21);
            this.toolStripMenuItem_instr.Text = "Instruments";
            // 
            // toolStripMenuItem_aiDevice
            // 
            this.toolStripMenuItem_aiDevice.Name = "toolStripMenuItem_aiDevice";
            this.toolStripMenuItem_aiDevice.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem_aiDevice.Text = "AnalogInputDevices";
            this.toolStripMenuItem_aiDevice.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenuItem_aiDevice_DropDownItemClicked);
            // 
            // toolStripMenuItem_graphs
            // 
            this.toolStripMenuItem_graphs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_time,
            this.toolStripMenuItem_freq});
            this.toolStripMenuItem_graphs.Name = "toolStripMenuItem_graphs";
            this.toolStripMenuItem_graphs.Size = new System.Drawing.Size(101, 21);
            this.toolStripMenuItem_graphs.Text = "Display Mode";
            this.toolStripMenuItem_graphs.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenuItem_graphs_DropDownItemClicked);
            // 
            // toolStripMenuItem_time
            // 
            this.toolStripMenuItem_time.CheckOnClick = true;
            this.toolStripMenuItem_time.Name = "toolStripMenuItem_time";
            this.toolStripMenuItem_time.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem_time.Text = "Time Waveform";
            // 
            // toolStripMenuItem_freq
            // 
            this.toolStripMenuItem_freq.CheckOnClick = true;
            this.toolStripMenuItem_freq.Name = "toolStripMenuItem_freq";
            this.toolStripMenuItem_freq.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem_freq.Text = "Spectrum";
            // 
            // toolStripMenuItem_help
            // 
            this.toolStripMenuItem_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v102ToolStripMenuItem});
            this.toolStripMenuItem_help.Name = "toolStripMenuItem_help";
            this.toolStripMenuItem_help.Size = new System.Drawing.Size(47, 21);
            this.toolStripMenuItem_help.Text = "Help";
            // 
            // v102ToolStripMenuItem
            // 
            this.v102ToolStripMenuItem.Name = "v102ToolStripMenuItem";
            this.v102ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.v102ToolStripMenuItem.Text = "v 1.2.1";
            // 
            // splitContainer_bg
            // 
            this.splitContainer_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_bg.Location = new System.Drawing.Point(0, 80);
            this.splitContainer_bg.Name = "splitContainer_bg";
            // 
            // splitContainer_bg.Panel1
            // 
            this.splitContainer_bg.Panel1.Controls.Add(this.easyChart1);
            // 
            // splitContainer_bg.Panel2
            // 
            this.splitContainer_bg.Panel2.Controls.Add(this.splitContainer_cfg);
            this.splitContainer_bg.Size = new System.Drawing.Size(1196, 561);
            this.splitContainer_bg.SplitterDistance = 834;
            this.splitContainer_bg.TabIndex = 18;
            // 
            // splitContainer_cfg
            // 
            this.splitContainer_cfg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_cfg.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_cfg.Name = "splitContainer_cfg";
            this.splitContainer_cfg.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_cfg.Panel1
            // 
            this.splitContainer_cfg.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer_cfg.Panel2
            // 
            this.splitContainer_cfg.Panel2.Controls.Add(this.splitContainer_ctrl);
            this.splitContainer_cfg.Size = new System.Drawing.Size(358, 561);
            this.splitContainer_cfg.SplitterDistance = 346;
            this.splitContainer_cfg.TabIndex = 0;
            // 
            // splitContainer_ctrl
            // 
            this.splitContainer_ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_ctrl.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_ctrl.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_ctrl.Name = "splitContainer_ctrl";
            this.splitContainer_ctrl.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_ctrl.Panel1
            // 
            this.splitContainer_ctrl.Panel1.Controls.Add(this.dgv_mathEngine);
            // 
            // splitContainer_ctrl.Panel2
            // 
            this.splitContainer_ctrl.Panel2.Controls.Add(this.easyButton_start);
            this.splitContainer_ctrl.Panel2.Controls.Add(this.easyButton_contStart);
            this.splitContainer_ctrl.Panel2.Controls.Add(this.easyButton_stop);
            this.splitContainer_ctrl.Size = new System.Drawing.Size(358, 211);
            this.splitContainer_ctrl.SplitterDistance = 150;
            this.splitContainer_ctrl.TabIndex = 19;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 641);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1196, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(19)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 62);
            this.label1.TabIndex = 16;
            this.label1.Text = "MACOs - 模拟输入软面板";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(19)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1196, 80);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 692);
            this.Controls.Add(this.splitContainer_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftFrontPanel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_chConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChannelsConfig)).EndInit();
            this.tabPage_timing.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_samples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            this.tabPage_Trigger.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mathEngine)).EndInit();
            this.splitContainer_Panel.Panel1.ResumeLayout(false);
            this.splitContainer_Panel.Panel1.PerformLayout();
            this.splitContainer_Panel.Panel2.ResumeLayout(false);
            this.splitContainer_Panel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Panel)).EndInit();
            this.splitContainer_Panel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer_bg.Panel1.ResumeLayout(false);
            this.splitContainer_bg.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_bg)).EndInit();
            this.splitContainer_bg.ResumeLayout(false);
            this.splitContainer_cfg.Panel1.ResumeLayout(false);
            this.splitContainer_cfg.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_cfg)).EndInit();
            this.splitContainer_cfg.ResumeLayout(false);
            this.splitContainer_ctrl.Panel1.ResumeLayout(false);
            this.splitContainer_ctrl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_ctrl)).EndInit();
            this.splitContainer_ctrl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_measure;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private SeeSharpTools.JY.GUI.EasyButton easyButton_start;
        private SeeSharpTools.JY.GUI.EasyButton easyButton_stop;
        private SeeSharpTools.JY.GUI.EasyButton easyButton_contStart;
        private SeeSharpTools.JY.GUI.EasyChart easyChart1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_chConfig;
        private System.Windows.Forms.TabPage tabPage_timing;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_samples;
        private System.Windows.Forms.NumericUpDown numericUpDown_sampleRate;
        private System.Windows.Forms.CheckBox checkBox_timeDisplay;
        private System.Windows.Forms.TabPage tabPage_Trigger;
        private System.Windows.Forms.DataGridView dgv_mathEngine;
        private System.Windows.Forms.SplitContainer splitContainer_Panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_instr;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_aiDevice;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_help;
        private System.Windows.Forms.ToolStripMenuItem v102ToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_attRatio;
        private System.Windows.Forms.PropertyGrid propertyGrid_trigProp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_graphs;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_time;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_freq;
        private System.Windows.Forms.DataGridView dgv_ChannelsConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer_ctrl;
        private System.Windows.Forms.SplitContainer splitContainer_bg;
        private System.Windows.Forms.SplitContainer splitContainer_cfg;
    }
}

