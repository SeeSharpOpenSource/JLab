using System.Windows.Forms;

namespace DsaSoftPanel
{
    partial class TriggerConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriggerConfigForm));
            this.label_title = new System.Windows.Forms.Label();
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_formButton = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_maximize = new System.Windows.Forms.Button();
            this.panel_mainPanel = new System.Windows.Forms.Panel();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.metroComboBox_triggerMode = new MetroFramework.Controls.MetroComboBox();
            this.label_triggerMode = new System.Windows.Forms.Label();
            this.txTabControl_channel = new TX.Framework.WindowUI.Controls.TXTabControl();
            this.tabPageAnalog = new System.Windows.Forms.TabPage();
            this.textBox_threshold = new System.Windows.Forms.TextBox();
            this.label_threshold = new System.Windows.Forms.Label();
            this.metroComboBox_analogTriggerCondition = new MetroFramework.Controls.MetroComboBox();
            this.label_triggerCondition = new System.Windows.Forms.Label();
            this.metroComboBox_analogTriggerChannel = new MetroFramework.Controls.MetroComboBox();
            this.label_triggerChannel = new System.Windows.Forms.Label();
            this.tabPageDigital = new System.Windows.Forms.TabPage();
            this.metroComboBox_digitalEdge = new MetroFramework.Controls.MetroComboBox();
            this.label_triggerEdge = new System.Windows.Forms.Label();
            this.metroComboBox_digitalSource = new MetroFramework.Controls.MetroComboBox();
            this.label_digitalSource = new System.Windows.Forms.Label();
            this.metroComboBox_triggerType = new MetroFramework.Controls.MetroComboBox();
            this.label_triggerType = new System.Windows.Forms.Label();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_formButton.SuspendLayout();
            this.panel_mainPanel.SuspendLayout();
            this.txTabControl_channel.SuspendLayout();
            this.tabPageAnalog.SuspendLayout();
            this.tabPageDigital.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_title.Location = new System.Drawing.Point(37, -2);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(308, 30);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "JYTEK Oscilloscope Soft Panel";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_title
            // 
            this.panel_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_title.Controls.Add(this.panel1);
            this.panel_title.Controls.Add(this.pictureBox_logo);
            this.panel_title.Controls.Add(this.panel_formButton);
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Location = new System.Drawing.Point(1, 1);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(462, 30);
            this.panel_title.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 218);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(3, 1);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(28, 28);
            this.pictureBox_logo.TabIndex = 13;
            this.pictureBox_logo.TabStop = false;
            // 
            // panel_formButton
            // 
            this.panel_formButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_formButton.Controls.Add(this.button_close);
            this.panel_formButton.Controls.Add(this.button_minimize);
            this.panel_formButton.Controls.Add(this.button_maximize);
            this.panel_formButton.Location = new System.Drawing.Point(354, 0);
            this.panel_formButton.Name = "panel_formButton";
            this.panel_formButton.Size = new System.Drawing.Size(107, 30);
            this.panel_formButton.TabIndex = 2;
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.ForeColor = System.Drawing.Color.Silver;
            this.button_close.Location = new System.Drawing.Point(76, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(30, 30);
            this.button_close.TabIndex = 5;
            this.button_close.Text = "×";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimize.ForeColor = System.Drawing.Color.Silver;
            this.button_minimize.Location = new System.Drawing.Point(6, 0);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(30, 30);
            this.button_minimize.TabIndex = 3;
            this.button_minimize.Text = "－";
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_maximize
            // 
            this.button_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_maximize.Enabled = false;
            this.button_maximize.FlatAppearance.BorderSize = 0;
            this.button_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_maximize.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_maximize.ForeColor = System.Drawing.Color.Silver;
            this.button_maximize.Location = new System.Drawing.Point(40, 0);
            this.button_maximize.Name = "button_maximize";
            this.button_maximize.Size = new System.Drawing.Size(30, 30);
            this.button_maximize.TabIndex = 4;
            this.button_maximize.Text = "□";
            this.button_maximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_maximize.UseVisualStyleBackColor = false;
            // 
            // panel_mainPanel
            // 
            this.panel_mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_mainPanel.Controls.Add(this.button_cancel);
            this.panel_mainPanel.Controls.Add(this.button_confirm);
            this.panel_mainPanel.Controls.Add(this.metroComboBox_triggerMode);
            this.panel_mainPanel.Controls.Add(this.label_triggerMode);
            this.panel_mainPanel.Controls.Add(this.txTabControl_channel);
            this.panel_mainPanel.Controls.Add(this.metroComboBox_triggerType);
            this.panel_mainPanel.Controls.Add(this.label_triggerType);
            this.panel_mainPanel.Location = new System.Drawing.Point(1, 31);
            this.panel_mainPanel.Name = "panel_mainPanel";
            this.panel_mainPanel.Size = new System.Drawing.Size(462, 194);
            this.panel_mainPanel.TabIndex = 7;
            // 
            // button_cancel
            // 
            this.button_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.Silver;
            this.button_cancel.Location = new System.Drawing.Point(136, 144);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 29);
            this.button_cancel.TabIndex = 21;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirm.ForeColor = System.Drawing.Color.Silver;
            this.button_confirm.Location = new System.Drawing.Point(30, 145);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 29);
            this.button_confirm.TabIndex = 20;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // metroComboBox_triggerMode
            // 
            this.metroComboBox_triggerMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroComboBox_triggerMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_triggerMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_triggerMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox_triggerMode.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox_triggerMode.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox_triggerMode.ForeColor = System.Drawing.SystemColors.Info;
            this.metroComboBox_triggerMode.FormattingEnabled = true;
            this.metroComboBox_triggerMode.ItemHeight = 19;
            this.metroComboBox_triggerMode.Location = new System.Drawing.Point(134, 87);
            this.metroComboBox_triggerMode.Name = "metroComboBox_triggerMode";
            this.metroComboBox_triggerMode.Size = new System.Drawing.Size(89, 25);
            this.metroComboBox_triggerMode.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox_triggerMode.StyleManager = null;
            this.metroComboBox_triggerMode.TabIndex = 18;
            this.metroComboBox_triggerMode.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_triggerMode
            // 
            this.label_triggerMode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_triggerMode.ForeColor = System.Drawing.Color.Silver;
            this.label_triggerMode.Location = new System.Drawing.Point(23, 89);
            this.label_triggerMode.Name = "label_triggerMode";
            this.label_triggerMode.Size = new System.Drawing.Size(103, 20);
            this.label_triggerMode.TabIndex = 19;
            this.label_triggerMode.Text = "Trigger Mode:";
            this.label_triggerMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txTabControl_channel
            // 
            this.txTabControl_channel.BaseTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txTabControl_channel.BorderColor = System.Drawing.Color.Gray;
            this.txTabControl_channel.CaptionFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTabControl_channel.CaptionForceColor = System.Drawing.Color.WhiteSmoke;
            this.txTabControl_channel.CheckedTabColor = System.Drawing.Color.DarkTurquoise;
            this.txTabControl_channel.Controls.Add(this.tabPageAnalog);
            this.txTabControl_channel.Controls.Add(this.tabPageDigital);
            this.txTabControl_channel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTabControl_channel.HeightLightTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTabControl_channel.Location = new System.Drawing.Point(244, 3);
            this.txTabControl_channel.Name = "txTabControl_channel";
            this.txTabControl_channel.SelectedIndex = 0;
            this.txTabControl_channel.Size = new System.Drawing.Size(212, 188);
            this.txTabControl_channel.TabCornerRadius = 3;
            this.txTabControl_channel.TabIndex = 17;
            // 
            // tabPageAnalog
            // 
            this.tabPageAnalog.Controls.Add(this.textBox_threshold);
            this.tabPageAnalog.Controls.Add(this.label_threshold);
            this.tabPageAnalog.Controls.Add(this.metroComboBox_analogTriggerCondition);
            this.tabPageAnalog.Controls.Add(this.label_triggerCondition);
            this.tabPageAnalog.Controls.Add(this.metroComboBox_analogTriggerChannel);
            this.tabPageAnalog.Controls.Add(this.label_triggerChannel);
            this.tabPageAnalog.Location = new System.Drawing.Point(4, 29);
            this.tabPageAnalog.Name = "tabPageAnalog";
            this.tabPageAnalog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnalog.Size = new System.Drawing.Size(204, 155);
            this.tabPageAnalog.TabIndex = 0;
            this.tabPageAnalog.Text = "Analog";
            this.tabPageAnalog.UseVisualStyleBackColor = true;
            // 
            // textBox_threshold
            // 
            this.textBox_threshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_threshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_threshold.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_threshold.ForeColor = System.Drawing.Color.Silver;
            this.textBox_threshold.Location = new System.Drawing.Point(119, 102);
            this.textBox_threshold.Name = "textBox_threshold";
            this.textBox_threshold.Size = new System.Drawing.Size(79, 26);
            this.textBox_threshold.TabIndex = 19;
            this.textBox_threshold.Text = "0";
            this.textBox_threshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_threshold.TextChanged += new System.EventHandler(this.textBox_threshold_TextChanged);
            // 
            // label_threshold
            // 
            this.label_threshold.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_threshold.ForeColor = System.Drawing.Color.Silver;
            this.label_threshold.Location = new System.Drawing.Point(8, 105);
            this.label_threshold.Name = "label_threshold";
            this.label_threshold.Size = new System.Drawing.Size(103, 20);
            this.label_threshold.TabIndex = 18;
            this.label_threshold.Text = "Threshold:";
            this.label_threshold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroComboBox_analogTriggerCondition
            // 
            this.metroComboBox_analogTriggerCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroComboBox_analogTriggerCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_analogTriggerCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_analogTriggerCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox_analogTriggerCondition.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox_analogTriggerCondition.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox_analogTriggerCondition.ForeColor = System.Drawing.SystemColors.Info;
            this.metroComboBox_analogTriggerCondition.FormattingEnabled = true;
            this.metroComboBox_analogTriggerCondition.ItemHeight = 19;
            this.metroComboBox_analogTriggerCondition.Location = new System.Drawing.Point(119, 62);
            this.metroComboBox_analogTriggerCondition.Name = "metroComboBox_analogTriggerCondition";
            this.metroComboBox_analogTriggerCondition.Size = new System.Drawing.Size(79, 25);
            this.metroComboBox_analogTriggerCondition.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox_analogTriggerCondition.StyleManager = null;
            this.metroComboBox_analogTriggerCondition.TabIndex = 15;
            this.metroComboBox_analogTriggerCondition.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_triggerCondition
            // 
            this.label_triggerCondition.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_triggerCondition.ForeColor = System.Drawing.Color.Silver;
            this.label_triggerCondition.Location = new System.Drawing.Point(8, 64);
            this.label_triggerCondition.Name = "label_triggerCondition";
            this.label_triggerCondition.Size = new System.Drawing.Size(103, 20);
            this.label_triggerCondition.TabIndex = 16;
            this.label_triggerCondition.Text = "Condition:";
            this.label_triggerCondition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroComboBox_analogTriggerChannel
            // 
            this.metroComboBox_analogTriggerChannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroComboBox_analogTriggerChannel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_analogTriggerChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_analogTriggerChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox_analogTriggerChannel.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox_analogTriggerChannel.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox_analogTriggerChannel.ForeColor = System.Drawing.SystemColors.Info;
            this.metroComboBox_analogTriggerChannel.FormattingEnabled = true;
            this.metroComboBox_analogTriggerChannel.ItemHeight = 19;
            this.metroComboBox_analogTriggerChannel.Location = new System.Drawing.Point(119, 23);
            this.metroComboBox_analogTriggerChannel.Name = "metroComboBox_analogTriggerChannel";
            this.metroComboBox_analogTriggerChannel.Size = new System.Drawing.Size(79, 25);
            this.metroComboBox_analogTriggerChannel.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox_analogTriggerChannel.StyleManager = null;
            this.metroComboBox_analogTriggerChannel.TabIndex = 13;
            this.metroComboBox_analogTriggerChannel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_triggerChannel
            // 
            this.label_triggerChannel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_triggerChannel.ForeColor = System.Drawing.Color.Silver;
            this.label_triggerChannel.Location = new System.Drawing.Point(8, 25);
            this.label_triggerChannel.Name = "label_triggerChannel";
            this.label_triggerChannel.Size = new System.Drawing.Size(103, 20);
            this.label_triggerChannel.TabIndex = 14;
            this.label_triggerChannel.Text = "Trigger Source:";
            this.label_triggerChannel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPageDigital
            // 
            this.tabPageDigital.Controls.Add(this.metroComboBox_digitalEdge);
            this.tabPageDigital.Controls.Add(this.label_triggerEdge);
            this.tabPageDigital.Controls.Add(this.metroComboBox_digitalSource);
            this.tabPageDigital.Controls.Add(this.label_digitalSource);
            this.tabPageDigital.Location = new System.Drawing.Point(4, 29);
            this.tabPageDigital.Name = "tabPageDigital";
            this.tabPageDigital.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDigital.Size = new System.Drawing.Size(204, 155);
            this.tabPageDigital.TabIndex = 1;
            this.tabPageDigital.Text = "Digital";
            this.tabPageDigital.UseVisualStyleBackColor = true;
            // 
            // metroComboBox_digitalEdge
            // 
            this.metroComboBox_digitalEdge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroComboBox_digitalEdge.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_digitalEdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_digitalEdge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox_digitalEdge.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox_digitalEdge.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox_digitalEdge.ForeColor = System.Drawing.SystemColors.Info;
            this.metroComboBox_digitalEdge.FormattingEnabled = true;
            this.metroComboBox_digitalEdge.ItemHeight = 19;
            this.metroComboBox_digitalEdge.Location = new System.Drawing.Point(118, 84);
            this.metroComboBox_digitalEdge.Name = "metroComboBox_digitalEdge";
            this.metroComboBox_digitalEdge.Size = new System.Drawing.Size(79, 25);
            this.metroComboBox_digitalEdge.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox_digitalEdge.StyleManager = null;
            this.metroComboBox_digitalEdge.TabIndex = 19;
            this.metroComboBox_digitalEdge.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_triggerEdge
            // 
            this.label_triggerEdge.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_triggerEdge.ForeColor = System.Drawing.Color.Silver;
            this.label_triggerEdge.Location = new System.Drawing.Point(7, 86);
            this.label_triggerEdge.Name = "label_triggerEdge";
            this.label_triggerEdge.Size = new System.Drawing.Size(103, 20);
            this.label_triggerEdge.TabIndex = 20;
            this.label_triggerEdge.Text = "Trigger Edge:";
            this.label_triggerEdge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroComboBox_digitalSource
            // 
            this.metroComboBox_digitalSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroComboBox_digitalSource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_digitalSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_digitalSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox_digitalSource.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox_digitalSource.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox_digitalSource.ForeColor = System.Drawing.SystemColors.Info;
            this.metroComboBox_digitalSource.FormattingEnabled = true;
            this.metroComboBox_digitalSource.ItemHeight = 19;
            this.metroComboBox_digitalSource.Location = new System.Drawing.Point(118, 45);
            this.metroComboBox_digitalSource.Name = "metroComboBox_digitalSource";
            this.metroComboBox_digitalSource.Size = new System.Drawing.Size(79, 25);
            this.metroComboBox_digitalSource.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox_digitalSource.StyleManager = null;
            this.metroComboBox_digitalSource.TabIndex = 17;
            this.metroComboBox_digitalSource.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_digitalSource
            // 
            this.label_digitalSource.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_digitalSource.ForeColor = System.Drawing.Color.Silver;
            this.label_digitalSource.Location = new System.Drawing.Point(7, 47);
            this.label_digitalSource.Name = "label_digitalSource";
            this.label_digitalSource.Size = new System.Drawing.Size(103, 20);
            this.label_digitalSource.TabIndex = 18;
            this.label_digitalSource.Text = "Trigger Source:";
            this.label_digitalSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroComboBox_triggerType
            // 
            this.metroComboBox_triggerType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroComboBox_triggerType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_triggerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_triggerType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox_triggerType.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox_triggerType.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox_triggerType.ForeColor = System.Drawing.SystemColors.Info;
            this.metroComboBox_triggerType.FormattingEnabled = true;
            this.metroComboBox_triggerType.ItemHeight = 19;
            this.metroComboBox_triggerType.Location = new System.Drawing.Point(134, 27);
            this.metroComboBox_triggerType.Name = "metroComboBox_triggerType";
            this.metroComboBox_triggerType.Size = new System.Drawing.Size(89, 25);
            this.metroComboBox_triggerType.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox_triggerType.StyleManager = null;
            this.metroComboBox_triggerType.TabIndex = 15;
            this.metroComboBox_triggerType.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_triggerType
            // 
            this.label_triggerType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_triggerType.ForeColor = System.Drawing.Color.Silver;
            this.label_triggerType.Location = new System.Drawing.Point(23, 29);
            this.label_triggerType.Name = "label_triggerType";
            this.label_triggerType.Size = new System.Drawing.Size(103, 20);
            this.label_triggerType.TabIndex = 16;
            this.label_triggerType.Text = "Trigger Type:";
            this.label_triggerType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TriggerConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(464, 226);
            this.Controls.Add(this.panel_mainPanel);
            this.Controls.Add(this.panel_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TriggerConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OscilloscopeSoftPanelForm";
            this.Load += new System.EventHandler(this.TriggerConfigForm_Load);
            this.panel_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_formButton.ResumeLayout(false);
            this.panel_mainPanel.ResumeLayout(false);
            this.txTabControl_channel.ResumeLayout(false);
            this.tabPageAnalog.ResumeLayout(false);
            this.tabPageAnalog.PerformLayout();
            this.tabPageDigital.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label label_title;
        private Panel panel_title;
        private Panel panel_formButton;
        internal Button button_minimize;
        internal Button button_close;
        internal Button button_maximize;
        private PictureBox pictureBox_logo;
        private Panel panel1;
        private Panel panel_mainPanel;
        internal TX.Framework.WindowUI.Controls.TXTabControl txTabControl_channel;
        private TabPage tabPageDigital;
        private TabPage tabPageAnalog;
        private MetroFramework.Controls.MetroComboBox metroComboBox_triggerType;
        private Label label_triggerType;
        private MetroFramework.Controls.MetroComboBox metroComboBox_analogTriggerChannel;
        private Label label_triggerChannel;
        private MetroFramework.Controls.MetroComboBox metroComboBox_triggerMode;
        private Label label_triggerMode;
        private Button button_cancel;
        private Button button_confirm;
        private MetroFramework.Controls.MetroComboBox metroComboBox_analogTriggerCondition;
        private Label label_triggerCondition;
        private Label label_threshold;
        private TextBox textBox_threshold;
        private MetroFramework.Controls.MetroComboBox metroComboBox_digitalEdge;
        private Label label_triggerEdge;
        private MetroFramework.Controls.MetroComboBox metroComboBox_digitalSource;
        private Label label_digitalSource;
    }
}