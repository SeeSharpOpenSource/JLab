namespace StreamingAndPlaybackDemo
{
    partial class FormMeasurementItemsSelect
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
            this.checkBox_SelectAll = new System.Windows.Forms.CheckBox();
            this.checkedListBox_MeasureItems1 = new System.Windows.Forms.CheckedListBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox_SelectAll
            // 
            this.checkBox_SelectAll.AutoSize = true;
            this.checkBox_SelectAll.Location = new System.Drawing.Point(572, 38);
            this.checkBox_SelectAll.Name = "checkBox_SelectAll";
            this.checkBox_SelectAll.Size = new System.Drawing.Size(48, 16);
            this.checkBox_SelectAll.TabIndex = 36;
            this.checkBox_SelectAll.Text = "全选";
            this.checkBox_SelectAll.UseVisualStyleBackColor = true;
            this.checkBox_SelectAll.CheckedChanged += new System.EventHandler(this.checkBox_SelectAll_CheckedChanged);
            // 
            // checkedListBox_MeasureItems1
            // 
            this.checkedListBox_MeasureItems1.FormattingEnabled = true;
            this.checkedListBox_MeasureItems1.Location = new System.Drawing.Point(32, 38);
            this.checkedListBox_MeasureItems1.MultiColumn = true;
            this.checkedListBox_MeasureItems1.Name = "checkedListBox_MeasureItems1";
            this.checkedListBox_MeasureItems1.Size = new System.Drawing.Size(522, 228);
            this.checkedListBox_MeasureItems1.TabIndex = 35;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(572, 89);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 43);
            this.buttonOK.TabIndex = 37;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(572, 152);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 43);
            this.buttonCancel.TabIndex = 38;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormMeasurementItemsSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 300);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkBox_SelectAll);
            this.Controls.Add(this.checkedListBox_MeasureItems1);
            this.Name = "FormMeasurementItemsSelect";
            this.Text = "FormMeasurementItemsSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_SelectAll;
        private System.Windows.Forms.CheckedListBox checkedListBox_MeasureItems1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}