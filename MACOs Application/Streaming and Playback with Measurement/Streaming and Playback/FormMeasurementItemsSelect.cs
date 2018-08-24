using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace StreamingAndPlaybackDemo
{
    public partial class FormMeasurementItemsSelect : Form
    {
        public List<int> checkedMeasureItems;
        public Timer timerOut;

        public FormMeasurementItemsSelect(FieldInfo[] ItemNames,ref List<int> checkedItems,ref Timer timer)
        {
            InitializeComponent();
            checkedMeasureItems = checkedItems;
            timerOut = timer;
            foreach (FieldInfo item in ItemNames)
            {
                if (item.Name != "Reserved")
                {
                    checkedListBox_MeasureItems1.Items.Add(item.Name);
                }
            }
            foreach (int item in checkedMeasureItems)
            {
                checkedListBox_MeasureItems1.SetSelected(item, true);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            checkedMeasureItems.Clear();
            for (int j = 0; j < checkedListBox_MeasureItems1.Items.Count; j++)
            {
                if (checkedListBox_MeasureItems1.GetItemChecked(j))
                {
                    checkedMeasureItems.Add(j);
                }
            }
            if (checkedMeasureItems.Count == 0)
            {
                MessageBox.Show("Please pick one Measurement Item at least");
                return;
            }
            timerOut.Enabled = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SelectAll.Checked)
            {
                for (int j = 0; j < checkedListBox_MeasureItems1.Items.Count; j++)
                    checkedListBox_MeasureItems1.SetItemChecked(j, true);
            }
            else
            {
                for (int j = 0; j < checkedListBox_MeasureItems1.Items.Count; j++)
                    checkedListBox_MeasureItems1.SetItemChecked(j, false);
            }
        }
    }
}
