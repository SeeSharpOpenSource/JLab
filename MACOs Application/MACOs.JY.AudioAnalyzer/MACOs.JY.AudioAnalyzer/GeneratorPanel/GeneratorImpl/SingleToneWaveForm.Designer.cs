namespace MACOs.JY.AudioAnalyzer.GeneratorPanel.GeneratorImpl
{
    partial class SingleToneWaveForm
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
            this.label_amplitude = new System.Windows.Forms.Label();
            this.numericUpDown_amplitude = new System.Windows.Forms.NumericUpDown();
            this.label_Duration = new System.Windows.Forms.Label();
            this.label_freq = new System.Windows.Forms.Label();
            this.numericUpDown_duration = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_freq = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_freq)).BeginInit();
            this.SuspendLayout();
            // 
            // label_amplitude
            // 
            this.label_amplitude.AutoSize = true;
            this.label_amplitude.Location = new System.Drawing.Point(31, 78);
            this.label_amplitude.Name = "label_amplitude";
            this.label_amplitude.Size = new System.Drawing.Size(77, 12);
            this.label_amplitude.TabIndex = 15;
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
            this.numericUpDown_amplitude.Location = new System.Drawing.Point(156, 76);
            this.numericUpDown_amplitude.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_amplitude.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_amplitude.Name = "numericUpDown_amplitude";
            this.numericUpDown_amplitude.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_amplitude.TabIndex = 14;
            this.numericUpDown_amplitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_Duration
            // 
            this.label_Duration.AutoSize = true;
            this.label_Duration.Location = new System.Drawing.Point(303, 32);
            this.label_Duration.Name = "label_Duration";
            this.label_Duration.Size = new System.Drawing.Size(77, 12);
            this.label_Duration.TabIndex = 11;
            this.label_Duration.Text = "Duration(ms)";
            // 
            // label_freq
            // 
            this.label_freq.AutoSize = true;
            this.label_freq.Location = new System.Drawing.Point(31, 34);
            this.label_freq.Name = "label_freq";
            this.label_freq.Size = new System.Drawing.Size(83, 12);
            this.label_freq.TabIndex = 10;
            this.label_freq.Text = "Frequency(Hz)";
            // 
            // numericUpDown_duration
            // 
            this.numericUpDown_duration.Location = new System.Drawing.Point(422, 28);
            this.numericUpDown_duration.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown_duration.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_duration.Name = "numericUpDown_duration";
            this.numericUpDown_duration.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_duration.TabIndex = 9;
            this.numericUpDown_duration.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDown_freq
            // 
            this.numericUpDown_freq.Location = new System.Drawing.Point(156, 30);
            this.numericUpDown_freq.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown_freq.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_freq.Name = "numericUpDown_freq";
            this.numericUpDown_freq.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_freq.TabIndex = 8;
            this.numericUpDown_freq.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // SingleToneWaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(550, 120);
            this.Controls.Add(this.label_amplitude);
            this.Controls.Add(this.numericUpDown_amplitude);
            this.Controls.Add(this.label_Duration);
            this.Controls.Add(this.label_freq);
            this.Controls.Add(this.numericUpDown_duration);
            this.Controls.Add(this.numericUpDown_freq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "SingleToneWaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SteppedSineWaveCrossTalkAnalyze";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_freq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_amplitude;
        private System.Windows.Forms.NumericUpDown numericUpDown_amplitude;
        private System.Windows.Forms.Label label_Duration;
        private System.Windows.Forms.Label label_freq;
        private System.Windows.Forms.NumericUpDown numericUpDown_duration;
        private System.Windows.Forms.NumericUpDown numericUpDown_freq;
    }
}