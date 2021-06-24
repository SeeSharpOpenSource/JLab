using System.Windows.Forms;

namespace DsaSoftPanel
{
    partial class DsaSoftPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DsaSoftPanelForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries33 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries34 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries35 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries36 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries37 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries38 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries39 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries40 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries41 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries42 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries43 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries44 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries45 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries46 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries47 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries48 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel_menuButton = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSwitch_Switch = new SeeSharpTools.JY.GUI.ButtonSwitch();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_runPause = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.flowLayoutPanel_status = new System.Windows.Forms.FlowLayoutPanel();
            this.label_sampleRateInMenu = new System.Windows.Forms.Label();
            this.label_status2 = new System.Windows.Forms.Label();
            this.label_status3 = new System.Windows.Forms.Label();
            this.label_status4 = new System.Windows.Forms.Label();
            this.label_ch1 = new System.Windows.Forms.Label();
            this.label_ch2 = new System.Windows.Forms.Label();
            this.label_ch3 = new System.Windows.Forms.Label();
            this.label_ch4 = new System.Windows.Forms.Label();
            this.checkBox_splitView = new System.Windows.Forms.CheckBox();
            this.radioButton_xZoom = new System.Windows.Forms.RadioButton();
            this.radioButton_zoomY = new System.Windows.Forms.RadioButton();
            this.radioButton_zoomArea = new System.Windows.Forms.RadioButton();
            this.radioButton_cursor = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel_channelInfos = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_function = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer_measureAndView = new System.Windows.Forms.SplitContainer();
            this.splitContainer_buttonAndFunction = new System.Windows.Forms.SplitContainer();
            this.button_function = new System.Windows.Forms.Button();
            this.button_measure = new System.Windows.Forms.Button();
            this.panel_measure = new System.Windows.Forms.Panel();
            this.metroComboBox_measureChannel = new MetroFramework.Controls.MetroComboBox();
            this.label_measureChannel = new System.Windows.Forms.Label();
            this.panel_measureValue = new System.Windows.Forms.Panel();
            this.dataGridView_measureValues = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel_measure = new System.Windows.Forms.TableLayoutPanel();
            this.label_measureRms = new System.Windows.Forms.Label();
            this.label_DC = new System.Windows.Forms.Label();
            this.label_peakAmp = new System.Windows.Forms.Label();
            this.label_peakFrequency = new System.Windows.Forms.Label();
            this.txCheckBox_rms = new TX.Framework.WindowUI.Controls.TXCheckBox();
            this.txCheckBox_DC = new TX.Framework.WindowUI.Controls.TXCheckBox();
            this.txCheckBox_peakAmp = new TX.Framework.WindowUI.Controls.TXCheckBox();
            this.txCheckBox_peakFreq = new TX.Framework.WindowUI.Controls.TXCheckBox();
            this.panel_function = new System.Windows.Forms.Panel();
            this.panel_functionConfig = new System.Windows.Forms.Panel();
            this.button_stopfunction = new System.Windows.Forms.Button();
            this.tableLayoutPanel_functionSelect = new System.Windows.Forms.TableLayoutPanel();
            this.label_filter = new System.Windows.Forms.Label();
            this.txRadioButton_filter = new TX.Framework.WindowUI.Controls.TXRadioButton();
            this.label_toneAnalyze = new System.Windows.Forms.Label();
            this.txRadioButton_toneAnalyze = new TX.Framework.WindowUI.Controls.TXRadioButton();
            this.txRadioButton_harmonic = new TX.Framework.WindowUI.Controls.TXRadioButton();
            this.label_harmonicFunction = new System.Windows.Forms.Label();
            this.label_spectrumFunction = new System.Windows.Forms.Label();
            this.txRadioButton_spectrum = new TX.Framework.WindowUI.Controls.TXRadioButton();
            this.label_squareAnalyze = new System.Windows.Forms.Label();
            this.txRadioButton_squareAnalyze = new TX.Framework.WindowUI.Controls.TXRadioButton();
            this.label_phaseShift = new System.Windows.Forms.Label();
            this.txRadioButton_phaseShift = new TX.Framework.WindowUI.Controls.TXRadioButton();
            this.splitContainer_viewAndConfig = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel_chartView = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer_plotArea = new System.Windows.Forms.SplitContainer();
            this.easyChartX_data = new SeeSharpTools.JY.GUI.EasyChartX();
            this.tableLayoutPanel_functionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_functionValues = new System.Windows.Forms.TableLayoutPanel();
            this.label_YValueLabel = new System.Windows.Forms.Label();
            this.label_XValueLabel = new System.Windows.Forms.Label();
            this.splitContainer_functionDataAndDetail = new System.Windows.Forms.SplitContainer();
            this.easyChartX_function = new SeeSharpTools.JY.GUI.EasyChartX();
            this.dataGridView_functionDetail = new System.Windows.Forms.DataGridView();
            this.Column_Parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer_channelAndCommon = new System.Windows.Forms.SplitContainer();
            this.txTabControl_channel = new TX.Framework.WindowUI.Controls.TXTabControl();
            this.tabPagech1 = new System.Windows.Forms.TabPage();
            this.metroComboBox_unit = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox_coupling = new MetroFramework.Controls.MetroComboBox();
            this.label_Coupling = new System.Windows.Forms.Label();
            this.metroComboBox_probe = new MetroFramework.Controls.MetroComboBox();
            this.label_probe = new System.Windows.Forms.Label();
            this.label_Unit = new System.Windows.Forms.Label();
            this.panel_commonConfig = new System.Windows.Forms.Panel();
            this.button_sendSoftTrigger = new System.Windows.Forms.Button();
            this.button_triggerConfig = new System.Windows.Forms.Button();
            this.numericUpDown_chartRange = new System.Windows.Forms.NumericUpDown();
            this.label_chartRange = new System.Windows.Forms.Label();
            this.knobControl_chartRange = new SeeSharpTools.JY.GUI.KnobControl();
            this.numericUpDown_viewTime = new System.Windows.Forms.NumericUpDown();
            this.label_viewTime = new System.Windows.Forms.Label();
            this.knobControl_viewTime = new SeeSharpTools.JY.GUI.KnobControl();
            this.pictureBox_titleIcon = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel_formButton = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_maximize = new System.Windows.Forms.Button();
            this.flowLayoutPanel_menuButton.SuspendLayout();
            this.flowLayoutPanel_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_measureAndView)).BeginInit();
            this.splitContainer_measureAndView.Panel1.SuspendLayout();
            this.splitContainer_measureAndView.Panel2.SuspendLayout();
            this.splitContainer_measureAndView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_buttonAndFunction)).BeginInit();
            this.splitContainer_buttonAndFunction.Panel1.SuspendLayout();
            this.splitContainer_buttonAndFunction.Panel2.SuspendLayout();
            this.splitContainer_buttonAndFunction.SuspendLayout();
            this.panel_measure.SuspendLayout();
            this.panel_measureValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_measureValues)).BeginInit();
            this.tableLayoutPanel_measure.SuspendLayout();
            this.panel_function.SuspendLayout();
            this.tableLayoutPanel_functionSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_viewAndConfig)).BeginInit();
            this.splitContainer_viewAndConfig.Panel1.SuspendLayout();
            this.splitContainer_viewAndConfig.Panel2.SuspendLayout();
            this.splitContainer_viewAndConfig.SuspendLayout();
            this.tableLayoutPanel_chartView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_plotArea)).BeginInit();
            this.splitContainer_plotArea.Panel1.SuspendLayout();
            this.splitContainer_plotArea.Panel2.SuspendLayout();
            this.splitContainer_plotArea.SuspendLayout();
            this.tableLayoutPanel_functionPanel.SuspendLayout();
            this.tableLayoutPanel_functionValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_functionDataAndDetail)).BeginInit();
            this.splitContainer_functionDataAndDetail.Panel1.SuspendLayout();
            this.splitContainer_functionDataAndDetail.Panel2.SuspendLayout();
            this.splitContainer_functionDataAndDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_functionDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_channelAndCommon)).BeginInit();
            this.splitContainer_channelAndCommon.Panel1.SuspendLayout();
            this.splitContainer_channelAndCommon.Panel2.SuspendLayout();
            this.splitContainer_channelAndCommon.SuspendLayout();
            this.txTabControl_channel.SuspendLayout();
            this.tabPagech1.SuspendLayout();
            this.panel_commonConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_chartRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_viewTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_titleIcon)).BeginInit();
            this.panel_title.SuspendLayout();
            this.panel_formButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_menuButton
            // 
            this.flowLayoutPanel_menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel_menuButton.Controls.Add(this.buttonSwitch_Switch);
            this.flowLayoutPanel_menuButton.Controls.Add(this.button_clear);
            this.flowLayoutPanel_menuButton.Controls.Add(this.button_runPause);
            this.flowLayoutPanel_menuButton.Controls.Add(this.button_reset);
            this.flowLayoutPanel_menuButton.Location = new System.Drawing.Point(1, 31);
            this.flowLayoutPanel_menuButton.Name = "flowLayoutPanel_menuButton";
            this.flowLayoutPanel_menuButton.Size = new System.Drawing.Size(1200, 30);
            this.flowLayoutPanel_menuButton.TabIndex = 1;
            // 
            // buttonSwitch_Switch
            // 
            this.buttonSwitch_Switch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSwitch_Switch.Location = new System.Drawing.Point(3, 3);
            this.buttonSwitch_Switch.Name = "buttonSwitch_Switch";
            this.buttonSwitch_Switch.OffFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSwitch_Switch.OnFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSwitch_Switch.Size = new System.Drawing.Size(61, 24);
            this.buttonSwitch_Switch.Style = SeeSharpTools.JY.GUI.ButtonSwitch.ButtonSwitchStyle.Modern;
            this.buttonSwitch_Switch.TabIndex = 0;
            this.buttonSwitch_Switch.ValueChanged += new SeeSharpTools.JY.GUI.ButtonSwitch.CheckedChangedDelegate(this.buttonSwitch_Switch_ValueChanged);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.Silver;
            this.button_clear.Location = new System.Drawing.Point(70, 3);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(70, 24);
            this.button_clear.TabIndex = 2;
            this.button_clear.Text = "CLEAR";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_runPause
            // 
            this.button_runPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_runPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_runPause.FlatAppearance.BorderSize = 0;
            this.button_runPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_runPause.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_runPause.ForeColor = System.Drawing.Color.Silver;
            this.button_runPause.Location = new System.Drawing.Point(146, 3);
            this.button_runPause.Name = "button_runPause";
            this.button_runPause.Size = new System.Drawing.Size(70, 24);
            this.button_runPause.TabIndex = 3;
            this.button_runPause.Text = "PAUSE";
            this.button_runPause.UseVisualStyleBackColor = false;
            this.button_runPause.Click += new System.EventHandler(this.button_runPause_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_reset.FlatAppearance.BorderSize = 0;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.Color.Silver;
            this.button_reset.Location = new System.Drawing.Point(222, 3);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(70, 24);
            this.button_reset.TabIndex = 4;
            this.button_reset.Text = "RESET";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // flowLayoutPanel_status
            // 
            this.flowLayoutPanel_status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel_status.Controls.Add(this.label_sampleRateInMenu);
            this.flowLayoutPanel_status.Controls.Add(this.label_status2);
            this.flowLayoutPanel_status.Controls.Add(this.label_status3);
            this.flowLayoutPanel_status.Controls.Add(this.label_status4);
            this.flowLayoutPanel_status.Controls.Add(this.label_ch1);
            this.flowLayoutPanel_status.Controls.Add(this.label_ch2);
            this.flowLayoutPanel_status.Controls.Add(this.label_ch3);
            this.flowLayoutPanel_status.Controls.Add(this.label_ch4);
            this.flowLayoutPanel_status.Controls.Add(this.checkBox_splitView);
            this.flowLayoutPanel_status.Controls.Add(this.radioButton_xZoom);
            this.flowLayoutPanel_status.Controls.Add(this.radioButton_zoomY);
            this.flowLayoutPanel_status.Controls.Add(this.radioButton_zoomArea);
            this.flowLayoutPanel_status.Controls.Add(this.radioButton_cursor);
            this.flowLayoutPanel_status.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanel_status.Location = new System.Drawing.Point(1, 61);
            this.flowLayoutPanel_status.Name = "flowLayoutPanel_status";
            this.flowLayoutPanel_status.Size = new System.Drawing.Size(1200, 20);
            this.flowLayoutPanel_status.TabIndex = 2;
            // 
            // label_sampleRateInMenu
            // 
            this.label_sampleRateInMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_sampleRateInMenu.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sampleRateInMenu.ForeColor = System.Drawing.Color.Orange;
            this.label_sampleRateInMenu.Location = new System.Drawing.Point(3, 0);
            this.label_sampleRateInMenu.Name = "label_sampleRateInMenu";
            this.label_sampleRateInMenu.Size = new System.Drawing.Size(103, 20);
            this.label_sampleRateInMenu.TabIndex = 3;
            this.label_sampleRateInMenu.Text = "TD:     KSa/s";
            this.label_sampleRateInMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_status2
            // 
            this.label_status2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_status2.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status2.ForeColor = System.Drawing.Color.Orange;
            this.label_status2.Location = new System.Drawing.Point(112, 0);
            this.label_status2.Name = "label_status2";
            this.label_status2.Size = new System.Drawing.Size(122, 20);
            this.label_status2.TabIndex = 4;
            this.label_status2.Text = "X Range:100.00ms";
            this.label_status2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_status3
            // 
            this.label_status3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_status3.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status3.ForeColor = System.Drawing.Color.Orange;
            this.label_status3.Location = new System.Drawing.Point(240, 0);
            this.label_status3.Name = "label_status3";
            this.label_status3.Size = new System.Drawing.Size(101, 20);
            this.label_status3.TabIndex = 4;
            this.label_status3.Text = "Y Range:20.00";
            this.label_status3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_status4
            // 
            this.label_status4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_status4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status4.ForeColor = System.Drawing.Color.Silver;
            this.label_status4.Location = new System.Drawing.Point(347, 0);
            this.label_status4.Name = "label_status4";
            this.label_status4.Size = new System.Drawing.Size(60, 20);
            this.label_status4.TabIndex = 4;
            this.label_status4.Text = "status4";
            this.label_status4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_status4.Visible = false;
            // 
            // label_ch1
            // 
            this.label_ch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_ch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ch1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ch1.ForeColor = System.Drawing.Color.Black;
            this.label_ch1.Location = new System.Drawing.Point(413, 0);
            this.label_ch1.Name = "label_ch1";
            this.label_ch1.Size = new System.Drawing.Size(60, 20);
            this.label_ch1.TabIndex = 4;
            this.label_ch1.Text = "CH1";
            this.label_ch1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ch2
            // 
            this.label_ch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_ch2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ch2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ch2.ForeColor = System.Drawing.Color.Black;
            this.label_ch2.Location = new System.Drawing.Point(479, 0);
            this.label_ch2.Name = "label_ch2";
            this.label_ch2.Size = new System.Drawing.Size(60, 20);
            this.label_ch2.TabIndex = 4;
            this.label_ch2.Text = "CH2";
            this.label_ch2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ch3
            // 
            this.label_ch3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_ch3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ch3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ch3.ForeColor = System.Drawing.Color.Black;
            this.label_ch3.Location = new System.Drawing.Point(545, 0);
            this.label_ch3.Name = "label_ch3";
            this.label_ch3.Size = new System.Drawing.Size(60, 20);
            this.label_ch3.TabIndex = 4;
            this.label_ch3.Text = "CH3";
            this.label_ch3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ch4
            // 
            this.label_ch4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_ch4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ch4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ch4.ForeColor = System.Drawing.Color.Black;
            this.label_ch4.Location = new System.Drawing.Point(611, 0);
            this.label_ch4.Name = "label_ch4";
            this.label_ch4.Size = new System.Drawing.Size(60, 20);
            this.label_ch4.TabIndex = 4;
            this.label_ch4.Text = "CH4";
            this.label_ch4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_splitView
            // 
            this.checkBox_splitView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_splitView.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_splitView.ForeColor = System.Drawing.Color.Silver;
            this.checkBox_splitView.Location = new System.Drawing.Point(677, 3);
            this.checkBox_splitView.Name = "checkBox_splitView";
            this.checkBox_splitView.Size = new System.Drawing.Size(85, 16);
            this.checkBox_splitView.TabIndex = 5;
            this.checkBox_splitView.Text = "Split View";
            this.checkBox_splitView.UseVisualStyleBackColor = true;
            this.checkBox_splitView.CheckedChanged += new System.EventHandler(this.checkBox_splitView_CheckedChanged);
            // 
            // radioButton_xZoom
            // 
            this.radioButton_xZoom.AutoSize = true;
            this.radioButton_xZoom.Checked = true;
            this.radioButton_xZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_xZoom.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_xZoom.ForeColor = System.Drawing.Color.Silver;
            this.radioButton_xZoom.Location = new System.Drawing.Point(768, 3);
            this.radioButton_xZoom.Name = "radioButton_xZoom";
            this.radioButton_xZoom.Size = new System.Drawing.Size(65, 16);
            this.radioButton_xZoom.TabIndex = 11;
            this.radioButton_xZoom.TabStop = true;
            this.radioButton_xZoom.Tag = "Spectrum";
            this.radioButton_xZoom.Text = "Zoom X";
            this.radioButton_xZoom.UseVisualStyleBackColor = true;
            this.radioButton_xZoom.CheckedChanged += new System.EventHandler(this.radioButton_xZoom_CheckedChanged);
            // 
            // radioButton_zoomY
            // 
            this.radioButton_zoomY.AutoSize = true;
            this.radioButton_zoomY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_zoomY.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_zoomY.ForeColor = System.Drawing.Color.Silver;
            this.radioButton_zoomY.Location = new System.Drawing.Point(839, 3);
            this.radioButton_zoomY.Name = "radioButton_zoomY";
            this.radioButton_zoomY.Size = new System.Drawing.Size(65, 16);
            this.radioButton_zoomY.TabIndex = 12;
            this.radioButton_zoomY.Tag = "Spectrum";
            this.radioButton_zoomY.Text = "Zoom Y";
            this.radioButton_zoomY.UseVisualStyleBackColor = true;
            this.radioButton_zoomY.CheckedChanged += new System.EventHandler(this.radioButton_zoomY_CheckedChanged);
            // 
            // radioButton_zoomArea
            // 
            this.radioButton_zoomArea.AutoSize = true;
            this.radioButton_zoomArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_zoomArea.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_zoomArea.ForeColor = System.Drawing.Color.Silver;
            this.radioButton_zoomArea.Location = new System.Drawing.Point(910, 3);
            this.radioButton_zoomArea.Name = "radioButton_zoomArea";
            this.radioButton_zoomArea.Size = new System.Drawing.Size(83, 16);
            this.radioButton_zoomArea.TabIndex = 13;
            this.radioButton_zoomArea.Tag = "Spectrum";
            this.radioButton_zoomArea.Text = "Zoom Area";
            this.radioButton_zoomArea.UseVisualStyleBackColor = true;
            this.radioButton_zoomArea.CheckedChanged += new System.EventHandler(this.radioButton_zoomArea_CheckedChanged);
            // 
            // radioButton_cursor
            // 
            this.radioButton_cursor.AutoSize = true;
            this.radioButton_cursor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_cursor.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_cursor.ForeColor = System.Drawing.Color.Silver;
            this.radioButton_cursor.Location = new System.Drawing.Point(999, 3);
            this.radioButton_cursor.Name = "radioButton_cursor";
            this.radioButton_cursor.Size = new System.Drawing.Size(58, 16);
            this.radioButton_cursor.TabIndex = 14;
            this.radioButton_cursor.Tag = "Spectrum";
            this.radioButton_cursor.Text = "Cursor";
            this.radioButton_cursor.UseVisualStyleBackColor = true;
            this.radioButton_cursor.CheckedChanged += new System.EventHandler(this.radioButton_cursor_CheckedChanged);
            // 
            // flowLayoutPanel_channelInfos
            // 
            this.flowLayoutPanel_channelInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_channelInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel_channelInfos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_channelInfos.Location = new System.Drawing.Point(1, 645);
            this.flowLayoutPanel_channelInfos.Name = "flowLayoutPanel_channelInfos";
            this.flowLayoutPanel_channelInfos.Size = new System.Drawing.Size(1200, 27);
            this.flowLayoutPanel_channelInfos.TabIndex = 3;
            // 
            // flowLayoutPanel_function
            // 
            this.flowLayoutPanel_function.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_function.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel_function.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_function.Location = new System.Drawing.Point(1, 671);
            this.flowLayoutPanel_function.Name = "flowLayoutPanel_function";
            this.flowLayoutPanel_function.Size = new System.Drawing.Size(1200, 30);
            this.flowLayoutPanel_function.TabIndex = 4;
            // 
            // splitContainer_measureAndView
            // 
            this.splitContainer_measureAndView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer_measureAndView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer_measureAndView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer_measureAndView.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_measureAndView.Location = new System.Drawing.Point(1, 81);
            this.splitContainer_measureAndView.Name = "splitContainer_measureAndView";
            // 
            // splitContainer_measureAndView.Panel1
            // 
            this.splitContainer_measureAndView.Panel1.Controls.Add(this.splitContainer_buttonAndFunction);
            // 
            // splitContainer_measureAndView.Panel2
            // 
            this.splitContainer_measureAndView.Panel2.AutoScroll = true;
            this.splitContainer_measureAndView.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer_measureAndView.Panel2.Controls.Add(this.splitContainer_viewAndConfig);
            this.splitContainer_measureAndView.Panel2MinSize = 50;
            this.splitContainer_measureAndView.Size = new System.Drawing.Size(1200, 565);
            this.splitContainer_measureAndView.SplitterDistance = 182;
            this.splitContainer_measureAndView.TabIndex = 5;
            // 
            // splitContainer_buttonAndFunction
            // 
            this.splitContainer_buttonAndFunction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer_buttonAndFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_buttonAndFunction.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_buttonAndFunction.IsSplitterFixed = true;
            this.splitContainer_buttonAndFunction.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_buttonAndFunction.Name = "splitContainer_buttonAndFunction";
            // 
            // splitContainer_buttonAndFunction.Panel1
            // 
            this.splitContainer_buttonAndFunction.Panel1.Controls.Add(this.button_function);
            this.splitContainer_buttonAndFunction.Panel1.Controls.Add(this.button_measure);
            // 
            // splitContainer_buttonAndFunction.Panel2
            // 
            this.splitContainer_buttonAndFunction.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer_buttonAndFunction.Panel2.Controls.Add(this.panel_measure);
            this.splitContainer_buttonAndFunction.Panel2.Controls.Add(this.panel_function);
            this.splitContainer_buttonAndFunction.Panel2MinSize = 0;
            this.splitContainer_buttonAndFunction.Size = new System.Drawing.Size(182, 565);
            this.splitContainer_buttonAndFunction.SplitterDistance = 30;
            this.splitContainer_buttonAndFunction.TabIndex = 0;
            // 
            // button_function
            // 
            this.button_function.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_function.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_function.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_function.BackgroundImage")));
            this.button_function.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_function.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_function.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_function.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_function.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_function.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_function.ForeColor = System.Drawing.Color.Silver;
            this.button_function.Location = new System.Drawing.Point(3, 85);
            this.button_function.Name = "button_function";
            this.button_function.Size = new System.Drawing.Size(24, 75);
            this.button_function.TabIndex = 4;
            this.button_function.UseVisualStyleBackColor = false;
            this.button_function.Click += new System.EventHandler(this.button_function_Click);
            // 
            // button_measure
            // 
            this.button_measure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_measure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_measure.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_measure.BackgroundImage")));
            this.button_measure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_measure.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_measure.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button_measure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_measure.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_measure.ForeColor = System.Drawing.Color.Silver;
            this.button_measure.Location = new System.Drawing.Point(3, 6);
            this.button_measure.Name = "button_measure";
            this.button_measure.Size = new System.Drawing.Size(24, 75);
            this.button_measure.TabIndex = 3;
            this.button_measure.UseVisualStyleBackColor = false;
            this.button_measure.Click += new System.EventHandler(this.button_measure_Click);
            // 
            // panel_measure
            // 
            this.panel_measure.Controls.Add(this.metroComboBox_measureChannel);
            this.panel_measure.Controls.Add(this.label_measureChannel);
            this.panel_measure.Controls.Add(this.panel_measureValue);
            this.panel_measure.Controls.Add(this.tableLayoutPanel_measure);
            this.panel_measure.Location = new System.Drawing.Point(0, 2);
            this.panel_measure.Name = "panel_measure";
            this.panel_measure.Size = new System.Drawing.Size(144, 270);
            this.panel_measure.TabIndex = 1;
            // 
            // metroComboBox_measureChannel
            // 
            this.metroComboBox_measureChannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroComboBox_measureChannel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_measureChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_measureChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox_measureChannel.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox_measureChannel.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox_measureChannel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.metroComboBox_measureChannel.FormattingEnabled = true;
            this.metroComboBox_measureChannel.ItemHeight = 19;
            this.metroComboBox_measureChannel.Location = new System.Drawing.Point(71, 147);
            this.metroComboBox_measureChannel.Name = "metroComboBox_measureChannel";
            this.metroComboBox_measureChannel.Size = new System.Drawing.Size(67, 25);
            this.metroComboBox_measureChannel.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox_measureChannel.StyleManager = null;
            this.metroComboBox_measureChannel.TabIndex = 27;
            this.metroComboBox_measureChannel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_measureChannel
            // 
            this.label_measureChannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_measureChannel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_measureChannel.ForeColor = System.Drawing.Color.Silver;
            this.label_measureChannel.Location = new System.Drawing.Point(3, 149);
            this.label_measureChannel.Name = "label_measureChannel";
            this.label_measureChannel.Size = new System.Drawing.Size(68, 20);
            this.label_measureChannel.TabIndex = 26;
            this.label_measureChannel.Text = "Channel:";
            this.label_measureChannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_measureValue
            // 
            this.panel_measureValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_measureValue.Controls.Add(this.dataGridView_measureValues);
            this.panel_measureValue.Location = new System.Drawing.Point(0, 178);
            this.panel_measureValue.Name = "panel_measureValue";
            this.panel_measureValue.Size = new System.Drawing.Size(144, 92);
            this.panel_measureValue.TabIndex = 24;
            // 
            // dataGridView_measureValues
            // 
            this.dataGridView_measureValues.AllowUserToAddRows = false;
            this.dataGridView_measureValues.AllowUserToDeleteRows = false;
            this.dataGridView_measureValues.AllowUserToResizeRows = false;
            this.dataGridView_measureValues.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView_measureValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_measureValues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView_measureValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_measureValues.ColumnHeadersVisible = false;
            this.dataGridView_measureValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView_measureValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_measureValues.EnableHeadersVisualStyles = false;
            this.dataGridView_measureValues.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_measureValues.Name = "dataGridView_measureValues";
            this.dataGridView_measureValues.ReadOnly = true;
            this.dataGridView_measureValues.RowHeadersVisible = false;
            this.dataGridView_measureValues.RowTemplate.Height = 23;
            this.dataGridView_measureValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_measureValues.Size = new System.Drawing.Size(144, 92);
            this.dataGridView_measureValues.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Silver;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn1.HeaderText = "Parameter Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Silver;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tableLayoutPanel_measure
            // 
            this.tableLayoutPanel_measure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_measure.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_measure.ColumnCount = 2;
            this.tableLayoutPanel_measure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_measure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel_measure.Controls.Add(this.label_measureRms, 0, 0);
            this.tableLayoutPanel_measure.Controls.Add(this.label_DC, 0, 1);
            this.tableLayoutPanel_measure.Controls.Add(this.label_peakAmp, 0, 2);
            this.tableLayoutPanel_measure.Controls.Add(this.label_peakFrequency, 0, 3);
            this.tableLayoutPanel_measure.Controls.Add(this.txCheckBox_rms, 1, 0);
            this.tableLayoutPanel_measure.Controls.Add(this.txCheckBox_DC, 1, 1);
            this.tableLayoutPanel_measure.Controls.Add(this.txCheckBox_peakAmp, 1, 2);
            this.tableLayoutPanel_measure.Controls.Add(this.txCheckBox_peakFreq, 1, 3);
            this.tableLayoutPanel_measure.Location = new System.Drawing.Point(2, 6);
            this.tableLayoutPanel_measure.Name = "tableLayoutPanel_measure";
            this.tableLayoutPanel_measure.RowCount = 4;
            this.tableLayoutPanel_measure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_measure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_measure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_measure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_measure.Size = new System.Drawing.Size(139, 119);
            this.tableLayoutPanel_measure.TabIndex = 7;
            // 
            // label_measureRms
            // 
            this.label_measureRms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_measureRms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_measureRms.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_measureRms.ForeColor = System.Drawing.Color.Yellow;
            this.label_measureRms.Location = new System.Drawing.Point(4, 1);
            this.label_measureRms.Name = "label_measureRms";
            this.label_measureRms.Size = new System.Drawing.Size(104, 28);
            this.label_measureRms.TabIndex = 9;
            this.label_measureRms.Text = "RMS";
            this.label_measureRms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_DC
            // 
            this.label_DC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_DC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_DC.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DC.ForeColor = System.Drawing.Color.Yellow;
            this.label_DC.Location = new System.Drawing.Point(4, 30);
            this.label_DC.Name = "label_DC";
            this.label_DC.Size = new System.Drawing.Size(104, 28);
            this.label_DC.TabIndex = 10;
            this.label_DC.Text = "DC";
            this.label_DC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_peakAmp
            // 
            this.label_peakAmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_peakAmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_peakAmp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_peakAmp.ForeColor = System.Drawing.Color.Yellow;
            this.label_peakAmp.Location = new System.Drawing.Point(4, 59);
            this.label_peakAmp.Name = "label_peakAmp";
            this.label_peakAmp.Size = new System.Drawing.Size(104, 28);
            this.label_peakAmp.TabIndex = 14;
            this.label_peakAmp.Text = "PeakAmp";
            this.label_peakAmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_peakFrequency
            // 
            this.label_peakFrequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_peakFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_peakFrequency.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_peakFrequency.ForeColor = System.Drawing.Color.Yellow;
            this.label_peakFrequency.Location = new System.Drawing.Point(4, 88);
            this.label_peakFrequency.Name = "label_peakFrequency";
            this.label_peakFrequency.Size = new System.Drawing.Size(104, 30);
            this.label_peakFrequency.TabIndex = 13;
            this.label_peakFrequency.Text = "PeakFreq";
            this.label_peakFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txCheckBox_rms
            // 
            this.txCheckBox_rms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txCheckBox_rms.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txCheckBox_rms.Location = new System.Drawing.Point(115, 4);
            this.txCheckBox_rms.MinimumSize = new System.Drawing.Size(20, 20);
            this.txCheckBox_rms.Name = "txCheckBox_rms";
            this.txCheckBox_rms.Size = new System.Drawing.Size(21, 22);
            this.txCheckBox_rms.TabIndex = 1;
            this.txCheckBox_rms.UseVisualStyleBackColor = false;
            this.txCheckBox_rms.CheckedChanged += new System.EventHandler(this.SelectMeasureType);
            // 
            // txCheckBox_DC
            // 
            this.txCheckBox_DC.Location = new System.Drawing.Point(115, 33);
            this.txCheckBox_DC.MinimumSize = new System.Drawing.Size(20, 20);
            this.txCheckBox_DC.Name = "txCheckBox_DC";
            this.txCheckBox_DC.Size = new System.Drawing.Size(21, 22);
            this.txCheckBox_DC.TabIndex = 2;
            this.txCheckBox_DC.UseVisualStyleBackColor = true;
            this.txCheckBox_DC.CheckedChanged += new System.EventHandler(this.SelectMeasureType);
            // 
            // txCheckBox_peakAmp
            // 
            this.txCheckBox_peakAmp.Location = new System.Drawing.Point(115, 62);
            this.txCheckBox_peakAmp.MinimumSize = new System.Drawing.Size(20, 20);
            this.txCheckBox_peakAmp.Name = "txCheckBox_peakAmp";
            this.txCheckBox_peakAmp.Size = new System.Drawing.Size(21, 22);
            this.txCheckBox_peakAmp.TabIndex = 3;
            this.txCheckBox_peakAmp.UseVisualStyleBackColor = true;
            this.txCheckBox_peakAmp.CheckedChanged += new System.EventHandler(this.SelectMeasureType);
            // 
            // txCheckBox_peakFreq
            // 
            this.txCheckBox_peakFreq.Location = new System.Drawing.Point(115, 91);
            this.txCheckBox_peakFreq.MinimumSize = new System.Drawing.Size(20, 20);
            this.txCheckBox_peakFreq.Name = "txCheckBox_peakFreq";
            this.txCheckBox_peakFreq.Size = new System.Drawing.Size(21, 24);
            this.txCheckBox_peakFreq.TabIndex = 4;
            this.txCheckBox_peakFreq.UseVisualStyleBackColor = true;
            this.txCheckBox_peakFreq.CheckedChanged += new System.EventHandler(this.SelectMeasureType);
            // 
            // panel_function
            // 
            this.panel_function.Controls.Add(this.panel_functionConfig);
            this.panel_function.Controls.Add(this.button_stopfunction);
            this.panel_function.Controls.Add(this.tableLayoutPanel_functionSelect);
            this.panel_function.Location = new System.Drawing.Point(0, 278);
            this.panel_function.Name = "panel_function";
            this.panel_function.Size = new System.Drawing.Size(144, 280);
            this.panel_function.TabIndex = 0;
            // 
            // panel_functionConfig
            // 
            this.panel_functionConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_functionConfig.Location = new System.Drawing.Point(0, 220);
            this.panel_functionConfig.Name = "panel_functionConfig";
            this.panel_functionConfig.Size = new System.Drawing.Size(144, 61);
            this.panel_functionConfig.TabIndex = 23;
            // 
            // button_stopfunction
            // 
            this.button_stopfunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_stopfunction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_stopfunction.FlatAppearance.BorderSize = 0;
            this.button_stopfunction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_stopfunction.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stopfunction.ForeColor = System.Drawing.Color.Silver;
            this.button_stopfunction.Location = new System.Drawing.Point(25, 190);
            this.button_stopfunction.Name = "button_stopfunction";
            this.button_stopfunction.Size = new System.Drawing.Size(93, 24);
            this.button_stopfunction.TabIndex = 22;
            this.button_stopfunction.Text = "STOP";
            this.button_stopfunction.UseVisualStyleBackColor = false;
            this.button_stopfunction.Click += new System.EventHandler(this.button_stopfunction_Click);
            // 
            // tableLayoutPanel_functionSelect
            // 
            this.tableLayoutPanel_functionSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_functionSelect.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_functionSelect.ColumnCount = 2;
            this.tableLayoutPanel_functionSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_functionSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel_functionSelect.Controls.Add(this.label_filter, 0, 3);
            this.tableLayoutPanel_functionSelect.Controls.Add(this.txRadioButton_filter, 1, 3);
            this.tableLayoutPanel_functionSelect.Controls.Add(this.label_toneAnalyze, 0, 2);
            this.tableLayoutPanel_functionSelect.Controls.Add(this.txRadioButton_toneAnalyze, 1, 2);
            this.tableLayoutPanel_functionSelect.Controls.Add(this.txRadioButton_harmonic, 1, 1);
            this.tableLayoutPanel_functionSelect.Controls.Add(this.label_harmonicFunction, 0, 1);
            this.tableLayoutPanel_functionSelect.Controls.Add(this.label_spectrumFunction, 0, 0);
            this.tableLayoutPanel_functionSelect.Controls.Add(this.txRadioButton_spectrum, 1, 0);
            this.tableLayoutPanel_functionSelect.Controls.Add(this.label_squareAnalyze, 0, 4);
            this.tableLayoutPanel_functionSelect.Controls.Add(this.txRadioButton_squareAnalyze, 1, 4);
            this.tableLayoutPanel_functionSelect.Controls.Add(this.label_phaseShift, 0, 5);
            this.tableLayoutPanel_functionSelect.Controls.Add(this.txRadioButton_phaseShift, 1, 5);
            this.tableLayoutPanel_functionSelect.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_functionSelect.Name = "tableLayoutPanel_functionSelect";
            this.tableLayoutPanel_functionSelect.RowCount = 6;
            this.tableLayoutPanel_functionSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6F));
            this.tableLayoutPanel_functionSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.7F));
            this.tableLayoutPanel_functionSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.7F));
            this.tableLayoutPanel_functionSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.7F));
            this.tableLayoutPanel_functionSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.7F));
            this.tableLayoutPanel_functionSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6F));
            this.tableLayoutPanel_functionSelect.Size = new System.Drawing.Size(140, 181);
            this.tableLayoutPanel_functionSelect.TabIndex = 8;
            // 
            // label_filter
            // 
            this.label_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_filter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_filter.ForeColor = System.Drawing.Color.Yellow;
            this.label_filter.Location = new System.Drawing.Point(4, 90);
            this.label_filter.Name = "label_filter";
            this.label_filter.Size = new System.Drawing.Size(103, 29);
            this.label_filter.TabIndex = 15;
            this.label_filter.Text = "Filter";
            this.label_filter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txRadioButton_filter
            // 
            this.txRadioButton_filter.Location = new System.Drawing.Point(114, 93);
            this.txRadioButton_filter.MaxRadius = 8;
            this.txRadioButton_filter.MinimumSize = new System.Drawing.Size(22, 22);
            this.txRadioButton_filter.MinRadius = 4;
            this.txRadioButton_filter.Name = "txRadioButton_filter";
            this.txRadioButton_filter.Size = new System.Drawing.Size(22, 23);
            this.txRadioButton_filter.TabIndex = 4;
            this.txRadioButton_filter.TabStop = true;
            this.txRadioButton_filter.UseVisualStyleBackColor = true;
            this.txRadioButton_filter.CheckedChanged += new System.EventHandler(this.SetFunctionType);
            // 
            // label_toneAnalyze
            // 
            this.label_toneAnalyze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_toneAnalyze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_toneAnalyze.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_toneAnalyze.ForeColor = System.Drawing.Color.Yellow;
            this.label_toneAnalyze.Location = new System.Drawing.Point(4, 60);
            this.label_toneAnalyze.Name = "label_toneAnalyze";
            this.label_toneAnalyze.Size = new System.Drawing.Size(103, 29);
            this.label_toneAnalyze.TabIndex = 13;
            this.label_toneAnalyze.Text = "Tone Analyze";
            this.label_toneAnalyze.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txRadioButton_toneAnalyze
            // 
            this.txRadioButton_toneAnalyze.Location = new System.Drawing.Point(114, 63);
            this.txRadioButton_toneAnalyze.MaxRadius = 8;
            this.txRadioButton_toneAnalyze.MinimumSize = new System.Drawing.Size(22, 22);
            this.txRadioButton_toneAnalyze.MinRadius = 4;
            this.txRadioButton_toneAnalyze.Name = "txRadioButton_toneAnalyze";
            this.txRadioButton_toneAnalyze.Size = new System.Drawing.Size(22, 23);
            this.txRadioButton_toneAnalyze.TabIndex = 3;
            this.txRadioButton_toneAnalyze.TabStop = true;
            this.txRadioButton_toneAnalyze.UseVisualStyleBackColor = true;
            this.txRadioButton_toneAnalyze.CheckedChanged += new System.EventHandler(this.SetFunctionType);
            // 
            // txRadioButton_harmonic
            // 
            this.txRadioButton_harmonic.Location = new System.Drawing.Point(114, 33);
            this.txRadioButton_harmonic.MaxRadius = 8;
            this.txRadioButton_harmonic.MinimumSize = new System.Drawing.Size(22, 22);
            this.txRadioButton_harmonic.MinRadius = 4;
            this.txRadioButton_harmonic.Name = "txRadioButton_harmonic";
            this.txRadioButton_harmonic.Size = new System.Drawing.Size(22, 23);
            this.txRadioButton_harmonic.TabIndex = 2;
            this.txRadioButton_harmonic.TabStop = true;
            this.txRadioButton_harmonic.UseVisualStyleBackColor = true;
            this.txRadioButton_harmonic.CheckedChanged += new System.EventHandler(this.SetFunctionType);
            // 
            // label_harmonicFunction
            // 
            this.label_harmonicFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_harmonicFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_harmonicFunction.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_harmonicFunction.ForeColor = System.Drawing.Color.Yellow;
            this.label_harmonicFunction.Location = new System.Drawing.Point(4, 30);
            this.label_harmonicFunction.Name = "label_harmonicFunction";
            this.label_harmonicFunction.Size = new System.Drawing.Size(103, 29);
            this.label_harmonicFunction.TabIndex = 9;
            this.label_harmonicFunction.Text = "Harmonic";
            this.label_harmonicFunction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_spectrumFunction
            // 
            this.label_spectrumFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_spectrumFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_spectrumFunction.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_spectrumFunction.ForeColor = System.Drawing.Color.Yellow;
            this.label_spectrumFunction.Location = new System.Drawing.Point(4, 1);
            this.label_spectrumFunction.Name = "label_spectrumFunction";
            this.label_spectrumFunction.Size = new System.Drawing.Size(103, 28);
            this.label_spectrumFunction.TabIndex = 8;
            this.label_spectrumFunction.Text = "Spectrum";
            this.label_spectrumFunction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txRadioButton_spectrum
            // 
            this.txRadioButton_spectrum.Location = new System.Drawing.Point(114, 4);
            this.txRadioButton_spectrum.MaxRadius = 8;
            this.txRadioButton_spectrum.MinimumSize = new System.Drawing.Size(22, 22);
            this.txRadioButton_spectrum.MinRadius = 4;
            this.txRadioButton_spectrum.Name = "txRadioButton_spectrum";
            this.txRadioButton_spectrum.Size = new System.Drawing.Size(22, 22);
            this.txRadioButton_spectrum.TabIndex = 1;
            this.txRadioButton_spectrum.TabStop = true;
            this.txRadioButton_spectrum.UseVisualStyleBackColor = true;
            this.txRadioButton_spectrum.CheckedChanged += new System.EventHandler(this.SetFunctionType);
            // 
            // label_squareAnalyze
            // 
            this.label_squareAnalyze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_squareAnalyze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_squareAnalyze.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_squareAnalyze.ForeColor = System.Drawing.Color.Yellow;
            this.label_squareAnalyze.Location = new System.Drawing.Point(4, 120);
            this.label_squareAnalyze.Name = "label_squareAnalyze";
            this.label_squareAnalyze.Size = new System.Drawing.Size(103, 29);
            this.label_squareAnalyze.TabIndex = 16;
            this.label_squareAnalyze.Text = "SqaureAnalyze";
            this.label_squareAnalyze.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txRadioButton_squareAnalyze
            // 
            this.txRadioButton_squareAnalyze.Location = new System.Drawing.Point(114, 123);
            this.txRadioButton_squareAnalyze.MaxRadius = 8;
            this.txRadioButton_squareAnalyze.MinimumSize = new System.Drawing.Size(22, 22);
            this.txRadioButton_squareAnalyze.MinRadius = 4;
            this.txRadioButton_squareAnalyze.Name = "txRadioButton_squareAnalyze";
            this.txRadioButton_squareAnalyze.Size = new System.Drawing.Size(22, 23);
            this.txRadioButton_squareAnalyze.TabIndex = 5;
            this.txRadioButton_squareAnalyze.TabStop = true;
            this.txRadioButton_squareAnalyze.UseVisualStyleBackColor = true;
            this.txRadioButton_squareAnalyze.CheckedChanged += new System.EventHandler(this.SetFunctionType);
            // 
            // label_phaseShift
            // 
            this.label_phaseShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_phaseShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_phaseShift.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phaseShift.ForeColor = System.Drawing.Color.Yellow;
            this.label_phaseShift.Location = new System.Drawing.Point(4, 150);
            this.label_phaseShift.Name = "label_phaseShift";
            this.label_phaseShift.Size = new System.Drawing.Size(103, 30);
            this.label_phaseShift.TabIndex = 18;
            this.label_phaseShift.Text = "PhaseShift";
            this.label_phaseShift.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txRadioButton_phaseShift
            // 
            this.txRadioButton_phaseShift.Location = new System.Drawing.Point(114, 153);
            this.txRadioButton_phaseShift.MaxRadius = 8;
            this.txRadioButton_phaseShift.MinimumSize = new System.Drawing.Size(22, 22);
            this.txRadioButton_phaseShift.MinRadius = 4;
            this.txRadioButton_phaseShift.Name = "txRadioButton_phaseShift";
            this.txRadioButton_phaseShift.Size = new System.Drawing.Size(22, 24);
            this.txRadioButton_phaseShift.TabIndex = 6;
            this.txRadioButton_phaseShift.TabStop = true;
            this.txRadioButton_phaseShift.UseVisualStyleBackColor = true;
            this.txRadioButton_phaseShift.CheckedChanged += new System.EventHandler(this.SetFunctionType);
            // 
            // splitContainer_viewAndConfig
            // 
            this.splitContainer_viewAndConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_viewAndConfig.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_viewAndConfig.IsSplitterFixed = true;
            this.splitContainer_viewAndConfig.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_viewAndConfig.Name = "splitContainer_viewAndConfig";
            // 
            // splitContainer_viewAndConfig.Panel1
            // 
            this.splitContainer_viewAndConfig.Panel1.Controls.Add(this.tableLayoutPanel_chartView);
            // 
            // splitContainer_viewAndConfig.Panel2
            // 
            this.splitContainer_viewAndConfig.Panel2.Controls.Add(this.splitContainer_channelAndCommon);
            this.splitContainer_viewAndConfig.Size = new System.Drawing.Size(1012, 563);
            this.splitContainer_viewAndConfig.SplitterDistance = 780;
            this.splitContainer_viewAndConfig.TabIndex = 0;
            // 
            // tableLayoutPanel_chartView
            // 
            this.tableLayoutPanel_chartView.AutoSize = true;
            this.tableLayoutPanel_chartView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_chartView.ColumnCount = 1;
            this.tableLayoutPanel_chartView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_chartView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_chartView.Controls.Add(this.splitContainer_plotArea, 0, 0);
            this.tableLayoutPanel_chartView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_chartView.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_chartView.Name = "tableLayoutPanel_chartView";
            this.tableLayoutPanel_chartView.RowCount = 1;
            this.tableLayoutPanel_chartView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_chartView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_chartView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 563F));
            this.tableLayoutPanel_chartView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 563F));
            this.tableLayoutPanel_chartView.Size = new System.Drawing.Size(780, 563);
            this.tableLayoutPanel_chartView.TabIndex = 0;
            // 
            // splitContainer_plotArea
            // 
            this.splitContainer_plotArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer_plotArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_plotArea.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_plotArea.Name = "splitContainer_plotArea";
            this.splitContainer_plotArea.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_plotArea.Panel1
            // 
            this.splitContainer_plotArea.Panel1.Controls.Add(this.easyChartX_data);
            // 
            // splitContainer_plotArea.Panel2
            // 
            this.splitContainer_plotArea.Panel2.Controls.Add(this.tableLayoutPanel_functionPanel);
            this.splitContainer_plotArea.Size = new System.Drawing.Size(774, 557);
            this.splitContainer_plotArea.SplitterDistance = 272;
            this.splitContainer_plotArea.TabIndex = 0;
            // 
            // easyChartX_data
            // 
            this.easyChartX_data.AutoClear = true;
            this.easyChartX_data.AxisX.AutoScale = true;
            this.easyChartX_data.AxisX.AutoZoomReset = false;
            this.easyChartX_data.AxisX.Color = System.Drawing.Color.DarkGray;
            this.easyChartX_data.AxisX.InitWithScaleView = false;
            this.easyChartX_data.AxisX.IsLogarithmic = false;
            this.easyChartX_data.AxisX.LabelAngle = 0;
            this.easyChartX_data.AxisX.LabelEnabled = true;
            this.easyChartX_data.AxisX.LabelFormat = "0.###ms";
            this.easyChartX_data.AxisX.MajorGridColor = System.Drawing.Color.DarkGray;
            this.easyChartX_data.AxisX.MajorGridCount = -1;
            this.easyChartX_data.AxisX.MajorGridEnabled = true;
            this.easyChartX_data.AxisX.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_data.AxisX.MaxGridCountPerPixel = 0.012D;
            this.easyChartX_data.AxisX.Maximum = 100D;
            this.easyChartX_data.AxisX.MinGridCountPerPixel = 0.004D;
            this.easyChartX_data.AxisX.Minimum = 0D;
            this.easyChartX_data.AxisX.MinorGridColor = System.Drawing.Color.DimGray;
            this.easyChartX_data.AxisX.MinorGridEnabled = true;
            this.easyChartX_data.AxisX.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDotDot;
            this.easyChartX_data.AxisX.TickWidth = 0.2F;
            this.easyChartX_data.AxisX.Title = "";
            this.easyChartX_data.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_data.AxisX.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_data.AxisX.ViewMaximum = 1000D;
            this.easyChartX_data.AxisX.ViewMinimum = 0D;
            this.easyChartX_data.AxisX2.AutoScale = true;
            this.easyChartX_data.AxisX2.AutoZoomReset = false;
            this.easyChartX_data.AxisX2.Color = System.Drawing.Color.Black;
            this.easyChartX_data.AxisX2.InitWithScaleView = false;
            this.easyChartX_data.AxisX2.IsLogarithmic = false;
            this.easyChartX_data.AxisX2.LabelAngle = 0;
            this.easyChartX_data.AxisX2.LabelEnabled = true;
            this.easyChartX_data.AxisX2.LabelFormat = null;
            this.easyChartX_data.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_data.AxisX2.MajorGridCount = -1;
            this.easyChartX_data.AxisX2.MajorGridEnabled = true;
            this.easyChartX_data.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Solid;
            this.easyChartX_data.AxisX2.MaxGridCountPerPixel = 0.012D;
            this.easyChartX_data.AxisX2.Maximum = 1000D;
            this.easyChartX_data.AxisX2.MinGridCountPerPixel = 0.004D;
            this.easyChartX_data.AxisX2.Minimum = 0D;
            this.easyChartX_data.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_data.AxisX2.MinorGridEnabled = false;
            this.easyChartX_data.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Solid;
            this.easyChartX_data.AxisX2.TickWidth = 1F;
            this.easyChartX_data.AxisX2.Title = "";
            this.easyChartX_data.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_data.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_data.AxisX2.ViewMaximum = 1000D;
            this.easyChartX_data.AxisX2.ViewMinimum = 0D;
            this.easyChartX_data.AxisY.AutoScale = false;
            this.easyChartX_data.AxisY.AutoZoomReset = false;
            this.easyChartX_data.AxisY.Color = System.Drawing.Color.DarkGray;
            this.easyChartX_data.AxisY.InitWithScaleView = false;
            this.easyChartX_data.AxisY.IsLogarithmic = false;
            this.easyChartX_data.AxisY.LabelAngle = 0;
            this.easyChartX_data.AxisY.LabelEnabled = true;
            this.easyChartX_data.AxisY.LabelFormat = "0.###";
            this.easyChartX_data.AxisY.MajorGridColor = System.Drawing.Color.DarkGray;
            this.easyChartX_data.AxisY.MajorGridCount = 6;
            this.easyChartX_data.AxisY.MajorGridEnabled = true;
            this.easyChartX_data.AxisY.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_data.AxisY.MaxGridCountPerPixel = 0.012D;
            this.easyChartX_data.AxisY.Maximum = 10D;
            this.easyChartX_data.AxisY.MinGridCountPerPixel = 0.004D;
            this.easyChartX_data.AxisY.Minimum = -10D;
            this.easyChartX_data.AxisY.MinorGridColor = System.Drawing.Color.DimGray;
            this.easyChartX_data.AxisY.MinorGridEnabled = true;
            this.easyChartX_data.AxisY.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDotDot;
            this.easyChartX_data.AxisY.TickWidth = 0.2F;
            this.easyChartX_data.AxisY.Title = "";
            this.easyChartX_data.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_data.AxisY.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_data.AxisY.ViewMaximum = 3.5D;
            this.easyChartX_data.AxisY.ViewMinimum = 0D;
            this.easyChartX_data.AxisY2.AutoScale = true;
            this.easyChartX_data.AxisY2.AutoZoomReset = false;
            this.easyChartX_data.AxisY2.Color = System.Drawing.Color.Black;
            this.easyChartX_data.AxisY2.InitWithScaleView = false;
            this.easyChartX_data.AxisY2.IsLogarithmic = false;
            this.easyChartX_data.AxisY2.LabelAngle = 0;
            this.easyChartX_data.AxisY2.LabelEnabled = true;
            this.easyChartX_data.AxisY2.LabelFormat = null;
            this.easyChartX_data.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_data.AxisY2.MajorGridCount = 6;
            this.easyChartX_data.AxisY2.MajorGridEnabled = true;
            this.easyChartX_data.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Solid;
            this.easyChartX_data.AxisY2.MaxGridCountPerPixel = 0.012D;
            this.easyChartX_data.AxisY2.Maximum = 3.5D;
            this.easyChartX_data.AxisY2.MinGridCountPerPixel = 0.004D;
            this.easyChartX_data.AxisY2.Minimum = 0D;
            this.easyChartX_data.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_data.AxisY2.MinorGridEnabled = false;
            this.easyChartX_data.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Solid;
            this.easyChartX_data.AxisY2.TickWidth = 1F;
            this.easyChartX_data.AxisY2.Title = "";
            this.easyChartX_data.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_data.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_data.AxisY2.ViewMaximum = 3.5D;
            this.easyChartX_data.AxisY2.ViewMinimum = 0D;
            this.easyChartX_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.easyChartX_data.ChartAreaBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.easyChartX_data.Cumulitive = false;
            this.easyChartX_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easyChartX_data.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyChartX_data.ForeColor = System.Drawing.Color.Silver;
            this.easyChartX_data.GradientStyle = SeeSharpTools.JY.GUI.EasyChartX.ChartGradientStyle.None;
            this.easyChartX_data.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartX_data.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.easyChartX_data.LegendForeColor = System.Drawing.Color.Black;
            this.easyChartX_data.LegendVisible = false;
            easyChartXSeries33.Color = System.Drawing.Color.Yellow;
            easyChartXSeries33.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries33.Name = "CH1";
            easyChartXSeries33.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries33.Visible = true;
            easyChartXSeries33.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries33.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries33.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries34.Color = System.Drawing.Color.Cyan;
            easyChartXSeries34.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries34.Name = "CH2";
            easyChartXSeries34.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries34.Visible = false;
            easyChartXSeries34.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries34.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries34.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries35.Color = System.Drawing.Color.DarkOrange;
            easyChartXSeries35.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries35.Name = "CH3";
            easyChartXSeries35.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries35.Visible = false;
            easyChartXSeries35.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries35.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries35.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries36.Color = System.Drawing.Color.PaleVioletRed;
            easyChartXSeries36.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries36.Name = "CH4";
            easyChartXSeries36.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries36.Visible = false;
            easyChartXSeries36.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries36.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries36.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries37.Color = System.Drawing.Color.BlueViolet;
            easyChartXSeries37.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries37.Name = "CH5";
            easyChartXSeries37.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries37.Visible = false;
            easyChartXSeries37.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries37.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries37.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries38.Color = System.Drawing.Color.Blue;
            easyChartXSeries38.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries38.Name = "CH6";
            easyChartXSeries38.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries38.Visible = false;
            easyChartXSeries38.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries38.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries38.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries39.Color = System.Drawing.Color.LimeGreen;
            easyChartXSeries39.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries39.Name = "CH7";
            easyChartXSeries39.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries39.Visible = false;
            easyChartXSeries39.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries39.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries39.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries40.Color = System.Drawing.Color.Magenta;
            easyChartXSeries40.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries40.Name = "CH8";
            easyChartXSeries40.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries40.Visible = false;
            easyChartXSeries40.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries40.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries40.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            this.easyChartX_data.LineSeries.Add(easyChartXSeries33);
            this.easyChartX_data.LineSeries.Add(easyChartXSeries34);
            this.easyChartX_data.LineSeries.Add(easyChartXSeries35);
            this.easyChartX_data.LineSeries.Add(easyChartXSeries36);
            this.easyChartX_data.LineSeries.Add(easyChartXSeries37);
            this.easyChartX_data.LineSeries.Add(easyChartXSeries38);
            this.easyChartX_data.LineSeries.Add(easyChartXSeries39);
            this.easyChartX_data.LineSeries.Add(easyChartXSeries40);
            this.easyChartX_data.Location = new System.Drawing.Point(0, 0);
            this.easyChartX_data.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.easyChartX_data.Miscellaneous.CheckInfinity = false;
            this.easyChartX_data.Miscellaneous.CheckNaN = false;
            this.easyChartX_data.Miscellaneous.CheckNegtiveOrZero = false;
            this.easyChartX_data.Miscellaneous.DataStorage = SeeSharpTools.JY.GUI.DataStorageType.NoClone;
            this.easyChartX_data.Miscellaneous.DirectionChartCount = 3;
            this.easyChartX_data.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.EasyChartX.FitType.Range;
            this.easyChartX_data.Miscellaneous.MarkerSize = 7;
            this.easyChartX_data.Miscellaneous.MaxSeriesCount = 32;
            this.easyChartX_data.Miscellaneous.MaxSeriesPointCount = 4000;
            this.easyChartX_data.Miscellaneous.ShowFunctionMenu = false;
            this.easyChartX_data.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.easyChartX_data.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.EasyChartXUtility.LayoutDirection.LeftToRight;
            this.easyChartX_data.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.easyChartX_data.Miscellaneous.SplitViewAutoLayout = true;
            this.easyChartX_data.Name = "easyChartX_data";
            this.easyChartX_data.SeriesCount = 0;
            this.easyChartX_data.Size = new System.Drawing.Size(772, 270);
            this.easyChartX_data.SplitView = false;
            this.easyChartX_data.TabIndex = 0;
            this.easyChartX_data.XCursor.AutoInterval = true;
            this.easyChartX_data.XCursor.Color = System.Drawing.Color.Red;
            this.easyChartX_data.XCursor.Interval = 0.001D;
            this.easyChartX_data.XCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Zoom;
            this.easyChartX_data.XCursor.SelectionColor = System.Drawing.Color.Lime;
            this.easyChartX_data.XCursor.Value = double.NaN;
            this.easyChartX_data.YCursor.AutoInterval = true;
            this.easyChartX_data.YCursor.Color = System.Drawing.Color.Red;
            this.easyChartX_data.YCursor.Interval = 0.001D;
            this.easyChartX_data.YCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Disabled;
            this.easyChartX_data.YCursor.SelectionColor = System.Drawing.Color.Lime;
            this.easyChartX_data.YCursor.Value = double.NaN;
            this.easyChartX_data.AxisViewChanged += new SeeSharpTools.JY.GUI.EasyChartX.ViewEvents(this.easyChartX_data_AxisViewChanged);
            // 
            // tableLayoutPanel_functionPanel
            // 
            this.tableLayoutPanel_functionPanel.ColumnCount = 1;
            this.tableLayoutPanel_functionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_functionPanel.Controls.Add(this.tableLayoutPanel_functionValues, 0, 1);
            this.tableLayoutPanel_functionPanel.Controls.Add(this.splitContainer_functionDataAndDetail, 0, 0);
            this.tableLayoutPanel_functionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_functionPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_functionPanel.Name = "tableLayoutPanel_functionPanel";
            this.tableLayoutPanel_functionPanel.RowCount = 2;
            this.tableLayoutPanel_functionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_functionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_functionPanel.Size = new System.Drawing.Size(772, 279);
            this.tableLayoutPanel_functionPanel.TabIndex = 0;
            // 
            // tableLayoutPanel_functionValues
            // 
            this.tableLayoutPanel_functionValues.ColumnCount = 2;
            this.tableLayoutPanel_functionValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_functionValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_functionValues.Controls.Add(this.label_YValueLabel, 0, 0);
            this.tableLayoutPanel_functionValues.Controls.Add(this.label_XValueLabel, 0, 0);
            this.tableLayoutPanel_functionValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_functionValues.Location = new System.Drawing.Point(3, 252);
            this.tableLayoutPanel_functionValues.Name = "tableLayoutPanel_functionValues";
            this.tableLayoutPanel_functionValues.RowCount = 1;
            this.tableLayoutPanel_functionValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_functionValues.Size = new System.Drawing.Size(791, 24);
            this.tableLayoutPanel_functionValues.TabIndex = 4;
            // 
            // label_YValueLabel
            // 
            this.label_YValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_YValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_YValueLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_YValueLabel.ForeColor = System.Drawing.Color.Silver;
            this.label_YValueLabel.Location = new System.Drawing.Point(398, 0);
            this.label_YValueLabel.Name = "label_YValueLabel";
            this.label_YValueLabel.Size = new System.Drawing.Size(390, 24);
            this.label_YValueLabel.TabIndex = 13;
            this.label_YValueLabel.Text = "YValueFormat";
            this.label_YValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_XValueLabel
            // 
            this.label_XValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_XValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_XValueLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_XValueLabel.ForeColor = System.Drawing.Color.Silver;
            this.label_XValueLabel.Location = new System.Drawing.Point(3, 0);
            this.label_XValueLabel.Name = "label_XValueLabel";
            this.label_XValueLabel.Size = new System.Drawing.Size(389, 24);
            this.label_XValueLabel.TabIndex = 12;
            this.label_XValueLabel.Text = "XValueFormat";
            this.label_XValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer_functionDataAndDetail
            // 
            this.splitContainer_functionDataAndDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer_functionDataAndDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_functionDataAndDetail.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_functionDataAndDetail.Name = "splitContainer_functionDataAndDetail";
            // 
            // splitContainer_functionDataAndDetail.Panel1
            // 
            this.splitContainer_functionDataAndDetail.Panel1.Controls.Add(this.easyChartX_function);
            // 
            // splitContainer_functionDataAndDetail.Panel2
            // 
            this.splitContainer_functionDataAndDetail.Panel2.Controls.Add(this.dataGridView_functionDetail);
            this.splitContainer_functionDataAndDetail.Size = new System.Drawing.Size(791, 243);
            this.splitContainer_functionDataAndDetail.SplitterDistance = 475;
            this.splitContainer_functionDataAndDetail.TabIndex = 5;
            // 
            // easyChartX_function
            // 
            this.easyChartX_function.AutoClear = true;
            this.easyChartX_function.AxisX.AutoScale = true;
            this.easyChartX_function.AxisX.AutoZoomReset = false;
            this.easyChartX_function.AxisX.Color = System.Drawing.Color.DarkGray;
            this.easyChartX_function.AxisX.InitWithScaleView = true;
            this.easyChartX_function.AxisX.IsLogarithmic = false;
            this.easyChartX_function.AxisX.LabelAngle = 0;
            this.easyChartX_function.AxisX.LabelEnabled = true;
            this.easyChartX_function.AxisX.LabelFormat = "0.#";
            this.easyChartX_function.AxisX.MajorGridColor = System.Drawing.Color.DarkGray;
            this.easyChartX_function.AxisX.MajorGridCount = -1;
            this.easyChartX_function.AxisX.MajorGridEnabled = true;
            this.easyChartX_function.AxisX.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_function.AxisX.MaxGridCountPerPixel = 0.012D;
            this.easyChartX_function.AxisX.Maximum = 1000D;
            this.easyChartX_function.AxisX.MinGridCountPerPixel = 0.004D;
            this.easyChartX_function.AxisX.Minimum = 0D;
            this.easyChartX_function.AxisX.MinorGridColor = System.Drawing.Color.DimGray;
            this.easyChartX_function.AxisX.MinorGridEnabled = true;
            this.easyChartX_function.AxisX.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDotDot;
            this.easyChartX_function.AxisX.TickWidth = 1F;
            this.easyChartX_function.AxisX.Title = "XAxisTitle";
            this.easyChartX_function.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_function.AxisX.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_function.AxisX.ViewMaximum = 10000D;
            this.easyChartX_function.AxisX.ViewMinimum = 0D;
            this.easyChartX_function.AxisX2.AutoScale = true;
            this.easyChartX_function.AxisX2.AutoZoomReset = false;
            this.easyChartX_function.AxisX2.Color = System.Drawing.Color.Black;
            this.easyChartX_function.AxisX2.InitWithScaleView = false;
            this.easyChartX_function.AxisX2.IsLogarithmic = false;
            this.easyChartX_function.AxisX2.LabelAngle = 0;
            this.easyChartX_function.AxisX2.LabelEnabled = true;
            this.easyChartX_function.AxisX2.LabelFormat = null;
            this.easyChartX_function.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_function.AxisX2.MajorGridCount = -1;
            this.easyChartX_function.AxisX2.MajorGridEnabled = true;
            this.easyChartX_function.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Solid;
            this.easyChartX_function.AxisX2.MaxGridCountPerPixel = 0.012D;
            this.easyChartX_function.AxisX2.Maximum = 1000D;
            this.easyChartX_function.AxisX2.MinGridCountPerPixel = 0.004D;
            this.easyChartX_function.AxisX2.Minimum = 0D;
            this.easyChartX_function.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_function.AxisX2.MinorGridEnabled = false;
            this.easyChartX_function.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Solid;
            this.easyChartX_function.AxisX2.TickWidth = 1F;
            this.easyChartX_function.AxisX2.Title = "";
            this.easyChartX_function.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_function.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_function.AxisX2.ViewMaximum = 1000D;
            this.easyChartX_function.AxisX2.ViewMinimum = 0D;
            this.easyChartX_function.AxisY.AutoScale = true;
            this.easyChartX_function.AxisY.AutoZoomReset = false;
            this.easyChartX_function.AxisY.Color = System.Drawing.Color.DarkGray;
            this.easyChartX_function.AxisY.InitWithScaleView = false;
            this.easyChartX_function.AxisY.IsLogarithmic = false;
            this.easyChartX_function.AxisY.LabelAngle = 0;
            this.easyChartX_function.AxisY.LabelEnabled = true;
            this.easyChartX_function.AxisY.LabelFormat = null;
            this.easyChartX_function.AxisY.MajorGridColor = System.Drawing.Color.DarkGray;
            this.easyChartX_function.AxisY.MajorGridCount = 6;
            this.easyChartX_function.AxisY.MajorGridEnabled = true;
            this.easyChartX_function.AxisY.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_function.AxisY.MaxGridCountPerPixel = 0.012D;
            this.easyChartX_function.AxisY.Maximum = 3.5D;
            this.easyChartX_function.AxisY.MinGridCountPerPixel = 0.004D;
            this.easyChartX_function.AxisY.Minimum = 0D;
            this.easyChartX_function.AxisY.MinorGridColor = System.Drawing.Color.DimGray;
            this.easyChartX_function.AxisY.MinorGridEnabled = true;
            this.easyChartX_function.AxisY.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDotDot;
            this.easyChartX_function.AxisY.TickWidth = 1F;
            this.easyChartX_function.AxisY.Title = "YAxisTitle";
            this.easyChartX_function.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_function.AxisY.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_function.AxisY.ViewMaximum = 3.5D;
            this.easyChartX_function.AxisY.ViewMinimum = 0D;
            this.easyChartX_function.AxisY2.AutoScale = true;
            this.easyChartX_function.AxisY2.AutoZoomReset = false;
            this.easyChartX_function.AxisY2.Color = System.Drawing.Color.Black;
            this.easyChartX_function.AxisY2.InitWithScaleView = false;
            this.easyChartX_function.AxisY2.IsLogarithmic = false;
            this.easyChartX_function.AxisY2.LabelAngle = 0;
            this.easyChartX_function.AxisY2.LabelEnabled = true;
            this.easyChartX_function.AxisY2.LabelFormat = null;
            this.easyChartX_function.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_function.AxisY2.MajorGridCount = 6;
            this.easyChartX_function.AxisY2.MajorGridEnabled = true;
            this.easyChartX_function.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Solid;
            this.easyChartX_function.AxisY2.MaxGridCountPerPixel = 0.012D;
            this.easyChartX_function.AxisY2.Maximum = 3.5D;
            this.easyChartX_function.AxisY2.MinGridCountPerPixel = 0.004D;
            this.easyChartX_function.AxisY2.Minimum = 0D;
            this.easyChartX_function.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_function.AxisY2.MinorGridEnabled = false;
            this.easyChartX_function.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Solid;
            this.easyChartX_function.AxisY2.TickWidth = 1F;
            this.easyChartX_function.AxisY2.Title = "";
            this.easyChartX_function.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_function.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_function.AxisY2.ViewMaximum = 3.5D;
            this.easyChartX_function.AxisY2.ViewMinimum = 0D;
            this.easyChartX_function.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.easyChartX_function.ChartAreaBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.easyChartX_function.Cumulitive = false;
            this.easyChartX_function.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easyChartX_function.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyChartX_function.ForeColor = System.Drawing.Color.Silver;
            this.easyChartX_function.GradientStyle = SeeSharpTools.JY.GUI.EasyChartX.ChartGradientStyle.None;
            this.easyChartX_function.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartX_function.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.easyChartX_function.LegendForeColor = System.Drawing.Color.Black;
            this.easyChartX_function.LegendVisible = false;
            easyChartXSeries41.Color = System.Drawing.Color.Yellow;
            easyChartXSeries41.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries41.Name = "CH1";
            easyChartXSeries41.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries41.Visible = true;
            easyChartXSeries41.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries41.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries41.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries42.Color = System.Drawing.Color.Cyan;
            easyChartXSeries42.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries42.Name = "CH2";
            easyChartXSeries42.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries42.Visible = false;
            easyChartXSeries42.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries42.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries42.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries43.Color = System.Drawing.Color.DarkOrange;
            easyChartXSeries43.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries43.Name = "CH3";
            easyChartXSeries43.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries43.Visible = false;
            easyChartXSeries43.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries43.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries43.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries44.Color = System.Drawing.Color.PaleVioletRed;
            easyChartXSeries44.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries44.Name = "CH4";
            easyChartXSeries44.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries44.Visible = false;
            easyChartXSeries44.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries44.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries44.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries45.Color = System.Drawing.Color.BlueViolet;
            easyChartXSeries45.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries45.Name = "CH5";
            easyChartXSeries45.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries45.Visible = false;
            easyChartXSeries45.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries45.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries45.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries46.Color = System.Drawing.Color.Blue;
            easyChartXSeries46.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries46.Name = "CH6";
            easyChartXSeries46.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries46.Visible = false;
            easyChartXSeries46.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries46.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries46.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries47.Color = System.Drawing.Color.LimeGreen;
            easyChartXSeries47.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries47.Name = "CH7";
            easyChartXSeries47.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries47.Visible = false;
            easyChartXSeries47.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries47.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries47.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries48.Color = System.Drawing.Color.Magenta;
            easyChartXSeries48.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries48.Name = "CH8";
            easyChartXSeries48.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries48.Visible = false;
            easyChartXSeries48.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries48.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries48.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            this.easyChartX_function.LineSeries.Add(easyChartXSeries41);
            this.easyChartX_function.LineSeries.Add(easyChartXSeries42);
            this.easyChartX_function.LineSeries.Add(easyChartXSeries43);
            this.easyChartX_function.LineSeries.Add(easyChartXSeries44);
            this.easyChartX_function.LineSeries.Add(easyChartXSeries45);
            this.easyChartX_function.LineSeries.Add(easyChartXSeries46);
            this.easyChartX_function.LineSeries.Add(easyChartXSeries47);
            this.easyChartX_function.LineSeries.Add(easyChartXSeries48);
            this.easyChartX_function.Location = new System.Drawing.Point(0, 0);
            this.easyChartX_function.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.easyChartX_function.Miscellaneous.CheckInfinity = true;
            this.easyChartX_function.Miscellaneous.CheckNaN = false;
            this.easyChartX_function.Miscellaneous.CheckNegtiveOrZero = false;
            this.easyChartX_function.Miscellaneous.DataStorage = SeeSharpTools.JY.GUI.DataStorageType.Clone;
            this.easyChartX_function.Miscellaneous.DirectionChartCount = 3;
            this.easyChartX_function.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.EasyChartX.FitType.Range;
            this.easyChartX_function.Miscellaneous.MarkerSize = 7;
            this.easyChartX_function.Miscellaneous.MaxSeriesCount = 32;
            this.easyChartX_function.Miscellaneous.MaxSeriesPointCount = 4000;
            this.easyChartX_function.Miscellaneous.ShowFunctionMenu = true;
            this.easyChartX_function.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.easyChartX_function.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.EasyChartXUtility.LayoutDirection.LeftToRight;
            this.easyChartX_function.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.easyChartX_function.Miscellaneous.SplitViewAutoLayout = true;
            this.easyChartX_function.Name = "easyChartX_function";
            this.easyChartX_function.SeriesCount = 0;
            this.easyChartX_function.Size = new System.Drawing.Size(473, 241);
            this.easyChartX_function.SplitView = false;
            this.easyChartX_function.TabIndex = 4;
            this.easyChartX_function.XCursor.AutoInterval = true;
            this.easyChartX_function.XCursor.Color = System.Drawing.Color.Red;
            this.easyChartX_function.XCursor.Interval = 0.001D;
            this.easyChartX_function.XCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Cursor;
            this.easyChartX_function.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX_function.XCursor.Value = double.NaN;
            this.easyChartX_function.YCursor.AutoInterval = true;
            this.easyChartX_function.YCursor.Color = System.Drawing.Color.Red;
            this.easyChartX_function.YCursor.Interval = 0.001D;
            this.easyChartX_function.YCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Cursor;
            this.easyChartX_function.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX_function.YCursor.Value = double.NaN;
            this.easyChartX_function.CursorPositionChanged += new SeeSharpTools.JY.GUI.EasyChartX.CursorEvents(this.easyChartX_function_CursorPositionChanged);
            // 
            // dataGridView_functionDetail
            // 
            this.dataGridView_functionDetail.AllowUserToAddRows = false;
            this.dataGridView_functionDetail.AllowUserToDeleteRows = false;
            this.dataGridView_functionDetail.AllowUserToResizeRows = false;
            this.dataGridView_functionDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView_functionDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_functionDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView_functionDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_functionDetail.ColumnHeadersVisible = false;
            this.dataGridView_functionDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Parameter,
            this.Column_Value});
            this.dataGridView_functionDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_functionDetail.EnableHeadersVisualStyles = false;
            this.dataGridView_functionDetail.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_functionDetail.Name = "dataGridView_functionDetail";
            this.dataGridView_functionDetail.ReadOnly = true;
            this.dataGridView_functionDetail.RowHeadersVisible = false;
            this.dataGridView_functionDetail.RowTemplate.Height = 23;
            this.dataGridView_functionDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_functionDetail.Size = new System.Drawing.Size(310, 241);
            this.dataGridView_functionDetail.TabIndex = 0;
            // 
            // Column_Parameter
            // 
            this.Column_Parameter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Silver;
            this.Column_Parameter.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column_Parameter.HeaderText = "Parameter Name";
            this.Column_Parameter.Name = "Column_Parameter";
            this.Column_Parameter.ReadOnly = true;
            this.Column_Parameter.Width = 140;
            // 
            // Column_Value
            // 
            this.Column_Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Silver;
            this.Column_Value.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column_Value.HeaderText = "Value";
            this.Column_Value.Name = "Column_Value";
            this.Column_Value.ReadOnly = true;
            // 
            // splitContainer_channelAndCommon
            // 
            this.splitContainer_channelAndCommon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer_channelAndCommon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_channelAndCommon.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_channelAndCommon.Name = "splitContainer_channelAndCommon";
            this.splitContainer_channelAndCommon.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_channelAndCommon.Panel1
            // 
            this.splitContainer_channelAndCommon.Panel1.Controls.Add(this.txTabControl_channel);
            // 
            // splitContainer_channelAndCommon.Panel2
            // 
            this.splitContainer_channelAndCommon.Panel2.Controls.Add(this.panel_commonConfig);
            this.splitContainer_channelAndCommon.Panel2MinSize = 200;
            this.splitContainer_channelAndCommon.Size = new System.Drawing.Size(228, 563);
            this.splitContainer_channelAndCommon.SplitterDistance = 224;
            this.splitContainer_channelAndCommon.TabIndex = 0;
            // 
            // txTabControl_channel
            // 
            this.txTabControl_channel.BaseTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txTabControl_channel.BorderColor = System.Drawing.Color.Gray;
            this.txTabControl_channel.CaptionFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTabControl_channel.CaptionForceColor = System.Drawing.Color.WhiteSmoke;
            this.txTabControl_channel.CheckedTabColor = System.Drawing.Color.DarkTurquoise;
            this.txTabControl_channel.Controls.Add(this.tabPagech1);
            this.txTabControl_channel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txTabControl_channel.HeightLightTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTabControl_channel.Location = new System.Drawing.Point(0, 0);
            this.txTabControl_channel.Name = "txTabControl_channel";
            this.txTabControl_channel.SelectedIndex = 0;
            this.txTabControl_channel.Size = new System.Drawing.Size(226, 222);
            this.txTabControl_channel.TabCornerRadius = 3;
            this.txTabControl_channel.TabIndex = 2;
            // 
            // tabPagech1
            // 
            this.tabPagech1.Controls.Add(this.metroComboBox_unit);
            this.tabPagech1.Controls.Add(this.metroComboBox_coupling);
            this.tabPagech1.Controls.Add(this.label_Coupling);
            this.tabPagech1.Controls.Add(this.metroComboBox_probe);
            this.tabPagech1.Controls.Add(this.label_probe);
            this.tabPagech1.Controls.Add(this.label_Unit);
            this.tabPagech1.Location = new System.Drawing.Point(4, 29);
            this.tabPagech1.Name = "tabPagech1";
            this.tabPagech1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagech1.Size = new System.Drawing.Size(218, 189);
            this.tabPagech1.TabIndex = 0;
            this.tabPagech1.Text = "CH1";
            this.tabPagech1.UseVisualStyleBackColor = true;
            // 
            // metroComboBox_unit
            // 
            this.metroComboBox_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroComboBox_unit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_unit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox_unit.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox_unit.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox_unit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.metroComboBox_unit.FormattingEnabled = true;
            this.metroComboBox_unit.ItemHeight = 19;
            this.metroComboBox_unit.Location = new System.Drawing.Point(90, 90);
            this.metroComboBox_unit.Name = "metroComboBox_unit";
            this.metroComboBox_unit.Size = new System.Drawing.Size(106, 25);
            this.metroComboBox_unit.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox_unit.StyleManager = null;
            this.metroComboBox_unit.TabIndex = 12;
            this.metroComboBox_unit.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroComboBox_coupling
            // 
            this.metroComboBox_coupling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroComboBox_coupling.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_coupling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_coupling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox_coupling.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox_coupling.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox_coupling.ForeColor = System.Drawing.SystemColors.WindowText;
            this.metroComboBox_coupling.FormattingEnabled = true;
            this.metroComboBox_coupling.ItemHeight = 19;
            this.metroComboBox_coupling.Location = new System.Drawing.Point(90, 55);
            this.metroComboBox_coupling.Name = "metroComboBox_coupling";
            this.metroComboBox_coupling.Size = new System.Drawing.Size(106, 25);
            this.metroComboBox_coupling.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox_coupling.StyleManager = null;
            this.metroComboBox_coupling.TabIndex = 11;
            this.metroComboBox_coupling.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_Coupling
            // 
            this.label_Coupling.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Coupling.ForeColor = System.Drawing.Color.Silver;
            this.label_Coupling.Location = new System.Drawing.Point(17, 57);
            this.label_Coupling.Name = "label_Coupling";
            this.label_Coupling.Size = new System.Drawing.Size(67, 20);
            this.label_Coupling.TabIndex = 5;
            this.label_Coupling.Text = "Coupling:";
            this.label_Coupling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroComboBox_probe
            // 
            this.metroComboBox_probe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroComboBox_probe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_probe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_probe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox_probe.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox_probe.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox_probe.ForeColor = System.Drawing.SystemColors.Info;
            this.metroComboBox_probe.FormattingEnabled = true;
            this.metroComboBox_probe.ItemHeight = 19;
            this.metroComboBox_probe.Items.AddRange(new object[] {
            "123",
            "456"});
            this.metroComboBox_probe.Location = new System.Drawing.Point(90, 19);
            this.metroComboBox_probe.Name = "metroComboBox_probe";
            this.metroComboBox_probe.Size = new System.Drawing.Size(106, 25);
            this.metroComboBox_probe.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox_probe.StyleManager = null;
            this.metroComboBox_probe.TabIndex = 0;
            this.metroComboBox_probe.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_probe
            // 
            this.label_probe.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_probe.ForeColor = System.Drawing.Color.Silver;
            this.label_probe.Location = new System.Drawing.Point(17, 21);
            this.label_probe.Name = "label_probe";
            this.label_probe.Size = new System.Drawing.Size(67, 20);
            this.label_probe.TabIndex = 7;
            this.label_probe.Text = "Probe:";
            this.label_probe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Unit
            // 
            this.label_Unit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Unit.ForeColor = System.Drawing.Color.Silver;
            this.label_Unit.Location = new System.Drawing.Point(17, 92);
            this.label_Unit.Name = "label_Unit";
            this.label_Unit.Size = new System.Drawing.Size(67, 20);
            this.label_Unit.TabIndex = 9;
            this.label_Unit.Text = "Unit:";
            this.label_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_commonConfig
            // 
            this.panel_commonConfig.Controls.Add(this.button_sendSoftTrigger);
            this.panel_commonConfig.Controls.Add(this.button_triggerConfig);
            this.panel_commonConfig.Controls.Add(this.numericUpDown_chartRange);
            this.panel_commonConfig.Controls.Add(this.label_chartRange);
            this.panel_commonConfig.Controls.Add(this.knobControl_chartRange);
            this.panel_commonConfig.Controls.Add(this.numericUpDown_viewTime);
            this.panel_commonConfig.Controls.Add(this.label_viewTime);
            this.panel_commonConfig.Controls.Add(this.knobControl_viewTime);
            this.panel_commonConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_commonConfig.Location = new System.Drawing.Point(0, 0);
            this.panel_commonConfig.Name = "panel_commonConfig";
            this.panel_commonConfig.Size = new System.Drawing.Size(226, 333);
            this.panel_commonConfig.TabIndex = 0;
            // 
            // button_sendSoftTrigger
            // 
            this.button_sendSoftTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_sendSoftTrigger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_sendSoftTrigger.FlatAppearance.BorderSize = 0;
            this.button_sendSoftTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sendSoftTrigger.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sendSoftTrigger.ForeColor = System.Drawing.Color.Silver;
            this.button_sendSoftTrigger.Location = new System.Drawing.Point(33, 302);
            this.button_sendSoftTrigger.Name = "button_sendSoftTrigger";
            this.button_sendSoftTrigger.Size = new System.Drawing.Size(163, 24);
            this.button_sendSoftTrigger.TabIndex = 22;
            this.button_sendSoftTrigger.Text = "SEND SOFT TRIGGER";
            this.button_sendSoftTrigger.UseVisualStyleBackColor = false;
            this.button_sendSoftTrigger.Click += new System.EventHandler(this.button_sendSoftTrigger_Click);
            // 
            // button_triggerConfig
            // 
            this.button_triggerConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_triggerConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_triggerConfig.FlatAppearance.BorderSize = 0;
            this.button_triggerConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_triggerConfig.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_triggerConfig.ForeColor = System.Drawing.Color.Silver;
            this.button_triggerConfig.Location = new System.Drawing.Point(33, 272);
            this.button_triggerConfig.Name = "button_triggerConfig";
            this.button_triggerConfig.Size = new System.Drawing.Size(163, 24);
            this.button_triggerConfig.TabIndex = 21;
            this.button_triggerConfig.Text = "TRIGGER";
            this.button_triggerConfig.UseVisualStyleBackColor = false;
            this.button_triggerConfig.Click += new System.EventHandler(this.button_triggerConfig_Click);
            // 
            // numericUpDown_chartRange
            // 
            this.numericUpDown_chartRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown_chartRange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_chartRange.DecimalPlaces = 1;
            this.numericUpDown_chartRange.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_chartRange.ForeColor = System.Drawing.Color.Silver;
            this.numericUpDown_chartRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_chartRange.Location = new System.Drawing.Point(13, 238);
            this.numericUpDown_chartRange.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_chartRange.Name = "numericUpDown_chartRange";
            this.numericUpDown_chartRange.Size = new System.Drawing.Size(56, 18);
            this.numericUpDown_chartRange.TabIndex = 20;
            this.numericUpDown_chartRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_chartRange.ThousandsSeparator = true;
            this.numericUpDown_chartRange.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_chartRange.ValueChanged += new System.EventHandler(this.numericUpDown_chartRange_ValueChanged);
            // 
            // label_chartRange
            // 
            this.label_chartRange.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chartRange.ForeColor = System.Drawing.Color.Silver;
            this.label_chartRange.Location = new System.Drawing.Point(20, 147);
            this.label_chartRange.Name = "label_chartRange";
            this.label_chartRange.Size = new System.Drawing.Size(68, 20);
            this.label_chartRange.TabIndex = 19;
            this.label_chartRange.Text = "Range:";
            this.label_chartRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // knobControl_chartRange
            // 
            this.knobControl_chartRange.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knobControl_chartRange.ForeColor = System.Drawing.Color.Silver;
            this.knobControl_chartRange.ImeMode = System.Windows.Forms.ImeMode.On;
            this.knobControl_chartRange.IsTextShow = true;
            this.knobControl_chartRange.KnobColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.knobControl_chartRange.Location = new System.Drawing.Point(61, 147);
            this.knobControl_chartRange.Max = 50D;
            this.knobControl_chartRange.Min = 0D;
            this.knobControl_chartRange.Name = "knobControl_chartRange";
            this.knobControl_chartRange.Size = new System.Drawing.Size(150, 150);
            this.knobControl_chartRange.TabIndex = 18;
            this.knobControl_chartRange.TextDecimals = 3;
            this.knobControl_chartRange.TickWidth = 5;
            this.knobControl_chartRange.Value = 10D;
            this.knobControl_chartRange.Valuedecimals = 3;
            this.knobControl_chartRange.ValueChanged += new SeeSharpTools.JY.GUI.ValueChangedEventHandler(this.knobControl_chartRange_ValueChanged);
            // 
            // numericUpDown_viewTime
            // 
            this.numericUpDown_viewTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown_viewTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_viewTime.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_viewTime.ForeColor = System.Drawing.Color.Silver;
            this.numericUpDown_viewTime.Location = new System.Drawing.Point(12, 110);
            this.numericUpDown_viewTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_viewTime.Name = "numericUpDown_viewTime";
            this.numericUpDown_viewTime.Size = new System.Drawing.Size(56, 18);
            this.numericUpDown_viewTime.TabIndex = 17;
            this.numericUpDown_viewTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_viewTime.ThousandsSeparator = true;
            this.numericUpDown_viewTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_viewTime.ValueChanged += new System.EventHandler(this.numericUpDown_viewTime_ValueChanged);
            // 
            // label_viewTime
            // 
            this.label_viewTime.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_viewTime.ForeColor = System.Drawing.Color.Silver;
            this.label_viewTime.Location = new System.Drawing.Point(20, 15);
            this.label_viewTime.Name = "label_viewTime";
            this.label_viewTime.Size = new System.Drawing.Size(116, 20);
            this.label_viewTime.TabIndex = 16;
            this.label_viewTime.Text = "ViewTime(ms):";
            this.label_viewTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // knobControl_viewTime
            // 
            this.knobControl_viewTime.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knobControl_viewTime.ForeColor = System.Drawing.Color.Silver;
            this.knobControl_viewTime.ImeMode = System.Windows.Forms.ImeMode.On;
            this.knobControl_viewTime.IsTextShow = true;
            this.knobControl_viewTime.KnobColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.knobControl_viewTime.Location = new System.Drawing.Point(61, 18);
            this.knobControl_viewTime.Max = 1000D;
            this.knobControl_viewTime.Min = 0D;
            this.knobControl_viewTime.Name = "knobControl_viewTime";
            this.knobControl_viewTime.Size = new System.Drawing.Size(150, 150);
            this.knobControl_viewTime.TabIndex = 15;
            this.knobControl_viewTime.TextDecimals = 3;
            this.knobControl_viewTime.TickWidth = 5;
            this.knobControl_viewTime.Value = 100D;
            this.knobControl_viewTime.Valuedecimals = 3;
            this.knobControl_viewTime.ValueChanged += new SeeSharpTools.JY.GUI.ValueChangedEventHandler(this.knobControl_viewTime_ValueChanged);
            // 
            // pictureBox_titleIcon
            // 
            this.pictureBox_titleIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_titleIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_titleIcon.Image")));
            this.pictureBox_titleIcon.Location = new System.Drawing.Point(3, 1);
            this.pictureBox_titleIcon.Name = "pictureBox_titleIcon";
            this.pictureBox_titleIcon.Size = new System.Drawing.Size(28, 28);
            this.pictureBox_titleIcon.TabIndex = 0;
            this.pictureBox_titleIcon.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_title.Location = new System.Drawing.Point(37, -2);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(308, 30);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "JYTEK DSA Soft Panel";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_title
            // 
            this.panel_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_title.Controls.Add(this.panel_formButton);
            this.panel_title.Controls.Add(this.pictureBox_titleIcon);
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Location = new System.Drawing.Point(1, 1);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1200, 30);
            this.panel_title.TabIndex = 6;
            // 
            // panel_formButton
            // 
            this.panel_formButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_formButton.Controls.Add(this.button_close);
            this.panel_formButton.Controls.Add(this.button_minimize);
            this.panel_formButton.Controls.Add(this.button_maximize);
            this.panel_formButton.Location = new System.Drawing.Point(1092, 0);
            this.panel_formButton.Name = "panel_formButton";
            this.panel_formButton.Size = new System.Drawing.Size(107, 30);
            this.panel_formButton.TabIndex = 2;
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.ForeColor = System.Drawing.Color.Silver;
            this.button_close.Location = new System.Drawing.Point(76, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(30, 30);
            this.button_close.TabIndex = 5;
            this.button_close.Text = "×";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimize.ForeColor = System.Drawing.Color.Silver;
            this.button_minimize.Location = new System.Drawing.Point(6, 0);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(30, 30);
            this.button_minimize.TabIndex = 3;
            this.button_minimize.Text = "－";
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_maximize
            // 
            this.button_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_maximize.FlatAppearance.BorderSize = 0;
            this.button_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_maximize.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_maximize.ForeColor = System.Drawing.Color.Silver;
            this.button_maximize.Location = new System.Drawing.Point(40, 0);
            this.button_maximize.Name = "button_maximize";
            this.button_maximize.Size = new System.Drawing.Size(30, 30);
            this.button_maximize.TabIndex = 4;
            this.button_maximize.Text = "□";
            this.button_maximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_maximize.UseVisualStyleBackColor = false;
            this.button_maximize.Click += new System.EventHandler(this.button_maximize_Click);
            // 
            // DsaSoftPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1202, 702);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.splitContainer_measureAndView);
            this.Controls.Add(this.flowLayoutPanel_function);
            this.Controls.Add(this.flowLayoutPanel_channelInfos);
            this.Controls.Add(this.flowLayoutPanel_status);
            this.Controls.Add(this.flowLayoutPanel_menuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DsaSoftPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OscilloscopeSoftPanelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OscilloscopeSoftPanelForm_FormClosing);
            this.Load += new System.EventHandler(this.OscilloscopeSoftPanelForm_Load);
            this.Shown += new System.EventHandler(this.OscilloscopeSoftPanelForm_Shown);
            this.flowLayoutPanel_menuButton.ResumeLayout(false);
            this.flowLayoutPanel_status.ResumeLayout(false);
            this.flowLayoutPanel_status.PerformLayout();
            this.splitContainer_measureAndView.Panel1.ResumeLayout(false);
            this.splitContainer_measureAndView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_measureAndView)).EndInit();
            this.splitContainer_measureAndView.ResumeLayout(false);
            this.splitContainer_buttonAndFunction.Panel1.ResumeLayout(false);
            this.splitContainer_buttonAndFunction.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_buttonAndFunction)).EndInit();
            this.splitContainer_buttonAndFunction.ResumeLayout(false);
            this.panel_measure.ResumeLayout(false);
            this.panel_measureValue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_measureValues)).EndInit();
            this.tableLayoutPanel_measure.ResumeLayout(false);
            this.panel_function.ResumeLayout(false);
            this.tableLayoutPanel_functionSelect.ResumeLayout(false);
            this.splitContainer_viewAndConfig.Panel1.ResumeLayout(false);
            this.splitContainer_viewAndConfig.Panel1.PerformLayout();
            this.splitContainer_viewAndConfig.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_viewAndConfig)).EndInit();
            this.splitContainer_viewAndConfig.ResumeLayout(false);
            this.tableLayoutPanel_chartView.ResumeLayout(false);
            this.splitContainer_plotArea.Panel1.ResumeLayout(false);
            this.splitContainer_plotArea.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_plotArea)).EndInit();
            this.splitContainer_plotArea.ResumeLayout(false);
            this.tableLayoutPanel_functionPanel.ResumeLayout(false);
            this.tableLayoutPanel_functionValues.ResumeLayout(false);
            this.splitContainer_functionDataAndDetail.Panel1.ResumeLayout(false);
            this.splitContainer_functionDataAndDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_functionDataAndDetail)).EndInit();
            this.splitContainer_functionDataAndDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_functionDetail)).EndInit();
            this.splitContainer_channelAndCommon.Panel1.ResumeLayout(false);
            this.splitContainer_channelAndCommon.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_channelAndCommon)).EndInit();
            this.splitContainer_channelAndCommon.ResumeLayout(false);
            this.txTabControl_channel.ResumeLayout(false);
            this.tabPagech1.ResumeLayout(false);
            this.panel_commonConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_chartRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_viewTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_titleIcon)).EndInit();
            this.panel_title.ResumeLayout(false);
            this.panel_formButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_menuButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_status;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_function;
        internal System.Windows.Forms.Button button_clear;
        internal System.Windows.Forms.Label label_status2;
        internal System.Windows.Forms.Label label_status3;
        internal System.Windows.Forms.Label label_status4;
        internal System.Windows.Forms.Label label_ch1;
        internal System.Windows.Forms.Label label_ch2;
        internal System.Windows.Forms.Label label_ch3;
        internal System.Windows.Forms.Label label_ch4;
        private SeeSharpTools.JY.GUI.ButtonSwitch buttonSwitch_Switch;
        private System.Windows.Forms.CheckBox checkBox_splitView;
        internal Button button_runPause;
        private SplitContainer splitContainer_measureAndView;
        private SplitContainer splitContainer_buttonAndFunction;
        private SplitContainer splitContainer_viewAndConfig;
        private TableLayoutPanel tableLayoutPanel_chartView;
        private SplitContainer splitContainer_channelAndCommon;
        private Panel panel_commonConfig;
        private NumericUpDown numericUpDown_chartRange;
        private Label label_chartRange;
        private SeeSharpTools.JY.GUI.KnobControl knobControl_chartRange;
        private NumericUpDown numericUpDown_viewTime;
        private Label label_viewTime;
        private SeeSharpTools.JY.GUI.KnobControl knobControl_viewTime;
        private SplitContainer splitContainer_plotArea;
        internal SeeSharpTools.JY.GUI.EasyChartX easyChartX_data;
        internal FlowLayoutPanel flowLayoutPanel_channelInfos;
        internal Button button_measure;
        internal Button button_function;
        private Label label_title;
        private PictureBox pictureBox_titleIcon;
        private Panel panel_title;
        private Panel panel_formButton;
        internal Button button_minimize;
        internal Button button_close;
        internal Button button_maximize;
        private Panel panel_function;
        private Panel panel_measure;
        private TableLayoutPanel tableLayoutPanel_measure;
        private TableLayoutPanel tableLayoutPanel_functionPanel;
        private TableLayoutPanel tableLayoutPanel_functionValues;
        internal Label label_XValueLabel;
        internal Label label_YValueLabel;
        private TabPage tabPagech1;
        private MetroFramework.Controls.MetroComboBox metroComboBox_unit;
        private MetroFramework.Controls.MetroComboBox metroComboBox_coupling;
        private Label label_Coupling;
        private MetroFramework.Controls.MetroComboBox metroComboBox_probe;
        private Label label_probe;
        private Label label_Unit;
        internal TX.Framework.WindowUI.Controls.TXTabControl txTabControl_channel;
        internal Button button_triggerConfig;
        private SplitContainer splitContainer_functionDataAndDetail;
        internal SeeSharpTools.JY.GUI.EasyChartX easyChartX_function;
        private DataGridView dataGridView_functionDetail;
        private TableLayoutPanel tableLayoutPanel_functionSelect;
        internal Label label_spectrumFunction;
        internal Label label_harmonicFunction;
        internal Label label_toneAnalyze;
        internal Button button_stopfunction;
        internal Label label_filter;
        private Panel panel_functionConfig;
        private Panel panel_measureValue;
        internal Label label_measureChannel;
        private MetroFramework.Controls.MetroComboBox metroComboBox_measureChannel;
        private DataGridView dataGridView_measureValues;
        internal Label label_measureRms;
        internal Label label_DC;
        internal Label label_squareAnalyze;
        internal Label label_phaseShift;
        internal Button button_reset;
        private RadioButton radioButton_xZoom;
        internal Label label_sampleRateInMenu;
        private RadioButton radioButton_zoomY;
        private RadioButton radioButton_zoomArea;
        private RadioButton radioButton_cursor;
        internal Label label_peakFrequency;
        internal Label label_peakAmp;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private TX.Framework.WindowUI.Controls.TXRadioButton txRadioButton_spectrum;
        private TX.Framework.WindowUI.Controls.TXRadioButton txRadioButton_harmonic;
        private TX.Framework.WindowUI.Controls.TXRadioButton txRadioButton_toneAnalyze;
        private TX.Framework.WindowUI.Controls.TXRadioButton txRadioButton_filter;
        private TX.Framework.WindowUI.Controls.TXRadioButton txRadioButton_squareAnalyze;
        private TX.Framework.WindowUI.Controls.TXRadioButton txRadioButton_phaseShift;
        private TX.Framework.WindowUI.Controls.TXCheckBox txCheckBox_rms;
        private TX.Framework.WindowUI.Controls.TXCheckBox txCheckBox_DC;
        private TX.Framework.WindowUI.Controls.TXCheckBox txCheckBox_peakAmp;
        private TX.Framework.WindowUI.Controls.TXCheckBox txCheckBox_peakFreq;
        internal Button button_sendSoftTrigger;
        private DataGridViewTextBoxColumn Column_Parameter;
        private DataGridViewTextBoxColumn Column_Value;
    }
}