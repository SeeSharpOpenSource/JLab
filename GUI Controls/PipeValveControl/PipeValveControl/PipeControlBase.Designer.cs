namespace PipeValveControl
{
    partial class PipeControlBase
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
            this.pictureBox_pipeView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipeView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_pipeView
            // 
            this.pictureBox_pipeView.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_pipeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_pipeView.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_pipeView.Name = "pictureBox_pipeView";
            this.pictureBox_pipeView.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_pipeView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pipeView.TabIndex = 0;
            this.pictureBox_pipeView.TabStop = false;
            // 
            // PipeControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox_pipeView);
            this.Name = "PipeControlBase";
            this.Move += new System.EventHandler(this.PipeControlBase_Move);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipeView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_pipeView;
    }
}
