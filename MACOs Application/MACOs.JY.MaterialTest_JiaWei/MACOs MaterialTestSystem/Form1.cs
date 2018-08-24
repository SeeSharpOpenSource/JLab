using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MACOs.JY.JYPCI69524;
using System.Diagnostics;
using SeeSharpTools.JY.File;


namespace MACOs_MaterialTestSystem
{
    public partial class Form1 : Form
    {
        #region Fields
        private MACOsJYPCI69524 device;
        Stopwatch watch = new Stopwatch();
        private bool isArrivedInitPos1 = false;
        private bool isArrivedInitPos2 = false;
        private bool isArrivedInitPos3 = false;
        private bool isMeasuring1 = false;
        private bool isMeasuring2 = false;
        private bool isMeasuring3 = false;

        #endregion

        public Form1()
        {
            InitializeComponent();
            device = new MACOsJYPCI69524();
            device.EngineStart(0);
            // disable start button
            motor1_Start.Enabled = false;
            motor2_Start.Enabled = false;
            motor3_Start.Enabled = false;
            acquisition3_Start.Enabled = false;

            // enable initialize button
            AcquisitionConfig.Enabled = true;


        }

        #region Methods
        //电机控制
        private void MoveToInitialPos1()
        {
            while (!isArrivedInitPos1)
            {
                if (device.AnalogInput.ReadyToFetch)
                {
                    double valueMax = device.AnalogInput.GetChannelData(4).Max();
                    currentforce1.Invoke((MethodInvoker)delegate
                    {
                        currentforce1.Text = valueMax.ToString();
                    });


                    if (valueMax > (double)peaksetup1.Value)
                    {
                        device.MotorControl[0].Stop();
                        isArrivedInitPos1 = true;
                    }
                }
            }
        }
        #region 轴2，3的运动控制
        private void MoveToInitialPos2()
        {
            while (!isArrivedInitPos2)
            {
                if (device.AnalogInput.ReadyToFetch)
                {
                    double valueMax1 = device.AnalogInput.GetChannelData(5).Max();
                    currentforce2.Invoke((MethodInvoker)delegate
                    {
                        currentforce2.Text = valueMax1.ToString();

                    });

                    if (valueMax1 > (double)peaksetup2.Value)
                    {
                        device.MotorControl[1].Stop();
                        isArrivedInitPos2 = true;
                    }
                }
            }
        }
        private void MoveToInitialPos3()
        {
            while (!isArrivedInitPos3)
            {
                if (device.AnalogInput.ReadyToFetch)
                {
                    double valueMax2 = device.AnalogInput.GetChannelData(6).Max();

                    // display displacement 
                    displacement3.Invoke((MethodInvoker)delegate
                    {
                        displacement3.Value = (decimal)(device.AnalogInput.GetEncoderData(6).Last());
                    });
                    // display force
                    force3.Invoke((MethodInvoker)delegate
                    {
                        force3.Value = (decimal)device.AnalogInput.GetChannelData(6).Last();
                    });
                    // display peak force
                    peak3.Invoke((MethodInvoker)delegate

                    {
                        peak3.Value = (decimal)device.AnalogInput.GetChannelData(6).Max();
                    });
                    // display trough force
                    trough3.Invoke((MethodInvoker)delegate
                    {
                        trough3.Value = (decimal)device.AnalogInput.GetChannelData(6).Min();
                    });

                    if (valueMax2 > (double)peaksetup3.Value | Math.Abs(valueMax2) > Math.Abs((double)peaksetup3.Value))
                    {
                        device.MotorControl[2].Stop();
                        isArrivedInitPos3 = true;
                        motor3_Start.Invoke((MethodInvoker)delegate
                       {
                           motor3_Start.BackColor = Color.Transparent;
                           motor3_Start.Enabled = true;
                       });

                        motor3_Stop.Invoke((MethodInvoker)delegate
                        {
                            motor3_Stop.BackColor = Color.LightBlue;
                        });
                        isArrivedInitPos3 = true;
                        isMeasuring3 = false;

                    }
                }
            }
        }
        #endregion
        //量测
        private void Measure1()
        {

            while (isMeasuring1)
            {

                if (device.AnalogInput.ReadyToFetch)
                {
                    double[] forcedata1 = device.AnalogInput.GetChannelData(4);
                    double[] data = device.AnalogInput.GetEncoderData(4);

                    force1_Chart.Invoke((MethodInvoker)delegate
                    {
                        force1_Chart.Plot(forcedata1);
                    });

                    displacement1.Invoke((MethodInvoker)delegate
                    {
                        displacement1.Value = (decimal)(data.Last());
                    });



                    //压力值（及波峰波谷）显示
                    force1.Invoke((MethodInvoker)delegate
                    {
                        force1.Value = (decimal)forcedata1.Average();
                    });

                    peak1.Invoke((MethodInvoker)delegate

                    {
                        peak1.Value = (decimal)forcedata1.Max();
                    });


                    trough1.Invoke((MethodInvoker)delegate
                    {
                        trough1.Value = (decimal)forcedata1.Min();
                    });

                    //力反馈

                    //if (displacement1.Value < 5)
                    //{
                    if (peaksetup1.Value > (decimal)forcedata1.Max() + 2)
                    {
                        isArrivedInitPos1 = false;
                        device.MotorControl[0].Stop();
                        device.MotorControl[0].MoveInSpeed(0.05);
                        //Task.Factory.StartNew(MoveToInitialPos1);
                        //textBox1.Invoke((MethodInvoker)delegate
                        //{
                        //    textBox1.Text = "0.2"; 
                        //});
                        led1.Value = true;
                    }
                    else
                    {
                        if (peaksetup1.Value < (decimal)forcedata1.Max() - 2)
                        {
                            isArrivedInitPos1 = false;
                            device.MotorControl[0].Stop();
                            device.MotorControl[0].MoveInSpeed(-0.05);
                            //Task.Factory.StartNew(MoveToInitialPos1);
                            //textBox1.Invoke((MethodInvoker)delegate
                            //{
                            //    textBox1.Text = "-0.2";
                            //});
                            led1.Value = true;
                        }
                        else
                        {
                            isArrivedInitPos1 = true;
                            device.MotorControl[0].Stop();
                            //textBox1.Invoke((MethodInvoker)delegate
                            //{
                            //    textBox1.Text = "stop";
                            //});
                            led1.Value = false;
                        }
                    }

                    //}
                    //else
                    //{
                    //    isArrivedInitPos1 = true;
                    //    device.MotorControl[0].Stop();
                    //    device.DigitalOutput.WriteValue(0, false );
                    //}



                }

            }
        }
        #region 轴2，3数据采集和力反馈
        private void Measure2()
        {
            while (isMeasuring2)
            {
                if (device.AnalogInput.ReadyToFetch)
                {
                    double[] forcedata2 = device.AnalogInput.GetChannelData(5);
                    double[] data1 = device.AnalogInput.GetEncoderData(5);

                    force2_Chart.Invoke((MethodInvoker)delegate
                    {
                        force2_Chart.Plot(forcedata2);
                    });

                    displacement2.Invoke((MethodInvoker)delegate
                    {
                        displacement2.Value = (decimal)(data1.Last());
                    });

                    //压力值（及波峰波谷）显示
                    force2.Invoke((MethodInvoker)delegate
                    {
                        force2.Value = (decimal)forcedata2.Average();
                    });

                    peak2.Invoke((MethodInvoker)delegate

                    {
                        peak2.Value = (decimal)forcedata2.Max();
                    });


                    trough2.Invoke((MethodInvoker)delegate
                    {
                        trough2.Value = (decimal)forcedata2.Min();
                    });

                    //力反馈
                    //if (displacement2.Value < 5)
                    //{
                    if (peaksetup2.Value > (decimal)forcedata2.Max() + 2)
                    {
                        isArrivedInitPos2 = false;
                        device.MotorControl[1].Stop();
                        device.MotorControl[1].MoveInSpeed(0.05);
                        led2.Value = true;
                    }
                    else
                    {
                        if (peaksetup2.Value < (decimal)forcedata2.Max() - 2)
                        {
                            isArrivedInitPos2 = false;
                            device.MotorControl[1].Stop();
                            device.MotorControl[1].MoveInSpeed(-0.05);
                            led2.Value = true;
                        }
                        else
                        {
                            isArrivedInitPos2 = true;
                            device.MotorControl[1].Stop();
                            led2.Value = false;
                        }
                    }

                    //}
                    //else
                    //{
                    //    isArrivedInitPos2 = true;
                    //    device.MotorControl[1].Stop();
                    //    device.DigitalOutput.WriteValue(1, false);
                    //}


                }

            }
        }
        private void Measure3()
        {
            while (isMeasuring3)
            {
                if (device.AnalogInput.ReadyToFetch)
                {
                    double[] forcedata3 = device.AnalogInput.GetChannelData(6);
                    double[] data2 = device.AnalogInput.GetEncoderData(6);

                    force3_Chart.Invoke((MethodInvoker)delegate
                    {
                        force3_Chart.Plot(forcedata3);
                    });


                    displacement3.Invoke((MethodInvoker)delegate
                    {
                        displacement3.Value = (decimal)(data2.Last());
                    });



                    //压力值（及波峰波谷）显示
                    force3.Invoke((MethodInvoker)delegate
                    {
                        force3.Value = (decimal)forcedata3.Average();
                    });

                    peak3.Invoke((MethodInvoker)delegate

                    {
                        peak3.Value = (decimal)forcedata3.Max();
                    });


                    trough3.Invoke((MethodInvoker)delegate
                    {
                        trough3.Value = (decimal)forcedata3.Min();
                    });

                    //力反馈
                    //if (displacement3.Value < 5)
                    //{
                    if (peaksetup3.Value > (decimal)forcedata3.Max() + 2)
                    {
                        isArrivedInitPos3 = false;
                        device.MotorControl[2].Stop();
                        device.MotorControl[2].MoveInSpeed(0.05);
                        led3.Value = true;
                    }
                    else
                    {
                        if (peaksetup3.Value < (decimal)forcedata3.Max() - 2)
                        {
                            isArrivedInitPos3 = false;
                            device.MotorControl[2].Stop();
                            device.MotorControl[2].MoveInSpeed(-0.05);
                            led3.Value = true;
                        }
                        else
                        {
                            isArrivedInitPos3 = true;
                            device.MotorControl[2].Stop();
                            led3.Value = false;
                        }
                    }

                    //}
                    //else
                    //{
                    //    isArrivedInitPos3 = true;
                    //    device.MotorControl[2].Stop();
                    //    device.DigitalOutput.WriteValue(2, false );
                    //}


                }
            }
        }
        #endregion
        private void Button9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Events
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            device.EngineStop();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Enabled = true;

        }


