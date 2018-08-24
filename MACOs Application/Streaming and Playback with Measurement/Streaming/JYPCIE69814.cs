using JYPCIE69814;
using System;
using System.IO;

namespace MACOs.JY.Streaming
{
    class JYPCIE69814 : StreamingTask
    {
        private readonly Type streamRawDataType = typeof(short);
        private JYPCIE69814AITask aitask;
        private FileStream txtFileStream;
        private StreamWriter txtStreamWriter;
        private int[] channelNumbers;
        private double range;
        private DateTime startTime;
        private string currentTime;

        public JYPCIE69814(int boardNum)
        {
            aitask = new JYPCIE69814AITask(boardNum);
            NumOfChannels = 4;
        }

        /// <summary>
        /// 添加单通道
        /// </summary>
        /// <param name="chnID">通道物理序号</param>
        /// <param name="sampleRate">每通道采样率</param>
        /// <param name="recordLength">流盘时间长度，单位为秒</param>
        /// <param name="rangelow">通道量程下限</param>
        /// <param name="rangeHigh">通道量程上限</param>
        public override void Record(int chnID, double sampleRate, double recordLength, double rangelow = -10, double rangeHigh = 10)
        {
            channelNumbers = new int[1];
            channelNumbers[0] = chnID;
            aitask.AddChannel(chnID, rangelow, rangeHigh, (AIImpedance)Enum.Parse(typeof(AIImpedance),InputImpedance.ToString()));
            aitask.Mode = AIMode.Record;
            aitask.Record.Mode = RecordMode.Finite;
            aitask.Record.Length = recordLength;
            aitask.SampleRate = sampleRate;
            range = GetVendorRange(rangelow, rangeHigh);
        }

        /// <summary>
        /// 添加多通道
        /// </summary>
        /// <param name="chnsID">通道物理序号</param>
        /// <param name="sampleRate">每通道采样率</param>
        /// <param name="recordLength">流盘时间长度，单位为秒</param>
        /// <param name="rangelow">通道量程下限</param>
        /// <param name="rangeHigh">通道量程上限</param>
        public override void Record(int[] chnsID, double sampleRate, double recordLength, double rangelow = -10, double rangeHigh = 10)
        {
            channelNumbers = chnsID;
            aitask.AddChannel(chnsID, rangelow, rangeHigh, (AIImpedance)Enum.Parse(typeof(AIImpedance), InputImpedance.ToString()));
            aitask.Mode = AIMode.Record;
            aitask.Record.Mode = RecordMode.Finite;
            aitask.Record.Length = recordLength;
            aitask.SampleRate = sampleRate;
            range = GetVendorRange(rangelow, rangeHigh);
        }

        /// <summary>
        /// 启动流盘任务
        /// </summary>
        public override void Start()
        {
            startTime = DateTime.Now;
            currentTime = startTime.ToString("m") + "_" + Convert.ToString(startTime.Hour)
                + "_" + Convert.ToString(startTime.Minute) + "_" + Convert.ToString(startTime.Second);
            if (FilePath != null)
            {
                aitask.Record.FilePath = FilePath + "\\" + currentTime + ".bin";
                txtFileStream = new FileStream(FilePath + "\\" + currentTime + ".txt", FileMode.Create);
                WriteInfoToTxt(txtFileStream);
                txtFileStream.Close();
                aitask.Start();
            }
            else
            {
                throw new Exception("请指定文件保存路径！");
            }
        }

        /// <summary>
        /// 停止流盘任务
        /// </summary>
        public override void Stop()
        {
            txtFileStream = new FileStream(FilePath + "\\" + currentTime + ".txt", FileMode.Append);
            StreamWriter txt = new StreamWriter(txtFileStream);
            txt.WriteLine("ElapsedTime = " + (DateTime.Now - startTime).TotalMilliseconds);
            txt.Close();
            txtFileStream.Close();
            aitask.Stop();
        }

