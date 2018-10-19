namespace DsaSoftPanel.FunctionUtility.FunctionConfigView
{
    partial class SpectrumConfigForm
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
            this.metroComboBox_window = new MetroFramework.Controls.MetroComboBox();
            this.label_window = new System.Windows.Forms.Label();
            this.textBox_windowsPara = new System.Windows.Forms.TextBox();
            this.label_windowPara = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroComboBox_window
            // 
            this.metroComboBox_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroComboBox_window.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_window.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox_window.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox_window.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox_window.ForeColor = System.Drawing.SystemColors.Info;
            this.metroComboBox_window.FormattingEnabled = true;
            this.metroComboBox_window.ItemHeight = 19;
            this.metroComboBox_window.Items.AddRange(new object[] {
            "None",
            "Hanning",
            "Hamming",
            "Blackman_Harris",
            "Exact_Blackman",
            "Blackman",
            "Flat_Top",
            "Four_Term_B_Harris",
            "Seven_Term_B_Harris"});
            this.metroComboBox_window.Location = new System.Drawing.Point(12, 42);
            this.metroComboBox_window.Name = "metroComboBox_window";
            this.metroComboBox_window.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metroComboBox_window.Size = new System.Drawing.Size(120, 25);
            this.metroComboBox_window.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox_window.StyleManager = null;
            this.metroComboBox_window.TabIndex = 1;
            this.metroComboBox_window.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_window
            // 
            this.label_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_window.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_window.ForeColor = System.Drawing.Color.Silver;
            this.label_window.Location = new System.Drawing.Point(5, 19);
            this.label_window.Name = "label_window";
            this.label_window.Size = new System.Drawing.Size(135, 20);
            this.label_window.TabIndex = 25;
            this.label_window.Text = "Window";
            this.label_window.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_windowsPara
            // 
            this.textBox_windowsPara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_windowsPara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_windowsPara.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_windowsPara.ForeColor = System.Drawing.Color.Silver;
            this.textBox_windowsPara.Location = new System.Drawing.Point(12, 104);
            this.textBox_windowsPara.Name = "textBox_windowsPara";
            this.textBox_windowsPara.Size = new System.Drawing.Size(120, 26);
            this.textBox_windowsPara.TabIndex = 26;
            this.textBox_windowsPara.Text = "0";
            this.textBox_windowsPara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_windowsPara.TextChanged += new System.EventHandler(this.textBox_windowsPara_TextChanged);
            // 
            // label_windowPara
            // 
            this.label_windowPara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_windowPara.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_windowPara.ForeColor = System.Drawing.Color.Silver;
            this.label_windowPara.Location = new System.Drawing.Point(5, 81);
            this.label_windowPara.Name = "label_windowPara";
            this.label_windowPara.Size = new System.Drawing.Size(135, 20);
            this.label_windowPara.TabIndex = 27;
            this.label_windowPara.Text = "Windows Para";
            this.label_windowPara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpectrumConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(144, 202);
            this.Controls.Add(this.label_windowPara);
            this.Controls.Add(this.textBox_windowsPara);
            this.Controls.Add(this.label_window);
            this.Controls.Add(this.metroComboBox_window);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpectrumConfigForm";
            this.Text = "SpectrumSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox_window;
        internal System.Windows.Forms.Label label_window;
        private System.Windows.Forms.TextBox textBox_windowsPara;
        internal System.Windows.Forms.Label label_windowPara;
    }
}