        private void motor1_Stop_Click(object sender, EventArgs e)
        {
            motor1_Start.BackColor = Color.Transparent;
            motor1_Stop.BackColor = Color.LightBlue;
            isArrivedInitPos1 = true;
            isMeasuring1 = false;
            device.MotorControl[0].Stop();
            //device.AnalogInput.Stop();

            motor1_Start.Enabled = true;
        }

        private void motor1_Start_Click(object sender, EventArgs e)
        {
            try
            {
                motor1_Start.Enabled = false;

                motor1_Start.BackColor = Color.LightBlue;
                motor1_Stop.BackColor = Color.Transparent;
                isArrivedInitPos1 = false;
                device.MotorControl[0].MoveInSpeed((double)rotationspeed1.Value);
                Task.Factory.StartNew(MoveToInitialPos1);
            }
            catch (Exception ex)
            {
                device.MotorControl[0].Stop();
                throw new Exception(ex.Message);
            }

        }


        private void aquisition_Start_Click(object sender, EventArgs e)
        {
            //轴1采集+数据保存+计数
            isMeasuring1 = acquisition_Start.Value;
            device.AnalogInput.AIChannels[0].SaveDisk = isMeasuring1;
            device.AnalogInput.AIChannels[0].CountThreshold = (double)peaksetup1.Value - 50;

            device.AnalogInput.AIChannels[0].IsCounting = true;

            if (isMeasuring1)
            {
                Task.Factory.StartNew(Measure1);
            }


        }

