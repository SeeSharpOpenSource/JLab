namespace DEMO
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.easyDAQ61902DI1 = new EasyDAQ.EasyDAQ61902DI(this.components);
            this.easyDAQ61902DO1 = new EasyDAQ.EasyDAQ61902DO(this.components);
            this.ledArray1 = new SeeSharpTools.JY.GUI.LEDArray();
            this.industrySwitch0 = new SeeSharpTools.JY.GUI.IndustrySwitch();
            this.industrySwitch3 = new SeeSharpTools.JY.GUI.IndustrySwitch();
            this.industrySwitch2 = new SeeSharpTools.JY.GUI.IndustrySwitch();
            this.industrySwitch1 = new SeeSharpTools.JY.GUI.IndustrySwitch();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // buttonStart
            // 
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // easyDAQ61902DI1
            // 
            this.easyDAQ61902DI1.BoardID = 0;
            this.easyDAQ61902DI1.Channels = ((System.Collections.Generic.List<int>)(resources.GetObject("easyDAQ61902DI1.Channels")));
            this.easyDAQ61902DI1.DataReceived += new System.EventHandler<System.EventArgs>(this.easyDAQ61902DI1_DataReceived);
            // 
            // easyDAQ61902DO1
            // 
            this.easyDAQ61902DO1.BoardID = 0;
            this.easyDAQ61902DO1.Channels = ((System.Collections.Generic.List<int>)(resources.GetObject("easyDAQ61902DO1.Channels")));
            // 
            // ledArray1
            // 
            this.ledArray1.ControlHeight = 40;
            this.ledArray1.ControlWidth = 40;
            this.ledArray1.Dimension = ((uint)(4u));
            this.ledArray1.Direction = false;
            this.ledArray1.LEDOffColor = System.Drawing.Color.Gray;
            this.ledArray1.LEDOnColor = System.Drawing.Color.Lime;
            this.ledArray1.LEDStyle = SeeSharpTools.JY.GUI.LED.LedStyle.Circular;
            resources.ApplyResources(this.ledArray1, "ledArray1");
            this.ledArray1.Name = "ledArray1";
            this.ledArray1.Value = new bool[] {
        false,
        false,
        false,
        false};
            // 
            // industrySwitch0
            // 
            this.industrySwitch0.BackColor = System.Drawing.Color.Transparent;
            this.industrySwitch0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.industrySwitch0.Interacton = SeeSharpTools.JY.GUI.IndustrySwitch.InteractionStyle.SwitchWhenPressed;
            resources.ApplyResources(this.industrySwitch0, "industrySwitch0");
            this.industrySwitch0.Name = "industrySwitch0";
            this.industrySwitch0.OffColor = System.Drawing.Color.Silver;
            this.industrySwitch0.OnColor = System.Drawing.Color.Silver;
            this.industrySwitch0.Style = SeeSharpTools.JY.GUI.IndustrySwitch.SwitchStyles.Vertical;
            this.industrySwitch0.Value = false;
            this.industrySwitch0.ValueChanged += new System.EventHandler(this.industrySwitch0_ValueChanged);
            // 
            // industrySwitch3
            // 
            this.industrySwitch3.BackColor = System.Drawing.Color.Transparent;
            this.industrySwitch3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.industrySwitch3.Interacton = SeeSharpTools.JY.GUI.IndustrySwitch.InteractionStyle.SwitchWhenPressed;
            resources.ApplyResources(this.industrySwitch3, "industrySwitch3");
            this.industrySwitch3.Name = "industrySwitch3";
            this.industrySwitch3.OffColor = System.Drawing.Color.Silver;
            this.industrySwitch3.OnColor = System.Drawing.Color.Silver;
            this.industrySwitch3.Style = SeeSharpTools.JY.GUI.IndustrySwitch.SwitchStyles.Vertical;
            this.industrySwitch3.Value = false;
            this.industrySwitch3.ValueChanged += new System.EventHandler(this.industrySwitch0_ValueChanged);
            // 
            // industrySwitch2
            // 
            this.industrySwitch2.BackColor = System.Drawing.Color.Transparent;
            this.industrySwitch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.industrySwitch2.Interacton = SeeSharpTools.JY.GUI.IndustrySwitch.InteractionStyle.SwitchWhenPressed;
            resources.ApplyResources(this.industrySwitch2, "industrySwitch2");
            this.industrySwitch2.Name = "industrySwitch2";
            this.industrySwitch2.OffColor = System.Drawing.Color.Silver;
            this.industrySwitch2.OnColor = System.Drawing.Color.Silver;
            this.industrySwitch2.Style = SeeSharpTools.JY.GUI.IndustrySwitch.SwitchStyles.Vertical;
            this.industrySwitch2.Value = false;
            this.industrySwitch2.ValueChanged += new System.EventHandler(this.industrySwitch0_ValueChanged);
            // 
            // industrySwitch1
            // 
            this.industrySwitch1.BackColor = System.Drawing.Color.Transparent;
            this.industrySwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.industrySwitch1.Interacton = SeeSharpTools.JY.GUI.IndustrySwitch.InteractionStyle.SwitchWhenPressed;
            resources.ApplyResources(this.industrySwitch1, "industrySwitch1");
            this.industrySwitch1.Name = "industrySwitch1";
            this.industrySwitch1.OffColor = System.Drawing.Color.Silver;
            this.industrySwitch1.OnColor = System.Drawing.Color.Silver;
            this.industrySwitch1.Style = SeeSharpTools.JY.GUI.IndustrySwitch.SwitchStyles.Vertical;
            this.industrySwitch1.Value = false;
            this.industrySwitch1.ValueChanged += new System.EventHandler(this.industrySwitch0_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Name = "label11";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label11);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.ledArray1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.industrySwitch0);
            this.Controls.Add(this.industrySwitch3);
            this.Controls.Add(this.industrySwitch2);
            this.Controls.Add(this.industrySwitch1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
      
        private SeeSharpTools.JY.GUI.IndustrySwitch industrySwitch1;
        private SeeSharpTools.JY.GUI.IndustrySwitch industrySwitch2;
        private SeeSharpTools.JY.GUI.IndustrySwitch industrySwitch3;
        private SeeSharpTools.JY.GUI.IndustrySwitch industrySwitch0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private SeeSharpTools.JY.GUI.LEDArray ledArray1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonStart;
        private EasyDAQ.EasyDAQ61902DI easyDAQ61902DI1;
        private EasyDAQ.EasyDAQ61902DO easyDAQ61902DO1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label11;
    }
}

