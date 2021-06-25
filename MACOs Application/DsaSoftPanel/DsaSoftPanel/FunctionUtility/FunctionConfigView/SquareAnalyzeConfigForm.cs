using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DsaSoftPanel.FunctionUtility.FunctionConfigView
{
    public partial class SquareAnalyzeConfigForm : Form
    {
        public SquareAnalyzeConfigForm()
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
            int index1 = 0, index2 = 0;
            Invoke(new Action(() =>
            {
                index1 = metroComboBox_signal1.SelectedIndex;
            }));
            signal1Index = index1;
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
            metroComboBox_signal1.SelectedIndex = 0;
        }
    }
}
