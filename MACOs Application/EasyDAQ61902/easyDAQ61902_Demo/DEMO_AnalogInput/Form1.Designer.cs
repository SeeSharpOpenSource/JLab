namespace DEMO
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
            this.easyButton_start = new SeeSharpTools.JY.GUI.EasyButton();
            this.easyButton_stop = new SeeSharpTools.JY.GUI.EasyButton();
            this.industrySwitch1 = new SeeSharpTools.JY.GUI.IndustrySwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.easyDAQ61902AI1 = new EasyDAQ.EasyDAQ61902AI(this.components);
            this.SuspendLayout();
            // 
            // easyChart1
            // 
            this.easyChart1.AxisYMax = double.NaN;
            this.easyChart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart1.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChart1.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChart1.FixAxisX = false;
            this.easyChart1.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart1.LegendVisible = true;
            this.easyChart1.Location = new System.Drawing.Point(11, 11);
            this.easyChart1.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart1.MajorGridEnabled = true;
            this.easyChart1.Margin = new System.Windows.Forms.Padding(1);
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
            this.easyChart1.Size = new System.Drawing.Size(482, 395);
            this.easyChart1.TabIndex = 0;
            this.easyChart1.XAxisLogarithmic = false;
            this.easyChart1.YAutoEnable = true;
            this.easyChart1.YAxisLogarithmic = false;
            // 
            // easyButton_start
            // 
            this.easyButton_start.Image = ((System.Drawing.Image)(resources.GetObject("easyButton_start.Image")));
            this.easyButton_start.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.easyButton_start.Location = new System.Drawing.Point(59, 498);
            this.easyButton_start.Name = "easyButton_start";
            this.easyButton_start.PreSetImage = SeeSharpTools.JY.GUI.EasyButton.ButtonPresetImage.Go;
            this.easyButton_start.Size = new System.Drawing.Size(88, 47);
            this.easyButton_start.TabIndex = 3;
            this.easyButton_start.Text = "Start";
            this.easyButton_start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.easyButton_start.Click += new System.EventHandler(this.easyButton_start_Click);
            // 
            // easyButton_stop
            // 
            this.easyButton_stop.Image = ((System.Drawing.Image)(resources.GetObject("easyButton_stop.Image")));
            this.easyButton_stop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.easyButton_stop.Location = new System.Drawing.Point(358, 498);
            this.easyButton_stop.Name = "easyButton_stop";
            this.easyButton_stop.PreSetImage = SeeSharpTools.JY.GUI.EasyButton.ButtonPresetImage.Close;
            this.easyButton_stop.Size = new System.Drawing.Size(88, 47);
            this.easyButton_stop.TabIndex = 3;
            this.easyButton_stop.Text = "Stop";
            this.easyButton_stop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.easyButton_stop.Click += new System.EventHandler(this.easyButton_stop_Click);
            // 
            // industrySwitch1
            // 
            this.industrySwitch1.BackColor = System.Drawing.Color.Transparent;
            this.industrySwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.industrySwitch1.Interacton = SeeSharpTools.JY.GUI.IndustrySwitch.InteractionStyle.SwitchWhenPressed;
            this.industrySwitch1.Location = new System.Drawing.Point(59, 427);
            this.industrySwitch1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.industrySwitch1.Name = "industrySwitch1";
            this.industrySwitch1.OffColor = System.Drawing.Color.Silver;
            this.industrySwitch1.OnColor = System.Drawing.Color.Silver;
            this.industrySwitch1.Size = new System.Drawing.Size(150, 30);
            this.industrySwitch1.Style = SeeSharpTools.JY.GUI.IndustrySwitch.SwitchStyles.HorizontalSlider;
            this.industrySwitch1.TabIndex = 4;
            this.industrySwitch1.Value = false;
            this.industrySwitch1.ValueChanged += new System.EventHandler(this.industrySwitch1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Continuous";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Finite";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(353, 427);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 30);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Available Samples";
            // 
            // easyDAQ61902AI1
            // 
            this.easyDAQ61902AI1.BoardID = 0;
            this.easyDAQ61902AI1.Channels = ((System.Collections.Generic.List<int>)(resources.GetObject("easyDAQ61902AI1.Channels")));
            this.easyDAQ61902AI1.RangeHigh = 10D;
            this.easyDAQ61902AI1.RangeLow = -10D;
            this.easyDAQ61902AI1.SampleRate = 10000D;
            this.easyDAQ61902AI1.SamplesToRead = 1000;
            this.easyDAQ61902AI1.Terminal = "RSE";
            this.easyDAQ61902AI1.DataReceived += new System.EventHandler<System.EventArgs>(this.easyDAQ61902AI1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 575);
            this.Controls.Add(this.easyButton_start);
            this.Controls.Add(this.easyButton_stop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.industrySwitch1);
            this.Controls.Add(this.easyChart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalogInput DEMO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeeSharpTools.JY.GUI.EasyChart easyChart1;
        private SeeSharpTools.JY.GUI.EasyButton easyButton_start;
        private SeeSharpTools.JY.GUI.EasyButton easyButton_stop;
        private SeeSharpTools.JY.GUI.IndustrySwitch industrySwitch1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private EasyDAQ.EasyDAQ61902AI easyDAQ61902AI1;
    }
}

