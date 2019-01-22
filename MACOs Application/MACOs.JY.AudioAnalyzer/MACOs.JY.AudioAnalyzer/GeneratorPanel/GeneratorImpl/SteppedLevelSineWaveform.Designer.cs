namespace MACOs.JY.AudioAnalyzer.GeneratorPanel.GeneratorImpl
{
    partial class SteppedLevelSineWaveform
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
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_duration = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_minCycle = new System.Windows.Forms.NumericUpDown();
            this.label_amplitudeMax = new System.Windows.Forms.Label();
            this.numericUpDown_amplitudeMax = new System.Windows.Forms.NumericUpDown();
            this.label_amplitudeMin = new System.Windows.Forms.Label();
            this.label_freq = new System.Windows.Forms.Label();
            this.numericUpDown_freq = new System.Windows.Forms.NumericUpDown();
            this.label_steps = new System.Windows.Forms.Label();
            this.numericUpDown_steps = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_amplitudeMin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitudeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_freq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_steps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitudeMin)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "Min Duration(ms)";
            // 
            // numericUpDown_duration
            // 
            this.numericUpDown_duration.Location = new System.Drawing.Point(170, 86);
            this.numericUpDown_duration.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_duration.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_duration.Name = "numericUpDown_duration";
            this.numericUpDown_duration.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_duration.TabIndex = 18;
            this.numericUpDown_duration.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "Min Cycle";
            // 
            // numericUpDown_minCycle
            // 
            this.numericUpDown_minCycle.Location = new System.Drawing.Point(412, 51);
            this.numericUpDown_minCycle.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_minCycle.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_minCycle.Name = "numericUpDown_minCycle";
            this.numericUpDown_minCycle.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_minCycle.TabIndex = 16;
            this.numericUpDown_minCycle.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label_amplitudeMax
            // 
            this.label_amplitudeMax.AutoSize = true;
            this.label_amplitudeMax.Location = new System.Drawing.Point(45, 51);
            this.label_amplitudeMax.Name = "label_amplitudeMax";
            this.label_amplitudeMax.Size = new System.Drawing.Size(101, 12);
            this.label_amplitudeMax.TabIndex = 15;
            this.label_amplitudeMax.Text = "Max Amplitude(V)";
            // 
            // numericUpDown_amplitudeMax
            // 
            this.numericUpDown_amplitudeMax.DecimalPlaces = 1;
            this.numericUpDown_amplitudeMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_amplitudeMax.Location = new System.Drawing.Point(170, 49);
            this.numericUpDown_amplitudeMax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_amplitudeMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_amplitudeMax.Name = "numericUpDown_amplitudeMax";
            this.numericUpDown_amplitudeMax.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_amplitudeMax.TabIndex = 14;
            this.numericUpDown_amplitudeMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_amplitudeMin
            // 
            this.label_amplitudeMin.AutoSize = true;
            this.label_amplitudeMin.Location = new System.Drawing.Point(293, 14);
            this.label_amplitudeMin.Name = "label_amplitudeMin";
            this.label_amplitudeMin.Size = new System.Drawing.Size(95, 12);
            this.label_amplitudeMin.TabIndex = 13;
            this.label_amplitudeMin.Text = "Min Ampitude(V)";
            // 
            // label_freq
            // 
            this.label_freq.AutoSize = true;
            this.label_freq.Location = new System.Drawing.Point(45, 14);
            this.label_freq.Name = "label_freq";
            this.label_freq.Size = new System.Drawing.Size(83, 12);
            this.label_freq.TabIndex = 12;
            this.label_freq.Text = "Frequency(Hz)";
            // 
            // numericUpDown_freq
            // 
            this.numericUpDown_freq.Location = new System.Drawing.Point(170, 12);
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
            this.numericUpDown_freq.TabIndex = 10;
            this.numericUpDown_freq.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label_steps
            // 
            this.label_steps.AutoSize = true;
            this.label_steps.Location = new System.Drawing.Point(293, 88);
            this.label_steps.Name = "label_steps";
            this.label_steps.Size = new System.Drawing.Size(35, 12);
            this.label_steps.TabIndex = 21;
            this.label_steps.Text = "Steps";
            // 
            // numericUpDown_steps
            // 
            this.numericUpDown_steps.Location = new System.Drawing.Point(412, 87);
            this.numericUpDown_steps.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown_steps.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_steps.Name = "numericUpDown_steps";
            this.numericUpDown_steps.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_steps.TabIndex = 20;
            this.numericUpDown_steps.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_amplitudeMin
            // 
            this.numericUpDown_amplitudeMin.DecimalPlaces = 1;
            this.numericUpDown_amplitudeMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_amplitudeMin.Location = new System.Drawing.Point(412, 12);
            this.numericUpDown_amplitudeMin.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_amplitudeMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_amplitudeMin.Name = "numericUpDown_amplitudeMin";
            this.numericUpDown_amplitudeMin.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_amplitudeMin.TabIndex = 22;
            this.numericUpDown_amplitudeMin.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // SteppedLevelSineWaveform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(550, 120);
            this.Controls.Add(this.numericUpDown_amplitudeMin);
            this.Controls.Add(this.label_steps);
            this.Controls.Add(this.numericUpDown_steps);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_duration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_minCycle);
            this.Controls.Add(this.label_amplitudeMax);
            this.Controls.Add(this.numericUpDown_amplitudeMax);
            this.Controls.Add(this.label_amplitudeMin);
            this.Controls.Add(this.label_freq);
            this.Controls.Add(this.numericUpDown_freq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "SteppedLevelSineWaveform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SteppedSineWaveCrossTalkAnalyze";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitudeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_freq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_steps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitudeMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_duration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_minCycle;
        private System.Windows.Forms.Label label_amplitudeMax;
        private System.Windows.Forms.NumericUpDown numericUpDown_amplitudeMax;
        private System.Windows.Forms.Label label_amplitudeMin;
        private System.Windows.Forms.Label label_freq;
        private System.Windows.Forms.NumericUpDown numericUpDown_freq;
        private System.Windows.Forms.Label label_steps;
        private System.Windows.Forms.NumericUpDown numericUpDown_steps;
        private System.Windows.Forms.NumericUpDown numericUpDown_amplitudeMin;
    }
}