        //轴2采集+数据保存+计数
        private void aquisition_Start1_ValueChanged(object sender, EventArgs e)
        {
            isMeasuring2 = aquisition_Start1.Value;
            device.AnalogInput.AIChannels[1].SaveDisk = isMeasuring2;
            device.AnalogInput.AIChannels[1].CountThreshold = (double)peaksetup2.Value - 50;

            device.AnalogInput.AIChannels[1].IsCounting = true;

            if (isMeasuring2)
            {
                Task.Factory.StartNew(Measure2);
            }

        }

        private void acquisition3_Start_Click(object sender, EventArgs e)
        {
            //disable acquisition button
            acquisition3_Start.Enabled = false;
            motor3_Start.Enabled = false;

            // enable Measure method thread
            isMeasuring3 = true;

            device.AnalogInput.AIChannels[2].SaveDisk = true;
            device.AnalogInput.AIChannels[2].CountThreshold = (double)peaksetup3.Value - 50;
            device.AnalogInput.AIChannels[2].IsCounting = true;
            // start measure
            Task.Factory.StartNew(Measure3);

        }
        private void acquisition3_stop_Click(object sender, EventArgs e)
        {
            // disable Measure method thread
            isMeasuring3 = false;
            led3.Value = false;

            device.AnalogInput.AIChannels[2].SaveDisk = false;
            device.AnalogInput.AIChannels[2].CountThreshold = (double)peaksetup3.Value - 50;

            device.MotorControl[2].Stop();

            //enable acquisition button
            acquisition3_Start.Enabled = true;
            motor3_Start.Enabled = true;
        }


