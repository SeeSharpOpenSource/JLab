using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
namespace EasyDAQ
{
    class AnalogOutputEngine
    {

        public static string driverDirectory = @"C:\SeeSharp\JYTEK\Hardware";
        public static string driverClassName = "JYUSB61902";
        public static int channelCount = 8;


        private string dllPath = "";
        private int boardID = 0;
        private double updateRate = 10000;
        private int samplesToUpdate = 1000;
        private List<int> selectedChannels = new List<int>() { };
        private bool continuousMode = false;

        private bool isDriverExisted = false;
        private bool isConnected = false;

        private object taskObj;
        private double[] data = new double[] { };

        private Assembly assem;

        private Type pvType;
        private object[] pvParam;

        public AnalogOutputEngine()
        {
            DirectoryInfo di = new DirectoryInfo(driverDirectory);
            FileInfo[] fi = di.GetFiles(driverClassName + ".dll", SearchOption.AllDirectories);
            isDriverExisted = fi.Length != 0;

            if (isDriverExisted)
            {
                dllPath = fi[0].FullName;
                assem = Assembly.LoadFile(dllPath);

            }
        }

        public string DriverName
        {
            get { return driverClassName; }
        }

        public string DllPath
        {
            get { return dllPath; }
        }


        public bool IsDriverExisted
        {
            get { return isDriverExisted; }
        }

        public bool IsConnected
        {
            get { return isConnected; }
        }
        public List<int> Channels
        {
            get { return selectedChannels; }
            set { selectedChannels = value; }
        }

        public double UpdateRate
        {
            get
            {
                if (isConnected)
                {
                    updateRate = (double)taskObj.GetType().GetProperty("UpdateRate").GetValue(taskObj, null);
                }
                return updateRate;
            }

            set
            {
                if (isConnected)
                {
                    updateRate = value;
                    taskObj.GetType().GetProperty("UpdateRate").SetValue(taskObj, updateRate, null);
                }

            }
        }



        public int SamplesToUpdate
        {
            get
            {
                if (IsConnected)
                    samplesToUpdate = (int)taskObj.GetType().GetProperty("SamplesToUpdate").GetValue(taskObj, null);
                return samplesToUpdate;
            }

            set
            {
                if (isConnected)
                {
                    samplesToUpdate = value;
                    taskObj.GetType().GetProperty("SamplesToUpdate").SetValue(taskObj, samplesToUpdate, null);
                }

            }
        }


        public bool ContinuousMode
        {
            get
            {
                if (isConnected)
                {
                    continuousMode = (int)taskObj.GetType().GetProperty("Mode").GetValue(taskObj, null) == 3;
                }
                return continuousMode;
            }

            set
            {
                if (isConnected)
                {
                    continuousMode = value;
                    object mode = continuousMode ? 3 : 1;
                    taskObj.GetType().GetProperty("Mode").SetValue(taskObj, mode, null);
                }

            }
        }


        public bool Initialize()
        {
            pvType = assem.GetType(driverClassName + "." + driverClassName + "AOTask");
            taskObj = Activator.CreateInstance(pvType, boardID);
            isConnected = taskObj != null;
            if (isConnected)
            {
                selectedChannels.Clear();
            }
            return isConnected;
        }


        public void ConfigureChannel(int chID, double lowRange, double highRange)
        {
            Type[] protoTypes = new Type[] { typeof(int), typeof(double), typeof(double) };
            pvParam = new object[] { chID, lowRange, highRange };
            taskObj.GetType().GetMethod("AddChannel", protoTypes).Invoke(taskObj, BindingFlags.Public | BindingFlags.InvokeMethod | BindingFlags.Instance, null, pvParam, null);
            selectedChannels.Add(chID);
        }

        public void WriteData(double[] writeValve, int timeout = -1)
        {
            Type[] protoTypes = new Type[] { typeof(double[]), typeof(int) };
            pvParam = new object[] { writeValve, timeout };
            taskObj.GetType().GetMethod("WriteData", protoTypes).Invoke(taskObj, pvParam);

        }

        public void Start()
        {
            pvParam = new object[] { };
            taskObj.GetType().GetMethod("Start").Invoke(taskObj, pvParam);
        }

        public void Stop()
        {
            pvParam = new object[] { };
            taskObj.GetType().GetMethod("Stop").Invoke(taskObj, pvParam);
            isConnected = false;
        }
    }
}
