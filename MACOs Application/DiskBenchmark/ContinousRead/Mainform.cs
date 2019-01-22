using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeeSharpTools.JXI.FileIO.VectorFile;
using System.Runtime.InteropServices;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace ContinuousRead
{
    public partial class Mainform : Form
    {
        private FixFrequencyStreamFile _streamFile;
        private const int _readFileBlockSizeInShort = 2 * 1024 * 1024; //8M short
        private ConcurrentBag<BufferBlock> _bufferListPool = new ConcurrentBag<BufferBlock>();
        private long _playBackLength;
        private long _playbackStartPosition;
        private ConcurrentQueue<BufferBlock> _bufferQueue = new ConcurrentQueue<BufferBlock>();
        private long _playedSampleCount;
        /// <summary>
        /// 控制读取时间间隔
        /// </summary>
        private double _writeIntervalIn_ms = 10; 
        private Semaphore _semStopThread = new Semaphore(0, 2);

        private double _elapsedCurrent = 0;
        private double _elapsedMax = 0;
        private double _elapsedMin = 0;
        private double _elapsedAvg = 0;
        private double _readCount = 0;
        private int[] _elapsedHistogram = new int[1000];
        private int _overflowCount = 0;
        /// <summary>
        /// 直方图统计门限
        /// </summary>
        private int _histThreshold = 1000;

        private string _exceedThresholdInfo = string.Empty;
        private Stopwatch _swTotalTime = new Stopwatch();

        public Mainform()
        {
            InitializeComponent();
        }

        private void btBrowserDataFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            tbDataFilePath.Text = ofd.FileName;            
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if(!File.Exists(tbDataFilePath.Text))
            {
                MessageBox.Show("File not found.");
                return;
            }
            _streamFile = new FixFrequencyStreamFile();
            try
            {
                _streamFile.Open(tbDataFilePath.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read, true);
                _playBackLength = _streamFile.NumberOfSamples;
                _playbackStartPosition = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            _playedSampleCount = 0;
            _playBackLength = _streamFile.NumberOfSamples;
            _playbackStartPosition = 0;
            _elapsedMax = 0;
            _elapsedMin = double.MaxValue;
            btStart.Enabled = false;
            btStop.Enabled = true;
            _overflowCount = 0;
            _swTotalTime.Reset();
            _swTotalTime.Start();
            timer1.Enabled = true;
            new Thread(ThreadReadFile).Start();
            new Thread(ThreadGetData).Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            _semStopThread.Release(2);
            btStart.Enabled = true;
            btStop.Enabled = false;
            timer1.Enabled = false;
            _swTotalTime.Stop();
        }

        private void ThreadReadFile()
        {
            double[] afterExceedThreshold = new double[100];
            int afterExceedThresholdCount = 0;
            bool isExceedThreshold = false;
            for (int i = 0; i < 128; i++) //初始化Buffer Pool
            {
                short[] dataToBuffer = new short[_readFileBlockSizeInShort + 8];
                var gcHdl = GCHandle.Alloc(dataToBuffer, GCHandleType.Pinned);
                var dataToBufferPtr = gcHdl.AddrOfPinnedObject();
                long dataAdd = (long)dataToBufferPtr;
                if (dataAdd % 16 != 0)
                {
                    dataToBufferPtr = dataToBufferPtr + (int)(16 - dataAdd % 16);
                }
                _bufferListPool.Add(new BufferBlock(dataToBuffer, dataToBufferPtr, gcHdl));
            }
            var buffer = new BufferBlock();
            int refreshInterval = 50; //50ms
            Stopwatch sw = new Stopwatch();
            Stopwatch swRefresh = new Stopwatch();
            swRefresh.Start();
            while (!_semStopThread.WaitOne(0))
            {
                if (_bufferListPool.Count > 0)
                {
                    _bufferListPool.TryTake(out buffer);
                    long availableSamplesInFile = (_playBackLength + _playbackStartPosition - _streamFile.Position) * _streamFile.Storage.NumberOfChannels;
                    if (availableSamplesInFile >= _readFileBlockSizeInShort)
                    {
                        sw.Start();
                        _streamFile.Read(buffer.Ptr, (buffer.Buffer.Length - 8) * sizeof(short));
                        _elapsedCurrent = sw.ElapsedMilliseconds;
                        sw.Stop();
                        sw.Reset();
                        _readCount++;
                        if (_elapsedMax < _elapsedCurrent)
                        {
                            _elapsedMax = _elapsedCurrent;
                        }
                        if (_elapsedMin > _elapsedCurrent)
                        {
                            _elapsedMin = _elapsedCurrent;
                        }
                        _elapsedAvg = (_elapsedAvg * (_readCount - 1) + _elapsedCurrent)  /  _readCount;
                        if (_elapsedCurrent >= _histThreshold)
                        {
                            _overflowCount++;
                            if(!isExceedThreshold)
                            {
                                isExceedThreshold = true;
                            }
                        }
                        else
                        {
                            _elapsedHistogram[(int)_elapsedCurrent]++;
                        }
                        if(isExceedThreshold)
                        {
                            afterExceedThreshold[afterExceedThresholdCount++] = _elapsedCurrent;
                            if(afterExceedThresholdCount > 99)
                            {
                                isExceedThreshold = false;
                                _exceedThresholdInfo += "\r\nExceed " + _overflowCount.ToString() + " at " + DateTime.Now .TimeOfDay.ToString() + ": \r\n";
                                for (int i = 0; i < 100; i++)
                                {
                                    _exceedThresholdInfo += afterExceedThreshold[i].ToString() + "\t";
                                }
                                _exceedThresholdInfo += "\r\n";
                                afterExceedThresholdCount = 0;
                            }

                        }
                        if (swRefresh.ElapsedMilliseconds >= refreshInterval)
                        {
                            Action a = new Action(() =>
                            tbTestResult.Text = "Test Result：\r\n" +
                                                "Current Interval: " + _elapsedCurrent.ToString("F3") + "\r\n" +
                                                "Max Interval: " + _elapsedMax.ToString("F3") + "\r\n" +
                                                "Min Interval: " + _elapsedMin.ToString("F3") + "\r\n" +
                                                "Avg Interval: " + _elapsedAvg.ToString("F3") + "\r\n" +
                                                "Exceed " + _histThreshold.ToString() + "ms Count=" + _overflowCount.ToString() +
                                                _exceedThresholdInfo

                            );
                            this.tbTestResult.BeginInvoke(a);

                            Action b = new Action(() =>
                            {
                                chart1.Series[0].Points.Clear();
                                for (int i = 0; i < 50; i++)
                                {
                                    chart1.Series[0].Points.AddXY(i, _elapsedHistogram[i]);
                                }
                            }
                            );
                            this.chart1.BeginInvoke(b);
                            swRefresh.Reset();
                            swRefresh.Restart();
                        }
                    }
                    else if (availableSamplesInFile < _readFileBlockSizeInShort && availableSamplesInFile > 0)
                    {
                        short[] dataFileEnd = new short[availableSamplesInFile];
                        _streamFile.Read(dataFileEnd);
                        Marshal.Copy(dataFileEnd, 0, buffer.Ptr, dataFileEnd.Length);
                        _streamFile.Position = _playbackStartPosition;//跳转到文件头
                        short[] dataFileHead = new short[_readFileBlockSizeInShort - availableSamplesInFile];
                        _streamFile.Read(dataFileHead);
                        Marshal.Copy(dataFileHead, 0, buffer.Ptr + dataFileEnd.Length * sizeof(short), dataFileHead.Length);
                    }
                    else//块大小刚好相等
                    {
                        _streamFile.Position = _playbackStartPosition;//跳转到文件头
                        _streamFile.Read(buffer.Ptr, (buffer.Buffer.Length - 8) * sizeof(short));
                    }

                    lock (_bufferQueue)
                    {
                        _bufferQueue.Enqueue(buffer);
                    }
                    _playedSampleCount += _readFileBlockSizeInShort; //累加写入的点数
                    Debug.Print("{2}:\t从文件中读取{0}个样点，当前已从文件读取的样点总数为{1}", _readFileBlockSizeInShort, _playedSampleCount, DateTime.Now.Day.ToString()+ DateTime.Now.TimeOfDay.ToString());
                }
                else
                {
                    Thread.Sleep(1);
                }
            }

        }

        private void ThreadGetData()
        {
            Stopwatch sw = new Stopwatch();
            while (!_semStopThread.WaitOne(0))
            {                
                if (_bufferQueue.Count > 0)
                {
                    BufferBlock bufferToFile;
                    lock (_bufferQueue)
                    {
                        _bufferQueue.TryDequeue(out bufferToFile);
                    }
                    _bufferListPool.Add(bufferToFile);
                }

                sw.Start();
                while (true)
                {
                    if (sw.ElapsedMilliseconds >= _writeIntervalIn_ms)
                    {
                        break;
                    }
                    Thread.Sleep(1);
                }
                sw.Stop();
                sw.Reset();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = TimeSpan.FromMilliseconds(_swTotalTime.ElapsedMilliseconds).TotalHours.ToString("F4") + "H";
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            btStop_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FixFrequencyStreamFile _streamFile;
            string fileName = Directory.GetCurrentDirectory() + @"\testFile.iq";
            Console.WriteLine("Dummy File Path:{0}", fileName);
            _streamFile = new FixFrequencyStreamFile();
            Console.WriteLine("Initialization done");
            _streamFile.Open(fileName, System.IO.FileMode.Create, System.IO.FileAccess.Write, true);
            _streamFile.Sampling.SampleRate = 2000000;
            _streamFile.Storage.FileFormat = FileFormat.FixFrequencyStream;
            _streamFile.Storage.DataType = DataType.RealI16;
            _streamFile.Storage.NumberOfChannels = 2;
            for (int i = 0; i < 2; i++)
            {
                _streamFile.Sampling.Channels.Add(new BaseChannelSamplingInfo()
                {
                    RFFrequency = 2400000000,
                    Bandwidth = _streamFile.Sampling.SampleRate * 0.8,
                    RFScaleFactor = 0.5,
                    DigitizerScaleFactor = 0.00001,
                });
            }
            _streamFile.WriteFileHeader();
            Console.WriteLine("Configuration done");
            short[] data = new short[8 * 1024 * 1024];
            int iteration = 256;
            Console.WriteLine("BlockData (size is {0}Bytes) is ready", data.Length);
            for (int i = 0; i < iteration; i++)
            {
                _streamFile.Write(data);
                Console.WriteLine("{0}/{1} cycle is done", i + 1, iteration);
            }
            _streamFile.Close();
            Console.WriteLine("Dummy file generation is done");
            MessageBox.Show("Generation Done!");
        }
    }

    /// <summary>
    /// BufferBlock
    /// </summary>
    internal struct BufferBlock
    {
        /// <summary>
        /// Buffer
        /// </summary>
        public short[] Buffer;

        /// <summary>
        /// Ptr
        /// </summary>
        public IntPtr Ptr;

        /// <summary>
        /// GCHandle
        /// </summary>
        public GCHandle GCHandle;

        /// <summary>
        /// Default value
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="ptr"></param>
        /// <param name="gcHandle"></param>
        public BufferBlock(short[] buffer, IntPtr ptr, GCHandle gcHandle)
        {
            Buffer = buffer;
            Ptr = ptr;
            GCHandle = gcHandle;
        }
    }
}
