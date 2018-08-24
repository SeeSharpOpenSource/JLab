using JYPXI62022;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace MACOs.JY.Streaming
{
    class JYPXI62022 : StreamingTask
    {
        #region Private filed
        private readonly Type streamRawDataType = typeof(short);
        private JYPXI62022AITask aitask;
        private FileStream txtFileStream;
        private StreamWriter txtStreamWriter;
        private int[] channelNumbers;
        private double range;
        private DateTime startTime;
        private string currentTime;
        /// <summary>
        /// 流盘块大小
        /// </summary>
        private int _recordBlockSize;
        /// <summary>
        /// 任务结束标志 
        /// </summary>
        private bool _taskDone;
        private bool TaskDone
        {
            get { return _taskDone; }
            set
            {
                _taskDone = value;
                if (_taskDone)
                {
                    _waitUntilDoneEvent.Set();
                }
            }
        }
        /// <summary>
        /// WaitUntilDone等待事件
        /// </summary>
        private JYCommon.WaitEvent _waitUntilDoneEvent;
        /// <summary>
        /// 事件队列。调用WaitUntilDone()或者ReadBuffer()时，使用事件通知方式，提高效率。
        /// </summary>
        private Queue<JYCommon.WaitEvent> EventQueue { get; }
        private int _recordCnt;
        /// <summary>
        /// 流盘的采样点数
        /// </summary>
        private double _recordLength;
        /// <summary>
        /// 已经流盘的采样点数
        /// </summary>
        private double _recordedLength;
        /// <summary>
        /// 流盘预览缓冲区锁
        /// </summary>
        private Mutex _previewBufferLock;
        /// <summary>
        /// 流盘预览缓冲内存
        /// </summary>
        private JYCommon.CircularBuffer<short> _localPreviewBuffer;
        /// <summary>
        /// 写二进制对象
        /// </summary>
        private BinaryWriter _wt;
        /// <summary>
        /// FileStream对象
        /// </summary>
        private FileStream _fs;
        /// <summary>
        /// 取数据的线程
        /// </summary>
        private Thread _thdFetchAndWriteData;
        /// <summary>
        /// 流盘预览缓冲转换前的数组
        /// </summary>
        private short[,] _previewDataConvertBuffer;
        /// <summary>
        /// 流盘是否完成
        /// </summary>
        private bool _recordDone;
        #endregion 

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="boardNum"></param>
        public JYPXI62022(int boardNum)
        {
            aitask = new JYPXI62022AITask(boardNum);
            EventQueue = new Queue<JYCommon.WaitEvent>(8);
            _waitUntilDoneEvent = new JYCommon.WaitEvent(() => _taskDone);
            NumOfChannels = 8;
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
            aitask.AddChannel(chnID, rangelow, rangeHigh);
            aitask.Mode = AIMode.Continuous;
            _recordLength = recordLength;
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
            aitask.AddChannel(chnsID, rangelow, rangeHigh);
            aitask.Mode = AIMode.Continuous;
            _recordLength = recordLength;
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
                _recordDone = false;
                _previewBufferLock = new Mutex();
                txtFileStream = new FileStream(FilePath + "\\" + currentTime + ".txt", FileMode.Create);
                _fs = new FileStream(FilePath + "\\" + currentTime + ".bin", FileMode.OpenOrCreate);
                _wt = new BinaryWriter(_fs);
                WriteInfoToTxt(txtFileStream);
                txtFileStream.Close();
                aitask.Start();
                _thdFetchAndWriteData = new Thread(ThdFetchAndWriteData);
                _thdFetchAndWriteData.Start();
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
            if (_thdFetchAndWriteData.IsAlive == true)
            {
                if (false == _thdFetchAndWriteData.Join(200))
                {
                    _thdFetchAndWriteData.Abort();
                    JYLog.Print(JYLogLevel.DEBUG, "WriteDataFile Thread Exit Abnormally...");
                }
            }
            aitask.Stop();
            _wt.Close();
            _fs.Close();
        }

        /// <summary>
        /// 获取最新的流盘数据
        /// </summary>
        /// <param name="buf">用户定义返回数据的缓冲区</param>
        /// <param name="timeout">超时时间，单位ms，-1为无限等待</param>
        /// <returns></returns>
        public override void ReadLatestData(ref double[] buf, int timeout = -1)
        {
            var tempBuf = new double[buf.Length / aitask.Channels.Count, aitask.Channels.Count];
            _localPreviewBuffer.Dequeue(ref _previewDataConvertBuffer, tempBuf.Length);
            ScaleRawData(_previewDataConvertBuffer, ref tempBuf, buf.Length / aitask.Channels.Count, range);
            Buffer.BlockCopy(tempBuf, 0, buf, 0, tempBuf.Length * sizeof(double));
        }

        /// <summary>
        /// 获取最新的流盘数据
        /// </summary>
        /// <param name="buf">用户定义返回数据的缓冲区</param>
        /// <param name="samplesPerChannel">每通道要取的数据</param>
        /// <param name="timeout">超时时间，单位ms，-1为无限等待</param>
        public override void ReadLatestData(ref double[] buf, int samplesPerChannel, int timeout)
        {
            if (buf.Length < samplesPerChannel * aitask.Channels.Count)
            {
                JYLog.Print("GetRecordPreviewData:参数buf长度不足");
                throw new JYDriverException(JYDriverExceptionPublic.UserBufferError);
            }
            var tempBuf = new double[samplesPerChannel, buf.Length / samplesPerChannel];
            _localPreviewBuffer.Dequeue(ref _previewDataConvertBuffer, tempBuf.Length);
            ScaleRawData(_previewDataConvertBuffer, ref tempBuf, samplesPerChannel, range);
            Buffer.BlockCopy(tempBuf, 0, buf, 0, tempBuf.Length * sizeof(double));
        }

        /// <summary>
        /// 获取最新的流盘数据
        /// </summary>
        /// <param name="buf">用户定义返回数据的缓冲区</param>
        /// <param name="timeout">超时时间，单位ms，-1为无限等待</param>
        /// <returns></returns>
        public override void ReadLatestData(ref double[,] buf, int timeout = -1)
        {
            //aitask.GetRecordPreviewData(ref buf, timeout);
            _localPreviewBuffer.Dequeue(ref _previewDataConvertBuffer, buf.Length);
            ScaleRawData(_previewDataConvertBuffer, ref buf, buf.Length / aitask.Channels.Count, range);
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
            if (buf.Length < samplesPerChannel * aitask.Channels.Count)
            {
                JYLog.Print("GetRecordPreviewData:参数buf长度不足");
                throw new JYDriverException(JYDriverExceptionPublic.UserBufferError);
            }
            _localPreviewBuffer.Dequeue(ref _previewDataConvertBuffer, samplesPerChannel * aitask.Channels.Count);
            ScaleRawData(_previewDataConvertBuffer, ref buf, samplesPerChannel, range);
        }

        /// <summary>
        /// 获取流盘状态
        /// </summary>
        /// <param name="recordedLength">已流盘的长度</param>
        /// <param name="recordDone">流盘是否结束</param>
        public override void GetRecordStatus(out double recordedLength, out bool recordDone)
        {
            recordedLength = _recordedLength;
            recordDone = _recordDone;
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
            if (rangeLow >= -2.5 && rangeHigh <= 2.5)
            {
                return 2.5;
            }
            else
            {
                return 10.0;
            }
        }

        /// <summary>
        /// 将RawData转换为Scale的数值
        /// </summary>
        /// <param name="rawbuf">原始数据</param>
        /// <param name="scaledData">Scale后的数据</param>
        /// <param name="samples">采集到的点数</param>
        /// <param name="scaleRange">需要scale的range</param>
        private void ScaleRawData(short[,] rawbuf, ref double[,] scaledData, int samples, double scaleRange)
        {
            for (int i = 0; i < samples; i++)
            {
                for (int j = 0; j < rawbuf.GetLength(1); j++)
                {
                    scaledData[i, j] = rawbuf[i, j] * scaleRange / (short.MaxValue);
                }
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

        /// <summary>
        /// 读取并写入数据的线程函数
        /// </summary>
        private void ThdFetchAndWriteData()
        {
            //_recordBlockSize = (int)GetNearest2N((uint)(aitask.SampleRate / 20) * (uint)aitask.Channels.Count);
            _recordBlockSize = (int)GetNearest2N((uint)(aitask.SampleRate / 20)) * aitask.Channels.Count;
            byte[] bufferToFile = new byte[_recordBlockSize * sizeof(short)];
            short[] tempBuff = new short[_recordBlockSize];
            short[] tempBuffDeq = new short[_recordBlockSize+aitask.Channels.Count];
            int currentElementCount = 0;
            long recordedCount = 0; //写入文件的点数（所有通道）
            _localPreviewBuffer = new JYCommon.CircularBuffer<short>(Math.Max(_recordBlockSize, (int)aitask.SampleRate * aitask.Channels.Count)); //流盘预览缓冲区建立,1s每通道
            _previewDataConvertBuffer = new short[_localPreviewBuffer.BufferSize * 2, aitask.Channels.Count];
            while (TaskDone == false)
            {
                //To Add: 以下添加从缓冲区取数据并存入文件
                JYCommon.WaitEvent waitEvent =
                    new JYCommon.WaitEvent(() => TaskDone || (aitask.AvailableSamples >= _recordBlockSize));
                if (waitEvent.EnqueueWait(EventQueue, 100))
                {
                    currentElementCount = aitask.AvailableSamples;
                    if (TaskDone == false && aitask.AvailableSamples >= _recordBlockSize)
                    {
                        _recordCnt += _recordBlockSize;
                        aitask.ReadRawData(ref tempBuff, 1000);
                        Buffer.BlockCopy(tempBuff, 0, bufferToFile, 0, _recordBlockSize * sizeof(short));
                        WriteDataToFile(bufferToFile, 0, _recordBlockSize * sizeof(short)); //写入文件

                        recordedCount += _recordBlockSize; //累加写入的点数
                        _recordedLength = (double)recordedCount / aitask.Channels.Count / aitask.SampleRate;
                        if (_previewBufferLock.WaitOne(1))
                        {
                            //如果放不下则，先清空，保证该缓冲区始终只有BlockSize那么多数据
                            if (_localPreviewBuffer.CurrentCapacity < _recordBlockSize)
                            {
                                _localPreviewBuffer.Dequeue(ref tempBuffDeq,
                                    ((_recordBlockSize - _localPreviewBuffer.CurrentCapacity) / aitask.Channels.Count + 1) * aitask.Channels.Count);
                            }
                            _localPreviewBuffer.Enqueue(tempBuff, _recordBlockSize);
                            _previewBufferLock.ReleaseMutex();
                            ActivateWaitEvents();
                        }
                        if (_recordedLength >= _recordLength)
                        {
                            TaskDone = true;
                        }
                    }

                }
            }
            _recordDone = true;
        }
        /// <summary>
        /// 取大于输入整数a的2的N方的数
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private uint GetNearest2N(uint a)
        {
            uint ret = 1;
            if (a <= 0)
            {
                return ret;
            }
            for (int i = 0; i < 32; i++)
            {
                a <<= 1;
                if ((a & 0x80000000) == 0x80000000)
                {
                    if ((a & 0x7fffffff) > 0)
                    {
                        ret <<= (32 - i - 1);
                    }
                    else
                    {
                        ret <<= (32 - i - 2);
                    }
                    break;
                }
            }
            return ret;
        }

        /// <summary>
        /// 数据写入流盘文件
        /// </summary>
        /// <param name="data"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private int WriteDataToFile(byte[] data, int index, int count)
        {
            if (data == null) throw new ArgumentException("data parameter cannot be null!");
            _wt.Write(data, index, count);
            return 0;
        }
        /// <summary>
        /// 激活等待事件
        /// </summary>
        private void ActivateWaitEvents()
        {
            JYCommon.WaitEvent waitEvent;
            for (var i = 0; i < EventQueue.Count; i++)
            {
                waitEvent = EventQueue.Dequeue();
                if (waitEvent == null || !waitEvent.IsEnabled) continue; //Just Dequeue when no one is waiting
                if (TaskDone || waitEvent.ConditionHandler())
                    waitEvent.Set();
                else
                    EventQueue.Enqueue(waitEvent);
            }
        }
    }



}
