using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DsaSoftPanel.ViewComponents
{
    public partial class StatisticPanel : Form
    {
        public int ChannelId { get; }
        public bool IsShown { get; set; }

        public StatisticPanel(int channelId)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.ChannelId = channelId;
            this.label_index.Text = (channelId+1).ToString();
        }

        public void SetMaxAndMin(double max, double min)
        {
            label_maxValue.Text = max.ToString("F4");
            label_minValue.Text = min.ToString("F4");
            this.IsShown = false;
        }

        public void Clear()
        {
            label_maxValue.Text = "";
            label_minValue.Text = "";
        }
    }
}
