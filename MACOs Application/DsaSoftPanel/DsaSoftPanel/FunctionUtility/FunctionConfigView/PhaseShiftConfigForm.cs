using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DsaSoftPanel.FunctionUtility.FunctionConfigView
{
    public partial class PhaseShiftConfigForm : Form
    {
        public PhaseShiftConfigForm()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        public void GetChannelIndex(out int signal1Index, out int signal2Index)
        {
            if (!IsHandleCreated)
            {
                signal1Index = -1;
                signal2Index = -1;
                return;
            }
            int index1 = 0, index2 = 0;
            Invoke(new Action(() =>
            {
                index1 = metroComboBox_signal1.SelectedIndex;
                index2 = metroComboBox_signal2.SelectedIndex;
            }));
            signal1Index = index1;
            signal2Index = index2;
        }

        public void RefreshChannelItems()
        {
            List<ChannelConfig> channels = SoftPanelGlobalInfo.GetInstance().Channels.FindAll(item => item.Enabled);
            if (channels.Count == metroComboBox_signal1.Items.Count && channels.All(item => metroComboBox_signal1.Items.Contains(item.ChannelName)))
            {
                return;
            }
            string signal1 = metroComboBox_signal1.Text;
            string signal2 = metroComboBox_signal2.Text;
            metroComboBox_signal1.Items.Clear();
            metroComboBox_signal2.Items.Clear();
            foreach (ChannelConfig channel in channels)
            {
                metroComboBox_signal1.Items.Add(channel.ChannelName);
                metroComboBox_signal2.Items.Add(channel.ChannelName);
            }
            if (channels.Count > 0 && (!metroComboBox_signal1.Items.Contains(signal1) || string.IsNullOrEmpty(signal1)))
            {
                metroComboBox_signal1.SelectedIndex = 0;
            }

            if (channels.Count > 0 && (string.IsNullOrEmpty(signal2) || !metroComboBox_signal2.Items.Contains(signal2)))
            {
                metroComboBox_signal2.SelectedIndex = 0;
            }
        }
    }
}
