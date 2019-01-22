namespace MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelImpl
{
    partial class SteppedSineWaveCrossTalkAnalyze
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.easyChart_data = new SeeSharpTools.JY.GUI.EasyChart();
            this.groupBox_channelSelect = new System.Windows.Forms.GroupBox();
            this.label_sampleRate = new System.Windows.Forms.Label();
            this.comboBox_aoChannel = new System.Windows.Forms.ComboBox();
            this.numericUpDown_sampleRate = new System.Windows.Forms.NumericUpDown();
            this.label_aoChannel = new System.Windows.Forms.Label();
            this.comboBox_testChannel = new System.Windows.Forms.ComboBox();
            this.label_testChannel = new System.Windows.Forms.Label();
            this.comboBox_refChannel = new System.Windows.Forms.ComboBox();
            this.label_refChannel = new System.Windows.Forms.Label();
            this.textBox_pathDelay = new System.Windows.Forms.TextBox();
            this.label_pathDelay = new System.Windows.Forms.Label();
            this.label_Waveform = new System.Windows.Forms.Label();
            this.label_crossTalk = new System.Windows.Forms.Label();
            this.easyChart_corssTalk = new SeeSharpTools.JY.GUI.EasyChart();
            this.tableLayoutPanel_waveConfig = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_channelSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            this.SuspendLayout();
            // 
            // easyChart_data
            // 
            this.easyChart_data.AxisYMax = double.NaN;
            this.easyChart_data.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_data.ChartAreaBackColor = System.Drawing.Color.DimGray;
            this.easyChart_data.EasyChartBackColor = System.Drawing.Color.DarkGray;
            this.easyChart_data.FixAxisX = false;
            this.easyChart_data.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_data.LegendVisible = true;
            this.easyChart_data.Location = new System.Drawing.Point(60, 47);
            this.easyChart_data.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart_data.MajorGridEnabled = true;
            this.easyChart_data.Margin = new System.Windows.Forms.Padding(2);
            this.easyChart_data.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart_data.MinorGridEnabled = false;
            this.easyChart_data.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChart_data.Name = "easyChart_data";
            this.easyChart_data.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart_data.SeriesNames = new string[] {
        "Ref Waveform",
        "Test Waveform",
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
            this.easyChart_data.Size = new System.Drawing.Size(1180, 250);
            this.easyChart_data.TabIndex = 0;
            this.easyChart_data.XAxisLogarithmic = false;
            this.easyChart_data.YAutoEnable = true;
            this.easyChart_data.YAxisLogarithmic = false;
            // 
            // groupBox_channelSelect
            // 
            this.groupBox_channelSelect.Controls.Add(this.label_sampleRate);
            this.groupBox_channelSelect.Controls.Add(this.comboBox_aoChannel);
            this.groupBox_channelSelect.Controls.Add(this.numericUpDown_sampleRate);
            this.groupBox_channelSelect.Controls.Add(this.label_aoChannel);
            this.groupBox_channelSelect.Controls.Add(this.comboBox_testChannel);
            this.groupBox_channelSelect.Controls.Add(this.label_testChannel);
            this.groupBox_channelSelect.Controls.Add(this.comboBox_refChannel);
            this.groupBox_channelSelect.Controls.Add(this.label_refChannel);
            this.groupBox_channelSelect.Location = new System.Drawing.Point(661, 365);
            this.groupBox_channelSelect.Name = "groupBox_channelSelect";
            this.groupBox_channelSelect.Size = new System.Drawing.Size(579, 111);
            this.groupBox_channelSelect.TabIndex = 3;
            this.groupBox_channelSelect.TabStop = false;
            this.groupBox_channelSelect.Text = "Channel Select";
            // 
            // label_sampleRate
            // 
            this.label_sampleRate.AutoSize = true;
            this.label_sampleRate.Location = new System.Drawing.Point(298, 76);
            this.label_sampleRate.Name = "label_sampleRate";
            this.label_sampleRate.Size = new System.Drawing.Size(65, 12);
            this.label_sampleRate.TabIndex = 11;
            this.label_sampleRate.Text = "SampleRate";
            // 
            // comboBox_aoChannel
            // 
            this.comboBox_aoChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_aoChannel.FormattingEnabled = true;
            this.comboBox_aoChannel.Location = new System.Drawing.Point(133, 33);
            this.comboBox_aoChannel.Name = "comboBox_aoChannel";
            this.comboBox_aoChannel.Size = new System.Drawing.Size(105, 20);
            this.comboBox_aoChannel.TabIndex = 5;
            // 
            // numericUpDown_sampleRate
            // 
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(416, 70);
            this.numericUpDown_sampleRate.Maximum = new decimal(new int[] {
            400000,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Name = "numericUpDown_sampleRate";
            this.numericUpDown_sampleRate.Size = new System.Drawing.Size(105, 21);
            this.numericUpDown_sampleRate.TabIndex = 10;
            this.numericUpDown_sampleRate.Value = new decimal(new int[] {
            400000,
            0,
            0,
            0});
            // 
            // label_aoChannel
            // 
            this.label_aoChannel.AutoSize = true;
            this.label_aoChannel.Location = new System.Drawing.Point(20, 36);
            this.label_aoChannel.Name = "label_aoChannel";
            this.label_aoChannel.Size = new System.Drawing.Size(89, 12);
            this.label_aoChannel.TabIndex = 4;
            this.label_aoChannel.Text = "Output Channel";
            // 
            // comboBox_testChannel
            // 
            this.comboBox_testChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_testChannel.FormattingEnabled = true;
            this.comboBox_testChannel.Location = new System.Drawing.Point(416, 33);
            this.comboBox_testChannel.Name = "comboBox_testChannel";
            this.comboBox_testChannel.Size = new System.Drawing.Size(105, 20);
            this.comboBox_testChannel.TabIndex = 3;
            // 
            // label_testChannel
            // 
            this.label_testChannel.AutoSize = true;
            this.label_testChannel.Location = new System.Drawing.Point(297, 36);
            this.label_testChannel.Name = "label_testChannel";
            this.label_testChannel.Size = new System.Drawing.Size(77, 12);
            this.label_testChannel.TabIndex = 2;
            this.label_testChannel.Text = "Test Channel";
            // 
            // comboBox_refChannel
            // 
            this.comboBox_refChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_refChannel.FormattingEnabled = true;
            this.comboBox_refChannel.Location = new System.Drawing.Point(133, 71);
            this.comboBox_refChannel.Name = "comboBox_refChannel";
            this.comboBox_refChannel.Size = new System.Drawing.Size(105, 20);
            this.comboBox_refChannel.TabIndex = 1;
            // 
            // label_refChannel
            // 
            this.label_refChannel.AutoSize = true;
            this.label_refChannel.Location = new System.Drawing.Point(20, 74);
            this.label_refChannel.Name = "label_refChannel";
            this.label_refChannel.Size = new System.Drawing.Size(107, 12);
            this.label_refChannel.TabIndex = 0;
            this.label_refChannel.Text = "Reference Channel";
            // 
            // textBox_pathDelay
            // 
            this.textBox_pathDelay.Enabled = false;
            this.textBox_pathDelay.Location = new System.Drawing.Point(340, 326);
            this.textBox_pathDelay.Name = "textBox_pathDelay";
            this.textBox_pathDelay.Size = new System.Drawing.Size(100, 21);
            this.textBox_pathDelay.TabIndex = 5;
            // 
            // label_pathDelay
            // 
            this.label_pathDelay.AutoSize = true;
            this.label_pathDelay.Location = new System.Drawing.Point(245, 329);
            this.label_pathDelay.Name = "label_pathDelay";
            this.label_pathDelay.Size = new System.Drawing.Size(89, 12);
            this.label_pathDelay.TabIndex = 6;
            this.label_pathDelay.Text = "Path Delay(ms)";
            // 
            // label_Waveform
            // 
            this.label_Waveform.AutoSize = true;
            this.label_Waveform.Location = new System.Drawing.Point(63, 29);
            this.label_Waveform.Name = "label_Waveform";
            this.label_Waveform.Size = new System.Drawing.Size(221, 12);
            this.label_Waveform.TabIndex = 7;
            this.label_Waveform.Text = "Reference Waveform And Test Waveform";
            // 
            // label_crossTalk
            // 
            this.label_crossTalk.AutoSize = true;
            this.label_crossTalk.Location = new System.Drawing.Point(63, 347);
            this.label_crossTalk.Name = "label_crossTalk";
            this.label_crossTalk.Size = new System.Drawing.Size(65, 12);
            this.label_crossTalk.TabIndex = 9;
            this.label_crossTalk.Text = "Cross Talk";
            // 
            // easyChart_corssTalk
            // 
            this.easyChart_corssTalk.AxisYMax = double.NaN;
            this.easyChart_corssTalk.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_corssTalk.ChartAreaBackColor = System.Drawing.Color.DimGray;
            this.easyChart_corssTalk.EasyChartBackColor = System.Drawing.Color.DarkGray;
            this.easyChart_corssTalk.FixAxisX = false;
            this.easyChart_corssTalk.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_corssTalk.LegendVisible = false;
            this.easyChart_corssTalk.Location = new System.Drawing.Point(60, 365);
            this.easyChart_corssTalk.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart_corssTalk.MajorGridEnabled = true;
            this.easyChart_corssTalk.Margin = new System.Windows.Forms.Padding(2);
            this.easyChart_corssTalk.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart_corssTalk.MinorGridEnabled = false;
            this.easyChart_corssTalk.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChart_corssTalk.Name = "easyChart_corssTalk";
            this.easyChart_corssTalk.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart_corssTalk.SeriesNames = new string[] {
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
            this.easyChart_corssTalk.Size = new System.Drawing.Size(550, 250);
            this.easyChart_corssTalk.TabIndex = 2;
            this.easyChart_corssTalk.XAxisLogarithmic = false;
            this.easyChart_corssTalk.YAutoEnable = true;
            this.easyChart_corssTalk.YAxisLogarithmic = false;
            // 
            // tableLayoutPanel_waveConfig
            // 
            this.tableLayoutPanel_waveConfig.ColumnCount = 1;
            this.tableLayoutPanel_waveConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_waveConfig.Location = new System.Drawing.Point(661, 495);
            this.tableLayoutPanel_waveConfig.Name = "tableLayoutPanel_waveConfig";
            this.tableLayoutPanel_waveConfig.RowCount = 1;
            this.tableLayoutPanel_waveConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_waveConfig.Size = new System.Drawing.Size(579, 120);
            this.tableLayoutPanel_waveConfig.TabIndex = 10;
            // 
            // SteppedSineWaveCrossTalkAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.tableLayoutPanel_waveConfig);
            this.Controls.Add(this.label_crossTalk);
            this.Controls.Add(this.label_Waveform);
            this.Controls.Add(this.label_pathDelay);
            this.Controls.Add(this.textBox_pathDelay);
            this.Controls.Add(this.groupBox_channelSelect);
            this.Controls.Add(this.easyChart_corssTalk);
            this.Controls.Add(this.easyChart_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "SteppedSineWaveCrossTalkAnalyze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SteppedSineWaveCrossTalkAnalyze";
            this.Load += new System.EventHandler(this.SteppedSineWaveCrossTalkAnalyze_Load);
            this.groupBox_channelSelect.ResumeLayout(false);
            this.groupBox_channelSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeeSharpTools.JY.GUI.EasyChart easyChart_data;
        private System.Windows.Forms.GroupBox groupBox_channelSelect;
        private System.Windows.Forms.Label label_refChannel;
        private System.Windows.Forms.ComboBox comboBox_refChannel;
        private System.Windows.Forms.ComboBox comboBox_testChannel;
        private System.Windows.Forms.Label label_testChannel;
        private System.Windows.Forms.TextBox textBox_pathDelay;
        private System.Windows.Forms.Label label_pathDelay;
        private System.Windows.Forms.Label label_Waveform;
        private System.Windows.Forms.ComboBox comboBox_aoChannel;
        private System.Windows.Forms.Label label_aoChannel;
        private System.Windows.Forms.Label label_sampleRate;
        private System.Windows.Forms.NumericUpDown numericUpDown_sampleRate;
        private System.Windows.Forms.Label label_crossTalk;
        private SeeSharpTools.JY.GUI.EasyChart easyChart_corssTalk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_waveConfig;
    }
}