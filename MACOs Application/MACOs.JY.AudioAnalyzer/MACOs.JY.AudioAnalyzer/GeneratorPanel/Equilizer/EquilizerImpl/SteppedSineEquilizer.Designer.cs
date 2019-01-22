namespace MACOs.JY.AudioAnalyzer.GeneratorPanel.Equilizer.EquilizerImpl
{
    partial class SteppedSineEquilizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteppedSineEquilizer));
            this.numericUpDown_targetAmplitude = new System.Windows.Forms.NumericUpDown();
            this.label_targetAmplitude = new System.Windows.Forms.Label();
            this.groupBox_equalizer = new System.Windows.Forms.GroupBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_targetAmplitude)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_targetAmplitude
            // 
            this.numericUpDown_targetAmplitude.DecimalPlaces = 1;
            this.numericUpDown_targetAmplitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_targetAmplitude.Location = new System.Drawing.Point(134, 10);
            this.numericUpDown_targetAmplitude.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_targetAmplitude.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numericUpDown_targetAmplitude.Name = "numericUpDown_targetAmplitude";
            this.numericUpDown_targetAmplitude.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown_targetAmplitude.TabIndex = 0;
            this.numericUpDown_targetAmplitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_targetAmplitude.ValueChanged += new System.EventHandler(this.numericUpDown_targetAmplitude_ValueChanged);
            // 
            // label_targetAmplitude
            // 
            this.label_targetAmplitude.AutoSize = true;
            this.label_targetAmplitude.Location = new System.Drawing.Point(12, 14);
            this.label_targetAmplitude.Name = "label_targetAmplitude";
            this.label_targetAmplitude.Size = new System.Drawing.Size(119, 12);
            this.label_targetAmplitude.TabIndex = 1;
            this.label_targetAmplitude.Text = "Target Amplitude(V)";
            // 
            // groupBox_equalizer
            // 
            this.groupBox_equalizer.Location = new System.Drawing.Point(12, 37);
            this.groupBox_equalizer.Name = "groupBox_equalizer";
            this.groupBox_equalizer.Size = new System.Drawing.Size(242, 173);
            this.groupBox_equalizer.TabIndex = 2;
            this.groupBox_equalizer.TabStop = false;
            this.groupBox_equalizer.Text = "Equalizer";
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(22, 218);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 3;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(131, 218);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Clear";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // SteppedSineEquilizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 253);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.groupBox_equalizer);
            this.Controls.Add(this.label_targetAmplitude);
            this.Controls.Add(this.numericUpDown_targetAmplitude);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SteppedSineEquilizer";
            this.Text = "SteppedSineEquilizer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_targetAmplitude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_targetAmplitude;
        private System.Windows.Forms.Label label_targetAmplitude;
        private System.Windows.Forms.GroupBox groupBox_equalizer;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
    }
}