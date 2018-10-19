namespace DsaSoftPanel.FunctionUtility.FunctionConfigView
{
    partial class PhaseShiftConfigForm
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
            this.label_signal1 = new System.Windows.Forms.Label();
            this.label_signal2 = new System.Windows.Forms.Label();
            this.metroComboBox_signal2 = new MetroFramework.Controls.MetroComboBox();
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
            // label_signal1
            // 
            this.label_signal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_signal1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signal1.ForeColor = System.Drawing.Color.Silver;
            this.label_signal1.Location = new System.Drawing.Point(5, 19);
            this.label_signal1.Name = "label_signal1";
            this.label_signal1.Size = new System.Drawing.Size(135, 20);
            this.label_signal1.TabIndex = 25;
            this.label_signal1.Text = "Signal 1";
            this.label_signal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_signal2
            // 
            this.label_signal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_signal2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signal2.ForeColor = System.Drawing.Color.Silver;
            this.label_signal2.Location = new System.Drawing.Point(5, 90);
            this.label_signal2.Name = "label_signal2";
            this.label_signal2.Size = new System.Drawing.Size(135, 20);
            this.label_signal2.TabIndex = 27;
            this.label_signal2.Text = "Signal 2";
            this.label_signal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroComboBox_signal2
            // 
            this.metroComboBox_signal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroComboBox_signal2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_signal2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_signal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox_signal2.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox_signal2.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox_signal2.ForeColor = System.Drawing.SystemColors.Info;
            this.metroComboBox_signal2.FormattingEnabled = true;
            this.metroComboBox_signal2.ItemHeight = 19;
            this.metroComboBox_signal2.Location = new System.Drawing.Point(12, 113);
            this.metroComboBox_signal2.Name = "metroComboBox_signal2";
            this.metroComboBox_signal2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metroComboBox_signal2.Size = new System.Drawing.Size(120, 25);
            this.metroComboBox_signal2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox_signal2.StyleManager = null;
            this.metroComboBox_signal2.TabIndex = 28;
            this.metroComboBox_signal2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // PhaseShiftConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(144, 235);
            this.Controls.Add(this.metroComboBox_signal2);
            this.Controls.Add(this.label_signal2);
            this.Controls.Add(this.label_signal1);
            this.Controls.Add(this.metroComboBox_signal1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhaseShiftConfigForm";
            this.Text = "SpectrumSelectionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox_signal1;
        internal System.Windows.Forms.Label label_signal1;
        internal System.Windows.Forms.Label label_signal2;
        private MetroFramework.Controls.MetroComboBox metroComboBox_signal2;
    }
}