using System;
using System.Collections.Generic;
using System.Threading;
using DsaSoftPanel.Enumeration;
using SeeSharpTools.JY.ArrayUtility;
using SeeSharpTools.JY.DSP.Fundamental;
using SeeSharpTools.JY.DSP.Utility;

namespace DsaSoftPanel.TaskComponents
{
    public class MeasureHandler
    {
        public Dictionary<MeasureType, string> Measures { get; }
        private SpinLock _dicLock = new SpinLock(false);
        private SoftPanelGlobalInfo _oscilloscopeGlobalInfo;

        public MeasureHandler()
        {
            Measures = new Dictionary<MeasureType, string>(Enum.GetNames(typeof (MeasureType)).Length);
            _oscilloscopeGlobalInfo = SoftPanelGlobalInfo.GetInstance();
        }

        public void AddMeasure(MeasureType type)
        {
            bool getLock = false;
            _dicLock.Enter(ref getLock);
            if (!Measures.ContainsKey(type))
            {
                Measures.Add(type, "");
            }
            _dicLock.Exit();
        }

        public void RemoveMeasure(MeasureType type)
        {
            bool getLock = false;
            _dicLock.Enter(ref getLock);
            if (Measures.ContainsKey(type))
            {
                Measures.Remove(type);
            }
            _dicLock.Exit();
        }

        public string[] Execute(double[] data)
        {
            bool getLock = false;
            try
            {
                _dicLock.Enter(ref getLock);
                string[] value = new string[Measures.Count];
                int index = 0;
                foreach (MeasureType measureType in Measures.Keys)
                {
                    value[index++] = PerformMeasure(measureType, data);
                }
                return value;
            }
            finally
            {
                if (getLock)
                {
                    _dicLock.Exit();
                }
            }
        }

        public string PerformMeasure(MeasureType type, double[] data)
        {
            string value;
            switch (type)
            {
                case MeasureType.DC:
                    value = ArrayCalculation.Average(data).ToString();
                    break;
                case MeasureType.RMS:
                    value = ArrayCalculation.RMS(data).ToString();
                    break;
                case MeasureType.PeakAmp:
                case MeasureType.PeakFreq:
                    double dt = 1.0/_oscilloscopeGlobalInfo.SampleRate;
                    double peakFreq, peakAmp;
                    Spectrum.PeakSpectrumAnalysis(data, dt, out peakFreq, out peakAmp);
                    value = (type == MeasureType.PeakFreq) ? peakFreq.ToString() : peakAmp.ToString();
                    break;
                default:
                    value = "";
                    break;
            }
            return value;
        }
    }
}