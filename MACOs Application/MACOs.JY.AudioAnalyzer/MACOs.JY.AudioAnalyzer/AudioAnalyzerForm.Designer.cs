namespace MACOs.JY.AudioAnalyzer
{
    partial class AudioAnalyzerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioAnalyzerForm));
            this.label_analyzeName = new System.Windows.Forms.Label();
            this.groupBox_analyzePanel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Analyzer = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripStatusLabel_configBoard = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_boardStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton_selectAnalyzer = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripStatusLabel_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.button_start = new System.Windows.Forms.Button();
            this.numericUpDown_delaySamples = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_trigger = new System.Windows.Forms.Button();
            this.button_analyze = new System.Windows.Forms.Button();
            this.groupBox_analyzePanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_delaySamples)).BeginInit();
            this.SuspendLayout();
            // 
            // label_analyzeName
            // 
            this.label_analyzeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_analyzeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_analyzeName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_analyzeName.Location = new System.Drawing.Point(233, 8);
            this.label_analyzeName.Name = "label_analyzeName";
            this.label_analyzeName.Size = new System.Drawing.Size(868, 45);
            this.label_analyzeName.TabIndex = 7;
            this.label_analyzeName.Text = "Audio Analyzer";
            this.label_analyzeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_analyzePanel
            // 
            this.groupBox_analyzePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_analyzePanel.Controls.Add(this.tableLayoutPanel_Analyzer);
            this.groupBox_analyzePanel.Location = new System.Drawing.Point(10, 55);
            this.groupBox_analyzePanel.Name = "groupBox_analyzePanel";
            this.groupBox_analyzePanel.Size = new System.Drawing.Size(1304, 666);
            this.groupBox_analyzePanel.TabIndex = 0;
            this.groupBox_analyzePanel.TabStop = false;
            // 
            // tableLayoutPanel_Analyzer
            // 
            this.tableLayoutPanel_Analyzer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Analyzer.ColumnCount = 1;
            this.tableLayoutPanel_Analyzer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Analyzer.Location = new System.Drawing.Point(2, 14);
            this.tableLayoutPanel_Analyzer.Name = "tableLayoutPanel_Analyzer";
            this.tableLayoutPanel_Analyzer.RowCount = 1;
            this.tableLayoutPanel_Analyzer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Analyzer.Size = new System.Drawing.Size(1300, 652);
            this.tableLayoutPanel_Analyzer.TabIndex = 9;
            // 
            // toolStripStatusLabel_configBoard
            // 
            this.toolStripStatusLabel_configBoard.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel_configBoard.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel_configBoard.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.toolStripStatusLabel_configBoard.Name = "toolStripStatusLabel_configBoard";
            this.toolStripStatusLabel_configBoard.Size = new System.Drawing.Size(99, 21);
            this.toolStripStatusLabel_configBoard.Text = "Connect Board";
            this.toolStripStatusLabel_configBoard.Click += new System.EventHandler(this.toolStripStatusLabel_configBoard_Click);
            this.toolStripStatusLabel_configBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripStatusLabel_configBoard_MouseDown);
            this.toolStripStatusLabel_configBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripStatusLabel_configBoard_MouseUp);
            // 
            // toolStripStatusLabel_boardStatus
            // 
            this.toolStripStatusLabel_boardStatus.AutoSize = false;
            this.toolStripStatusLabel_boardStatus.BackColor = System.Drawing.Color.OrangeRed;
            this.toolStripStatusLabel_boardStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel_boardStatus.Name = "toolStripStatusLabel_boardStatus";
            this.toolStripStatusLabel_boardStatus.Size = new System.Drawing.Size(200, 21);
            this.toolStripStatusLabel_boardStatus.Text = "toolStripStatusLabel_boardStatus";
            // 
            // toolStripDropDownButton_selectAnalyzer
            // 
            this.toolStripDropDownButton_selectAnalyzer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_selectAnalyzer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_selectAnalyzer.Image")));
            this.toolStripDropDownButton_selectAnalyzer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_selectAnalyzer.Name = "toolStripDropDownButton_selectAnalyzer";
            this.toolStripDropDownButton_selectAnalyzer.Size = new System.Drawing.Size(108, 24);
            this.toolStripDropDownButton_selectAnalyzer.Text = "Select Analyzer";
            // 
            // toolStripStatusLabel_status
            // 
            this.toolStripStatusLabel_status.Name = "toolStripStatusLabel_status";
            this.toolStripStatusLabel_status.Size = new System.Drawing.Size(902, 21);
            this.toolStripStatusLabel_status.Spring = true;
            this.toolStripStatusLabel_status.Text = "toolStripStatusLabel_status";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_configBoard,
            this.toolStripStatusLabel_boardStatus,
            this.toolStripDropDownButton_selectAnalyzer,
            this.toolStripStatusLabel_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 755);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1324, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // button_start
            // 
            this.button_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_start.Location = new System.Drawing.Point(1124, 727);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(92, 23);
            this.button_start.TabIndex = 10;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_test_Click);
            // 
            // numericUpDown_delaySamples
            // 
            this.numericUpDown_delaySamples.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown_delaySamples.Location = new System.Drawing.Point(884, 729);
            this.numericUpDown_delaySamples.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_delaySamples.Name = "numericUpDown_delaySamples";
            this.numericUpDown_delaySamples.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown_delaySamples.TabIndex = 11;
            this.numericUpDown_delaySamples.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_delaySamples.ValueChanged += new System.EventHandler(this.numericUpDown_delaySamples_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(786, 733);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Delay Samples:";
            // 
            // button_trigger
            // 
            this.button_trigger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_trigger.Location = new System.Drawing.Point(1022, 727);
            this.button_trigger.Name = "button_trigger";
            this.button_trigger.Size = new System.Drawing.Size(92, 23);
            this.button_trigger.TabIndex = 13;
            this.button_trigger.Text = "Trigger...";
            this.button_trigger.UseVisualStyleBackColor = true;
            this.button_trigger.Click += new System.EventHandler(this.button_trigger_Click);
            // 
            // button_analyze
            // 
            this.button_analyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_analyze.Location = new System.Drawing.Point(1226, 726);
            this.button_analyze.Name = "button_analyze";
            this.button_analyze.Size = new System.Drawing.Size(92, 23);
            this.button_analyze.TabIndex = 11;
            this.button_analyze.Text = "Analyze";
            this.button_analyze.UseVisualStyleBackColor = true;
            this.button_analyze.Click += new System.EventHandler(this.button_analyze_Click);
            // 
            // AudioAnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 781);
            this.Controls.Add(this.button_analyze);
            this.Controls.Add(this.button_trigger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_delaySamples);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBox_analyzePanel);
            this.Controls.Add(this.label_analyzeName);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1340, 820);
            this.MinimumSize = new System.Drawing.Size(1340, 600);
            this.Name = "AudioAnalyzerForm";
            this.Text = "Audio Analyzer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AudioAnalyzerForm_FormClosing);
            this.Load += new System.EventHandler(this.AudioAnalyzerForm_Load);
            this.groupBox_analyzePanel.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_delaySamples)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_analyzeName;
        private System.Windows.Forms.GroupBox groupBox_analyzePanel;
        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Analyzer;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_configBoard;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_boardStatus;
        internal System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_selectAnalyzer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button button_trigger;
        internal System.Windows.Forms.NumericUpDown numericUpDown_delaySamples;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_status;
        internal System.Windows.Forms.Button button_analyze;
    }
}

