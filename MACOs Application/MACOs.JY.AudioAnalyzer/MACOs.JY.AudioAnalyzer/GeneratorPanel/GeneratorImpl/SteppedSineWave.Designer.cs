namespace MACOs.JY.AudioAnalyzer.GeneratorPanel.GeneratorImpl
{
    partial class SteppedSineWave
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
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_amplitude = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_stopFreq = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_startFreq = new System.Windows.Forms.NumericUpDown();
            this.label_steps = new System.Windows.Forms.Label();
            this.numericUpDown_steps = new System.Windows.Forms.NumericUpDown();
            this.button_AddEquilizer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stopFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_steps)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "Min Duration(ms)";
            // 
            // numericUpDown_duration
            // 
            this.numericUpDown_duration.Location = new System.Drawing.Point(138, 86);
            this.numericUpDown_duration.Maximum = new decimal(new int[] {
            80,
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
            this.label6.Location = new System.Drawing.Point(246, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "Min Cycle";
            // 
            // numericUpDown_minCycle
            // 
            this.numericUpDown_minCycle.Location = new System.Drawing.Point(361, 51);
            this.numericUpDown_minCycle.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDown_minCycle.Minimum = new decimal(new int[] {
            10,
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "Amplitude(V)";
            // 
            // numericUpDown_amplitude
            // 
            this.numericUpDown_amplitude.DecimalPlaces = 1;
            this.numericUpDown_amplitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_amplitude.Location = new System.Drawing.Point(138, 49);
            this.numericUpDown_amplitude.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_amplitude.Minimum = new decimal(new int[] {
            5,
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Stop Frequency(Hz)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "Start Frequency(Hz)";
            // 
            // numericUpDown_stopFreq
            // 
            this.numericUpDown_stopFreq.Location = new System.Drawing.Point(361, 12);
            this.numericUpDown_stopFreq.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown_stopFreq.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_stopFreq.Name = "numericUpDown_stopFreq";
            this.numericUpDown_stopFreq.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_stopFreq.TabIndex = 11;
            this.numericUpDown_stopFreq.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDown_startFreq
            // 
            this.numericUpDown_startFreq.Location = new System.Drawing.Point(138, 12);
            this.numericUpDown_startFreq.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown_startFreq.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_startFreq.Name = "numericUpDown_startFreq";
            this.numericUpDown_startFreq.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown_startFreq.TabIndex = 10;
            this.numericUpDown_startFreq.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label_steps
            // 
            this.label_steps.AutoSize = true;
            this.label_steps.Location = new System.Drawing.Point(246, 88);
            this.label_steps.Name = "label_steps";
            this.label_steps.Size = new System.Drawing.Size(35, 12);
            this.label_steps.TabIndex = 21;
            this.label_steps.Text = "Steps";
            // 
            // numericUpDown_steps
            // 
            this.numericUpDown_steps.Location = new System.Drawing.Point(361, 87);
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
            // button_AddEquilizer
            // 
            this.button_AddEquilizer.Location = new System.Drawing.Point(465, 12);
            this.button_AddEquilizer.Name = "button_AddEquilizer";
            this.button_AddEquilizer.Size = new System.Drawing.Size(79, 95);
            this.button_AddEquilizer.TabIndex = 22;
            this.button_AddEquilizer.Text = "Add Equalizer";
            this.button_AddEquilizer.UseVisualStyleBackColor = true;
            this.button_AddEquilizer.Click += new System.EventHandler(this.button_AddEquilizer_Click);
            // 
            // SteppedSineWave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(550, 120);
            this.Controls.Add(this.button_AddEquilizer);
            this.Controls.Add(this.label_steps);
            this.Controls.Add(this.numericUpDown_steps);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_duration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_minCycle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_amplitude);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDown_stopFreq);
            this.Controls.Add(this.numericUpDown_startFreq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "SteppedSineWave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SteppedSineWaveCrossTalkAnalyze";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stopFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_steps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_duration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_minCycle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_amplitude;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_stopFreq;
        private System.Windows.Forms.NumericUpDown numericUpDown_startFreq;
        private System.Windows.Forms.Label label_steps;
        private System.Windows.Forms.NumericUpDown numericUpDown_steps;
        private System.Windows.Forms.Button button_AddEquilizer;
    }
}