        private void AO0_Config(object sender, EventArgs e)
        {
            device.AnalogOutput.WriteValue(0, (double)frequence1_Setup.Value / 4.5);

        }

        private void AO1_Config(object sender, EventArgs e)
        {
            device.AnalogOutput.WriteValue(1, (double)frequency2_Setup.Value / 4.5);
        }
        //AO 只有两个端口
        //private void AO2_Config(object sender, EventArgs e)
        //{
        //    device.AnalogOutput.WriteValue(2, (double)frequency3_Setup.Value / 5.28);
        //}

        private void DO0_ValueChanged(object sender, EventArgs e)
        {

            device.DigitalOutput.WriteValue(0, Docontrol1_Start.Value);
            timer2.Enabled = true;
        }

        private void DO1_ValueChanged(object sender, EventArgs e)
        {
            device.DigitalOutput.WriteValue(3, Docontrol2_Start.Value);
            timer3.Enabled = true;

        }

        private void DO2_ValueChanged(object sender, EventArgs e)
        {
            device.DigitalOutput.WriteValue(4, Docontrol3_Start.Value);
            timer4.Enabled = true;
        }


        #endregion
        //ORE-063
        private void motor2_Start_Click(object sender, EventArgs e)
        {
            motor2_Start.Enabled = false;
            motor2_Start.BackColor = Color.LightBlue;
            motor2_Stop.BackColor = Color.Transparent;
            isArrivedInitPos2 = false;
            device.MotorControl[1].MoveInSpeed((double)rotationspeed2.Value);
            Task.Factory.StartNew(MoveToInitialPos2);
        }

        private void motor2_Stop_Click(object sender, EventArgs e)
        {
            motor2_Start.BackColor = Color.Transparent;
            motor2_Stop.BackColor = Color.LightBlue;
            isArrivedInitPos2 = true;
            isMeasuring2 = false;
            device.MotorControl[1].Stop();
            //device.AnalogInput.Stop();
            motor2_Start.Enabled = true;
        }

        //ORE-064
        private void motor3_Start_Click(object sender, EventArgs e)
        {
            try
            {
                motor3_Start.Enabled = false;
                motor3_Start.BackColor = Color.LightBlue;
                motor3_Stop.BackColor = Color.Transparent;
                isArrivedInitPos3 = false;
                device.MotorControl[2].MoveInSpeed((double)rotationspeed3.Value);
                Task.Factory.StartNew(MoveToInitialPos3);
            }
            catch (Exception ex)
            {
                device.MotorControl[2].Stop();
                throw new Exception(ex.Message);
            }

        }

