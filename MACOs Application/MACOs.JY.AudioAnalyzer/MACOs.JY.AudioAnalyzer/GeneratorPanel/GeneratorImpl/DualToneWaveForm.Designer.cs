namespace MACOs.JY.AudioAnalyzer.GeneratorPanel.GeneratorImpl
{
    partial class DualToneWaveForm
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
            this.label_amplitude1 = new System.Windows.Forms.Label();
            this.label_freq1 = new System.Windows.Forms.Label();
            this.numericUpDown_amplitude1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_freq1 = new System.Windows.Forms.NumericUpDown();
            this.label_amplitude2 = new System.Windows.Forms.Label();
            this.label_freq2 = new System.Windows.Forms.Label();
            this.numericUpDown_amplitude2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_freq2 = new System.Windows.Forms.NumericUpDown();
            this.label_duration = new System.Windows.Forms.Label();
            this.numericUpDown_duration = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_freq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_freq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_duration)).BeginInit();
            this.SuspendLayout();
            // 
            // label_amplitude1
            // 
            this.label_amplitude1.AutoSize = true;
            this.label_amplitude1.Location = new System.Drawing.Point(303, 14);
            this.label_amplitude1.Name = "label_amplitude1";
            this.label_amplitude1.Size = new System.Drawing.Size(83, 12);
            this.label_amplitude1.TabIndex = 11;
            this.label_amplitude1.Text = "Amplitude1(V)";
            // 
            // label_freq1
            // 
            this.label_freq1.AutoSize = true;
            this.label_freq1.Location = new System.Drawing.Point(31, 16);
            this.label_freq1.Name = "label_freq1";
            this.label_freq1.Size = new System.Drawing.Size(89, 12);
            this.label_freq1.TabIndex = 10;
            this.label_freq1.Text = "Frequency1(Hz)";
            // 
            // numericUpDown_amplitude1
            // 
            this.numericUpDown_amplitude1.DecimalPlaces = 3;
            this.numericUpDown_amplitude1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_amplitude1.Location = new System.Drawing.Point(422, 10);
            this.numericUpDown_amplitude1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_amplitude1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_amplitude1.Name = "numericUpDown_amplitude1";
            this.numericUpDown_amplitude1.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_amplitude1.TabIndex = 9;
            this.numericUpDown_amplitude1.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numericUpDown_freq1
            // 
            this.numericUpDown_freq1.Location = new System.Drawing.Point(156, 12);
            this.numericUpDown_freq1.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown_freq1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_freq1.Name = "numericUpDown_freq1";
            this.numericUpDown_freq1.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_freq1.TabIndex = 8;
            this.numericUpDown_freq1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label_amplitude2
            // 
            this.label_amplitude2.AutoSize = true;
            this.label_amplitude2.Location = new System.Drawing.Point(303, 51);
            this.label_amplitude2.Name = "label_amplitude2";
            this.label_amplitude2.Size = new System.Drawing.Size(83, 12);
            this.label_amplitude2.TabIndex = 15;
            this.label_amplitude2.Text = "Amplitude2(V)";
            // 
            // label_freq2
            // 
            this.label_freq2.AutoSize = true;
            this.label_freq2.Location = new System.Drawing.Point(31, 53);
            this.label_freq2.Name = "label_freq2";
            this.label_freq2.Size = new System.Drawing.Size(89, 12);
            this.label_freq2.TabIndex = 14;
            this.label_freq2.Text = "Frequency2(Hz)";
            // 
            // numericUpDown_amplitude2
            // 
            this.numericUpDown_amplitude2.DecimalPlaces = 3;
            this.numericUpDown_amplitude2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_amplitude2.Location = new System.Drawing.Point(422, 47);
            this.numericUpDown_amplitude2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_amplitude2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_amplitude2.Name = "numericUpDown_amplitude2";
            this.numericUpDown_amplitude2.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_amplitude2.TabIndex = 13;
            this.numericUpDown_amplitude2.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numericUpDown_freq2
            // 
            this.numericUpDown_freq2.Location = new System.Drawing.Point(156, 49);
            this.numericUpDown_freq2.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown_freq2.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_freq2.Name = "numericUpDown_freq2";
            this.numericUpDown_freq2.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_freq2.TabIndex = 12;
            this.numericUpDown_freq2.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label_duration
            // 
            this.label_duration.AutoSize = true;
            this.label_duration.Location = new System.Drawing.Point(31, 90);
            this.label_duration.Name = "label_duration";
            this.label_duration.Size = new System.Drawing.Size(77, 12);
            this.label_duration.TabIndex = 17;
            this.label_duration.Text = "Duration(ms)";
            // 
            // numericUpDown_duration
            // 
            this.numericUpDown_duration.Location = new System.Drawing.Point(156, 86);
            this.numericUpDown_duration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_duration.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_duration.Name = "numericUpDown_duration";
            this.numericUpDown_duration.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_duration.TabIndex = 16;
            this.numericUpDown_duration.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // DualToneWaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(550, 120);
            this.Controls.Add(this.label_duration);
            this.Controls.Add(this.numericUpDown_duration);
            this.Controls.Add(this.label_amplitude2);
            this.Controls.Add(this.label_freq2);
            this.Controls.Add(this.numericUpDown_amplitude2);
            this.Controls.Add(this.numericUpDown_freq2);
            this.Controls.Add(this.label_amplitude1);
            this.Controls.Add(this.label_freq1);
            this.Controls.Add(this.numericUpDown_amplitude1);
            this.Controls.Add(this.numericUpDown_freq1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "DualToneWaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SteppedSineWaveCrossTalkAnalyze";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_freq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_freq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_amplitude1;
        private System.Windows.Forms.Label label_freq1;
        private System.Windows.Forms.NumericUpDown numericUpDown_amplitude1;
        private System.Windows.Forms.NumericUpDown numericUpDown_freq1;
        private System.Windows.Forms.Label label_amplitude2;
        private System.Windows.Forms.Label label_freq2;
        private System.Windows.Forms.NumericUpDown numericUpDown_amplitude2;
        private System.Windows.Forms.NumericUpDown numericUpDown_freq2;
        private System.Windows.Forms.Label label_duration;
        private System.Windows.Forms.NumericUpDown numericUpDown_duration;
    }
}