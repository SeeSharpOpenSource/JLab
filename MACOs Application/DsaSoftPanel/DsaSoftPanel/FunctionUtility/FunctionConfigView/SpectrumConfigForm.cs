using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SeeSharpTools.JY.DSP.Fundamental;

namespace DsaSoftPanel.FunctionUtility.FunctionConfigView
{
    public partial class SpectrumConfigForm : Form
    {
        public WindowType Window
        {
            get
            {
                string type = "";
                Invoke(new Action(() => { type = metroComboBox_window.Text; }));
                return (WindowType) Enum.Parse(typeof (WindowType), type);
            }
            set { metroComboBox_window.Text = value.ToString(); }
        }

        public double WindowPara
        {
            get { return double.Parse(textBox_windowsPara.Text); }
            set { textBox_windowsPara.Text = value.ToString(); }
        }

        public SpectrumConfigForm()
        {
            InitializeComponent();
            this.TopLevel = false;
            metroComboBox_window.Text = WindowType.Hanning.ToString();
        }

        private void textBox_windowsPara_TextChanged(object sender, EventArgs e)
        {
            double value = 0;
            if (!double.TryParse(textBox_windowsPara.Text, out value))
            {
                textBox_windowsPara.Text = "0";
            }
        }
    }
}
