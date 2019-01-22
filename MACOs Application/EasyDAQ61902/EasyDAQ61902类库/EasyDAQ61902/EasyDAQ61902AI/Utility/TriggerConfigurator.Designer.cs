namespace EasyDAQ
{
    partial class TriggerConfigurator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriggerConfigurator));
            this.easyButton_prevLevel = new SeeSharpTools.JY.GUI.EasyButton();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.easyButton_nextLevel = new SeeSharpTools.JY.GUI.EasyButton();
            this.easyButton_confirm = new SeeSharpTools.JY.GUI.EasyButton();
            this.SuspendLayout();
            // 
            // easyButton_prevLevel
            // 
            this.easyButton_prevLevel.Image = ((System.Drawing.Image)(resources.GetObject("easyButton_prevLevel.Image")));
            this.easyButton_prevLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.easyButton_prevLevel.Location = new System.Drawing.Point(56, 297);
            this.easyButton_prevLevel.Name = "easyButton_prevLevel";
            this.easyButton_prevLevel.PreSetImage = SeeSharpTools.JY.GUI.EasyButton.ButtonPresetImage.Back;
            this.easyButton_prevLevel.Size = new System.Drawing.Size(114, 32);
            this.easyButton_prevLevel.TabIndex = 0;
            this.easyButton_prevLevel.Text = "Prev. Level";
            this.easyButton_prevLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.easyButton_prevLevel.Click += new System.EventHandler(this.easyButton_prevLevel_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyGrid1.Location = new System.Drawing.Point(32, 48);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(307, 230);
            this.propertyGrid1.TabIndex = 1;
            this.propertyGrid1.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.propertyGrid1_SelectedGridItemChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 21);
            this.textBox1.TabIndex = 2;
            // 
            // easyButton_nextLevel
            // 
            this.easyButton_nextLevel.Image = ((System.Drawing.Image)(resources.GetObject("easyButton_nextLevel.Image")));
            this.easyButton_nextLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.easyButton_nextLevel.Location = new System.Drawing.Point(212, 297);
            this.easyButton_nextLevel.Name = "easyButton_nextLevel";
            this.easyButton_nextLevel.PreSetImage = SeeSharpTools.JY.GUI.EasyButton.ButtonPresetImage.Go;
            this.easyButton_nextLevel.Size = new System.Drawing.Size(108, 32);
            this.easyButton_nextLevel.TabIndex = 1;
            this.easyButton_nextLevel.Text = "Next Level";
            this.easyButton_nextLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.easyButton_nextLevel.Click += new System.EventHandler(this.easyButton_nextLevel_Click);
            // 
            // easyButton_confirm
            // 
            this.easyButton_confirm.Image = ((System.Drawing.Image)(resources.GetObject("easyButton_confirm.Image")));
            this.easyButton_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.easyButton_confirm.Location = new System.Drawing.Point(140, 354);
            this.easyButton_confirm.Name = "easyButton_confirm";
            this.easyButton_confirm.PreSetImage = SeeSharpTools.JY.GUI.EasyButton.ButtonPresetImage.Check;
            this.easyButton_confirm.Size = new System.Drawing.Size(108, 32);
            this.easyButton_confirm.TabIndex = 1;
            this.easyButton_confirm.Text = "Confirm";
            this.easyButton_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.easyButton_confirm.Click += new System.EventHandler(this.easyButton_confirm_Click);
            // 
            // TriggerConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 400);
            this.ControlBox = false;
            this.Controls.Add(this.easyButton_confirm);
            this.Controls.Add(this.easyButton_nextLevel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.easyButton_prevLevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TriggerConfigurator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TriggerConfigurator";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeeSharpTools.JY.GUI.EasyButton easyButton_prevLevel;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TextBox textBox1;
        private SeeSharpTools.JY.GUI.EasyButton easyButton_nextLevel;
        private SeeSharpTools.JY.GUI.EasyButton easyButton_confirm;
    }
}