        /// <summary>
        /// 获取最新的流盘数据
        /// </summary>
        /// <param name="buf">用户定义返回数据的缓冲区</param>
        /// <param name="timeout">超时时间，单位ms，-1为无限等待</param>
        /// <returns></returns>
        public override void ReadLatestData(ref double[] buf, int timeout = -1)
        {
            aitask.GetRecordPreviewData(ref buf, timeout);
        }

        /// <summary>
        /// 获取最新的流盘数据
        /// </summary>
        /// <param name="buf">用户定义返回数据的缓冲区</param>
        /// <param name="samplesPerChannel">每通道要取的数据</param>
        /// <param name="timeout">超时时间，单位ms，-1为无限等待</param>
        public override void ReadLatestData(ref double[] buf, int samplesPerChannel, int timeout)
        {
            aitask.GetRecordPreviewData(ref buf, samplesPerChannel, timeout);
        }

        /// <summary>
        /// 获取最新的流盘数据
        /// </summary>
        /// <param name="buf">用户定义返回数据的缓冲区</param>
        /// <param name="timeout">超时时间，单位ms，-1为无限等待</param>
        /// <returns></returns>
        public override void ReadLatestData(ref double[,] buf, int timeout = -1)
        {
            aitask.GetRecordPreviewData(ref buf, timeout);
        }

        /// <summary>
        /// 获取最新的流盘数据
        /// </summary>
        /// <param name="buf">用户定义返回数据的缓冲区</param>
        /// <param name="samplesPerChannel">每通道要取的数据</param>
        /// <param name="timeout">超时时间，单位ms，-1为无限等待</param>
        /// <returns></returns>
        public override void ReadLatestData(ref double[,] buf, int samplesPerChannel, int timeout)
        {
            aitask.GetRecordPreviewData(ref buf, samplesPerChannel, timeout);
        }

        /// <summary>
        /// 获取流盘状态
        /// </summary>
        /// <param name="recordedLength">已流盘的长度</param>
        /// <param name="recordDone">流盘是否结束</param>
        public override void GetRecordStatus(out double recordedLength, out bool recordDone)
        {
            aitask.GetRecordStatus(out recordedLength, out recordDone);
        }

        /// <summary>
        /// 等待当前任务完成
        /// </summary>
        /// <param name="timeout">等待的时间(单位:ms) </param>
        /// <returns>true:任务结束,false:超时</returns>
        public override void WaitUntilDone(int timeout = -1)
        {
            aitask.WaitUntilDone(timeout);
        }

        /// <summary>
        /// 根据输入范围匹配一个原厂驱动的Range值
        /// </summary>
        /// <param name="rangeLow">输入下限</param>
        /// <param name="rangeHigh">输入上限</param>
        /// <returns>
        /// 小于0：错误
        /// 大于0：原厂驱动的Range
        /// </returns>
        public override double GetVendorRange(double rangeLow, double rangeHigh)
        {
            if (rangeLow >= -0.5 && rangeHigh <= 0.5)
            {
                return 0.5;
            }
            else if (rangeLow >= -1 && rangeHigh <= 1)
            {
                return 1.0;
            }
            else if (rangeLow >= -5 && rangeHigh <= 5)
            {
                return 5.0;
            }
            else
            {
                return 10.0;
            }
        }

        /// <summary>
        /// 写入采集信息及参数到txt文件
        /// </summary>
        private void WriteInfoToTxt(FileStream txtFileStream)
        {
            txtStreamWriter = new StreamWriter(txtFileStream);
            txtStreamWriter.WriteLine("SampleRate = " + aitask.SampleRate);
            txtStreamWriter.WriteLine("Range = " + range);
            txtStreamWriter.WriteLine("DataType = " + streamRawDataType);
            txtStreamWriter.WriteLine("ChannelCount = {0}", channelNumbers.Length);
            for (int i = 0; i < channelNumbers.Length; i++)
            {
                txtStreamWriter.WriteLine("Channel[" + channelNumbers[i].ToString() + "]");
            }

            txtStreamWriter.Flush();
            txtStreamWriter.Close();
        }
    }
}
