using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;

namespace EasyDAQ
{
    /// <summary>
    /// Reflection engine for DO
    /// </summary>
    public class DigitalOutputEngine
    {
        public static string driverDirectory = @"C:\SeeSharp\JYTEK\Hardware";
        public static string driverClassName = "JYUSB61902";
        public static int channelCount = 4;
        #region Private Fields

        #region Fields relative to the hardware configuration
        private string dllPath = "";
        private List<int[]> selectedChannels = new List<int[]>();


        /// <summary>
        /// Check if the dll is existed in the desinated path
        /// </summary>
        private bool isDriverExisted = false;

        /// <summary>
        /// Status of the device (true if the device is successfully initialized)
        /// </summary>
        private bool isConnected = false;

        #endregion Fields relative to the hardware configuration

        #region Variables

        private object device;
        private bool[] data;
       

        //variables that used to save the parameters for reflection usage
        private Assembly assem;
        private Type pvType;
        private object[] pvParam;

        #endregion Variables

        #endregion Private Fields

        #region Constructor

        public DigitalOutputEngine()
        {
            //Check if the dll is existed
            DirectoryInfo di = new DirectoryInfo(driverDirectory);
            FileInfo[] fi = di.GetFiles(driverClassName + ".dll", SearchOption.AllDirectories);
            isDriverExisted = fi.Length != 0;

            if (isDriverExisted)
            {
                dllPath = fi[0].FullName;
                assem = Assembly.LoadFile(dllPath);
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

        public List<int[]> Channels
        {
            get { return selectedChannels; }
            set
            {
                selectedChannels = value;
            }
        }
        
        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Initialze DITask
        /// </summary>
        /// <returns></returns>
        public bool Initialize(int boardID)
        {
            try
            {
                //Find the DITask and initialize
                pvType = assem.GetType(driverClassName + "." + driverClassName + "DOTask");
                // Instance 
                device = Activator.CreateInstance(pvType, boardID);
                isConnected = device != null;

                if (isConnected)
                {
                    //If the device is successfully initialized, configure all the designdated methods and properties to the dictionary
                    selectedChannels.Clear();
                }
                return isConnected;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void ConfigureChannel(int[] chID)
        {
            try
            {
                
                Type[] protoTypes = new Type[] { typeof(int[]) };
                pvParam = new object[] { chID };
                data = new bool[chID.Length];
                device.GetType().GetMethod("AddChannel", protoTypes).Invoke(device, BindingFlags.Public | BindingFlags.InvokeMethod | BindingFlags.Instance, null, pvParam, null);
                selectedChannels.Add(chID);
             
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
       
        public void WriteData(bool[] data)
        {
            try
            {
                Type[] writeSignlePointType = new Type[] { typeof(bool[]) };
                pvParam = new object[] {data};

                device.GetType().GetMethod("WriteSinglePoint", writeSignlePointType).Invoke(device, pvParam);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        
        #endregion Public Methods

        #region Private Methods
      
        #endregion

      
    }


}