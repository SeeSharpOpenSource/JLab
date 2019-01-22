namespace MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelImpl
{
    partial class SingleToneAnalyze
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
            this.groupBox_waveConfig = new System.Windows.Forms.GroupBox();
            this.label_amplitude = new System.Windows.Forms.Label();
            this.numericUpDown_amplitude = new System.Windows.Forms.NumericUpDown();
            this.label_harmonicOrder = new System.Windows.Forms.Label();
            this.numericUpDown_harmonicOrder = new System.Windows.Forms.NumericUpDown();
            this.label_Duration = new System.Windows.Forms.Label();
            this.label_targetFreq = new System.Windows.Forms.Label();
            this.numericUpDown_Duration = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_targetFreq = new System.Windows.Forms.NumericUpDown();
            this.label_Waveform = new System.Windows.Forms.Label();
            this.label_specturm = new System.Windows.Forms.Label();
            this.groupBox_result = new System.Windows.Forms.GroupBox();
            this.label_analyzeResult = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label_spectrum = new System.Windows.Forms.Label();
            this.easyChart_spectrum = new SeeSharpTools.JY.GUI.EasyChart();
            this.groupBox_channelSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            this.groupBox_waveConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_harmonicOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_targetFreq)).BeginInit();
            this.groupBox_result.SuspendLayout();
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
            this.easyChart_data.LegendVisible = false;
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
        "Read Waveform",
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
            this.groupBox_waveConfig.Controls.Add(this.label_amplitude);
            this.groupBox_waveConfig.Controls.Add(this.numericUpDown_amplitude);
            this.groupBox_waveConfig.Controls.Add(this.label_harmonicOrder);
            this.groupBox_waveConfig.Controls.Add(this.numericUpDown_harmonicOrder);
            this.groupBox_waveConfig.Controls.Add(this.label_Duration);
            this.groupBox_waveConfig.Controls.Add(this.label_targetFreq);
            this.groupBox_waveConfig.Controls.Add(this.numericUpDown_Duration);
            this.groupBox_waveConfig.Controls.Add(this.numericUpDown_targetFreq);
            this.groupBox_waveConfig.Location = new System.Drawing.Point(661, 482);
            this.groupBox_waveConfig.Name = "groupBox_waveConfig";
            this.groupBox_waveConfig.Size = new System.Drawing.Size(579, 133);
            this.groupBox_waveConfig.TabIndex = 4;
            this.groupBox_waveConfig.TabStop = false;
            this.groupBox_waveConfig.Text = "Wave Configuration";
            // 
            // label_amplitude
            // 
            this.label_amplitude.AutoSize = true;
            this.label_amplitude.Location = new System.Drawing.Point(319, 91);
            this.label_amplitude.Name = "label_amplitude";
            this.label_amplitude.Size = new System.Drawing.Size(77, 12);
            this.label_amplitude.TabIndex = 7;
            this.label_amplitude.Text = "Amplitude(V)";
            // 
            // numericUpDown_amplitude
            // 
            this.numericUpDown_amplitude.DecimalPlaces = 1;
            this.numericUpDown_amplitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_amplitude.Location = new System.Drawing.Point(438, 87);
            this.numericUpDown_amplitude.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_amplitude.Minimum = new decimal(new int[] {
            316,
            0,
            0,
            196608});
            this.numericUpDown_amplitude.Name = "numericUpDown_amplitude";
            this.numericUpDown_amplitude.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_amplitude.TabIndex = 6;
            this.numericUpDown_amplitude.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label_harmonicOrder
            // 
            this.label_harmonicOrder.AutoSize = true;
            this.label_harmonicOrder.Location = new System.Drawing.Point(47, 91);
            this.label_harmonicOrder.Name = "label_harmonicOrder";
            this.label_harmonicOrder.Size = new System.Drawing.Size(89, 12);
            this.label_harmonicOrder.TabIndex = 5;
            this.label_harmonicOrder.Text = "Harmonic Order";
            // 
            // numericUpDown_harmonicOrder
            // 
            this.numericUpDown_harmonicOrder.Enabled = false;
            this.numericUpDown_harmonicOrder.Location = new System.Drawing.Point(172, 87);
            this.numericUpDown_harmonicOrder.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_harmonicOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_harmonicOrder.Name = "numericUpDown_harmonicOrder";
            this.numericUpDown_harmonicOrder.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_harmonicOrder.TabIndex = 4;
            this.numericUpDown_harmonicOrder.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label_Duration
            // 
            this.label_Duration.AutoSize = true;
            this.label_Duration.Location = new System.Drawing.Point(319, 48);
            this.label_Duration.Name = "label_Duration";
            this.label_Duration.Size = new System.Drawing.Size(77, 12);
            this.label_Duration.TabIndex = 3;
            this.label_Duration.Text = "Duration(ms)";
            // 
            // label_targetFreq
            // 
            this.label_targetFreq.AutoSize = true;
            this.label_targetFreq.Location = new System.Drawing.Point(47, 50);
            this.label_targetFreq.Name = "label_targetFreq";
            this.label_targetFreq.Size = new System.Drawing.Size(125, 12);
            this.label_targetFreq.TabIndex = 2;
            this.label_targetFreq.Text = "Target Frequency(Hz)";
            // 
            // numericUpDown_Duration
            // 
            this.numericUpDown_Duration.Location = new System.Drawing.Point(438, 44);
            this.numericUpDown_Duration.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown_Duration.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_Duration.Name = "numericUpDown_Duration";
            this.numericUpDown_Duration.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_Duration.TabIndex = 1;
            this.numericUpDown_Duration.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDown_targetFreq
            // 
            this.numericUpDown_targetFreq.Location = new System.Drawing.Point(172, 46);
            this.numericUpDown_targetFreq.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown_targetFreq.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_targetFreq.Name = "numericUpDown_targetFreq";
            this.numericUpDown_targetFreq.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_targetFreq.TabIndex = 0;
            this.numericUpDown_targetFreq.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label_Waveform
            // 
            this.label_Waveform.AutoSize = true;
            this.label_Waveform.Location = new System.Drawing.Point(63, 29);
            this.label_Waveform.Name = "label_Waveform";
            this.label_Waveform.Size = new System.Drawing.Size(89, 12);
            this.label_Waveform.TabIndex = 7;
            this.label_Waveform.Text = "Input Waveform";
            // 
            // label_specturm
            // 
            this.label_specturm.AutoSize = true;
            this.label_specturm.Location = new System.Drawing.Point(63, 327);
            this.label_specturm.Name = "label_specturm";
            this.label_specturm.Size = new System.Drawing.Size(203, 12);
            this.label_specturm.TabIndex = 9;
            this.label_specturm.Text = "Source Waveform And Test Waveform";
            // 
            // groupBox_result
            // 
            this.groupBox_result.Controls.Add(this.label_analyzeResult);
            this.groupBox_result.Controls.Add(this.textBox_result);
            this.groupBox_result.Controls.Add(this.label_spectrum);
            this.groupBox_result.Controls.Add(this.easyChart_spectrum);
            this.groupBox_result.Location = new System.Drawing.Point(60, 365);
            this.groupBox_result.Name = "groupBox_result";
            this.groupBox_result.Size = new System.Drawing.Size(547, 238);
            this.groupBox_result.TabIndex = 10;
            this.groupBox_result.TabStop = false;
            this.groupBox_result.Text = "Test result";
            // 
            // label_analyzeResult
            // 
            this.label_analyzeResult.AutoSize = true;
            this.label_analyzeResult.Location = new System.Drawing.Point(430, 23);
            this.label_analyzeResult.Name = "label_analyzeResult";
            this.label_analyzeResult.Size = new System.Drawing.Size(89, 12);
            this.label_analyzeResult.TabIndex = 12;
            this.label_analyzeResult.Text = "Analyze Result";
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.Color.Silver;
            this.textBox_result.Enabled = false;
            this.textBox_result.ForeColor = System.Drawing.Color.Green;
            this.textBox_result.Location = new System.Drawing.Point(427, 39);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(108, 188);
            this.textBox_result.TabIndex = 11;
            // 
            // label_spectrum
            // 
            this.label_spectrum.AutoSize = true;
            this.label_spectrum.Location = new System.Drawing.Point(15, 25);
            this.label_spectrum.Name = "label_spectrum";
            this.label_spectrum.Size = new System.Drawing.Size(113, 12);
            this.label_spectrum.TabIndex = 11;
            this.label_spectrum.Text = "Test Wave Specturm";
            // 
            // easyChart_spectrum
            // 
            this.easyChart_spectrum.AxisYMax = double.NaN;
            this.easyChart_spectrum.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_spectrum.ChartAreaBackColor = System.Drawing.Color.DimGray;
            this.easyChart_spectrum.EasyChartBackColor = System.Drawing.Color.DarkGray;
            this.easyChart_spectrum.FixAxisX = false;
            this.easyChart_spectrum.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_spectrum.LegendVisible = false;
            this.easyChart_spectrum.Location = new System.Drawing.Point(12, 39);
            this.easyChart_spectrum.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart_spectrum.MajorGridEnabled = true;
            this.easyChart_spectrum.Margin = new System.Windows.Forms.Padding(2);
            this.easyChart_spectrum.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart_spectrum.MinorGridEnabled = false;
            this.easyChart_spectrum.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
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
            this.easyChart_spectrum.Size = new System.Drawing.Size(407, 188);
            this.easyChart_spectrum.TabIndex = 11;
            this.easyChart_spectrum.XAxisLogarithmic = false;
            this.easyChart_spectrum.YAutoEnable = true;
            this.easyChart_spectrum.YAxisLogarithmic = false;
            // 
            // SingleToneAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.groupBox_result);
            this.Controls.Add(this.label_specturm);
            this.Controls.Add(this.label_Waveform);
            this.Controls.Add(this.groupBox_waveConfig);
            this.Controls.Add(this.groupBox_channelSelect);
            this.Controls.Add(this.easyChart_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "SingleToneAnalyze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SteppedSineWaveCrossTalkAnalyze";
            this.Load += new System.EventHandler(this.SteppedSineWaveCrossTalkAnalyze_Load);
            this.groupBox_channelSelect.ResumeLayout(false);
            this.groupBox_channelSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            this.groupBox_waveConfig.ResumeLayout(false);
            this.groupBox_waveConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_harmonicOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_targetFreq)).EndInit();
            this.groupBox_result.ResumeLayout(false);
            this.groupBox_result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeeSharpTools.JY.GUI.EasyChart easyChart_data;
        private System.Windows.Forms.GroupBox groupBox_channelSelect;
        private System.Windows.Forms.ComboBox comboBox_testChannel;
        private System.Windows.Forms.Label label_testChannel;
        private System.Windows.Forms.GroupBox groupBox_waveConfig;
        private System.Windows.Forms.NumericUpDown numericUpDown_targetFreq;
        private System.Windows.Forms.NumericUpDown numericUpDown_Duration;
        private System.Windows.Forms.Label label_targetFreq;
        private System.Windows.Forms.Label label_Duration;
        private System.Windows.Forms.Label label_Waveform;
        private System.Windows.Forms.ComboBox comboBox_aoChannel;
        private System.Windows.Forms.Label label_aoChannel;
        private System.Windows.Forms.Label label_sampleRate;
        private System.Windows.Forms.NumericUpDown numericUpDown_sampleRate;
        private System.Windows.Forms.Label label_harmonicOrder;
        private System.Windows.Forms.NumericUpDown numericUpDown_harmonicOrder;
        private System.Windows.Forms.Label label_amplitude;
        private System.Windows.Forms.NumericUpDown numericUpDown_amplitude;
        private System.Windows.Forms.Label label_specturm;
        private System.Windows.Forms.GroupBox groupBox_result;
        private SeeSharpTools.JY.GUI.EasyChart easyChart_spectrum;
        private System.Windows.Forms.Label label_spectrum;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label_analyzeResult;
    }
}