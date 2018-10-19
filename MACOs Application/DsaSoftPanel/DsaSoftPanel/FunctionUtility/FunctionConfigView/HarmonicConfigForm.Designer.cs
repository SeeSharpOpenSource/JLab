namespace DsaSoftPanel.FunctionUtility.FunctionConfigView
{
    partial class HarmonicConfigForm
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
            this.metroComboBox_signal1 = new MetroFramework.Controls.MetroComboBox();
            this.label_signal = new System.Windows.Forms.Label();
            this.label_highestHarmonic = new System.Windows.Forms.Label();
            this.textBox_highestHarmonic = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // metroComboBox_signal1
            // 
            this.metroComboBox_signal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroComboBox_signal1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_signal1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_signal1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox_signal1.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox_signal1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox_signal1.ForeColor = System.Drawing.SystemColors.Info;
            this.metroComboBox_signal1.FormattingEnabled = true;
            this.metroComboBox_signal1.ItemHeight = 19;
            this.metroComboBox_signal1.Location = new System.Drawing.Point(12, 42);
            this.metroComboBox_signal1.Name = "metroComboBox_signal1";
            this.metroComboBox_signal1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metroComboBox_signal1.Size = new System.Drawing.Size(120, 25);
            this.metroComboBox_signal1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox_signal1.StyleManager = null;
            this.metroComboBox_signal1.TabIndex = 1;
            this.metroComboBox_signal1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_signal
            // 
            this.label_signal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_signal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signal.ForeColor = System.Drawing.Color.Silver;
            this.label_signal.Location = new System.Drawing.Point(5, 19);
            this.label_signal.Name = "label_signal";
            this.label_signal.Size = new System.Drawing.Size(135, 20);
            this.label_signal.TabIndex = 25;
            this.label_signal.Text = "Signal";
            this.label_signal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_highestHarmonic
            // 
            this.label_highestHarmonic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_highestHarmonic.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_highestHarmonic.ForeColor = System.Drawing.Color.Silver;
            this.label_highestHarmonic.Location = new System.Drawing.Point(5, 93);
            this.label_highestHarmonic.Name = "label_highestHarmonic";
            this.label_highestHarmonic.Size = new System.Drawing.Size(135, 20);
            this.label_highestHarmonic.TabIndex = 29;
            this.label_highestHarmonic.Text = "Highest Harmonic";
            this.label_highestHarmonic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_highestHarmonic
            // 
            this.textBox_highestHarmonic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_highestHarmonic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_highestHarmonic.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_highestHarmonic.ForeColor = System.Drawing.Color.Silver;
            this.textBox_highestHarmonic.Location = new System.Drawing.Point(12, 116);
            this.textBox_highestHarmonic.Name = "textBox_highestHarmonic";
            this.textBox_highestHarmonic.Size = new System.Drawing.Size(120, 26);
            this.textBox_highestHarmonic.TabIndex = 28;
            this.textBox_highestHarmonic.Text = "10";
            this.textBox_highestHarmonic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_highestHarmonic.TextChanged += new System.EventHandler(this.textBox_highestHarmonic_TextChanged);
            // 
            // HarmonicConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(144, 235);
            this.Controls.Add(this.label_highestHarmonic);
            this.Controls.Add(this.textBox_highestHarmonic);
            this.Controls.Add(this.label_signal);
            this.Controls.Add(this.metroComboBox_signal1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HarmonicConfigForm";
            this.Text = "SpectrumSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox_signal1;
        internal System.Windows.Forms.Label label_signal;
        internal System.Windows.Forms.Label label_highestHarmonic;
        private System.Windows.Forms.TextBox textBox_highestHarmonic;
    }
}