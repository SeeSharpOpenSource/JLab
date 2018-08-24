namespace FrequencyResponseFunctionDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.easyChartMagnitude = new SeeSharpTools.JY.GUI.EasyChart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.easyChartInput = new SeeSharpTools.JY.GUI.EasyChart();
            this.label11 = new System.Windows.Forms.Label();
            this.easyChartOutput = new SeeSharpTools.JY.GUI.EasyChart();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.easyChartTHD = new SeeSharpTools.JY.GUI.EasyChart();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSwitchSimulation = new SeeSharpTools.JY.GUI.ButtonSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSignal = new System.Windows.Forms.ComboBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.numericUpDownDelaySamples = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSamplingRate = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.numericUpDownTestTime = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxWaveType = new System.Windows.Forms.ComboBox();
            this.numericUpDownHighestHamonic = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfFrequencies = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownChirpFrequencyStop = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownChirpFrequencyStart = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelaySamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSamplingRate)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTestTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighestHamonic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfFrequencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChirpFrequencyStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChirpFrequencyStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(822, 80);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("SimSun", 23F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 31);
            this.label1.TabIndex = 76;
            this.label1.Text = "Speaker Test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(342, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Bode Magnitude";
            // 
            // easyChartMagnitude
            // 
            this.easyChartMagnitude.AxisYMax = double.NaN;
            this.easyChartMagnitude.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChartMagnitude.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChartMagnitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easyChartMagnitude.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChartMagnitude.FixAxisX = false;
            this.easyChartMagnitude.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartMagnitude.LegendVisible = false;
            this.easyChartMagnitude.Location = new System.Drawing.Point(3, 3);
            this.easyChartMagnitude.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartMagnitude.MajorGridEnabled = true;
            this.easyChartMagnitude.Margin = new System.Windows.Forms.Padding(2);
            this.easyChartMagnitude.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartMagnitude.MinorGridEnabled = false;
            this.easyChartMagnitude.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChartMagnitude.Name = "easyChartMagnitude";
            this.easyChartMagnitude.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChartMagnitude.SeriesNames = new string[] {
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
            this.easyChartMagnitude.Size = new System.Drawing.Size(802, 539);
            this.easyChartMagnitude.TabIndex = 0;
            this.easyChartMagnitude.XAxisLogarithmic = false;
            this.easyChartMagnitude.YAutoEnable = true;
            this.easyChartMagnitude.YAxisLogarithmic = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.02158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.97842F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 695);
            this.tableLayoutPanel1.TabIndex = 80;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 571);
            this.tabControl1.TabIndex = 78;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Getting Started";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(409, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 333);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 365);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 172);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Time Domain";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.easyChartInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.easyChartOutput);
            this.splitContainer1.Size = new System.Drawing.Size(802, 539);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(332, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "InputWaveform";
            // 
            // easyChartInput
            // 
            this.easyChartInput.AxisYMax = double.NaN;
            this.easyChartInput.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChartInput.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChartInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easyChartInput.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChartInput.FixAxisX = false;
            this.easyChartInput.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartInput.LegendVisible = false;
            this.easyChartInput.Location = new System.Drawing.Point(0, 0);
            this.easyChartInput.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartInput.MajorGridEnabled = true;
            this.easyChartInput.Margin = new System.Windows.Forms.Padding(2);
            this.easyChartInput.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartInput.MinorGridEnabled = false;
            this.easyChartInput.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChartInput.Name = "easyChartInput";
            this.easyChartInput.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChartInput.SeriesNames = new string[] {
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
            this.easyChartInput.Size = new System.Drawing.Size(802, 287);
            this.easyChartInput.TabIndex = 0;
            this.easyChartInput.XAxisLogarithmic = false;
            this.easyChartInput.YAutoEnable = false;
            this.easyChartInput.YAxisLogarithmic = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(332, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "OutputWaveform";
            // 
            // easyChartOutput
            // 
            this.easyChartOutput.AxisYMax = double.NaN;
            this.easyChartOutput.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChartOutput.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChartOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easyChartOutput.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChartOutput.FixAxisX = false;
            this.easyChartOutput.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartOutput.LegendVisible = false;
            this.easyChartOutput.Location = new System.Drawing.Point(0, 0);
            this.easyChartOutput.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartOutput.MajorGridEnabled = true;
            this.easyChartOutput.Margin = new System.Windows.Forms.Padding(2);
            this.easyChartOutput.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartOutput.MinorGridEnabled = false;
            this.easyChartOutput.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChartOutput.Name = "easyChartOutput";
            this.easyChartOutput.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChartOutput.SeriesNames = new string[] {
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
            this.easyChartOutput.Size = new System.Drawing.Size(802, 248);
            this.easyChartOutput.TabIndex = 1;
            this.easyChartOutput.XAxisLogarithmic = false;
            this.easyChartOutput.YAutoEnable = true;
            this.easyChartOutput.YAxisLogarithmic = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.easyChartMagnitude);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(808, 545);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Frequency Response";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.easyChartTHD);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(808, 545);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Harmonic Distortion";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(353, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "THD (dB)";
            // 
            // easyChartTHD
            // 
            this.easyChartTHD.AxisYMax = double.NaN;
            this.easyChartTHD.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChartTHD.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChartTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easyChartTHD.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChartTHD.FixAxisX = false;
            this.easyChartTHD.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartTHD.LegendVisible = false;
            this.easyChartTHD.Location = new System.Drawing.Point(3, 3);
            this.easyChartTHD.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartTHD.MajorGridEnabled = true;
            this.easyChartTHD.Margin = new System.Windows.Forms.Padding(2);
            this.easyChartTHD.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartTHD.MinorGridEnabled = false;
            this.easyChartTHD.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChartTHD.Name = "easyChartTHD";
            this.easyChartTHD.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChartTHD.SeriesNames = new string[] {
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
            this.easyChartTHD.Size = new System.Drawing.Size(802, 539);
            this.easyChartTHD.TabIndex = 0;
            this.easyChartTHD.XAxisLogarithmic = false;
            this.easyChartTHD.YAutoEnable = true;
            this.easyChartTHD.YAxisLogarithmic = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 580);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(816, 112);
            this.tabControl2.TabIndex = 79;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.buttonSwitchSimulation);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.comboBoxSignal);
            this.tabPage3.Controls.Add(this.buttonRun);
            this.tabPage3.Controls.Add(this.numericUpDownDelaySamples);
            this.tabPage3.Controls.Add(this.numericUpDownSamplingRate);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(808, 86);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "DAQ Configuration";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Simulation";
            // 
            // buttonSwitchSimulation
            // 
            this.buttonSwitchSimulation.Location = new System.Drawing.Point(545, 49);
            this.buttonSwitchSimulation.Name = "buttonSwitchSimulation";
            this.buttonSwitchSimulation.OffFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSwitchSimulation.OnFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSwitchSimulation.Size = new System.Drawing.Size(50, 19);
            this.buttonSwitchSimulation.Style = SeeSharpTools.JY.GUI.ButtonSwitch.ButtonSwitchStyle.IOS5;
            this.buttonSwitchSimulation.TabIndex = 7;
            this.buttonSwitchSimulation.Value = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Signal";
            // 
            // comboBoxSignal
            // 
            this.comboBoxSignal.FormattingEnabled = true;
            this.comboBoxSignal.Items.AddRange(new object[] {
            "WhiteNoise",
            "Chirp"});
            this.comboBoxSignal.Location = new System.Drawing.Point(523, 13);
            this.comboBoxSignal.Name = "comboBoxSignal";
            this.comboBoxSignal.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSignal.TabIndex = 5;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(692, 25);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(74, 36);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // numericUpDownDelaySamples
            // 
            this.numericUpDownDelaySamples.Location = new System.Drawing.Point(210, 47);
            this.numericUpDownDelaySamples.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownDelaySamples.Name = "numericUpDownDelaySamples";
            this.numericUpDownDelaySamples.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownDelaySamples.TabIndex = 3;
            // 
            // numericUpDownSamplingRate
            // 
            this.numericUpDownSamplingRate.Location = new System.Drawing.Point(210, 11);
            this.numericUpDownSamplingRate.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numericUpDownSamplingRate.Name = "numericUpDownSamplingRate";
            this.numericUpDownSamplingRate.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownSamplingRate.TabIndex = 2;
            this.numericUpDownSamplingRate.Value = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Propagation Delay [Samples]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "SamplingRate";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.numericUpDownTestTime);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.comboBoxWaveType);
            this.tabPage4.Controls.Add(this.numericUpDownHighestHamonic);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.numericUpDownNumberOfFrequencies);
            this.tabPage4.Controls.Add(this.numericUpDownChirpFrequencyStop);
            this.tabPage4.Controls.Add(this.numericUpDownChirpFrequencyStart);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(808, 86);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Chirp Configuration";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTestTime
            // 
            this.numericUpDownTestTime.Location = new System.Drawing.Point(597, 49);
            this.numericUpDownTestTime.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownTestTime.Name = "numericUpDownTestTime";
            this.numericUpDownTestTime.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownTestTime.TabIndex = 15;
            this.numericUpDownTestTime.ThousandsSeparator = true;
            this.numericUpDownTestTime.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(521, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 14;
            this.label15.Text = "Test Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(521, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "Wave Type";
            // 
            // comboBoxWaveType
            // 
            this.comboBoxWaveType.FormattingEnabled = true;
            this.comboBoxWaveType.Items.AddRange(new object[] {
            "Sine",
            "Square",
            "Saw"});
            this.comboBoxWaveType.Location = new System.Drawing.Point(597, 17);
            this.comboBoxWaveType.Name = "comboBoxWaveType";
            this.comboBoxWaveType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxWaveType.TabIndex = 12;
            // 
            // numericUpDownHighestHamonic
            // 
            this.numericUpDownHighestHamonic.Location = new System.Drawing.Point(375, 49);
            this.numericUpDownHighestHamonic.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownHighestHamonic.Name = "numericUpDownHighestHamonic";
            this.numericUpDownHighestHamonic.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownHighestHamonic.TabIndex = 11;
            this.numericUpDownHighestHamonic.ThousandsSeparator = true;
            this.numericUpDownHighestHamonic.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "Highest Harmonic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Number of Frequencies";
            // 
            // numericUpDownNumberOfFrequencies
            // 
            this.numericUpDownNumberOfFrequencies.Location = new System.Drawing.Point(375, 17);
            this.numericUpDownNumberOfFrequencies.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownNumberOfFrequencies.Name = "numericUpDownNumberOfFrequencies";
            this.numericUpDownNumberOfFrequencies.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownNumberOfFrequencies.TabIndex = 8;
            this.numericUpDownNumberOfFrequencies.ThousandsSeparator = true;
            this.numericUpDownNumberOfFrequencies.Value = new decimal(new int[] {
            121,
            0,
            0,
            0});
            // 
            // numericUpDownChirpFrequencyStop
            // 
            this.numericUpDownChirpFrequencyStop.Location = new System.Drawing.Point(112, 49);
            this.numericUpDownChirpFrequencyStop.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownChirpFrequencyStop.Name = "numericUpDownChirpFrequencyStop";
            this.numericUpDownChirpFrequencyStop.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownChirpFrequencyStop.TabIndex = 7;
            this.numericUpDownChirpFrequencyStop.ThousandsSeparator = true;
            this.numericUpDownChirpFrequencyStop.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // numericUpDownChirpFrequencyStart
            // 
            this.numericUpDownChirpFrequencyStart.Location = new System.Drawing.Point(112, 17);
            this.numericUpDownChirpFrequencyStart.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownChirpFrequencyStart.Name = "numericUpDownChirpFrequencyStart";
            this.numericUpDownChirpFrequencyStart.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownChirpFrequencyStart.TabIndex = 6;
            this.numericUpDownChirpFrequencyStart.ThousandsSeparator = true;
            this.numericUpDownChirpFrequencyStart.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 5;
            this.label14.Text = "Stop Frequency";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 12);
            this.label13.TabIndex = 4;
            this.label13.Text = "Start Frequency";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(375, 353);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 775);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Speaker Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelaySamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSamplingRate)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTestTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighestHamonic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfFrequencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChirpFrequencyStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChirpFrequencyStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SeeSharpTools.JY.GUI.EasyChart easyChartMagnitude;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private SeeSharpTools.JY.GUI.ButtonSwitch buttonSwitchSimulation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSignal;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.NumericUpDown numericUpDownDelaySamples;
        private System.Windows.Forms.NumericUpDown numericUpDownSamplingRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NumericUpDown numericUpDownChirpFrequencyStop;
        private System.Windows.Forms.NumericUpDown numericUpDownChirpFrequencyStart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label10;
        private SeeSharpTools.JY.GUI.EasyChart easyChartInput;
        private System.Windows.Forms.Label label11;
        private SeeSharpTools.JY.GUI.EasyChart easyChartOutput;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label12;
        private SeeSharpTools.JY.GUI.EasyChart easyChartTHD;
        private System.Windows.Forms.NumericUpDown numericUpDownHighestHamonic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfFrequencies;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxWaveType;
        private System.Windows.Forms.NumericUpDown numericUpDownTestTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

