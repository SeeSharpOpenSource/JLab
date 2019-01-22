namespace MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelImpl
{
    partial class LogChripAnalyze
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
            this.groupBox_channelSelect = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_sampleRate = new System.Windows.Forms.Label();
            this.comboBox_aoChannel = new System.Windows.Forms.ComboBox();
            this.numericUpDown_sampleRate = new System.Windows.Forms.NumericUpDown();
            this.label_aoChannel = new System.Windows.Forms.Label();
            this.comboBox_testChannel = new System.Windows.Forms.ComboBox();
            this.groupBox_waveConfig = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_waveConfig = new System.Windows.Forms.TableLayoutPanel();
            this.label_Waveform = new System.Windows.Forms.Label();
            this.groupBox_result = new System.Windows.Forms.GroupBox();
            this.label_thd = new System.Windows.Forms.Label();
            this.label_response = new System.Windows.Forms.Label();
            this.easyChart_thd = new SeeSharpTools.JY.GUI.EasyChart();
            this.easyChart_response = new SeeSharpTools.JY.GUI.EasyChart();
            this.easyChart_testWaveform = new SeeSharpTools.JY.GUI.EasyChart();
            this.groupBox_channelSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            this.groupBox_waveConfig.SuspendLayout();
            this.groupBox_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_channelSelect
            // 
            this.groupBox_channelSelect.Controls.Add(this.label1);
            this.groupBox_channelSelect.Controls.Add(this.label_sampleRate);
            this.groupBox_channelSelect.Controls.Add(this.comboBox_aoChannel);
            this.groupBox_channelSelect.Controls.Add(this.numericUpDown_sampleRate);
            this.groupBox_channelSelect.Controls.Add(this.label_aoChannel);
            this.groupBox_channelSelect.Controls.Add(this.comboBox_testChannel);
            this.groupBox_channelSelect.Location = new System.Drawing.Point(661, 321);
            this.groupBox_channelSelect.Name = "groupBox_channelSelect";
            this.groupBox_channelSelect.Size = new System.Drawing.Size(579, 111);
            this.groupBox_channelSelect.TabIndex = 3;
            this.groupBox_channelSelect.TabStop = false;
            this.groupBox_channelSelect.Text = "Channel Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Test Channel";
            // 
            // label_sampleRate
            // 
            this.label_sampleRate.AutoSize = true;
            this.label_sampleRate.Location = new System.Drawing.Point(340, 36);
            this.label_sampleRate.Name = "label_sampleRate";
            this.label_sampleRate.Size = new System.Drawing.Size(65, 12);
            this.label_sampleRate.TabIndex = 11;
            this.label_sampleRate.Text = "SampleRate";
            // 
            // comboBox_aoChannel
            // 
            this.comboBox_aoChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_aoChannel.FormattingEnabled = true;
            this.comboBox_aoChannel.Location = new System.Drawing.Point(160, 33);
            this.comboBox_aoChannel.Name = "comboBox_aoChannel";
            this.comboBox_aoChannel.Size = new System.Drawing.Size(105, 20);
            this.comboBox_aoChannel.TabIndex = 5;
            // 
            // numericUpDown_sampleRate
            // 
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(438, 32);
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
            this.label_aoChannel.Location = new System.Drawing.Point(47, 36);
            this.label_aoChannel.Name = "label_aoChannel";
            this.label_aoChannel.Size = new System.Drawing.Size(89, 12);
            this.label_aoChannel.TabIndex = 4;
            this.label_aoChannel.Text = "Output Channel";
            // 
            // comboBox_testChannel
            // 
            this.comboBox_testChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_testChannel.FormattingEnabled = true;
            this.comboBox_testChannel.Location = new System.Drawing.Point(160, 71);
            this.comboBox_testChannel.Name = "comboBox_testChannel";
            this.comboBox_testChannel.Size = new System.Drawing.Size(105, 20);
            this.comboBox_testChannel.TabIndex = 3;
            // 
            // groupBox_waveConfig
            // 
            this.groupBox_waveConfig.Controls.Add(this.tableLayoutPanel_waveConfig);
            this.groupBox_waveConfig.Location = new System.Drawing.Point(661, 438);
            this.groupBox_waveConfig.Name = "groupBox_waveConfig";
            this.groupBox_waveConfig.Size = new System.Drawing.Size(579, 185);
            this.groupBox_waveConfig.TabIndex = 4;
            this.groupBox_waveConfig.TabStop = false;
            this.groupBox_waveConfig.Text = "Wave Configuration";
            // 
            // tableLayoutPanel_waveConfig
            // 
            this.tableLayoutPanel_waveConfig.ColumnCount = 1;
            this.tableLayoutPanel_waveConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_waveConfig.Location = new System.Drawing.Point(15, 40);
            this.tableLayoutPanel_waveConfig.Name = "tableLayoutPanel_waveConfig";
            this.tableLayoutPanel_waveConfig.RowCount = 1;
            this.tableLayoutPanel_waveConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_waveConfig.Size = new System.Drawing.Size(550, 120);
            this.tableLayoutPanel_waveConfig.TabIndex = 0;
            // 
            // label_Waveform
            // 
            this.label_Waveform.AutoSize = true;
            this.label_Waveform.Location = new System.Drawing.Point(63, 29);
            this.label_Waveform.Name = "label_Waveform";
            this.label_Waveform.Size = new System.Drawing.Size(83, 12);
            this.label_Waveform.TabIndex = 7;
            this.label_Waveform.Text = "Test Waveform";
            // 
            // groupBox_result
            // 
            this.groupBox_result.Controls.Add(this.label_thd);
            this.groupBox_result.Controls.Add(this.label_response);
            this.groupBox_result.Controls.Add(this.easyChart_thd);
            this.groupBox_result.Controls.Add(this.easyChart_response);
            this.groupBox_result.Location = new System.Drawing.Point(60, 321);
            this.groupBox_result.Name = "groupBox_result";
            this.groupBox_result.Size = new System.Drawing.Size(547, 302);
            this.groupBox_result.TabIndex = 10;
            this.groupBox_result.TabStop = false;
            this.groupBox_result.Text = "Test result";
            // 
            // label_thd
            // 
            this.label_thd.AutoSize = true;
            this.label_thd.Location = new System.Drawing.Point(268, 154);
            this.label_thd.Name = "label_thd";
            this.label_thd.Size = new System.Drawing.Size(23, 12);
            this.label_thd.TabIndex = 13;
            this.label_thd.Text = "THD";
            // 
            // label_response
            // 
            this.label_response.AutoSize = true;
            this.label_response.Location = new System.Drawing.Point(253, 17);
            this.label_response.Name = "label_response";
            this.label_response.Size = new System.Drawing.Size(53, 12);
            this.label_response.TabIndex = 12;
            this.label_response.Text = "Response";
            // 
            // easyChart_thd
            // 
            this.easyChart_thd.AxisYMax = double.NaN;
            this.easyChart_thd.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_thd.ChartAreaBackColor = System.Drawing.Color.DimGray;
            this.easyChart_thd.EasyChartBackColor = System.Drawing.Color.DarkGray;
            this.easyChart_thd.FixAxisX = false;
            this.easyChart_thd.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_thd.LegendVisible = false;
            this.easyChart_thd.Location = new System.Drawing.Point(26, 156);
            this.easyChart_thd.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart_thd.MajorGridEnabled = true;
            this.easyChart_thd.Margin = new System.Windows.Forms.Padding(2);
            this.easyChart_thd.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart_thd.MinorGridEnabled = false;
            this.easyChart_thd.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChart_thd.Name = "easyChart_thd";
            this.easyChart_thd.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart_thd.SeriesNames = new string[] {
        "Source Waveform",
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
            this.easyChart_thd.Size = new System.Drawing.Size(492, 133);
            this.easyChart_thd.TabIndex = 12;
            this.easyChart_thd.XAxisLogarithmic = false;
            this.easyChart_thd.YAutoEnable = true;
            this.easyChart_thd.YAxisLogarithmic = false;
            // 
            // easyChart_response
            // 
            this.easyChart_response.AxisYMax = double.NaN;
            this.easyChart_response.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_response.ChartAreaBackColor = System.Drawing.Color.DimGray;
            this.easyChart_response.EasyChartBackColor = System.Drawing.Color.DarkGray;
            this.easyChart_response.FixAxisX = false;
            this.easyChart_response.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_response.LegendVisible = false;
            this.easyChart_response.Location = new System.Drawing.Point(26, 19);
            this.easyChart_response.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart_response.MajorGridEnabled = true;
            this.easyChart_response.Margin = new System.Windows.Forms.Padding(2);
            this.easyChart_response.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart_response.MinorGridEnabled = false;
            this.easyChart_response.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChart_response.Name = "easyChart_response";
            this.easyChart_response.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart_response.SeriesNames = new string[] {
        "Source Waveform",
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
            this.easyChart_response.Size = new System.Drawing.Size(492, 133);
            this.easyChart_response.TabIndex = 11;
            this.easyChart_response.XAxisLogarithmic = false;
            this.easyChart_response.YAutoEnable = true;
            this.easyChart_response.YAxisLogarithmic = false;
            // 
            // easyChart_testWaveform
            // 
            this.easyChart_testWaveform.AxisYMax = double.NaN;
            this.easyChart_testWaveform.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_testWaveform.ChartAreaBackColor = System.Drawing.Color.DimGray;
            this.easyChart_testWaveform.EasyChartBackColor = System.Drawing.Color.DarkGray;
            this.easyChart_testWaveform.FixAxisX = false;
            this.easyChart_testWaveform.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_testWaveform.LegendVisible = false;
            this.easyChart_testWaveform.Location = new System.Drawing.Point(65, 43);
            this.easyChart_testWaveform.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart_testWaveform.MajorGridEnabled = true;
            this.easyChart_testWaveform.Margin = new System.Windows.Forms.Padding(2);
            this.easyChart_testWaveform.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart_testWaveform.MinorGridEnabled = false;
            this.easyChart_testWaveform.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChart_testWaveform.Name = "easyChart_testWaveform";
            this.easyChart_testWaveform.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart_testWaveform.SeriesNames = new string[] {
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
            this.easyChart_testWaveform.Size = new System.Drawing.Size(1175, 259);
            this.easyChart_testWaveform.TabIndex = 11;
            this.easyChart_testWaveform.XAxisLogarithmic = false;
            this.easyChart_testWaveform.YAutoEnable = true;
            this.easyChart_testWaveform.YAxisLogarithmic = false;
            // 
            // LogChripAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.easyChart_testWaveform);
            this.Controls.Add(this.groupBox_result);
            this.Controls.Add(this.label_Waveform);
            this.Controls.Add(this.groupBox_waveConfig);
            this.Controls.Add(this.groupBox_channelSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "LogChripAnalyze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SteppedSineWaveCrossTalkAnalyze";
            this.Load += new System.EventHandler(this.DualToneAnalyze_Load);
            this.groupBox_channelSelect.ResumeLayout(false);
            this.groupBox_channelSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            this.groupBox_waveConfig.ResumeLayout(false);
            this.groupBox_result.ResumeLayout(false);
            this.groupBox_result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_channelSelect;
        private System.Windows.Forms.ComboBox comboBox_testChannel;
        private System.Windows.Forms.GroupBox groupBox_waveConfig;
        private System.Windows.Forms.Label label_Waveform;
        private System.Windows.Forms.ComboBox comboBox_aoChannel;
        private System.Windows.Forms.Label label_aoChannel;
        private System.Windows.Forms.Label label_sampleRate;
        private System.Windows.Forms.NumericUpDown numericUpDown_sampleRate;
        private System.Windows.Forms.GroupBox groupBox_result;
        private SeeSharpTools.JY.GUI.EasyChart easyChart_response;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_waveConfig;
        private SeeSharpTools.JY.GUI.EasyChart easyChart_testWaveform;
        private SeeSharpTools.JY.GUI.EasyChart easyChart_thd;
        private System.Windows.Forms.Label label_response;
        private System.Windows.Forms.Label label_thd;
        private System.Windows.Forms.Label label1;
    }
}