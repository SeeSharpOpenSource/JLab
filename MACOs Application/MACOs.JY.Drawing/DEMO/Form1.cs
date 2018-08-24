using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SeeSharpTools.JY.File;
using SeeSharpTools.JY.ArrayUtility;
using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using MACOs.JY.Drawing;
using System.Threading;

namespace DEMO
{
    public partial class Form1 : Form
    {
        double[,] _imgData;
        int width = 640;
        int height = 480;
        Bitmap bitmap;
        Stopwatch sp = new Stopwatch();
        Thread t_capure;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(width, height);
            pictureBox1.Height = height;
            pictureBox1.Width = width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _imgData = new double[bitmap.Height, bitmap.Width];

            for (int i = 0; i < _imgData.GetLength(0); i++)
            {
                for (int j = 0; j < _imgData.GetLength(1); j++)
                {
                    bitmap.SetPixel(j, i, Color.White);
                }
            }
            sp.Restart();
            
            //TransferToImage(_imgData, ref bitmap);
            
            t_capure = new Thread(Display);
            t_capure.Start();

            
        }
        private void Display()
        {
            try
            {
                Random rand = new Random();
                while (true)
                {
                    for (int i = 0; i < _imgData.GetLength(0); i++)
                    {
                        for (int j = 0; j < _imgData.GetLength(1); j++)
                        {
                            _imgData[i, j] = ((double)(i * width + j) / (double)(width * height));
                        }
                    }
                    sp.Restart();
                    var pic= Graphs.DensityGraph(_imgData, ref bitmap,  checkBox1.Checked, 1, 0);
                    
                    Invoke(new Action(() => 
                    {
                        pictureBox1.Image = pic;
                        textBox1.Text = string.Format("{0} ms", sp.ElapsedMilliseconds);
                    }));
                }

            }
            catch (Exception )
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t_capure.Abort();
        }
    }

}
