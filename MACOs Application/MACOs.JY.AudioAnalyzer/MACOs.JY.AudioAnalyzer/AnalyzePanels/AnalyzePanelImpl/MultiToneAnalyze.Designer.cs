namespace MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelImpl
{
    partial class MultiToneAnalyze
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
            this.label_sampleRate = new System.Windows.Forms.Label();
            this.comboBox_aoChannel = new System.Windows.Forms.ComboBox();
            this.numericUpDown_sampleRate = new System.Windows.Forms.NumericUpDown();
            this.label_aoChannel = new System.Windows.Forms.Label();
            this.comboBox_testChannel = new System.Windows.Forms.ComboBox();
            this.label_testChannel = new System.Windows.Forms.Label();
            this.groupBox_waveConfig = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_waveConfig = new System.Windows.Forms.TableLayoutPanel();
            this.label_waveform = new System.Windows.Forms.Label();
            this.groupBox_result = new System.Windows.Forms.GroupBox();
            this.label_analyzeResult = new System.Windows.Forms.Label();
            this.label_phase = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.easyChart_phase = new SeeSharpTools.JY.GUI.EasyChart();
            this.label_power = new System.Windows.Forms.Label();
            this.easyChart_power = new SeeSharpTools.JY.GUI.EasyChart();
            this.easyChart_waveform = new SeeSharpTools.JY.GUI.EasyChart();
            this.groupBox_channelSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            this.groupBox_waveConfig.SuspendLayout();
            this.groupBox_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_channelSelect
            // 
            this.groupBox_channelSelect.Controls.Add(this.label_sampleRate);
            this.groupBox_channelSelect.Controls.Add(this.comboBox_aoChannel);
            this.groupBox_channelSelect.Controls.Add(this.numericUpDown_sampleRate);
            this.groupBox_channelSelect.Controls.Add(this.label_aoChannel);
            this.groupBox_channelSelect.Controls.Add(this.comboBox_testChannel);
            this.groupBox_channelSelect.Controls.Add(this.label_testChannel);
            this.groupBox_channelSelect.Location = new System.Drawing.Point(661, 321);
            this.groupBox_channelSelect.Name = "groupBox_channelSelect";
            this.groupBox_channelSelect.Size = new System.Drawing.Size(579, 111);
            this.groupBox_channelSelect.TabIndex = 3;
            this.groupBox_channelSelect.TabStop = false;
            this.groupBox_channelSelect.Text = "Channel Select";
            // 
            // label_sampleRate
            // 
            this.label_sampleRate.AutoSize = true;
            this.label_sampleRate.Location = new System.Drawing.Point(309, 38);
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
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(433, 34);
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
            40000,
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
            this.comboBox_testChannel.Location = new System.Drawing.Point(160, 76);
            this.comboBox_testChannel.Name = "comboBox_testChannel";
            this.comboBox_testChannel.Size = new System.Drawing.Size(105, 20);
            this.comboBox_testChannel.TabIndex = 3;
            // 
            // label_testChannel
            // 
            this.label_testChannel.AutoSize = true;
            this.label_testChannel.Location = new System.Drawing.Point(47, 79);
            this.label_testChannel.Name = "label_testChannel";
            this.label_testChannel.Size = new System.Drawing.Size(77, 12);
            this.label_testChannel.TabIndex = 2;
            this.label_testChannel.Text = "Test Channel";
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
            // label_waveform
            // 
            this.label_waveform.AutoSize = true;
            this.label_waveform.Location = new System.Drawing.Point(63, 29);
            this.label_waveform.Name = "label_waveform";
            this.label_waveform.Size = new System.Drawing.Size(221, 12);
            this.label_waveform.TabIndex = 7;
            this.label_waveform.Text = "Reference Waveform And Test Waveform";
            // 
            // groupBox_result
            // 
            this.groupBox_result.Controls.Add(this.label_analyzeResult);
            this.groupBox_result.Controls.Add(this.label_phase);
            this.groupBox_result.Controls.Add(this.textBox_result);
            this.groupBox_result.Controls.Add(this.easyChart_phase);
            this.groupBox_result.Controls.Add(this.label_power);
            this.groupBox_result.Controls.Add(this.easyChart_power);
            this.groupBox_result.Location = new System.Drawing.Point(60, 321);
            this.groupBox_result.Name = "groupBox_result";
            this.groupBox_result.Size = new System.Drawing.Size(547, 302);
            this.groupBox_result.TabIndex = 10;
            this.groupBox_result.TabStop = false;
            this.groupBox_result.Text = "Test result";
            // 
            // label_analyzeResult
            // 
            this.label_analyzeResult.AutoSize = true;
            this.label_analyzeResult.Location = new System.Drawing.Point(430, 22);
            this.label_analyzeResult.Name = "label_analyzeResult";
            this.label_analyzeResult.Size = new System.Drawing.Size(89, 12);
            this.label_analyzeResult.TabIndex = 14;
            this.label_analyzeResult.Text = "Analyze Result";
            // 
            // label_phase
            // 
            this.label_phase.AutoSize = true;
            this.label_phase.Location = new System.Drawing.Point(176, 162);
            this.label_phase.Name = "label_phase";
            this.label_phase.Size = new System.Drawing.Size(89, 12);
            this.label_phase.TabIndex = 17;
            this.label_phase.Text = "Phase Spectrum";
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.Color.Silver;
            this.textBox_result.Enabled = false;
            this.textBox_result.ForeColor = System.Drawing.Color.Green;
            this.textBox_result.Location = new System.Drawing.Point(427, 38);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(108, 258);
            this.textBox_result.TabIndex = 13;
            // 
            // easyChart_phase
            // 
            this.easyChart_phase.AxisYMax = double.NaN;
            this.easyChart_phase.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_phase.ChartAreaBackColor = System.Drawing.Color.DimGray;
            this.easyChart_phase.EasyChartBackColor = System.Drawing.Color.DarkGray;
            this.easyChart_phase.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_phase.LegendVisible = false;
            this.easyChart_phase.Location = new System.Drawing.Point(9, 164);
            this.easyChart_phase.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart_phase.MajorGridEnabled = true;
            this.easyChart_phase.Margin = new System.Windows.Forms.Padding(2);
            this.easyChart_phase.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart_phase.MinorGridEnabled = false;
            this.easyChart_phase.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChart_phase.Name = "easyChart_phase";
            this.easyChart_phase.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart_phase.SeriesNames = new string[] {
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
            this.easyChart_phase.Size = new System.Drawing.Size(409, 133);
            this.easyChart_phase.TabIndex = 16;
            this.easyChart_phase.XAxisLogarithmic = false;
            this.easyChart_phase.YAutoEnable = true;
            this.easyChart_phase.YAxisLogarithmic = false;
            // 
            // label_power
            // 
            this.label_power.AutoSize = true;
            this.label_power.Location = new System.Drawing.Point(176, 27);
            this.label_power.Name = "label_power";
            this.label_power.Size = new System.Drawing.Size(89, 12);
            this.label_power.TabIndex = 15;
            this.label_power.Text = "Power Spectrum";
            // 
            // easyChart_power
            // 
            this.easyChart_power.AxisYMax = double.NaN;
            this.easyChart_power.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_power.ChartAreaBackColor = System.Drawing.Color.DimGray;
            this.easyChart_power.EasyChartBackColor = System.Drawing.Color.DarkGray;
            this.easyChart_power.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_power.LegendVisible = false;
            this.easyChart_power.Location = new System.Drawing.Point(9, 27);
            this.easyChart_power.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart_power.MajorGridEnabled = true;
            this.easyChart_power.Margin = new System.Windows.Forms.Padding(2);
            this.easyChart_power.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart_power.MinorGridEnabled = false;
            this.easyChart_power.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChart_power.Name = "easyChart_power";
            this.easyChart_power.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart_power.SeriesNames = new string[] {
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
            this.easyChart_power.Size = new System.Drawing.Size(409, 133);
            this.easyChart_power.TabIndex = 14;
            this.easyChart_power.XAxisLogarithmic = false;
            this.easyChart_power.YAutoEnable = true;
            this.easyChart_power.YAxisLogarithmic = false;
            // 
            // easyChart_waveform
            // 
            this.easyChart_waveform.AxisYMax = double.NaN;
            this.easyChart_waveform.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_waveform.ChartAreaBackColor = System.Drawing.Color.DimGray;
            this.easyChart_waveform.EasyChartBackColor = System.Drawing.Color.DarkGray;
            this.easyChart_waveform.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_waveform.LegendVisible = true;
            this.easyChart_waveform.Location = new System.Drawing.Point(65, 43);
            this.easyChart_waveform.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart_waveform.MajorGridEnabled = true;
            this.easyChart_waveform.Margin = new System.Windows.Forms.Padding(2);
            this.easyChart_waveform.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart_waveform.MinorGridEnabled = false;
            this.easyChart_waveform.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChart_waveform.Name = "easyChart_waveform";
            this.easyChart_waveform.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart_waveform.SeriesNames = new string[] {
        "Reference Waveform",
        "Test Waveform",
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
        "Series32",
        "Series32"};
            this.easyChart_waveform.Size = new System.Drawing.Size(1175, 259);
            this.easyChart_waveform.TabIndex = 11;
            this.easyChart_waveform.XAxisLogarithmic = false;
            this.easyChart_waveform.YAutoEnable = true;
            this.easyChart_waveform.YAxisLogarithmic = false;
            // 
            // MultiToneAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.easyChart_waveform);
            this.Controls.Add(this.groupBox_result);
            this.Controls.Add(this.label_waveform);
            this.Controls.Add(this.groupBox_waveConfig);
            this.Controls.Add(this.groupBox_channelSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "MultiToneAnalyze";
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
        private System.Windows.Forms.Label label_testChannel;
        private System.Windows.Forms.GroupBox groupBox_waveConfig;
        private System.Windows.Forms.Label label_waveform;
        private System.Windows.Forms.ComboBox comboBox_aoChannel;
        private System.Windows.Forms.Label label_aoChannel;
        private System.Windows.Forms.Label label_sampleRate;
        private System.Windows.Forms.NumericUpDown numericUpDown_sampleRate;
        private System.Windows.Forms.GroupBox groupBox_result;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_waveConfig;
        private SeeSharpTools.JY.GUI.EasyChart easyChart_waveform;
        private System.Windows.Forms.Label label_phase;
        private SeeSharpTools.JY.GUI.EasyChart easyChart_phase;
        private System.Windows.Forms.Label label_power;
        private SeeSharpTools.JY.GUI.EasyChart easyChart_power;
        private System.Windows.Forms.Label label_analyzeResult;
        private System.Windows.Forms.TextBox textBox_result;
    }
}