        private void motor3_Stop_Click(object sender, EventArgs e)
        {
            motor3_Start.BackColor = Color.Transparent;
            motor3_Stop.BackColor = Color.LightBlue;
            isArrivedInitPos3 = true;
            isMeasuring3 = false;
            device.MotorControl[2].Stop();
            //device.AnalogInput.Stop();
            motor3_Start.Enabled = true;
        }




        private void motor1_Dis_Reset_Click(object sender, EventArgs e)
        {
            device.AnalogInput.AIChannels[0].EncoderUnitOffset += (-1) * device.AnalogInput.GetEncoderData(4).Last();
        }

        private void motor2_Dis_Reset_Click(object sender, EventArgs e)
        {
            device.AnalogInput.AIChannels[1].EncoderUnitOffset += (-1) * device.AnalogInput.GetEncoderData(5).Last();
        }

        private void motor3_Dis_Reset_Click(object sender, EventArgs e)
        {
            device.AnalogInput.AIChannels[2].EncoderUnitOffset += (-1) * device.AnalogInput.GetEncoderData(6).Last();
        }

        private void force1_Reset_Click(object sender, EventArgs e)
        {
            device.AnalogInput.AIChannels[0].SensorOffset += (-1) * device.AnalogInput.GetChannelData(4).Average();


        }

        private void force2_Reset_Click(object sender, EventArgs e)
        {
            device.AnalogInput.AIChannels[1].SensorOffset += (-1) * device.AnalogInput.GetChannelData(5).Last();
        }

        private void force3_Reset_Click(object sender, EventArgs e)
        {
            device.AnalogInput.AIChannels[2].SensorOffset += (-1) * device.AnalogInput.GetChannelData(6).Last();
            force3.Value = (decimal)device.AnalogInput.GetChannelData(6).Last();
        }

