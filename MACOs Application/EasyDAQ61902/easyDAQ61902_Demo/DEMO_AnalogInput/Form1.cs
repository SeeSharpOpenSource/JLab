using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void industrySwitch1_ValueChanged(object sender, EventArgs e)
        {
            easyDAQ61902AI1.ContinuousRun = industrySwitch1.Value;
        }

        private void easyButton_start_Click(object sender, EventArgs e)
        {
            easyDAQ61902AI1.Start();


        }
        private void easyButton_stop_Click(object sender, EventArgs e)
        {
            easyDAQ61902AI1.Stop();
        }


        private void easyDAQ61902AI1_DataReceived(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                easyChart1.Plot(easyDAQ61902AI1.ReadData());
                textBox1.Text = easyDAQ61902AI1.AvailableSamples.ToString();
            }));
        }
    }
}