using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MACOs.JY.AudioAnalyzer.StateMachine;

namespace MACOs.JY.AudioAnalyzer
{
    public partial class TriggerConfigForm : Form
    {
        public TriggerConfigForm()
        {
            InitializeComponent();
            GlobalInfo globalInfo = GlobalInfo.GetInstance();
            InitComboBoxItem(comboBox_trigType, Enum.GetNames(typeof (TriggerType)), globalInfo.AITask.TrigType.ToString());
            InitComboBoxItem(comboBox_trigCondition, Enum.GetNames((typeof(TriggerCondition))), globalInfo.AITask.TrigCondition.ToString());
        }
       
        private void InitComboBoxItem(ComboBox comboBox, string[] items, string selectedItem)
        {
            comboBox.Items.Clear();
            foreach (string item in items)
            {
                comboBox.Items.Add(item);
            }
            comboBox.SelectedItem = selectedItem;
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            GlobalInfo globalInfo = GlobalInfo.GetInstance();

            globalInfo.AITask.TrigType = (TriggerType) Enum.Parse(typeof (TriggerType), comboBox_trigType.Text);
            globalInfo.AITask.TrigCondition = (TriggerCondition) Enum.Parse(typeof (TriggerCondition), comboBox_trigCondition.Text);

            globalInfo.AOTask.TrigType = (TriggerType) Enum.Parse(typeof (TriggerType), comboBox_trigType.Text);
            globalInfo.AOTask.TrigCondition = (TriggerCondition) Enum.Parse(typeof (TriggerCondition), comboBox_trigCondition.Text);

            this.Dispose();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
    }
}
