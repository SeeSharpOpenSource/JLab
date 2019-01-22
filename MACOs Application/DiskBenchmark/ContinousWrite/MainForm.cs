using Microsoft.Win32.SafeHandles;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ContinuousWrite
{
    public partial class MainForm : Form
    {
        private byte[] blockData;
        private string filePath = "";
        private long iteration = 1;
        private int _sleep = 0;
        private Stopwatch sw = new Stopwatch();
        private Thread _writeThread;
        private ulong index = 0;
        private volatile bool isRunning = false;
        private PerformanceCounter pCounter;
        private int timeCounter = 0;
        private DriveInfo[] info;
        private DriveInfo activeDrive;
        private string instanceName = "";
        private long totalDataSize = 0;
        private int reWriteCount = 0;
        private double sumSpeed = 0;
        private StreamWriter csvWriter;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_start.Enabled = false;
            button_stop.Enabled = true;
            chart1.Series[0].Points.Clear();
            ConfigureParameters();
            if (iteration * blockData.Length > activeDrive.AvailableFreeSpace)
            {
                MessageBox.Show("硬盘空间不够");
                return;
            }

            CreateFileWin32(filePath);

            _writeThread = new Thread(WriteData);

            isRunning = true;

            _writeThread.Start();
            timer1.Enabled = true;
        }

        private void ConfigureParameters()
        {
            ConfigureBlockData();
            textBox1.Text = "";
            index = 0;
            timeCounter = 0;
            reWriteCount = 0;
            sumSpeed = 0;
            iteration = (long)numericUpDown_iteration.Value;

            filePath = comboBox_drive.Text + @"\testdata32.bin";
            var date = DateTime.Now;
            string logName = string.Format("{0}{1}{2}", date.Year, date.Month.ToString("00"), date.Day.ToString("00"));
            csvWriter = new StreamWriter(Directory.GetCurrentDirectory() + logName + "DiskWriteTest.csv", false, Encoding.Default);
            activeDrive = info[comboBox_drive.SelectedIndex];
            _sleep = (int)numericUpDown_sleep.Value;
            var catName = PerformanceCounterCategory.GetCategories().Where(x => x.CategoryName == "PhysicalDisk").ToArray();
            instanceName = catName[0].GetInstanceNames().Where(x => x.Contains(comboBox_drive.Text.Replace(@"\", ""))).ToArray()[0];
            pCounter = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", instanceName);
            totalDataSize = (long)(blockData.Length) * iteration;
        }

        private void ConfigureBlockData()
        {
            switch (comboBox_blockData.Text)
            {
                case "1M":
                    blockData = new byte[1 * 1024 * 1024];
                    break;

                case "2M":
                    blockData = new byte[2 * 1024 * 1024];
                    break;

                case "4M":
                    blockData = new byte[4 * 1024 * 1024];
                    break;

                case "8M":
                    blockData = new byte[8 * 1024 * 1024];
                    break;

                case "16M":
                    blockData = new byte[16 * 1024 * 1024];
                    break;

                case "32M":
                    blockData = new byte[32 * 1024 * 1024];
                    break;

                case "64M":
                    blockData = new byte[64 * 1024 * 1024];
                    break;

                case "128M":
                    blockData = new byte[128 * 1024 * 1024];
                    break;

                default:
                    break;
            }
        }

        private void WriteData()
        {
            try
            {
                sw.Restart();
                while ((iteration == -1 || (long)index < iteration) && isRunning)
                {
                    writeToDiskWin32(blockData);
                    index++;
                    Thread.Sleep(_sleep);
                }
            }
            catch (ThreadAbortException ex)
            {

            }
            finally
            {
                sw.Stop();
                CloseFileWin32();
                timer1.Enabled = false;
                GC.Collect();
                csvWriter?.Dispose();

                BeginInvoke(new Action(() => 
                {
                    button_stop.Enabled = false;
                    button_start.Enabled = true;
                }));

            }
        }

        #region win32 functions

        //function import
        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern SafeFileHandle CreateFile(
            string fileName,
            [MarshalAs(UnmanagedType.U4)] FileAccess fileAccess,
            [MarshalAs(UnmanagedType.U4)] FileShare fileShare,
            IntPtr securityAttributes,
            [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
            int flags,
            IntPtr template);

        private SafeFileHandle drive;
        private FileStream diskStreamToWrite;

        private void CreateFileWin32(string FileName)
        {
            drive = CreateFile(fileName: FileName,
            fileAccess: FileAccess.Write,
            fileShare: FileShare.Write | FileShare.Read | FileShare.Delete,
            securityAttributes: IntPtr.Zero,
            creationDisposition: FileMode.OpenOrCreate,
            flags: 0x20000000, //with this also an enum can be used. (as described above as EFileAttributes)
                     template: IntPtr.Zero);
            diskStreamToWrite = new FileStream(drive, FileAccess.Write);
        }

        //function to write
        private void writeToDiskWin32(byte[] dataToWrite)
        {
            if (dataToWrite == null) throw new System.ArgumentException("dataToWrite parameter cannot be null!");
            diskStreamToWrite.Write(dataToWrite, 0, dataToWrite.Length);
        }

        private void CloseFileWin32()
        {
            try { diskStreamToWrite.Close(); } catch { }
            try { drive.Close(); } catch { }
        }

        #endregion win32 functions

        private void MainForm_Load(object sender, EventArgs e)
        {
            info = DriveInfo.GetDrives();
            comboBox_drive.Items.AddRange(info);
            comboBox_drive.SelectedIndex = 0;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            button_stop.Enabled = false;
            button_start.Enabled = true;
            isRunning = false;
            if (_writeThread != null && !_writeThread.Join(1000))
            {
                _writeThread?.Abort();
            }
            timer1.Enabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            button_stop_Click(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (isRunning)
            {
                var data = pCounter.NextValue();
                csvWriter.WriteLine(string.Format("{0:HH:mm:ss.fff},{1}", DateTime.Now, data));
                timeCounter++;
                sumSpeed = (sumSpeed + data);
                textBox1.Text = (sumSpeed / (double)timeCounter / Math.Pow(10, 9)).ToString("0.000000") + @"GB/s";
                chart1.Series[0].Points.AddY(data / Math.Pow(10, 9));
                if (chart1.Series[0].Points.Count > 1000)
                {
                    chart1.Series[0].Points.RemoveAt(0);
                }

                double freeSpace = (double)activeDrive.TotalFreeSpace / activeDrive.TotalSize * 100;
                if (freeSpace < 10.00)
                {
                    isRunning = false;
                    if (_writeThread != null && !_writeThread.Join(1000))
                    {
                        _writeThread?.Abort();
                    }
                    timer1.Enabled = false;

                    reWriteCount++;

                    File.Delete(filePath);
                    CreateFileWin32(filePath);
                    _writeThread = new Thread(WriteData);

                    isRunning = true;

                    _writeThread.Start();
                    timer1.Enabled = true;
                }
                toolStripStatusLabel1.Text = string.Format("磁盘剩余空间：{0}%；数据删除重写次数：{1}", freeSpace.ToString("0.000"), reWriteCount);
            }
            timer1.Enabled = true;
        }
    }
}