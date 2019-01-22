namespace EasyDAQ
{
    partial class ChannelSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChannelSelector));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxAllChannels = new System.Windows.Forms.CheckBox();
            this.cklChannelsSelect = new System.Windows.Forms.CheckedListBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbxAllChannels);
            this.groupBox1.Controls.Add(this.cklChannelsSelect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 98);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通道参数";
            // 
            // CbxAllChannels
            // 
            this.CbxAllChannels.AutoSize = true;
            this.CbxAllChannels.Location = new System.Drawing.Point(9, 45);
            this.CbxAllChannels.Name = "CbxAllChannels";
            this.CbxAllChannels.Size = new System.Drawing.Size(60, 16);
            this.CbxAllChannels.TabIndex = 9;
            this.CbxAllChannels.Text = "全通道";
            this.CbxAllChannels.UseVisualStyleBackColor = true;
            this.CbxAllChannels.CheckedChanged += new System.EventHandler(this.CbxAllChannels_CheckedChanged);
            // 
            // cklChannelsSelect
            // 
            this.cklChannelsSelect.FormattingEnabled = true;
            this.cklChannelsSelect.Location = new System.Drawing.Point(75, 20);
            this.cklChannelsSelect.Name = "cklChannelsSelect";
            this.cklChannelsSelect.Size = new System.Drawing.Size(161, 68);
            this.cklChannelsSelect.TabIndex = 8;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(145, 136);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(21, 136);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 15;
            this.btn_Ok.Text = "确认";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // ChannelSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 183);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChannelSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChannelSelector";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CbxAllChannels;
        public System.Windows.Forms.CheckedListBox cklChannelsSelect;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
    }
}