using MACOs.JY.DAQDevice.Utilities;
using SeeSharpTools.JY.DSP.Fundamental;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace MACOs.JY.DAQDevice.AnalogInput
{
    public class AnalogInputDevice
    {
        private bool _isSim = true;
        private double[] sineData = new double[10000];
        private double[] squreData = new double[10000];
        private double[] noiseData = new double[10000];
        private List<AnalogInputChannel> list;

        #region Constructor

        public AnalogInputDevice(string deviceName = null)
        {
            try
            {                
                _isSim = string.IsNullOrEmpty(deviceName) || deviceName == "Simulated";
                this.ChannelMapping = new ChannelMap();

                if (!_isSim)
                {
                    this.DeviceName = deviceName;
                    this.DriverFolder = @"C:\SeeSharp\JYTEK\Hardware";
                    var files = Directory.GetFiles(this.DriverFolder, deviceName + ".dll", SearchOption.AllDirectories);
                    if (files.Length != 0)
                    {
                        string destPath = Directory.GetCurrentDirectory() + @"\" + deviceName + ".dll";
                        if (!File.Exists(destPath))
                        {
                            File.Copy(files[0], destPath);
                        }
                        this.DriverPath = destPath;
                    }
                    else
                    {
                        throw new Exception("找不到驱动路径");
                    }
                }
                else
                {
                    list = new List<AnalogInputChannel>();
                    list.Add(new AnalogInputChannel() { ChannelID = 0 });
                    list.Add(new AnalogInputChannel() { ChannelID = 1 });
                    ChannelMapping.ChannelList = list;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Constructor

        #region Information

        public virtual string DeviceName { get; set; }
        public virtual string DriverFolder { get; set; }
        public virtual string DriverPath { get; set; }
        public HardwareInformation HardwareInformation
        {
            get
            {
                return Utility.GetHardwareInfo(Directory.GetCurrentDirectory() + @"\HardwareInformation.ini", DeviceName + "AI");
            }
        }

        #endregion Information

        #region Hardware Related

        public virtual object AITask { get; set; }

        public virtual double SampleRate
        {
            get
            {
                try
                {
                    return _isSim ? 10000 : (double)this.AITask.GetType().GetProperty("SampleRate").GetValue(this.AITask, null);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            set
            {
                try
                {
                    if (!_isSim)
                    {
                        this.AITask.GetType().GetProperty("SampleRate").SetValue(this.AITask, value, null);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public virtual int SamplesToAcquire
        {
            get
            {
                try
                {
                    return _isSim ? 10000 : (int)this.AITask.GetType().GetProperty("SamplesToAcquire").GetValue(this.AITask, null);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            set
            {
                try
                {
                    if (!_isSim)
                    {
                        this.AITask.GetType().GetProperty("SamplesToAcquire").SetValue(this.AITask, value, null);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public virtual int AvailabeSamples
        {
            get
            {
                try
                {
                    if (!_isSim)
                    {
                        Type t = this.AITask.GetType().GetProperty("AvailableSamples").PropertyType;
                        object value = this.AITask.GetType().GetProperty("AvailableSamples").GetValue(this.AITask, null);
                        if (t.Name == "Int64")
                        {
                            return int.Parse(((long)value).ToString());
                        }
                        else
                        {
                            return int.Parse(((int)value).ToString());
                        }
                    }
                    else
                    {
                        return 10000;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public virtual string Mode
        {
            get
            {
                try
                {
                    return _isSim ? "Continuous" : this.AITask.GetType().GetProperty("Mode").GetValue(this.AITask, null).ToString();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            set
            {
                try
                {
                    if (!_isSim)
                    {
                        Type t = ReflectionEngine.GetEnums(this.DriverPath, this.DeviceName).ToList().Find(x => x.Name == "AIMode");
                        Array arr = t.GetEnumValues();
                        int index = t.GetEnumNames().ToList().FindIndex(x => x == value);
                        this.AITask.GetType().GetProperty("Mode").SetValue(this.AITask, arr.GetValue(index), null);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public virtual IList Channels
        {
            get
            {
                try
                {
                    return _isSim ? list : this.AITask.GetType().GetProperty("Channels").GetValue(this.AITask, null) as IList;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public virtual void Initialize(params object[] parameter)
        {
            try
            {
                if (!_isSim)
                {
                    ConstructorInfo ctor = ReflectionEngine.GetConstructors(this.DriverPath, this.DeviceName, this.DeviceName + "AITask")[0];
                    this.AITask = ReflectionEngine.CreateObject(ctor, parameter);
                }
                else
                {
                    Generation.SineWave(ref sineData, 1, 0, 10, 10000);
                    Generation.SquareWave(ref squreData, 1, 50, 10, 10000);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void AddChannel(AnalogInputChannel channelInfo, params object[] parameter)
        {
            try
            {
                if (!_isSim)
                {
                    MethodInfo mi = ReflectionEngine.GetMethods(this.AITask).ToList().Find(x => x.Name == "AddChannel");
                    ParameterInfo[] pi = mi.GetParameters();
                    object[] param = new object[pi.Length];
                    for (int i = 0; i < pi.Length; i++)
                    {
                        if (i == 0)
                        {
                            param[i] = channelInfo.ChannelID;
                        }
                        else if (i == 1)
                        {
                            param[i] = channelInfo.RangeLow;
                        }
                        else if (i == 2)
                        {
                            param[i] = channelInfo.RangeHigh;
                        }
                        else
                        {
                            if (parameter.Length == 0 || parameter[i - 3] == null)
                            {
                                if (pi[i].DefaultValue == null)
                                {
                                    throw new Exception("参数未指定值");
                                }
                                else
                                {
                                    param[i] = pi[i].DefaultValue;
                                }
                            }
                            else
                            {
                                Type t = pi[i].ParameterType;
                                param[i] = Utility.TypeCast(parameter[i - 3], t);
                            }
                        }
                    }
                    mi.Invoke(this.AITask, param);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void RemoveChannel(int channelID)
        {
            try
            {
                if (!_isSim)
                {
                    MethodInfo mi = ReflectionEngine.GetMethods(this.AITask).ToList().Find(x => x.Name == "RemoveChannel");
                    mi.Invoke(this.AITask, new object[] { channelID });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void ConfigureChannel()
        {
        }

        public virtual void Start()
        {
            try
            {
                if (!_isSim)
                {
                    MethodInfo mi = ReflectionEngine.GetMethods(this.AITask).ToList().Find(x => x.Name == "Start");
                    mi.Invoke(this.AITask, null);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void ReadData(ref double[] data, int timeout = -1)
        {
            try
            {
                if (!_isSim)
                {
                    Type[] types = new Type[2];
                    types[0] = data.GetType().MakeByRefType();
                    types[1] = timeout.GetType();
                    MethodInfo mi = this.AITask.GetType().GetMethod("ReadData", types);

                    object[] param = new object[2];
                    param[0] = data;
                    param[1] = timeout;
                    mi.Invoke(this.AITask, param);
                }
                else
                {
                    Generation.UniformWhiteNoise(ref noiseData, list[0].RangeHigh / 50);

                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        data[i] = sineData[i % 10000] + noiseData[i % 10000];
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void ReadData(ref double[,] data, int timeout = -1)
        {
            try
            {
                if (!_isSim)
                {
                    Type[] types = new Type[2];
                    types[0] = data.GetType().MakeByRefType();
                    types[1] = timeout.GetType();
                    MethodInfo mi = this.AITask.GetType().GetMethod("ReadData", types);

                    object[] param = new object[2];
                    param[0] = data;
                    param[1] = timeout;
                    mi.Invoke(this.AITask, param);
                }
                else
                {

                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        Generation.UniformWhiteNoise(ref noiseData, list[0].RangeHigh / 50);

                        for (int i = 0; i < data.GetLength(0); i++)
                        {
                            if (j % 2 == 0)
                            {
                                data[i, j] = sineData[i % 10000] + noiseData[i % 10000];
                            }
                            else
                            {
                                data[i, j] = squreData[i % 10000] + noiseData[i % 10000];
                            }
                        }
                        Thread.Sleep(10);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Stop()
        {
            try
            {
                if (!_isSim)
                {
                    MethodInfo mi = ReflectionEngine.GetMethods(this.AITask).ToList().Find(x => x.Name == "Stop");
                    mi.Invoke(this.AITask, null);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Hardware Related

        #region GUI interaction related

        public virtual ChannelMap ChannelMapping { get; set; }

        #endregion GUI interaction related
    }
}