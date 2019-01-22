namespace MACOs.JY.AudioAnalyzer
{
    partial class ConfigBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigBoardForm));
            this.label1_boardId = new System.Windows.Forms.Label();
            this.numericUpDown_boardId = new System.Windows.Forms.NumericUpDown();
            this.button_connect = new System.Windows.Forms.Button();
            this.label_boardSelect = new System.Windows.Forms.Label();
            this.led_boardStatus = new SeeSharpTools.JY.GUI.LED();
            this.comboBox_boardSelect = new System.Windows.Forms.ComboBox();
            this.button_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_boardId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_boardId
            // 
            this.label1_boardId.AutoSize = true;
            this.label1_boardId.Location = new System.Drawing.Point(106, 61);
            this.label1_boardId.Name = "label1_boardId";
            this.label1_boardId.Size = new System.Drawing.Size(47, 12);
            this.label1_boardId.TabIndex = 16;
            this.label1_boardId.Text = "BoardId";
            // 
            // numericUpDown_boardId
            // 
            this.numericUpDown_boardId.Location = new System.Drawing.Point(199, 59);
            this.numericUpDown_boardId.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_boardId.Name = "numericUpDown_boardId";
            this.numericUpDown_boardId.Size = new System.Drawing.Size(111, 21);
            this.numericUpDown_boardId.TabIndex = 15;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(108, 101);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(84, 23);
            this.button_connect.TabIndex = 14;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label_boardSelect
            // 
            this.label_boardSelect.AutoSize = true;
            this.label_boardSelect.Location = new System.Drawing.Point(106, 18);
            this.label_boardSelect.Name = "label_boardSelect";
            this.label_boardSelect.Size = new System.Drawing.Size(71, 12);
            this.label_boardSelect.TabIndex = 13;
            this.label_boardSelect.Text = "BoardSelect";
            // 
            // led_boardStatus
            // 
            this.led_boardStatus.BlinkColor = System.Drawing.Color.Lime;
            this.led_boardStatus.BlinkInterval = 1000;
            this.led_boardStatus.BlinkOn = false;
            this.led_boardStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.led_boardStatus.Interacton = SeeSharpTools.JY.GUI.LED.InteractionStyle.Indicator;
            this.led_boardStatus.Location = new System.Drawing.Point(28, 32);
            this.led_boardStatus.Name = "led_boardStatus";
            this.led_boardStatus.OffColor = System.Drawing.Color.Red;
            this.led_boardStatus.OnColor = System.Drawing.Color.Chartreuse;
            this.led_boardStatus.Size = new System.Drawing.Size(53, 73);
            this.led_boardStatus.Style = SeeSharpTools.JY.GUI.LED.LedStyle.Rectangular3D;
            this.led_boardStatus.TabIndex = 11;
            this.led_boardStatus.Value = false;
            // 
            // comboBox_boardSelect
            // 
            this.comboBox_boardSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_boardSelect.FormattingEnabled = true;
            this.comboBox_boardSelect.Location = new System.Drawing.Point(199, 15);
            this.comboBox_boardSelect.Name = "comboBox_boardSelect";
            this.comboBox_boardSelect.Size = new System.Drawing.Size(111, 20);
            this.comboBox_boardSelect.TabIndex = 12;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(226, 101);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(84, 23);
            this.button_cancel.TabIndex = 17;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // ConfigBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 147);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label1_boardId);
            this.Controls.Add(this.numericUpDown_boardId);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.label_boardSelect);
            this.Controls.Add(this.led_boardStatus);
            this.Controls.Add(this.comboBox_boardSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigBoardForm";
            this.Text = "ConfigBoard";
            this.Load += new System.EventHandler(this.ConfigBoardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_boardId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_boardId;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label_boardSelect;
        private System.Windows.Forms.Button button_cancel;
        internal System.Windows.Forms.NumericUpDown numericUpDown_boardId;
        internal SeeSharpTools.JY.GUI.LED led_boardStatus;
        internal System.Windows.Forms.ComboBox comboBox_boardSelect;
    }
}