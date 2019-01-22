using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//使用EasyDAQ61902AO前，要确定安装了SeeSharpTools在C:\SeeSharp\JYTEK\SeeSharpTools 中
namespace EasyDAQ61902AIAO_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAI_Click(object sender, EventArgs e)
        {
             
            easyDAQ61902AI1.Start();

           /* 如果是有限点采集，则不需要DataReceived事件和Start方法，直接在这里写一行
              easyChart1.Plot(easyDAQ61902AI1.ReadData());
              即可 
                                                                                */
        }

        private void easyDAQ61902AI1_DataReceived(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                easyChart1.Plot(easyDAQ61902AI1.ReadData());
            }));
        }

        private void buttonAO_Click(object sender, EventArgs e)
        {
            easyDAQ61902AO1.WriteData();  //不输入实参直接输出属性窗口定义的波形
           

            /*
             
            //重载，可以自己定义一个波形输出,在WriteData方法输入实参
            double[] writeValue = new double[100];
            for (int i = 0; i < writeValue.Length; i++)
            {
                writeValue[i] = 0.5 * i;
            }
            easyDAQ61902AO1.WriteData(writeValue);
            */
        }
    }
}
