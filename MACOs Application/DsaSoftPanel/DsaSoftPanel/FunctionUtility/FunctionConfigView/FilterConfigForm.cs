using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MathNet.Filtering.FIR;
using SeeSharpTools.JY.DSP.Fundamental;

namespace DsaSoftPanel.FunctionUtility.FunctionConfigView
{
    public partial class FilterConfigForm : Form
    {
        private OnlineFirFilter _filter;
        public OnlineFirFilter Filter
        {
            get
            {
                if (null == _filter)
                {
                    RefreshCoefficient();
                }
                return _filter;
            }
        }

        public FilterConfigForm()
        {
            InitializeComponent();
            this.TopLevel = false;
            metroComboBox_type.Text = FilterType.LowPass.ToString();
            textBox_highCutoff.Tag = 1000;
            textBox_lowerCutoff.Tag = 100;
        }

        private void metroComboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCoefficient();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            // 如果不是double则重新赋值为原来的值，如果是则将该值保存到tag中。
            TextBox textBox = sender as TextBox;
            double value = 0;
            if (!double.TryParse(textBox.Text, out value) || value < 0)
            {
                textBox.Text = textBox.Tag.ToString();
            }
            else
            {
                RefreshCoefficient();
                textBox.Tag = value;
            }
        }

        private void RefreshCoefficient()
        {
            double[] coefficient = null;
            SoftPanelGlobalInfo globalInfo = SoftPanelGlobalInfo.GetInstance();
            FilterType type = (FilterType)Enum.Parse(typeof(FilterType), metroComboBox_type.Text);
            double lowCutoff = double.Parse(textBox_lowerCutoff.Text);
            double highCutoff = double.Parse(textBox_highCutoff.Text);
            switch (type)
            {
                case FilterType.LowPass:
                    coefficient = FirCoefficients.LowPass(globalInfo.SampleRate, lowCutoff);
                    break;
                case FilterType.HighPass:
                    coefficient = FirCoefficients.HighPass(globalInfo.SampleRate, highCutoff);
                    break;
                case FilterType.BandPass:
                    if (lowCutoff > highCutoff)
                    {
                        double tmp = lowCutoff;
                        lowCutoff = highCutoff;
                        highCutoff = tmp;
                    }
                    coefficient = FirCoefficients.BandPass(globalInfo.SampleRate, lowCutoff, highCutoff);
                    break;
                case FilterType.BandStop:
                    if (lowCutoff > highCutoff)
                    {
                        double tmp = lowCutoff;
                        lowCutoff = highCutoff;
                        highCutoff = tmp;
                    }
                    coefficient = FirCoefficients.BandStop(globalInfo.SampleRate, lowCutoff, highCutoff);
                    break;
            }
            _filter =  new OnlineFirFilter(coefficient);
        }
        
        enum FilterType
        {
            LowPass,
            HighPass,
            BandPass,
            BandStop
        }
        
    }
}
