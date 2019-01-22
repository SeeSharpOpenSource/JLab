using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DEMO
{
    public partial class Form1 : Form
    {
        bool[] writeValue;
        private List<SeeSharpTools.JY.GUI.IndustrySwitch> listData = new List<SeeSharpTools.JY.GUI.IndustrySwitch>();
        public Form1()
        {
            InitializeComponent();
            writeValue = new bool[easyDAQ61902DO1.Channels.Count];

            listData.Add(industrySwitch0);
            listData.Add(industrySwitch1);
            listData.Add(industrySwitch2);
            listData.Add(industrySwitch3);
        }

        private void industrySwitch0_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < easyDAQ61902DO1.Channels.Count; i++)
            {
                writeValue[i] = listData[i].Value;
            }

            easyDAQ61902DO1.WriteData(writeValue);
           

        }

        //点击开始按钮后，DO输出industrySwitch的初始值，DI开始读取
        private void buttonStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < easyDAQ61902DO1.Channels.Count; i++)
            {
                writeValue[i] = listData[i].Value;
            }

            easyDAQ61902DO1.WriteData(writeValue);  
            easyDAQ61902DI1.Start();
        }

        //每当有数据变化，事件触发使DI读取一次数据
        private void easyDAQ61902DI1_DataReceived(object sender, EventArgs e)
        {
                Invoke(new Action(() =>
                {
                    ledArray1.Value = easyDAQ61902DI1.ReadData();
                }));

        }
    }
}