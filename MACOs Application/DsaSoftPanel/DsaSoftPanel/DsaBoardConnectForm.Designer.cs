namespace DsaSoftPanel
{
    partial class DsaBoardConnectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DsaBoardConnectForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroComboBox_cardId = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox_boardType = new MetroFramework.Controls.MetroComboBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.led_status = new SeeSharpTools.JY.GUI.LED();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.metroComboBox_cardId);
            this.panel1.Controls.Add(this.metroComboBox_boardType);
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.button_connect);
            this.panel1.Controls.Add(this.pictureBox_icon);
            this.panel1.Controls.Add(this.led_status);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 114);
            this.panel1.TabIndex = 0;
            // 
            // metroComboBox_cardId
            // 
            this.metroComboBox_cardId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroComboBox_cardId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_cardId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_cardId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox_cardId.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox_cardId.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox_cardId.ForeColor = System.Drawing.SystemColors.Info;
            this.metroComboBox_cardId.FormattingEnabled = true;
            this.metroComboBox_cardId.ItemHeight = 19;
            this.metroComboBox_cardId.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.metroComboBox_cardId.Location = new System.Drawing.Point(209, 37);
            this.metroComboBox_cardId.Name = "metroComboBox_cardId";
            this.metroComboBox_cardId.Size = new System.Drawing.Size(121, 25);
            this.metroComboBox_cardId.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox_cardId.StyleManager = null;
            this.metroComboBox_cardId.TabIndex = 17;
            this.metroComboBox_cardId.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox_cardId.SelectedIndexChanged += new System.EventHandler(this.RefreshLedStatus);
            // 
            // metroComboBox_boardType
            // 
            this.metroComboBox_boardType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroComboBox_boardType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_boardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_boardType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox_boardType.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox_boardType.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox_boardType.ForeColor = System.Drawing.SystemColors.Info;
            this.metroComboBox_boardType.FormattingEnabled = true;
            this.metroComboBox_boardType.ItemHeight = 19;
            this.metroComboBox_boardType.Items.AddRange(new object[] {
            "JYPCI69527",
            "JYPXI69527",
            "JYPXIe69529"});
            this.metroComboBox_boardType.Location = new System.Drawing.Point(209, 6);
            this.metroComboBox_boardType.Name = "metroComboBox_boardType";
            this.metroComboBox_boardType.Size = new System.Drawing.Size(121, 25);
            this.metroComboBox_boardType.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox_boardType.StyleManager = null;
            this.metroComboBox_boardType.TabIndex = 16;
            this.metroComboBox_boardType.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // button_cancel
            // 
            this.button_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.Silver;
            this.button_cancel.Location = new System.Drawing.Point(241, 69);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 29);
            this.button_cancel.TabIndex = 11;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_connect
            // 
            this.button_connect.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connect.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_connect.ForeColor = System.Drawing.Color.Silver;
            this.button_connect.Location = new System.Drawing.Point(135, 70);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 29);
            this.button_connect.TabIndex = 10;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_icon.Image")));
            this.pictureBox_icon.InitialImage = null;
            this.pictureBox_icon.Location = new System.Drawing.Point(18, 6);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(103, 95);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_icon.TabIndex = 9;
            this.pictureBox_icon.TabStop = false;
            // 
            // led_status
            // 
            this.led_status.BlinkColor = System.Drawing.Color.Lime;
            this.led_status.BlinkInterval = 1000;
            this.led_status.BlinkOn = false;
            this.led_status.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.led_status.Interacton = SeeSharpTools.JY.GUI.LED.InteractionStyle.Indicator;
            this.led_status.Location = new System.Drawing.Point(127, 2);
            this.led_status.Name = "led_status";
            this.led_status.OffColor = System.Drawing.Color.Maroon;
            this.led_status.OnColor = System.Drawing.Color.Lime;
            this.led_status.Size = new System.Drawing.Size(59, 60);
            this.led_status.Style = SeeSharpTools.JY.GUI.LED.LedStyle.Rectangular3D;
            this.led_status.TabIndex = 6;
            this.led_status.Value = false;
            // 
            // DsaBoardConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(364, 122);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DsaBoardConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConnectBoard";
            this.Load += new System.EventHandler(this.DsaBoardConnectForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.PictureBox pictureBox_icon;
        private SeeSharpTools.JY.GUI.LED led_status;
        private MetroFramework.Controls.MetroComboBox metroComboBox_boardType;
        private MetroFramework.Controls.MetroComboBox metroComboBox_cardId;
    }
}

