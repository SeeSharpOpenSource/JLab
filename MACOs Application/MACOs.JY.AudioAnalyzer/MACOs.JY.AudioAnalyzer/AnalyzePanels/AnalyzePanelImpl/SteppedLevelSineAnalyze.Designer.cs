namespace MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelImpl
{
    partial class SteppedLevelSineAnalyze
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
            this.comboBox_refChannel = new System.Windows.Forms.ComboBox();
            this.label_refChannel = new System.Windows.Forms.Label();
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
            this.easyChart_waveform = new SeeSharpTools.JY.GUI.EasyChart();
            this.dataGridView_result = new System.Windows.Forms.DataGridView();
            this.Amplitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThdPlusN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_channelSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            this.groupBox_waveConfig.SuspendLayout();
            this.groupBox_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_result)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_channelSelect
            // 
            this.groupBox_channelSelect.Controls.Add(this.comboBox_refChannel);
            this.groupBox_channelSelect.Controls.Add(this.label_refChannel);
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
            // comboBox_refChannel
            // 
            this.comboBox_refChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_refChannel.FormattingEnabled = true;
            this.comboBox_refChannel.Location = new System.Drawing.Point(437, 33);
            this.comboBox_refChannel.Name = "comboBox_refChannel";
            this.comboBox_refChannel.Size = new System.Drawing.Size(105, 20);
            this.comboBox_refChannel.TabIndex = 13;
            // 
            // label_refChannel
            // 
            this.label_refChannel.AutoSize = true;
            this.label_refChannel.Location = new System.Drawing.Point(313, 36);
            this.label_refChannel.Name = "label_refChannel";
            this.label_refChannel.Size = new System.Drawing.Size(107, 12);
            this.label_refChannel.TabIndex = 12;
            this.label_refChannel.Text = "Reference Channel";
            // 
            // label_sampleRate
            // 
            this.label_sampleRate.AutoSize = true;
            this.label_sampleRate.Location = new System.Drawing.Point(313, 79);
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
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(437, 75);
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
            this.groupBox_result.Controls.Add(this.dataGridView_result);
            this.groupBox_result.Location = new System.Drawing.Point(60, 321);
            this.groupBox_result.Name = "groupBox_result";
            this.groupBox_result.Size = new System.Drawing.Size(547, 302);
            this.groupBox_result.TabIndex = 10;
            this.groupBox_result.TabStop = false;
            this.groupBox_result.Text = "Test result";
            // 
            // easyChart_waveform
            // 
            this.easyChart_waveform.AxisYMax = double.NaN;
            this.easyChart_waveform.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_waveform.ChartAreaBackColor = System.Drawing.Color.DimGray;
            this.easyChart_waveform.EasyChartBackColor = System.Drawing.Color.DarkGray;
            this.easyChart_waveform.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_waveform.LegendVisible = false;
            this.easyChart_waveform.Location = new System.Drawing.Point(65, 43);
            this.easyChart_waveform.Margin = new System.Windows.Forms.Padding(2);
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
            // dataGridView_result
            // 
            this.dataGridView_result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Amplitude,
            this.Thd,
            this.Nr,
            this.ThdPlusN,
            this.Rms});
            this.dataGridView_result.Location = new System.Drawing.Point(17, 24);
            this.dataGridView_result.Name = "dataGridView_result";
            this.dataGridView_result.RowTemplate.Height = 23;
            this.dataGridView_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_result.Size = new System.Drawing.Size(513, 264);
            this.dataGridView_result.TabIndex = 0;
            // 
            // Amplitude
            // 
            this.Amplitude.HeaderText = "Peak To Peak(V)";
            this.Amplitude.Name = "Amplitude";
            this.Amplitude.ReadOnly = true;
            // 
            // Thd
            // 
            this.Thd.HeaderText = "THD(Db)";
            this.Thd.Name = "Thd";
            this.Thd.ReadOnly = true;
            // 
            // Nr
            // 
            this.Nr.HeaderText = "NoiseRatio";
            this.Nr.Name = "Nr";
            this.Nr.ReadOnly = true;
            // 
            // ThdPlusN
            // 
            this.ThdPlusN.HeaderText = "THD+N(Db)";
            this.ThdPlusN.Name = "ThdPlusN";
            this.ThdPlusN.ReadOnly = true;
            // 
            // Rms
            // 
            this.Rms.HeaderText = "RMS";
            this.Rms.Name = "Rms";
            this.Rms.ReadOnly = true;
            // 
            // SteppedLevelSineAnalyze
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
            this.Name = "SteppedLevelSineAnalyze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SteppedSineWaveCrossTalkAnalyze";
            this.Load += new System.EventHandler(this.DualToneAnalyze_Load);
            this.groupBox_channelSelect.ResumeLayout(false);
            this.groupBox_channelSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            this.groupBox_waveConfig.ResumeLayout(false);
            this.groupBox_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_result)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox_refChannel;
        private System.Windows.Forms.Label label_refChannel;
        private System.Windows.Forms.DataGridView dataGridView_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amplitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThdPlusN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rms;
    }
}