        //采集初始化设置
        private void aquisition_Config_Click(object sender, EventArgs e)
        {
            AcquisitionConfig.BackColor = Color.LightBlue;
            device.AnalogInput.AIAppMode = JYPCI69524.AIApplicationMode.AquireWithEncoder;//电压采集模式
            device.AnalogInput.AcqMode = JYPCI69524.AIMode.Continuous;//连续采样
            device.AnalogInput.SampleRate = AnalogInput.SamplingRateList.Rate01000;//采样率
            device.AnalogInput.SamplesToAcquire = 100;//采样点数


            device.AnalogInput.BufferMode = true;
            device.AnalogInput.RecordLength = 1;
            device.AnalogInput.GeneralChNulling = false;

            //采集电压及放大倍数
            device.AnalogInput.ConfigChannelGroup(JYPCI69524.AIChannelGroup.General);

            device.AnalogInput.ConfigGeneralChannel(4, 0, 5);
            device.AnalogInput.AIChannels[0].SensorScaling = (double)sensor1Scale.Value;
            //device.AnalogInput.AIChannels[0].SaveDisk = true;
            device.AnalogInput.AIChannels[0].FolderPath = @"D:\";
            device.AnalogInput.AIChannels[0].FilePath = @"ORE067.csv";
            device.AnalogInput.AIChannels[0].WriteMode = WriteMode.Append;

            device.AnalogInput.ConfigGeneralChannel(5, 0, 5);
            device.AnalogInput.AIChannels[1].SensorScaling = (double)sensor2Scale.Value;
            device.AnalogInput.AIChannels[1].FolderPath = @"D:\";
            device.AnalogInput.AIChannels[1].FilePath = @"ORE066.csv";
            device.AnalogInput.AIChannels[1].WriteMode = WriteMode.Append;

            device.AnalogInput.ConfigGeneralChannel(6, -10, 10);
            device.AnalogInput.AIChannels[2].SensorScaling = (double)sensor3Scale.Value;
            device.AnalogInput.AIChannels[2].FolderPath = @"D:\";
            device.AnalogInput.AIChannels[2].FilePath = @"ORE065.csv";
            device.AnalogInput.AIChannels[2].WriteMode = WriteMode.Append;

            //电机初始化设置
            device.MotorControl.Add(new MotorControl(0, 0));
            device.MotorControl[0].CommandMode = MotorCommandMode.CWCCW;
            device.MotorControl[0].ControlMode = MotorControlMode.Velocity;
            device.MotorControl[0].CountPerRev = 500000;
            device.MotorControl[0].CountPerUnit = 500000.0 / 6.0;//CountPerUnit是指电机多少脉冲走1mm / 6.0 (mm per count)
            device.AnalogInput.AIChannels[0].EncoderUnitPitch = 0.000012;

            device.MotorControl.Add(new MotorControl(0, 1));
            device.MotorControl[1].CommandMode = MotorCommandMode.CWCCW;
            device.MotorControl[1].ControlMode = MotorControlMode.Velocity;
            device.MotorControl[1].CountPerRev = 500000;
            device.MotorControl[1].CountPerUnit = 500000.0 / 6.0;
            device.AnalogInput.AIChannels[1].EncoderUnitPitch = 0.000012;

            device.MotorControl.Add(new MotorControl(0, 2));
            device.MotorControl[2].CommandMode = MotorCommandMode.CWCCW;
            device.MotorControl[2].ControlMode = MotorControlMode.Velocity;
            device.MotorControl[2].CountPerRev = 500000;
            device.MotorControl[2].CountPerUnit = 500000.0 / 6.0; // 6.0 (mm per count)
            device.AnalogInput.AIChannels[2].EncoderUnitPitch = 0.000012;


            device.AnalogInput.Start();
            device.AnalogInput.AIChannels[0].Counts = 0;
            device.AnalogInput.AIChannels[1].Counts = 0;
            device.AnalogInput.AIChannels[2].Counts = 0;

            // enable start button
            motor1_Start.Enabled = true;
            motor2_Start.Enabled = true;
            motor3_Start.Enabled = true;
            acquisition3_Start.Enabled = true;

            // disable initialize button
            AcquisitionConfig.Enabled = false;

        }

        private void counter1_Click(object sender, EventArgs e)
        {
            device.AnalogInput.AIChannels[0].Counts = 0;

        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {

            timer2.Enabled = false;

            counter1.Text = device.AnalogInput.AIChannels[0].Counts.ToString();

            if (device.AnalogInput.AIChannels[0].Counts > (double)Cycle_Setup.Value)

            {
                isArrivedInitPos1 = true;
                isMeasuring1 = false;
                device.MotorControl[0].Stop();
                device.DigitalOutput.WriteValue(0, false);
                timer2.Enabled = false;
            }

            else
            { timer2.Enabled = true; }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = false;

            counter2.Text = device.AnalogInput.AIChannels[1].Counts.ToString();

            if (device.AnalogInput.AIChannels[1].Counts > (double)Cycle_Setup2.Value)

            {
                isArrivedInitPos2 = true;
                isMeasuring2 = false;
                device.MotorControl[1].Stop();
                device.DigitalOutput.WriteValue(1, false);
                timer3.Enabled = false;

            }


            else
            { timer3.Enabled = true; }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Enabled = false;

            counter3.Text = device.AnalogInput.AIChannels[2].Counts.ToString();

            if (device.AnalogInput.AIChannels[2].Counts > (double)Cycle_Setup3.Value)

            {
                isArrivedInitPos3 = true;
                isMeasuring3 = false;
                device.MotorControl[2].Stop();
                device.DigitalOutput.WriteValue(2, false);
                timer4.Enabled = false;
            }

            else
            { timer4.Enabled = true; }

        }

        private void counter2_Start_Click(object sender, EventArgs e)
        {
            device.AnalogInput.AIChannels[1].Counts = 0;
        }

        private void counter3_Start_Click(object sender, EventArgs e)
        {
            device.AnalogInput.AIChannels[2].Counts = 0;
        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void Cycle_Setup_ValueChanged(object sender, EventArgs e)
        {

        }


    }


}




