namespace DsaSoftPanel.Common
{
    partial class ErrorInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorInfoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_OK = new System.Windows.Forms.Button();
            this.label_message = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button_OK);
            this.panel1.Controls.Add(this.label_message);
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Controls.Add(this.pictureBox_icon);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 137);
            this.panel1.TabIndex = 0;
            // 
            // button_OK
            // 
            this.button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_OK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OK.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.ForeColor = System.Drawing.Color.Silver;
            this.button_OK.Location = new System.Drawing.Point(167, 98);
            this.button_OK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(85, 27);
            this.button_OK.TabIndex = 9;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_message
            // 
            this.label_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_message.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_message.ForeColor = System.Drawing.Color.Silver;
            this.label_message.Location = new System.Drawing.Point(98, 37);
            this.label_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(274, 58);
            this.label_message.TabIndex = 8;
            this.label_message.Text = "label1";
            // 
            // label_title
            // 
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(387, 35);
            this.label_title.TabIndex = 7;
            this.label_title.Text = "Error";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_icon.Image")));
            this.pictureBox_icon.Location = new System.Drawing.Point(16, 51);
            this.pictureBox_icon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(70, 70);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_icon.TabIndex = 6;
            this.pictureBox_icon.TabStop = false;
            // 
            // ErrorInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(392, 142);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ErrorInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ErrorInfoForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox pictureBox_icon;
    }
}