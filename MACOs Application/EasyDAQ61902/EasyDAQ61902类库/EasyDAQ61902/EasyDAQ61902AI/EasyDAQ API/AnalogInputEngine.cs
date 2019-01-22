using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace EasyDAQ
{
    /// <summary>
    /// Reflection engine for AI
    /// </summary>
    internal class AnalogInputEngine
    {
        public static string driverDirectory = @"C:\SeeSharp\JYTEK\Hardware";
        public static string driverClassName = "JYUSB61902";
        public static int channelCount = 16;
        public static List<string> aiTerminal = new List<string>();

        #region Private Fields

        #region Fields relative to the hardware configuration

        private string _dllPath = "";
        private int _boardNum = 0;
        private int _samplesToAcquire = 1000;
        private List<int> _selectedChannels = new List<int>();
        private double _sampleRate = 10000;
        private int _availableSamples;
        private bool _continuourMode;

        /// <summary>
        /// Check if the dll is existed in the desinated path
        /// </summary>
        private bool _isDriverExisted = false;

        /// <summary>
        /// Status of the device (true if the device is successfully initialized)
        /// </summary>
        private bool _isConnected = false;

        #endregion Fields relative to the hardware configuration

        #region Variables

        private object _taskObj;
        private double[,] _data = new double[,] { };
        private double[,] _tData = new double[,] { };
        private double[] _chData = new double[] { };

        //variables that used to save the parameters for reflection usage
        private Assembly _assem;

        private Type _pvType;
        private object[] _pvParam;

        #endregion Variables

        #endregion Private Fields

        #region Constructor

        public AnalogInputEngine()
        {
            try
            {
                //Check if the dll is existed
                DirectoryInfo di = new DirectoryInfo(driverDirectory);
                FileInfo[] fi = di.GetFiles(driverClassName + ".dll", SearchOption.AllDirectories);
                _isDriverExisted = fi.Length != 0;

                if (_isDriverExisted)
                {
                    _dllPath = fi[0].FullName;
                    _assem = Assembly.LoadFile(_dllPath);
                    //parse the enum to list
                    aiTerminal = EnumToList("AITerminal");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Constructor Error!\r\n" + ex.Message);
            }
        }

        #endregion Constructor

        #region Public Properties

        public string DriverName
        {
            get { return driverClassName; }
        }

        public string DllPath
        {
            get { return _dllPath; }
        }

        public bool IsDriverExisted
        {
            get { return _isDriverExisted; }
        }

        public bool IsConnected
        {
            get { return _isConnected; }
        }

        public double SampleRate
        {
            get
            {
                if (_isConnected)
                {
                    _sampleRate = (double)_taskObj.GetType().GetProperty("SampleRate").GetValue(_taskObj, null);
                }
                return _sampleRate;
            }
            set
            {
                if (_isConnected)
                {
                    _sampleRate = value;
                    _taskObj.GetType().GetProperty("SampleRate").SetValue(_taskObj, _sampleRate, null);
                }
            }
        }

        public List<int> Channels
        {
            get { return _selectedChannels; }
            set { _selectedChannels = value; }
        }

        public int SamplesToRead
        {
            get
            {
                if (_isConnected)
                {
                    _samplesToAcquire = (int)_taskObj.GetType().GetProperty("SamplesToAcquire").GetValue(_taskObj, null);
                }
                return _samplesToAcquire;
            }
            set
            {
                if (_isConnected)
                {
                    _samplesToAcquire = value;
                    _taskObj.GetType().GetProperty("SamplesToAcquire").SetValue(_taskObj, _samplesToAcquire, null);
                }
            }
        }

        public int AvailableSamples
        {
            get
            {
                _availableSamples = (int)_taskObj.GetType().GetProperty("AvailableSamples").GetValue(_taskObj, null);
                return _availableSamples;
            }
        }

        public bool ContinuousRun
        {
            get
            {
                if (_isConnected)
                {
                    _continuourMode = (int)_taskObj.GetType().GetProperty("Mode").GetValue(_taskObj, null) == 2;
                }
                return _continuourMode;
            }
            set
            {
                if (_isConnected)
                {
                    _continuourMode = value;
                    object mode = _continuourMode ? 2 : 1;
                    _taskObj.GetType().GetProperty("Mode").SetValue(_taskObj, mode, null);
                }
            }
        }

        /* Trigger is currently not supported
        public object Trigger
        {
            get
            {
                if (_isConnected)
                {
                    return _taskObj.GetType().GetProperty("Trigger").GetValue(_taskObj, null);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (_isConnected)
                {
                    _taskObj.GetType().GetProperty("Trigger").SetValue(_taskObj, value, null);
                }
            }
        }
        */

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Initialze AITask
        /// </summary>
        /// <returns></returns>
        public bool Initialize()
        {
            try
            {
                //Find the AITask and initialize
                _pvType = _assem.GetType(driverClassName + "." + driverClassName + "AITask");
                _taskObj = Activator.CreateInstance(_pvType, _boardNum);
                _isConnected = _taskObj != null;

                if (_isConnected)
                {
                    //If the device is successfully initialized, configure all the designdated methods and properties to the dictionary
                    _selectedChannels.Clear();
                }
                return _isConnected;
            }
            catch (Exception ex)
            {
                throw new Exception("Initialize Error\r\n" + ex.InnerException);
            }
        }

        /// <summary>
        /// Add and configure the channel
        /// </summary>
        public void ConfigureChannel(int chID, double lowRange, double highRange, string aiTerminal)
        {
            try
            {
                //Get the AITerminal enum value for further usage
                _pvType = _assem.GetType(driverClassName + ".AITerminal");
                object terminal = Enum.Parse(_pvType, aiTerminal);
                Type[] protoTypes = new Type[] { typeof(int), typeof(double), typeof(double), _pvType };
                _pvParam = new object[] { chID, lowRange, highRange, terminal };
                _taskObj?.GetType().GetMethod("AddChannel", protoTypes).Invoke(_taskObj, BindingFlags.Public | BindingFlags.InvokeMethod | BindingFlags.Instance, null, _pvParam, null);
                _selectedChannels.Add(chID);
            }
            catch (Exception ex)
            {
                throw new Exception("ConfigureChannel Error\r\n" + ex.InnerException);
            }
        }

        /// <summary>
        /// Start the AITask
        /// </summary>
        public void Start()
        {
            try
            {
                //only create new array when the size is different from the setting
                if (_samplesToAcquire != _data.GetLength(0) || _selectedChannels.Count != _data.GetLength(1))
                {
                    _data = new double[_samplesToAcquire, _selectedChannels.Count];
                    _tData = new double[_selectedChannels.Count, _samplesToAcquire];
                    _chData = new double[_samplesToAcquire];
                }

                _pvParam = new object[] { };
                _taskObj?.GetType().GetMethod("Start").Invoke(_taskObj, _pvParam);
            }
            catch (Exception ex)
            {
                throw new Exception("Start Error\r\n" + ex.InnerException);
            }
        }

        /// <summary>
        /// ReadData the measured data
        /// </summary>
        public double[,] Fetch()
        {
            try
            {
                _pvParam = new object[] { _data, 10000 };
                Type[] protoTypes = new Type[] { typeof(double[,]).MakeByRefType(), typeof(int) };
                _taskObj?.GetType().GetMethod("ReadData", protoTypes).Invoke(_taskObj, _pvParam);
                for (int i = 0; i < _data.GetLength(0); i++)
                {
                    for (int j = 0; j < _data.GetLength(1); j++)
                    {
                        _tData[j, i] = _data[i, j];
                    }
                }
                return _tData;
            }
            catch (Exception ex)
            {
                throw new Exception("Fetch Error\r\n" + ex.InnerException);
            }
        }

        /// <summary>
        /// Stop the AITask
        /// </summary>
        public void Stop()
        {
            try
            {
                _pvParam = new object[] { };
                _taskObj?.GetType().GetMethod("Stop").Invoke(_taskObj, _pvParam);
                _isConnected = false;
            }
            catch (Exception ex)
            {
                throw new Exception("Stop Error\r\n" + ex.InnerException);
            }
        }

        #endregion Public Methods

        #region Private Methods

        private List<string> EnumToList(string enumName)
        {
            return new List<string>(Enum.GetNames(_assem.GetType(driverClassName + "." + enumName)));
        }

        #endregion Private Methods
    }
}