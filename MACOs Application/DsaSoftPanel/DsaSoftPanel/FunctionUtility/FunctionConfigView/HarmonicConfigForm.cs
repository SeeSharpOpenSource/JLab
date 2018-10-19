using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DsaSoftPanel.FunctionUtility.FunctionConfigView
{
    public partial class HarmonicConfigForm : Form
    {
        public HarmonicConfigForm()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        public void GetChannelIndex(out int signal1Index)
        {
            if (!IsHandleCreated)
            {
                signal1Index = -1;
                return;
            }
            int index1 = 0;
            Invoke(new Action(() =>
            {
                index1 = metroComboBox_signal1.SelectedIndex;
            }));
            signal1Index = index1;
        }

        public int GetHarmonicLevel()
        {
            return int.Parse(textBox_highestHarmonic.Text);
        }

        public void RefreshChannelItems()
        {
            List<ChannelConfig> channels = SoftPanelGlobalInfo.GetInstance().Channels.FindAll(item => item.Enabled);
            if (channels.Count == metroComboBox_signal1.Items.Count &&
                channels.All(item => metroComboBox_signal1.Items.Contains(item.ChannelName)))
            {
                return;
            }
            string signal1 = metroComboBox_signal1.Text;
            metroComboBox_signal1.Items.Clear();
            foreach (ChannelConfig channel in channels)
            {
                metroComboBox_signal1.Items.Add(channel.ChannelName);
            }
            if (channels.Count > 0 && (!metroComboBox_signal1.Items.Contains(signal1) || string.IsNullOrEmpty(signal1)))
            {
                metroComboBox_signal1.SelectedIndex = 0;
            }
        }

        private void textBox_highestHarmonic_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            TextBox textBox = sender as TextBox;
            if (!int.TryParse(textBox.Text, out value) || value > 20 && value < 1)
            {
                textBox.Text = Constants.HarmonicLevel.ToString();
            }
        }
    }
}
