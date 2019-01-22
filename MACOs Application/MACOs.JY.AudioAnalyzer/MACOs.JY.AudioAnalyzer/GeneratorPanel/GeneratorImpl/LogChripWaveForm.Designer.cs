namespace MACOs.JY.AudioAnalyzer.GeneratorPanel.GeneratorImpl
{
    partial class LogChripWaveForm
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
            this.label_freqMin = new System.Windows.Forms.Label();
            this.numericUpDown_amplitude1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_freqMin = new System.Windows.Forms.NumericUpDown();
            this.label_preSweepRatio = new System.Windows.Forms.Label();
            this.label_freqMax = new System.Windows.Forms.Label();
            this.numericUpDown_preSweepRatio = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_freqMax = new System.Windows.Forms.NumericUpDown();
            this.label_duration = new System.Windows.Forms.Label();
            this.numericUpDown_duration = new System.Windows.Forms.NumericUpDown();
            this.label_postSweepRatio = new System.Windows.Forms.Label();
            this.numericUpDown_postSweepRatio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_freqMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_preSweepRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_freqMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_postSweepRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // label_amplitude
            // 
            this.label_amplitude.AutoSize = true;
            this.label_amplitude.Location = new System.Drawing.Point(303, 14);
            this.label_amplitude.Name = "label_amplitude";
            this.label_amplitude.Size = new System.Drawing.Size(77, 12);
            this.label_amplitude.TabIndex = 11;
            this.label_amplitude.Text = "Amplitude(V)";
            // 
            // label_freqMin
            // 
            this.label_freqMin.AutoSize = true;
            this.label_freqMin.Location = new System.Drawing.Point(31, 16);
            this.label_freqMin.Name = "label_freqMin";
            this.label_freqMin.Size = new System.Drawing.Size(107, 12);
            this.label_freqMin.TabIndex = 10;
            this.label_freqMin.Text = "Frequency Min(Hz)";
            // 
            // numericUpDown_amplitude1
            // 
            this.numericUpDown_amplitude1.DecimalPlaces = 1;
            this.numericUpDown_amplitude1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_amplitude1.Location = new System.Drawing.Point(422, 10);
            this.numericUpDown_amplitude1.Maximum = new decimal(new int[] {
            5,
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
            // numericUpDown_freqMin
            // 
            this.numericUpDown_freqMin.Location = new System.Drawing.Point(156, 12);
            this.numericUpDown_freqMin.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown_freqMin.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_freqMin.Name = "numericUpDown_freqMin";
            this.numericUpDown_freqMin.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_freqMin.TabIndex = 8;
            this.numericUpDown_freqMin.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label_preSweepRatio
            // 
            this.label_preSweepRatio.AutoSize = true;
            this.label_preSweepRatio.Location = new System.Drawing.Point(303, 51);
            this.label_preSweepRatio.Name = "label_preSweepRatio";
            this.label_preSweepRatio.Size = new System.Drawing.Size(95, 12);
            this.label_preSweepRatio.TabIndex = 15;
            this.label_preSweepRatio.Text = "Pre Sweep Ratio";
            // 
            // label_freqMax
            // 
            this.label_freqMax.AutoSize = true;
            this.label_freqMax.Location = new System.Drawing.Point(31, 53);
            this.label_freqMax.Name = "label_freqMax";
            this.label_freqMax.Size = new System.Drawing.Size(107, 12);
            this.label_freqMax.TabIndex = 14;
            this.label_freqMax.Text = "Frequency Max(Hz)";
            // 
            // numericUpDown_preSweepRatio
            // 
            this.numericUpDown_preSweepRatio.DecimalPlaces = 3;
            this.numericUpDown_preSweepRatio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_preSweepRatio.Location = new System.Drawing.Point(422, 47);
            this.numericUpDown_preSweepRatio.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_preSweepRatio.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.numericUpDown_preSweepRatio.Name = "numericUpDown_preSweepRatio";
            this.numericUpDown_preSweepRatio.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_preSweepRatio.TabIndex = 13;
            this.numericUpDown_preSweepRatio.Value = new decimal(new int[] {
            25,
            0,
            0,
            196608});
            // 
            // numericUpDown_freqMax
            // 
            this.numericUpDown_freqMax.Location = new System.Drawing.Point(156, 49);
            this.numericUpDown_freqMax.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown_freqMax.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_freqMax.Name = "numericUpDown_freqMax";
            this.numericUpDown_freqMax.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_freqMax.TabIndex = 12;
            this.numericUpDown_freqMax.Value = new decimal(new int[] {
            10000,
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
            100,
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
            // label_postSweepRatio
            // 
            this.label_postSweepRatio.AutoSize = true;
            this.label_postSweepRatio.Location = new System.Drawing.Point(303, 90);
            this.label_postSweepRatio.Name = "label_postSweepRatio";
            this.label_postSweepRatio.Size = new System.Drawing.Size(95, 12);
            this.label_postSweepRatio.TabIndex = 19;
            this.label_postSweepRatio.Text = "Post SweepRatio";
            // 
            // numericUpDown_postSweepRatio
            // 
            this.numericUpDown_postSweepRatio.DecimalPlaces = 3;
            this.numericUpDown_postSweepRatio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_postSweepRatio.Location = new System.Drawing.Point(422, 86);
            this.numericUpDown_postSweepRatio.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_postSweepRatio.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.numericUpDown_postSweepRatio.Name = "numericUpDown_postSweepRatio";
            this.numericUpDown_postSweepRatio.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_postSweepRatio.TabIndex = 18;
            this.numericUpDown_postSweepRatio.Value = new decimal(new int[] {
            25,
            0,
            0,
            196608});
            // 
            // LogChripWaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(550, 120);
            this.Controls.Add(this.label_postSweepRatio);
            this.Controls.Add(this.numericUpDown_postSweepRatio);
            this.Controls.Add(this.label_duration);
            this.Controls.Add(this.numericUpDown_duration);
            this.Controls.Add(this.label_preSweepRatio);
            this.Controls.Add(this.label_freqMax);
            this.Controls.Add(this.numericUpDown_preSweepRatio);
            this.Controls.Add(this.numericUpDown_freqMax);
            this.Controls.Add(this.label_amplitude);
            this.Controls.Add(this.label_freqMin);
            this.Controls.Add(this.numericUpDown_amplitude1);
            this.Controls.Add(this.numericUpDown_freqMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "LogChripWaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SteppedSineWaveCrossTalkAnalyze";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_freqMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_preSweepRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_freqMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_postSweepRatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_amplitude;
        private System.Windows.Forms.Label label_freqMin;
        private System.Windows.Forms.NumericUpDown numericUpDown_amplitude1;
        private System.Windows.Forms.NumericUpDown numericUpDown_freqMin;
        private System.Windows.Forms.Label label_preSweepRatio;
        private System.Windows.Forms.Label label_freqMax;
        private System.Windows.Forms.NumericUpDown numericUpDown_preSweepRatio;
        private System.Windows.Forms.NumericUpDown numericUpDown_freqMax;
        private System.Windows.Forms.Label label_duration;
        private System.Windows.Forms.NumericUpDown numericUpDown_duration;
        private System.Windows.Forms.Label label_postSweepRatio;
        private System.Windows.Forms.NumericUpDown numericUpDown_postSweepRatio;
    }
}