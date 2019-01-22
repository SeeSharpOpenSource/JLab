namespace EasyDAQ61902AIAO_Demo
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
            this.easyChart1 = new SeeSharpTools.JY.GUI.EasyChart();
            this.buttonAI = new System.Windows.Forms.Button();
            this.buttonAO = new System.Windows.Forms.Button();
            this.easyDAQ61902AI1 = new EasyDAQ.EasyDAQ61902AI(this.components);
            this.easyDAQ61902AO1 = new EasyDAQ.EasyDAQ61902AO(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // easyChart1
            // 
            this.easyChart1.AxisX.AutoScale = true;
            this.easyChart1.AxisX.Maximum = 1001D;
            this.easyChart1.AxisX.Minimum = 0D;
            this.easyChart1.AxisX.Orientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChart1.AxisX.Position = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            this.easyChart1.AxisX.Title = "";
            this.easyChart1.AxisX.ViewMaximum = 1001D;
            this.easyChart1.AxisX.ViewMinimum = 0D;
            this.easyChart1.AxisY.AutoScale = true;
            this.easyChart1.AxisY.Maximum = 3.5D;
            this.easyChart1.AxisY.Minimum = 0D;
            this.easyChart1.AxisY.Orientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChart1.AxisY.Position = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            this.easyChart1.AxisY.Title = "";
            this.easyChart1.AxisY.ViewMaximum = 3.5D;
            this.easyChart1.AxisY.ViewMinimum = 0D;
            this.easyChart1.AxisYMax = 3.5D;
            this.easyChart1.AxisYMin = 0D;
            this.easyChart1.BackGradientStyle = null;
            this.easyChart1.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChart1.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChart1.GradientStyle = SeeSharpTools.JY.GUI.EasyChart.EasyChartGradientStyle.None;
            this.easyChart1.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart1.LegendVisible = true;
            this.easyChart1.Location = new System.Drawing.Point(26, 97);
            this.easyChart1.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart1.MajorGridEnabled = true;
            this.easyChart1.Margin = new System.Windows.Forms.Padding(2);
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
            this.easyChart1.Size = new System.Drawing.Size(588, 285);
            this.easyChart1.TabIndex = 0;
            this.easyChart1.XAxisLogarithmic = false;
            this.easyChart1.XAxisTitle = "";
            this.easyChart1.XTitleOrientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChart1.XTitlePosition = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            this.easyChart1.YAutoEnable = true;
            this.easyChart1.YAxisLogarithmic = false;
            this.easyChart1.YAxisTitle = "";
            this.easyChart1.YTitleOrientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChart1.YTitlePosition = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            // 
            // buttonAI
            // 
            this.buttonAI.Location = new System.Drawing.Point(35, 411);
            this.buttonAI.Name = "buttonAI";
            this.buttonAI.Size = new System.Drawing.Size(74, 29);
            this.buttonAI.TabIndex = 1;
            this.buttonAI.Text = "开始采集";
            this.buttonAI.UseVisualStyleBackColor = true;
            this.buttonAI.Click += new System.EventHandler(this.buttonAI_Click);
            // 
            // buttonAO
            // 
            this.buttonAO.Location = new System.Drawing.Point(415, 411);
            this.buttonAO.Name = "buttonAO";
            this.buttonAO.Size = new System.Drawing.Size(77, 28);
            this.buttonAO.TabIndex = 2;
            this.buttonAO.Text = "开始输出";
            this.buttonAO.UseVisualStyleBackColor = true;
            this.buttonAO.Click += new System.EventHandler(this.buttonAO_Click);
            // 
            // easyDAQ61902AI1
            // 
            this.easyDAQ61902AI1.BoardID = 0;
            this.easyDAQ61902AI1.Channels = ((System.Collections.Generic.List<int>)(resources.GetObject("easyDAQ61902AI1.Channels")));
            this.easyDAQ61902AI1.ContinuousRun = true;
            this.easyDAQ61902AI1.RangeHigh = 10D;
            this.easyDAQ61902AI1.RangeLow = -10D;
            this.easyDAQ61902AI1.SampleRate = 10000D;
            this.easyDAQ61902AI1.SamplesToRead = 1000;
            this.easyDAQ61902AI1.Terminal = "RSE";
            this.easyDAQ61902AI1.DataReceived += new System.EventHandler<System.EventArgs>(this.easyDAQ61902AI1_DataReceived);
            // 
            // easyDAQ61902AO1
            // 
            this.easyDAQ61902AO1.BoardID = 0;
            this.easyDAQ61902AO1.ChannelID = EasyDAQ.EasyDAQ61902AO.channelID.CH0;
            this.easyDAQ61902AO1.ContinuousRun = true;
            this.easyDAQ61902AO1.DutyCycle = 50D;
            this.easyDAQ61902AO1.HighRange = 10D;
            this.easyDAQ61902AO1.LowRange = -10D;
            this.easyDAQ61902AO1.Phase = 0D;
            this.easyDAQ61902AO1.SamplesToUpdate = 1000;
            this.easyDAQ61902AO1.SineWaveAmplitude = 1D;
            this.easyDAQ61902AO1.SineWaveFrequency = 100D;
            this.easyDAQ61902AO1.SquareWaveAmplitude = 1D;
            this.easyDAQ61902AO1.SquareWaveFrequency = 100D;
            this.easyDAQ61902AO1.UpdateRate = 10000D;
            this.easyDAQ61902AO1.WaveType = "SineWave";
            this.easyDAQ61902AO1.WhiteNoiseAmplitude = 1D;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label11.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(159, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 31);
            this.label11.TabIndex = 76;
            this.label11.Text = "EasyDAQ61902AI+AO";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(650, 80);
            this.splitter1.TabIndex = 75;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 470);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.buttonAO);
            this.Controls.Add(this.buttonAI);
            this.Controls.Add(this.easyChart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AI+AO Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SeeSharpTools.JY.GUI.EasyChart easyChart1;
        private System.Windows.Forms.Button buttonAI;
        private System.Windows.Forms.Button buttonAO;
        private EasyDAQ.EasyDAQ61902AI easyDAQ61902AI1;
        private EasyDAQ.EasyDAQ61902AO easyDAQ61902AO1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Splitter splitter1;
    }
}

