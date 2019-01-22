using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EasyDAQ
{
    internal partial class ChannelSelector : Form
    {
        public List<int> selectChannels = new List<int>();

        public object temp = new object();

        public ChannelSelector(int chCount)
        {
            InitializeComponent();
            for (int i = 0; i < chCount; i++)
            {
                cklChannelsSelect.Items.Add("channel" + i.ToString());
            }

        }

        /// <summary>
        /// 打开数据编辑窗体
        /// </summary>
        /// <param name="value">编辑的数据</param>
        /// <returns></returns>
        public static object EditValue(object value, int chCount)
        {
            ChannelSelector form = new ChannelSelector(chCount);
            
            foreach (var item in (List<int>)value)
            {
                form.cklChannelsSelect.SetItemChecked(item, true);
            }
            form.temp = value;
            //form.selectChannels = (List<int>)value;

            form.CbxAllChannels.Checked = ((List<int>)value).Count == chCount;

            form.ShowDialog();

            return form.selectChannels;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            selectChannels.Clear();
            for (int i = 0; i < cklChannelsSelect.Items.Count; i++)
            {
                if (cklChannelsSelect.GetItemChecked(i))
                {
                    selectChannels.Add(i);
                }
            }
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            selectChannels = (List<int>)temp;
            this.Close();
        }

        private void CbxAllChannels_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxAllChannels.Checked)
            {
                for (int i = 0; i < cklChannelsSelect.Items.Count; i++)
                    cklChannelsSelect.SetItemChecked(i, true);
            }
            else
            {
                for (int i = 0; i < cklChannelsSelect.Items.Count; i++)
                    cklChannelsSelect.SetItemChecked(i, false);
            }
        }
    }
}