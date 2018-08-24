using System;
using System.Windows.Forms;

namespace MACOs.JY.SoftFrontPanel
{
    public partial class userDialog : Form
    {
        private int boardNum;
        public userDialog(string title, string Label)
        {
            InitializeComponent();
            this.Text = title;
            label1.Text = Label;
            comboBox1.SelectedIndex = 0;
        }

        public int BoardNumber
        {
            get { return boardNum; }
            set { boardNum = value; }
        }

        private void easyButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem!=null)
            {
                boardNum = Int32.Parse(comboBox1.SelectedItem.ToString());
            }
            else
            {
                boardNum = 0;
            }
            this.Close();
        }

        private void userDialog_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
