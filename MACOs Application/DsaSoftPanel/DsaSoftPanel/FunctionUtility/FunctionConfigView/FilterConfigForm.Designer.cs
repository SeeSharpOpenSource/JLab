namespace DsaSoftPanel.FunctionUtility.FunctionConfigView
{
    partial class FilterConfigForm
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
            this.metroComboBox_type = new MetroFramework.Controls.MetroComboBox();
            this.label_type = new System.Windows.Forms.Label();
            this.textBox_lowerCutoff = new System.Windows.Forms.TextBox();
            this.label_lowerCutoff = new System.Windows.Forms.Label();
            this.label_highCutoff = new System.Windows.Forms.Label();
            this.textBox_highCutoff = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // metroComboBox_type
            // 
            this.metroComboBox_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroComboBox_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox_type.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox_type.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox_type.ForeColor = System.Drawing.SystemColors.Info;
            this.metroComboBox_type.FormattingEnabled = true;
            this.metroComboBox_type.ItemHeight = 19;
            this.metroComboBox_type.Items.AddRange(new object[] {
            "LowPass",
            "HighPass",
            "BandPass",
            "BandStop"});
            this.metroComboBox_type.Location = new System.Drawing.Point(12, 42);
            this.metroComboBox_type.Name = "metroComboBox_type";
            this.metroComboBox_type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metroComboBox_type.Size = new System.Drawing.Size(120, 25);
            this.metroComboBox_type.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox_type.StyleManager = null;
            this.metroComboBox_type.TabIndex = 1;
            this.metroComboBox_type.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox_type.SelectedIndexChanged += new System.EventHandler(this.metroComboBox_type_SelectedIndexChanged);
            // 
            // label_type
            // 
            this.label_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type.ForeColor = System.Drawing.Color.Silver;
            this.label_type.Location = new System.Drawing.Point(5, 19);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(135, 20);
            this.label_type.TabIndex = 25;
            this.label_type.Text = "Filter Type";
            this.label_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_lowerCutoff
            // 
            this.textBox_lowerCutoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_lowerCutoff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_lowerCutoff.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lowerCutoff.ForeColor = System.Drawing.Color.Silver;
            this.textBox_lowerCutoff.Location = new System.Drawing.Point(12, 113);
            this.textBox_lowerCutoff.Name = "textBox_lowerCutoff";
            this.textBox_lowerCutoff.Size = new System.Drawing.Size(120, 26);
            this.textBox_lowerCutoff.TabIndex = 26;
            this.textBox_lowerCutoff.Text = "100";
            this.textBox_lowerCutoff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_lowerCutoff.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label_lowerCutoff
            // 
            this.label_lowerCutoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_lowerCutoff.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lowerCutoff.ForeColor = System.Drawing.Color.Silver;
            this.label_lowerCutoff.Location = new System.Drawing.Point(5, 90);
            this.label_lowerCutoff.Name = "label_lowerCutoff";
            this.label_lowerCutoff.Size = new System.Drawing.Size(135, 20);
            this.label_lowerCutoff.TabIndex = 27;
            this.label_lowerCutoff.Text = "Low Cutoff(Hz)";
            this.label_lowerCutoff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_highCutoff
            // 
            this.label_highCutoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_highCutoff.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_highCutoff.ForeColor = System.Drawing.Color.Silver;
            this.label_highCutoff.Location = new System.Drawing.Point(5, 157);
            this.label_highCutoff.Name = "label_highCutoff";
            this.label_highCutoff.Size = new System.Drawing.Size(135, 20);
            this.label_highCutoff.TabIndex = 29;
            this.label_highCutoff.Text = "High Cutoff(Hz)";
            this.label_highCutoff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_highCutoff
            // 
            this.textBox_highCutoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_highCutoff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_highCutoff.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_highCutoff.ForeColor = System.Drawing.Color.Silver;
            this.textBox_highCutoff.Location = new System.Drawing.Point(12, 180);
            this.textBox_highCutoff.Name = "textBox_highCutoff";
            this.textBox_highCutoff.Size = new System.Drawing.Size(120, 26);
            this.textBox_highCutoff.TabIndex = 28;
            this.textBox_highCutoff.Text = "1000";
            this.textBox_highCutoff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_highCutoff.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // FilterConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(144, 235);
            this.Controls.Add(this.label_highCutoff);
            this.Controls.Add(this.textBox_highCutoff);
            this.Controls.Add(this.label_lowerCutoff);
            this.Controls.Add(this.textBox_lowerCutoff);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.metroComboBox_type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilterConfigForm";
            this.Text = "SpectrumSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox_type;
        internal System.Windows.Forms.Label label_type;
        private System.Windows.Forms.TextBox textBox_lowerCutoff;
        internal System.Windows.Forms.Label label_lowerCutoff;
        internal System.Windows.Forms.Label label_highCutoff;
        private System.Windows.Forms.TextBox textBox_highCutoff;
    }
}