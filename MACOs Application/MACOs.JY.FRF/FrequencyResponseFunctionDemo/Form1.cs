using System;
using System.Windows.Forms;
using JYPXI69527;
using SeeSharpTools.JY.DSP.FRF;
using SeeSharpTools.JY.DSP.Utility.ToneAnalysis;
using System.IO;
using SeeSharpTools.JY.DSP.Fundamental;
using SeeSharpTools.JY.ArrayUtility;

namespace FrequencyResponseFunctionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Fields
        /// <summary>
        /// AI 任务
        /// </summary>
        JYPXI69527AITask aitask;
        /// <summary>
        /// AO 任务
        /// </summary>
        JYPXI69527AOTask aotask;
        /// <summary>
        /// 数据读取buffer
        /// </summary>
        double[,] readValue;
        /// <summary>
        /// Input数据
        /// </summary>
        double[] TempInput;
        /// <summary>
        /// Output数据
        /// </summary>
        double[] TempOutput;
        /// <summary>
        /// AO写入数据
        /// </summary>
        double[] writeValue;

        StepSineFRF stepSine;

        #endregion

        #region Event Handler
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxSignal.SelectedIndex = 0;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            buttonRun.Enabled = false;
            if(comboBoxSignal.Text == "StepSine")
            {
                stepSine = new StepSineFRF();
                stepSine.FStepMode = StepSineFRF.FrequencyStepMode.Linear;
                stepSine.LengthMode = StepSineFRF.StepLengthMode.ConstCycle;
                stepSine.MinCycles = (int)numericUpDownStepSineMinCycles.Value;
                stepSine.NumOfFreq = (int)numericUpDownStepPoints.Value;
                stepSine.StartF = (double)numericUpDownStepSineFrequencyStart.Value;
                stepSine.StopF = (double)numericUpDownStepSineFrequencyStop.Value;
                stepSine.SampleRate = (double)numericUpDownSamplingRate.Value;
                stepSine.TotalTime = 0.2;
                stepSine.Generation();
                if (buttonSwitchSimulation.Value)
                {
                    LoadStepSineData();
                }
                else
                {
                    //生成SweptSine
                    writeValue = stepSine.Sin;

                    //将Input数据写入AO0并从AI0读取出来，同时由AI1读取Output
                    AOWriteAIRead();

                    //将测试数据保存为.bin文件
                    //WriteData();

                }
                StepSineAnalysis();
            }
            else if (comboBoxSignal.Text == "WhiteNoise")
            {
                if (buttonSwitchSimulation.Value)
                {
                    LoadWhiteNoiseData();
                }
                else
                {
                    //生成白噪音
                    writeValue = new double[102400];
                    Generation.UniformWhiteNoise(ref writeValue);

                    //将Input数据写入AO0并从AI0读取出来，同时由AI1读取Output
                    AOWriteAIRead();

                    //将测试数据保存为.bin文件
                    //WriteData();
                }
                WhiteNoiseAnalysis();
                easyChartTHD.Clear();
            }

            buttonRun.Enabled = true;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// 配置AI
        /// </summary>
        private void AIConfig()
        {
            //添加任务
            aitask = new JYPXI69527AITask(0);
            //AI配置
            aitask.AddChannel(0, -10, 10, Coupling.DC, AITerminal.Differential);
            aitask.AddChannel(1, -10, 10, Coupling.DC, AITerminal.Differential);
            aitask.Mode = AIMode.Finite;
            aitask.SampleRateRadio = SampleRateRadio.AIO_1to1 ;
            aitask.Trigger.Type = AITriggerType.SoftWare;
            aitask.SampleRate = (double)numericUpDownSamplingRate.Value;
        }
        /// <summary>
        /// 配置AO
        /// </summary>
        private void AOConfig()
        {
            //添加任务
            aotask = new JYPXI69527AOTask(0);
            //AO配置
            aotask.AddChannel(0, -10, 10, AOTerminal.Differential);
            aotask.Mode = AOMode.Finite;
            aotask.UpdateRate = (double)numericUpDownSamplingRate.Value;
            aotask.Trigger.Type = AOTriggerType.SoftWare;

        }
        /// <summary>
        /// 分析StepSine数据
        /// </summary>
        private void StepSineAnalysis()
        {
            stepSine.Excitation = TempInput;
            stepSine.Response = TempOutput;
            stepSine.Analysis();
            easyChartInput.Plot(TempInput);
            easyChartOutput.Plot(TempOutput);

            easyChartMagnitude.Plot(stepSine.Frequencies,stepSine.AmplitudesDB);
            easyChartPhase.Plot(stepSine.Frequencies,stepSine.PhasesDeg);
            easyChartTHD.Plot(stepSine.Frequencies,stepSine.THDsDB);
             
        }
        /// <summary>
        /// 分析WhiteNoise数据
        /// </summary>
        private void WhiteNoiseAnalysis()
        {
            double samplingRate = 200000;
            int freqLines = 5000; //set frequency resolution here
            double df = samplingRate / 2 / freqLines;
            double[] analysisInWav = new double[freqLines * 2];
            double[] analysisOutWav = new double[freqLines * 2];
            double[] bodeMag = new double[freqLines];
            double[] bodePhase = new double[freqLines];

            int numOfAverage = (int)Math.Floor((decimal)(TempInput.Length / 2 / freqLines));
            easyChartInput.Plot(TempInput);
            easyChartOutput.Plot(TempOutput);
            //创建FRF分析对象
            WhiteNoiseFRF FRFAnalysis = new WhiteNoiseFRF();
            FRFAnalysis.SetAveraging(WhiteNoiseFRF.AverageMode.RMS, numOfAverage, true);
            //FRF多次分析取平均
            for (int i = 0; i < numOfAverage; i++)
            {
                ArrayManipulation.GetArraySubset(TempInput, i * 2 * freqLines, ref analysisInWav);
                ArrayManipulation.GetArraySubset(TempOutput, i * 2 * freqLines, ref analysisOutWav);
                FRFAnalysis.SetInput(analysisInWav);
                FRFAnalysis.SetOutput(analysisOutWav);
                if (i == 0) FRFAnalysis.InitStatus();
                bodeMag = FRFAnalysis.GetMagenitude(true);
                bodePhase = FRFAnalysis.GetPhase(true);
            }
            bool averageDone = FRFAnalysis.AveragingDone();
            easyChartMagnitude.Plot(bodeMag, 0, df);
            easyChartPhase.Plot(bodePhase, 0, df);
        }
        /// <summary>
        /// 读取StepSine数据
        /// </summary>
        private void LoadStepSineData()
        {
            string FilePath = Environment.CurrentDirectory.Replace("FrequencyResponseFunctionDemo\\bin\\Debug", "Source\\StepSine.bin") ;
            FileStream fs = new FileStream(FilePath, FileMode.Open);
            BinaryReader fileReadHandle = new BinaryReader(fs);
            long fileLength = fs.Length;
            byte[] bytebuffer = new byte[fileLength / 2];
            TempInput = new double[bytebuffer.Length / sizeof(double)];
            TempOutput = new double[TempInput.Length];
            bytebuffer = fileReadHandle.ReadBytes(bytebuffer.Length);
            Buffer.BlockCopy(bytebuffer, 0, TempInput, 0, bytebuffer.Length);
            bytebuffer = fileReadHandle.ReadBytes(bytebuffer.Length);
            Buffer.BlockCopy(bytebuffer, 0, TempOutput, 0, bytebuffer.Length);
            fileReadHandle.Close();
            fs.Close();
        }
        /// <summary>
        /// 读取WhiteNoise数据
        /// </summary>
        private void LoadWhiteNoiseData()
        {
            string FilePath = Environment.CurrentDirectory.Replace("FrequencyResponseFunctionDemo\\bin\\Debug", "Source\\WhiteNoise.bin");
            FileStream fs = new FileStream(FilePath, FileMode.Open);
            BinaryReader fileReadHandle = new BinaryReader(fs);
            long fileLength = fs.Length;
            byte[] bytebuffer = new byte[fileLength / 2];
            TempInput = new double[bytebuffer.Length / sizeof(double)];
            TempOutput = new double[TempInput.Length];
            bytebuffer = fileReadHandle.ReadBytes(bytebuffer.Length);
            Buffer.BlockCopy(bytebuffer, 0, TempInput, 0, bytebuffer.Length);
            bytebuffer = fileReadHandle.ReadBytes(bytebuffer.Length);
            Buffer.BlockCopy(bytebuffer, 0, TempOutput, 0, bytebuffer.Length);
            fileReadHandle.Close();
            fs.Close();
        }
        /// <summary>
        /// AO写入数据AI读取数据
        /// </summary>
        private void AOWriteAIRead()
        {
            //配置AI与AO
            AIConfig();
            AOConfig();

            //添加延时
            aotask.SamplesToUpdate = writeValue.Length;
            aitask.SamplesToAcquire = writeValue.Length + (int)numericUpDownDelaySamples.Value;
            readValue = new double[aitask.SamplesToAcquire, aitask.Channels.Count];
            //AO写入数据 AI读取数据
            aotask.WriteData(writeValue, -1);
            aotask.Start();
            aitask.Start();
            aitask.SendSoftTrigger();
            aitask.ReadData(ref readValue, -1);

            TempInput = new double[writeValue.Length];
            TempOutput = new double[writeValue.Length];

            for (int k = 0; k < writeValue.Length; k++)
            {
                TempInput[k] = readValue[k, 0];
                TempOutput[k] = readValue[k + (int)numericUpDownDelaySamples.Value, 1];
            }

            aotask.WaitUntilDone(-1);
            aotask.Stop();
            aotask.Channels.Clear();
            aitask.Stop();
            aitask.Channels.Clear();
        }
        /// <summary>
        /// 保存数据
        /// </summary>
        private void WriteData()
        {
            string FilePath = Environment.CurrentDirectory + @"\" + "WhiteNoise" + @".bin";
            //string FilePath = Environment.CurrentDirectory + @"\" + "StepSine" + @".bin";
            FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
            BinaryWriter fileWriteHandle = new BinaryWriter(fs);
            byte[] byteBuffer = new byte[TempInput.Length * sizeof(double)];
            Buffer.BlockCopy(TempInput, 0, byteBuffer, 0, byteBuffer.Length);
            fileWriteHandle.Write(byteBuffer);
            Buffer.BlockCopy(TempOutput, 0, byteBuffer, 0, byteBuffer.Length);
            fileWriteHandle.Write(byteBuffer);
            fileWriteHandle.Flush();
            fileWriteHandle.Close();
            fs.Close();
        }
        #endregion
    }
}
