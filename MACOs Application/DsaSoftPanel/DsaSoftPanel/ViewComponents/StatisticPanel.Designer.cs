namespace DsaSoftPanel.ViewComponents
{
    partial class StatisticPanel
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
            this.label_maxName = new System.Windows.Forms.Label();
            this.label_minValue = new System.Windows.Forms.Label();
            this.label_minName = new System.Windows.Forms.Label();
            this.label_index = new System.Windows.Forms.Label();
            this.label_maxValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_maxName
            // 
            this.label_maxName.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maxName.ForeColor = System.Drawing.Color.Black;
            this.label_maxName.Location = new System.Drawing.Point(17, 1);
            this.label_maxName.Name = "label_maxName";
            this.label_maxName.Size = new System.Drawing.Size(47, 17);
            this.label_maxName.TabIndex = 0;
            this.label_maxName.Text = "MAX:";
            this.label_maxName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_minValue
            // 
            this.label_minValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_minValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_minValue.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_minValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_minValue.Location = new System.Drawing.Point(164, 1);
            this.label_minValue.Name = "label_minValue";
            this.label_minValue.Size = new System.Drawing.Size(70, 17);
            this.label_minValue.TabIndex = 3;
            this.label_minValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_minName
            // 
            this.label_minName.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_minName.ForeColor = System.Drawing.Color.Black;
            this.label_minName.Location = new System.Drawing.Point(126, 1);
            this.label_minName.Name = "label_minName";
            this.label_minName.Size = new System.Drawing.Size(46, 17);
            this.label_minName.TabIndex = 2;
            this.label_minName.Text = "MIN:";
            this.label_minName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_index
            // 
            this.label_index.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_index.ForeColor = System.Drawing.Color.Black;
            this.label_index.Location = new System.Drawing.Point(3, 0);
            this.label_index.Name = "label_index";
            this.label_index.Size = new System.Drawing.Size(20, 18);
            this.label_index.TabIndex = 4;
            this.label_index.Text = "1";
            this.label_index.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_maxValue
            // 
            this.label_maxValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_maxValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_maxValue.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maxValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_maxValue.Location = new System.Drawing.Point(56, 1);
            this.label_maxValue.Name = "label_maxValue";
            this.label_maxValue.Size = new System.Drawing.Size(70, 17);
            this.label_maxValue.TabIndex = 5;
            this.label_maxValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatisticPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(242, 19);
            this.Controls.Add(this.label_maxValue);
            this.Controls.Add(this.label_index);
            this.Controls.Add(this.label_minValue);
            this.Controls.Add(this.label_minName);
            this.Controls.Add(this.label_maxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticPanel";
            this.Text = "StatisticPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_maxName;
        private System.Windows.Forms.Label label_minValue;
        private System.Windows.Forms.Label label_minName;
        private System.Windows.Forms.Label label_index;
        private System.Windows.Forms.Label label_maxValue;
    }
}