namespace MACOs.JY.AudioAnalyzer
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
            this.comboBox_trigType = new System.Windows.Forms.ComboBox();
            this.label_triggerType = new System.Windows.Forms.Label();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_trigCondition = new System.Windows.Forms.Label();
            this.comboBox_trigCondition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox_trigType
            // 
            this.comboBox_trigType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_trigType.FormattingEnabled = true;
            this.comboBox_trigType.Items.AddRange(new object[] {
            "Analog",
            "Digital"});
            this.comboBox_trigType.Location = new System.Drawing.Point(135, 17);
            this.comboBox_trigType.Name = "comboBox_trigType";
            this.comboBox_trigType.Size = new System.Drawing.Size(121, 20);
            this.comboBox_trigType.TabIndex = 0;
            // 
            // label_triggerType
            // 
            this.label_triggerType.AutoSize = true;
            this.label_triggerType.Location = new System.Drawing.Point(24, 21);
            this.label_triggerType.Name = "label_triggerType";
            this.label_triggerType.Size = new System.Drawing.Size(83, 12);
            this.label_triggerType.TabIndex = 1;
            this.label_triggerType.Text = "Trigger Type:";
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(32, 86);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 6;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(170, 86);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label_trigCondition
            // 
            this.label_trigCondition.AutoSize = true;
            this.label_trigCondition.Location = new System.Drawing.Point(24, 53);
            this.label_trigCondition.Name = "label_trigCondition";
            this.label_trigCondition.Size = new System.Drawing.Size(65, 12);
            this.label_trigCondition.TabIndex = 13;
            this.label_trigCondition.Text = "Condition:";
            // 
            // comboBox_trigCondition
            // 
            this.comboBox_trigCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_trigCondition.FormattingEnabled = true;
            this.comboBox_trigCondition.Items.AddRange(new object[] {
            "Rising",
            "Falling"});
            this.comboBox_trigCondition.Location = new System.Drawing.Point(135, 49);
            this.comboBox_trigCondition.Name = "comboBox_trigCondition";
            this.comboBox_trigCondition.Size = new System.Drawing.Size(121, 20);
            this.comboBox_trigCondition.TabIndex = 12;
            // 
            // TriggerConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 130);
            this.Controls.Add(this.label_trigCondition);
            this.Controls.Add(this.comboBox_trigCondition);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.label_triggerType);
            this.Controls.Add(this.comboBox_trigType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(292, 169);
            this.MinimumSize = new System.Drawing.Size(292, 169);
            this.Name = "TriggerConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trigger Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_trigType;
        private System.Windows.Forms.Label label_triggerType;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_trigCondition;
        private System.Windows.Forms.ComboBox comboBox_trigCondition;
    }
}