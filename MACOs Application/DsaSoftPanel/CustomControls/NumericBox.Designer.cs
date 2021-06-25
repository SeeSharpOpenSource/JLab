namespace CustomControls
{
    partial class NumericBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.button_up = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox_value
            // 
            this.textBox_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_value.Location = new System.Drawing.Point(1, 1);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(77, 21);
            this.textBox_value.TabIndex = 1;
            this.textBox_value.Text = "0";
            this.textBox_value.SizeChanged += new System.EventHandler(this.textBox_value_SizeChanged);
            this.textBox_value.TextChanged += new System.EventHandler(this.textBox_value_TextChanged);
            // 
            // button_up
            // 
            this.button_up.BackColor = System.Drawing.Color.Transparent;
            this.button_up.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_up.Location = new System.Drawing.Point(79, 1);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(20, 10);
            this.button_up.TabIndex = 2;
            this.button_up.UseVisualStyleBackColor = false;
            this.button_up.Click += new System.EventHandler(this.button_up_Click);
            this.button_up.Paint += new System.Windows.Forms.PaintEventHandler(this.button_up_Paint);
            // 
            // button_down
            // 
            this.button_down.BackColor = System.Drawing.Color.Transparent;
            this.button_down.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_down.Location = new System.Drawing.Point(79, 12);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(20, 10);
            this.button_down.TabIndex = 3;
            this.button_down.UseVisualStyleBackColor = false;
            this.button_down.Click += new System.EventHandler(this.button_down_Click);
            this.button_down.Paint += new System.Windows.Forms.PaintEventHandler(this.button_down_Paint);
            // 
            // NumericBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_down);
            this.Controls.Add(this.button_up);
            this.Controls.Add(this.textBox_value);
            this.Name = "NumericBox";
            this.Size = new System.Drawing.Size(100, 23);
            this.BackColorChanged += new System.EventHandler(this.NumericBox_BackColorChanged);
            this.ForeColorChanged += new System.EventHandler(this.NumericBox_ForeColorChanged);
            this.SizeChanged += new System.EventHandler(this.NumericBox_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Button button_down;
    }
}
