namespace PipeValveDemo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button_on = new System.Windows.Forms.Button();
            this.button_off = new System.Windows.Forms.Button();
            this.button_alert = new System.Windows.Forms.Button();
            this.button_blink = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.timer_blink = new System.Windows.Forms.Timer(this.components);
            this.downNodePipe1 = new PipeValveControl.DownNodePipe();
            this.verticalValve1 = new PipeValveControl.VerticalValve();
            this.verticalPipe1 = new PipeValveControl.VerticalPipe();
            this.verticalGage1 = new PipeValveControl.VerticalGage();
            this.upToRightPipe1 = new PipeValveControl.UpToRightPipe();
            this.upToLeftPipe1 = new PipeValveControl.UpToLeftPipe();
            this.upsideTPipe1 = new PipeValveControl.UpsideTPipe();
            this.upPipeCap1 = new PipeValveControl.UpPipeCap();
            this.upNodePipe1 = new PipeValveControl.UpNodePipe();
            this.rightsideTPipe1 = new PipeValveControl.RightsideTPipe();
            this.rightPipeCap1 = new PipeValveControl.RightPipeCap();
            this.rightNodePipe1 = new PipeValveControl.RightNodePipe();
            this.leftsideTPipe1 = new PipeValveControl.LeftsideTPipe();
            this.leftPipeCap1 = new PipeValveControl.LeftPipeCap();
            this.leftNodePipe1 = new PipeValveControl.LeftNodePipe();
            this.horizentalValve1 = new PipeValveControl.HorizentalValve();
            this.horizentalPipe1 = new PipeValveControl.HorizentalPipe();
            this.horizentalGage1 = new PipeValveControl.HorizentalGage();
            this.downToRightPipe1 = new PipeValveControl.DownToRightPipe();
            this.downToLeftPipe1 = new PipeValveControl.DownToLeftPipe();
            this.downsideTPipe1 = new PipeValveControl.DownsideTPipe();
            this.downPipeCap1 = new PipeValveControl.DownPipeCap();
            this.crossPipe1 = new PipeValveControl.CrossPipe();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_on
            // 
            this.button_on.Location = new System.Drawing.Point(440, 415);
            this.button_on.Margin = new System.Windows.Forms.Padding(4);
            this.button_on.Name = "button_on";
            this.button_on.Size = new System.Drawing.Size(100, 29);
            this.button_on.TabIndex = 23;
            this.button_on.Text = "On";
            this.button_on.UseVisualStyleBackColor = true;
            this.button_on.Click += new System.EventHandler(this.button_on_Click);
            // 
            // button_off
            // 
            this.button_off.Location = new System.Drawing.Point(440, 500);
            this.button_off.Margin = new System.Windows.Forms.Padding(4);
            this.button_off.Name = "button_off";
            this.button_off.Size = new System.Drawing.Size(100, 29);
            this.button_off.TabIndex = 24;
            this.button_off.Text = "Off";
            this.button_off.UseVisualStyleBackColor = true;
            this.button_off.Click += new System.EventHandler(this.button_off_Click);
            // 
            // button_alert
            // 
            this.button_alert.Location = new System.Drawing.Point(440, 585);
            this.button_alert.Margin = new System.Windows.Forms.Padding(4);
            this.button_alert.Name = "button_alert";
            this.button_alert.Size = new System.Drawing.Size(100, 29);
            this.button_alert.TabIndex = 25;
            this.button_alert.Text = "Alert";
            this.button_alert.UseVisualStyleBackColor = true;
            this.button_alert.Click += new System.EventHandler(this.button_alert_Click);
            // 
            // button_blink
            // 
            this.button_blink.Location = new System.Drawing.Point(567, 454);
            this.button_blink.Margin = new System.Windows.Forms.Padding(4);
            this.button_blink.Name = "button_blink";
            this.button_blink.Size = new System.Drawing.Size(100, 29);
            this.button_blink.TabIndex = 26;
            this.button_blink.Text = "Blink";
            this.button_blink.UseVisualStyleBackColor = true;
            this.button_blink.Click += new System.EventHandler(this.button_blink_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(567, 539);
            this.button_stop.Margin = new System.Windows.Forms.Padding(4);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(100, 29);
            this.button_stop.TabIndex = 27;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // timer_blink
            // 
            this.timer_blink.Interval = 500;
            this.timer_blink.Tick += new System.EventHandler(this.timer_blink_Tick);
            // 
            // downNodePipe1
            // 
            this.downNodePipe1.Alert = false;
            this.downNodePipe1.DownNode = null;
            this.downNodePipe1.LeftNode = null;
            this.downNodePipe1.Location = new System.Drawing.Point(135, 450);
            this.downNodePipe1.Margin = new System.Windows.Forms.Padding(5);
            this.downNodePipe1.Name = "downNodePipe1";
            this.downNodePipe1.PipeWidth = 10;
            this.downNodePipe1.RightNode = null;
            this.downNodePipe1.Size = new System.Drawing.Size(61, 20);
            this.downNodePipe1.Status = false;
            this.downNodePipe1.TabIndex = 50;
            this.downNodePipe1.UpNode = null;
            // 
            // verticalValve1
            // 
            this.verticalValve1.Alert = false;
            this.verticalValve1.DownNode = null;
            this.verticalValve1.LeftNode = null;
            this.verticalValve1.Location = new System.Drawing.Point(56, 469);
            this.verticalValve1.Margin = new System.Windows.Forms.Padding(5);
            this.verticalValve1.Name = "verticalValve1";
            this.verticalValve1.PipeWidth = 10;
            this.verticalValve1.RightNode = null;
            this.verticalValve1.Size = new System.Drawing.Size(137, 77);
            this.verticalValve1.Status = false;
            this.verticalValve1.TabIndex = 49;
            this.verticalValve1.UpNode = null;
            // 
            // verticalPipe1
            // 
            this.verticalPipe1.Alert = false;
            this.verticalPipe1.DownNode = null;
            this.verticalPipe1.LeftNode = null;
            this.verticalPipe1.Location = new System.Drawing.Point(134, 294);
            this.verticalPipe1.Margin = new System.Windows.Forms.Padding(5);
            this.verticalPipe1.Name = "verticalPipe1";
            this.verticalPipe1.PipeWidth = 10;
            this.verticalPipe1.RightNode = null;
            this.verticalPipe1.Size = new System.Drawing.Size(61, 165);
            this.verticalPipe1.Status = false;
            this.verticalPipe1.TabIndex = 48;
            this.verticalPipe1.UpNode = null;
            // 
            // verticalGage1
            // 
            this.verticalGage1.Alert = false;
            this.verticalGage1.DownNode = null;
            this.verticalGage1.LeftNode = null;
            this.verticalGage1.Location = new System.Drawing.Point(685, 195);
            this.verticalGage1.Margin = new System.Windows.Forms.Padding(5);
            this.verticalGage1.Name = "verticalGage1";
            this.verticalGage1.PipeWidth = 10;
            this.verticalGage1.RightNode = null;
            this.verticalGage1.Size = new System.Drawing.Size(113, 67);
            this.verticalGage1.Status = false;
            this.verticalGage1.TabIndex = 47;
            this.verticalGage1.UpNode = null;
            // 
            // upToRightPipe1
            // 
            this.upToRightPipe1.Alert = false;
            this.upToRightPipe1.DownNode = null;
            this.upToRightPipe1.LeftNode = null;
            this.upToRightPipe1.Location = new System.Drawing.Point(236, 275);
            this.upToRightPipe1.Margin = new System.Windows.Forms.Padding(5);
            this.upToRightPipe1.Name = "upToRightPipe1";
            this.upToRightPipe1.PipeWidth = 10;
            this.upToRightPipe1.RightNode = null;
            this.upToRightPipe1.Size = new System.Drawing.Size(100, 100);
            this.upToRightPipe1.Status = false;
            this.upToRightPipe1.TabIndex = 46;
            this.upToRightPipe1.UpNode = null;
            // 
            // upToLeftPipe1
            // 
            this.upToLeftPipe1.Alert = false;
            this.upToLeftPipe1.DownNode = null;
            this.upToLeftPipe1.LeftNode = null;
            this.upToLeftPipe1.Location = new System.Drawing.Point(579, 276);
            this.upToLeftPipe1.Margin = new System.Windows.Forms.Padding(5);
            this.upToLeftPipe1.Name = "upToLeftPipe1";
            this.upToLeftPipe1.PipeWidth = 10;
            this.upToLeftPipe1.RightNode = null;
            this.upToLeftPipe1.Size = new System.Drawing.Size(100, 100);
            this.upToLeftPipe1.Status = false;
            this.upToLeftPipe1.TabIndex = 45;
            this.upToLeftPipe1.UpNode = null;
            // 
            // upsideTPipe1
            // 
            this.upsideTPipe1.Alert = false;
            this.upsideTPipe1.DownNode = null;
            this.upsideTPipe1.LeftNode = null;
            this.upsideTPipe1.Location = new System.Drawing.Point(718, 262);
            this.upsideTPipe1.Margin = new System.Windows.Forms.Padding(5);
            this.upsideTPipe1.Name = "upsideTPipe1";
            this.upsideTPipe1.PipeWidth = 10;
            this.upsideTPipe1.RightNode = null;
            this.upsideTPipe1.Size = new System.Drawing.Size(100, 80);
            this.upsideTPipe1.Status = false;
            this.upsideTPipe1.TabIndex = 44;
            this.upsideTPipe1.UpNode = null;
            // 
            // upPipeCap1
            // 
            this.upPipeCap1.Alert = false;
            this.upPipeCap1.DownNode = null;
            this.upPipeCap1.LeftNode = null;
            this.upPipeCap1.Location = new System.Drawing.Point(236, 155);
            this.upPipeCap1.Margin = new System.Windows.Forms.Padding(5);
            this.upPipeCap1.Name = "upPipeCap1";
            this.upPipeCap1.PipeWidth = 10;
            this.upPipeCap1.RightNode = null;
            this.upPipeCap1.Size = new System.Drawing.Size(61, 21);
            this.upPipeCap1.Status = false;
            this.upPipeCap1.TabIndex = 43;
            this.upPipeCap1.UpNode = null;
            // 
            // upNodePipe1
            // 
            this.upNodePipe1.Alert = false;
            this.upNodePipe1.DownNode = null;
            this.upNodePipe1.LeftNode = null;
            this.upNodePipe1.Location = new System.Drawing.Point(135, 275);
            this.upNodePipe1.Margin = new System.Windows.Forms.Padding(5);
            this.upNodePipe1.Name = "upNodePipe1";
            this.upNodePipe1.PipeWidth = 10;
            this.upNodePipe1.RightNode = null;
            this.upNodePipe1.Size = new System.Drawing.Size(61, 20);
            this.upNodePipe1.Status = false;
            this.upNodePipe1.TabIndex = 42;
            this.upNodePipe1.UpNode = null;
            // 
            // rightsideTPipe1
            // 
            this.rightsideTPipe1.Alert = false;
            this.rightsideTPipe1.DownNode = null;
            this.rightsideTPipe1.LeftNode = null;
            this.rightsideTPipe1.Location = new System.Drawing.Point(135, 175);
            this.rightsideTPipe1.Margin = new System.Windows.Forms.Padding(5);
            this.rightsideTPipe1.Name = "rightsideTPipe1";
            this.rightsideTPipe1.PipeWidth = 10;
            this.rightsideTPipe1.RightNode = null;
            this.rightsideTPipe1.Size = new System.Drawing.Size(80, 100);
            this.rightsideTPipe1.Status = false;
            this.rightsideTPipe1.TabIndex = 41;
            this.rightsideTPipe1.UpNode = null;
            // 
            // rightPipeCap1
            // 
            this.rightPipeCap1.Alert = false;
            this.rightPipeCap1.DownNode = null;
            this.rightPipeCap1.LeftNode = null;
            this.rightPipeCap1.Location = new System.Drawing.Point(336, 314);
            this.rightPipeCap1.Margin = new System.Windows.Forms.Padding(5);
            this.rightPipeCap1.Name = "rightPipeCap1";
            this.rightPipeCap1.PipeWidth = 10;
            this.rightPipeCap1.RightNode = null;
            this.rightPipeCap1.Size = new System.Drawing.Size(21, 61);
            this.rightPipeCap1.Status = false;
            this.rightPipeCap1.TabIndex = 40;
            this.rightPipeCap1.UpNode = null;
            // 
            // rightNodePipe1
            // 
            this.rightNodePipe1.Alert = false;
            this.rightNodePipe1.DownNode = null;
            this.rightNodePipe1.LeftNode = null;
            this.rightNodePipe1.Location = new System.Drawing.Point(579, 196);
            this.rightNodePipe1.Margin = new System.Windows.Forms.Padding(5);
            this.rightNodePipe1.Name = "rightNodePipe1";
            this.rightNodePipe1.PipeWidth = 10;
            this.rightNodePipe1.RightNode = null;
            this.rightNodePipe1.Size = new System.Drawing.Size(20, 61);
            this.rightNodePipe1.Status = false;
            this.rightNodePipe1.TabIndex = 39;
            this.rightNodePipe1.UpNode = null;
            // 
            // leftsideTPipe1
            // 
            this.leftsideTPipe1.Alert = false;
            this.leftsideTPipe1.DownNode = null;
            this.leftsideTPipe1.LeftNode = null;
            this.leftsideTPipe1.Location = new System.Drawing.Point(599, 176);
            this.leftsideTPipe1.Margin = new System.Windows.Forms.Padding(5);
            this.leftsideTPipe1.Name = "leftsideTPipe1";
            this.leftsideTPipe1.PipeWidth = 10;
            this.leftsideTPipe1.RightNode = null;
            this.leftsideTPipe1.Size = new System.Drawing.Size(80, 100);
            this.leftsideTPipe1.Status = false;
            this.leftsideTPipe1.TabIndex = 38;
            this.leftsideTPipe1.UpNode = null;
            // 
            // leftPipeCap1
            // 
            this.leftPipeCap1.Alert = false;
            this.leftPipeCap1.DownNode = null;
            this.leftPipeCap1.LeftNode = null;
            this.leftPipeCap1.Location = new System.Drawing.Point(697, 282);
            this.leftPipeCap1.Margin = new System.Windows.Forms.Padding(5);
            this.leftPipeCap1.Name = "leftPipeCap1";
            this.leftPipeCap1.PipeWidth = 10;
            this.leftPipeCap1.RightNode = null;
            this.leftPipeCap1.Size = new System.Drawing.Size(21, 61);
            this.leftPipeCap1.Status = false;
            this.leftPipeCap1.TabIndex = 37;
            this.leftPipeCap1.UpNode = null;
            // 
            // leftNodePipe1
            // 
            this.leftNodePipe1.Alert = false;
            this.leftNodePipe1.DownNode = null;
            this.leftNodePipe1.LeftNode = null;
            this.leftNodePipe1.Location = new System.Drawing.Point(315, 195);
            this.leftNodePipe1.Margin = new System.Windows.Forms.Padding(5);
            this.leftNodePipe1.Name = "leftNodePipe1";
            this.leftNodePipe1.PipeWidth = 10;
            this.leftNodePipe1.RightNode = null;
            this.leftNodePipe1.Size = new System.Drawing.Size(20, 61);
            this.leftNodePipe1.Status = false;
            this.leftNodePipe1.TabIndex = 36;
            this.leftNodePipe1.UpNode = null;
            // 
            // horizentalValve1
            // 
            this.horizentalValve1.Alert = false;
            this.horizentalValve1.DownNode = null;
            this.horizentalValve1.LeftNode = null;
            this.horizentalValve1.Location = new System.Drawing.Point(238, -3);
            this.horizentalValve1.Margin = new System.Windows.Forms.Padding(5);
            this.horizentalValve1.Name = "horizentalValve1";
            this.horizentalValve1.PipeWidth = 10;
            this.horizentalValve1.RightNode = null;
            this.horizentalValve1.Size = new System.Drawing.Size(77, 137);
            this.horizentalValve1.Status = false;
            this.horizentalValve1.TabIndex = 35;
            this.horizentalValve1.UpNode = null;
            // 
            // horizentalPipe1
            // 
            this.horizentalPipe1.Alert = false;
            this.horizentalPipe1.DownNode = null;
            this.horizentalPipe1.LeftNode = null;
            this.horizentalPipe1.Location = new System.Drawing.Point(334, 195);
            this.horizentalPipe1.Margin = new System.Windows.Forms.Padding(5);
            this.horizentalPipe1.Name = "horizentalPipe1";
            this.horizentalPipe1.PipeWidth = 10;
            this.horizentalPipe1.RightNode = null;
            this.horizentalPipe1.Size = new System.Drawing.Size(255, 61);
            this.horizentalPipe1.Status = false;
            this.horizentalPipe1.TabIndex = 34;
            this.horizentalPipe1.UpNode = null;
            // 
            // horizentalGage1
            // 
            this.horizentalGage1.Alert = false;
            this.horizentalGage1.DownNode = null;
            this.horizentalGage1.LeftNode = null;
            this.horizentalGage1.Location = new System.Drawing.Point(502, 264);
            this.horizentalGage1.Margin = new System.Windows.Forms.Padding(5);
            this.horizentalGage1.Name = "horizentalGage1";
            this.horizentalGage1.PipeWidth = 10;
            this.horizentalGage1.RightNode = null;
            this.horizentalGage1.Size = new System.Drawing.Size(77, 113);
            this.horizentalGage1.Status = false;
            this.horizentalGage1.TabIndex = 33;
            this.horizentalGage1.UpNode = null;
            // 
            // downToRightPipe1
            // 
            this.downToRightPipe1.Alert = false;
            this.downToRightPipe1.DownNode = null;
            this.downToRightPipe1.LeftNode = null;
            this.downToRightPipe1.Location = new System.Drawing.Point(135, 75);
            this.downToRightPipe1.Margin = new System.Windows.Forms.Padding(5);
            this.downToRightPipe1.Name = "downToRightPipe1";
            this.downToRightPipe1.PipeWidth = 10;
            this.downToRightPipe1.RightNode = null;
            this.downToRightPipe1.Size = new System.Drawing.Size(100, 100);
            this.downToRightPipe1.Status = false;
            this.downToRightPipe1.TabIndex = 32;
            this.downToRightPipe1.UpNode = null;
            // 
            // downToLeftPipe1
            // 
            this.downToLeftPipe1.Alert = false;
            this.downToLeftPipe1.DownNode = null;
            this.downToLeftPipe1.LeftNode = null;
            this.downToLeftPipe1.Location = new System.Drawing.Point(699, 95);
            this.downToLeftPipe1.Margin = new System.Windows.Forms.Padding(5);
            this.downToLeftPipe1.Name = "downToLeftPipe1";
            this.downToLeftPipe1.PipeWidth = 10;
            this.downToLeftPipe1.RightNode = null;
            this.downToLeftPipe1.Size = new System.Drawing.Size(100, 100);
            this.downToLeftPipe1.Status = false;
            this.downToLeftPipe1.TabIndex = 31;
            this.downToLeftPipe1.UpNode = null;
            // 
            // downsideTPipe1
            // 
            this.downsideTPipe1.Alert = false;
            this.downsideTPipe1.DownNode = null;
            this.downsideTPipe1.LeftNode = null;
            this.downsideTPipe1.Location = new System.Drawing.Point(599, 96);
            this.downsideTPipe1.Margin = new System.Windows.Forms.Padding(5);
            this.downsideTPipe1.Name = "downsideTPipe1";
            this.downsideTPipe1.PipeWidth = 10;
            this.downsideTPipe1.RightNode = null;
            this.downsideTPipe1.Size = new System.Drawing.Size(100, 80);
            this.downsideTPipe1.Status = false;
            this.downsideTPipe1.TabIndex = 30;
            this.downsideTPipe1.UpNode = null;
            // 
            // downPipeCap1
            // 
            this.downPipeCap1.Alert = false;
            this.downPipeCap1.DownNode = null;
            this.downPipeCap1.LeftNode = null;
            this.downPipeCap1.Location = new System.Drawing.Point(133, 546);
            this.downPipeCap1.Margin = new System.Windows.Forms.Padding(5);
            this.downPipeCap1.Name = "downPipeCap1";
            this.downPipeCap1.PipeWidth = 10;
            this.downPipeCap1.RightNode = null;
            this.downPipeCap1.Size = new System.Drawing.Size(61, 21);
            this.downPipeCap1.Status = false;
            this.downPipeCap1.TabIndex = 29;
            this.downPipeCap1.UpNode = null;
            // 
            // crossPipe1
            // 
            this.crossPipe1.Alert = false;
            this.crossPipe1.DownNode = null;
            this.crossPipe1.LeftNode = null;
            this.crossPipe1.Location = new System.Drawing.Point(215, 175);
            this.crossPipe1.Margin = new System.Windows.Forms.Padding(5);
            this.crossPipe1.Name = "crossPipe1";
            this.crossPipe1.PipeWidth = 10;
            this.crossPipe1.RightNode = null;
            this.crossPipe1.Size = new System.Drawing.Size(100, 100);
            this.crossPipe1.Status = false;
            this.crossPipe1.TabIndex = 28;
            this.crossPipe1.UpNode = null;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(718, 500);
            this.button_test.Margin = new System.Windows.Forms.Padding(4);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(100, 29);
            this.button_test.TabIndex = 51;
            this.button_test.Text = "Test";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 630);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.downNodePipe1);
            this.Controls.Add(this.verticalValve1);
            this.Controls.Add(this.verticalPipe1);
            this.Controls.Add(this.verticalGage1);
            this.Controls.Add(this.upToRightPipe1);
            this.Controls.Add(this.upToLeftPipe1);
            this.Controls.Add(this.upsideTPipe1);
            this.Controls.Add(this.upPipeCap1);
            this.Controls.Add(this.upNodePipe1);
            this.Controls.Add(this.rightsideTPipe1);
            this.Controls.Add(this.rightPipeCap1);
            this.Controls.Add(this.rightNodePipe1);
            this.Controls.Add(this.leftsideTPipe1);
            this.Controls.Add(this.leftPipeCap1);
            this.Controls.Add(this.leftNodePipe1);
            this.Controls.Add(this.horizentalValve1);
            this.Controls.Add(this.horizentalPipe1);
            this.Controls.Add(this.horizentalGage1);
            this.Controls.Add(this.downToRightPipe1);
            this.Controls.Add(this.downToLeftPipe1);
            this.Controls.Add(this.downsideTPipe1);
            this.Controls.Add(this.downPipeCap1);
            this.Controls.Add(this.crossPipe1);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_blink);
            this.Controls.Add(this.button_alert);
            this.Controls.Add(this.button_off);
            this.Controls.Add(this.button_on);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_on;
        private System.Windows.Forms.Button button_off;
        private System.Windows.Forms.Button button_alert;
        private System.Windows.Forms.Button button_blink;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Timer timer_blink;
        private PipeValveControl.CrossPipe crossPipe1;
        private PipeValveControl.DownPipeCap downPipeCap1;
        private PipeValveControl.DownsideTPipe downsideTPipe1;
        private PipeValveControl.DownToLeftPipe downToLeftPipe1;
        private PipeValveControl.DownToRightPipe downToRightPipe1;
        private PipeValveControl.HorizentalGage horizentalGage1;
        private PipeValveControl.HorizentalPipe horizentalPipe1;
        private PipeValveControl.HorizentalValve horizentalValve1;
        private PipeValveControl.LeftNodePipe leftNodePipe1;
        private PipeValveControl.LeftPipeCap leftPipeCap1;
        private PipeValveControl.LeftsideTPipe leftsideTPipe1;
        private PipeValveControl.RightNodePipe rightNodePipe1;
        private PipeValveControl.RightPipeCap rightPipeCap1;
        private PipeValveControl.RightsideTPipe rightsideTPipe1;
        private PipeValveControl.UpNodePipe upNodePipe1;
        private PipeValveControl.UpPipeCap upPipeCap1;
        private PipeValveControl.UpsideTPipe upsideTPipe1;
        private PipeValveControl.UpToLeftPipe upToLeftPipe1;
        private PipeValveControl.UpToRightPipe upToRightPipe1;
        private PipeValveControl.VerticalGage verticalGage1;
        private PipeValveControl.VerticalPipe verticalPipe1;
        private PipeValveControl.VerticalValve verticalValve1;
        private PipeValveControl.DownNodePipe downNodePipe1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_test;
    }
}

