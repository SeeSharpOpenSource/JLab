using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MACOs.JY.SoftFrontPanel
{
    public abstract class AnalogInputDevices
    {

        private string _range = "0.2";
        private double _sampleRate = 100000;
        private int _samplesToRead = 10000;
        private object _triggerSetting;


        #region Public Properties
        public double SampleRate
        {
            get { return _sampleRate; }
            set { _sampleRate = value; }
        }
        public string Range
        {
            get { return _range; }
            set { _range = value; }
        }
        public int SamplesToRead
        {
            get { return _samplesToRead; }
            set { _samplesToRead = value; }
        }
        public object TriggerSetting { get; set; }

        #endregion

        #region Constructor
        public AnalogInputDevices()
        { }

        #endregion

        #region Abstract Layer properties and methods
        public virtual int[] SelectedChannels { get; }
        public virtual bool ReadyToFetch { get; }
        public virtual void ConfigChannel(object chObject) { }
        public virtual void ConfigChannel(int chID, double range) { }

        public virtual void ConfigTiming(double samplingRate, int samplesToRead) { }
        public virtual void ConfigTrigger(object param) { }
        public virtual void Fetch(ref double[,] fetchData) { }
        public virtual void RemoveChannel(int chID) { }
        public virtual void Start() { }
        public virtual void Stop() { }
        public virtual BindingList<object> GetChannelMap() { return new BindingList<object>(); }

        #endregion

    }

}