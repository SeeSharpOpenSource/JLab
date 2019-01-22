using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PipeValveControl;

namespace PipeValveDemo
{
    public partial class Form1 : Form
    {

        private List<PipeControlBase> _pipeControls; 
        public Form1()
        {
            InitializeComponent();
            _pipeControls = new List<PipeControlBase>(20);

            foreach (Control control in this.Controls)
            {
                if (control is PipeControlBase)
                {
                    _pipeControls.Add(control as PipeControlBase);
                }
            }
        }

        private void button_on_Click(object sender, EventArgs e)
        {
            foreach (PipeControlBase control in _pipeControls)
            {
                control.Alert = false;
                control.Status = true;
            }
        }

        private void button_off_Click(object sender, EventArgs e)
        {
            foreach (PipeControlBase control in _pipeControls)
            {
                control.Alert = false;
                control.Status = false;
            }
        }

        private void button_alert_Click(object sender, EventArgs e)
        {
            foreach (PipeControlBase control in _pipeControls)
            {
                control.Alert = true;
            }
        }

        private void button_blink_Click(object sender, EventArgs e)
        {
            this.timer_blink.Enabled = true;
        }

        private void timer_blink_Tick(object sender, EventArgs e)
        {
            foreach (PipeControlBase control in _pipeControls)
            {
                control.Status = !control.Status;
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer_blink.Enabled = false;
            horizentalPipe1.PipeWidth = 8;
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var random = new Random();
            int nextWidth = random.Next(1, 100);
            int nextHeight = random.Next(1, 100);
            horizentalPipe1.Width = nextWidth;
            horizentalPipe1.Height = nextHeight;
        }
    }
}
