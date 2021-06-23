using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DsaSoftPanel.Enumeration;
using SeeSharpTools.JY.ArrayUtility;
using SeeSharpTools.JY.DSP.Fundamental;
using SeeSharpTools.JY.DSP.Utility;

namespace DsaSoftPanel.TaskComponents
{
    public class MeasureTask
    {
        public Dictionary<MeasureType, string> Measures { get; }
        private SpinLock _measuredicLock = new SpinLock(false);
        private readonly SoftPanelGlobalInfo _oscilloscopeGlobalInfo;
        private readonly DsaSoftPanelForm _parentForm;

        private Task _measureTask;

        private CancellationTokenSource _cancellation;

        private readonly SoftPanelGlobalInfo _globalInfo;

        public MeasureType[] MeasureTypes => Measures.Keys.ToArray();

        public MeasureTask(DsaSoftPanelForm parentForm)
        {
            Measures = new Dictionary<MeasureType, string>(Enum.GetNames(typeof (MeasureType)).Length);
            _oscilloscopeGlobalInfo = SoftPanelGlobalInfo.GetInstance();
            this._parentForm = parentForm;
            _globalInfo = SoftPanelGlobalInfo.GetInstance();
        }

        public void AddMeasure(MeasureType type)
        {
            bool getLock = false;
            this._measuredicLock.Enter(ref getLock);
            if (!Measures.ContainsKey(type))
            {
                Measures.Add(type, "");
            }
            this._measuredicLock.Exit();
        }

        public void RemoveMeasure(MeasureType type)
        {
            bool getLock = false;
            this._measuredicLock.Enter(ref getLock);
            if (Measures.ContainsKey(type))
            {
                Measures.Remove(type);
            }
            this._measuredicLock.Exit();
        }

        public void Start()
        {
            Stop();
            this._cancellation = new CancellationTokenSource(50);
            this._measureTask = new Task(MeasureExecutionTask, this._cancellation.Token);
            _cancellation = new CancellationTokenSource();
            this._measureTask.Start();
        }

        public void Stop()
        {
            if (null == this._measureTask || this._measureTask.IsCanceled)
            {
                return;
            }
            try
            {
                this._cancellation.Cancel();
                if (!this._measureTask.Wait(1000))
                {
                    this._measureTask.Dispose();
                }
                this._measureTask = null;
            }
            catch (Exception ex)
            {
                //ignore
            }
        }

        private void MeasureExecutionTask()
        {
            Thread.Sleep(2 * (_globalInfo.SamplesPerView / _globalInfo.SampleRate));
            try
            {
                while (!this._cancellation.IsCancellationRequested)
                {
                    // 清空数据buffer并拷贝最新的数据
                    this._dataBuf.Clear();
                    bool getLock = false;
                    try
                    {
                        getLock = _globalInfo.BufferLock.TryEnterReadLock(Constants.BufferReadTimeout);
                        if (!getLock)
                        {
                            continue;
                        }

                        this._dataBuf.AddRange(_globalInfo.DispBuf);
                    }
                    finally
                    {
                        if (getLock)
                        {
                            _globalInfo.BufferLock.ExitReadLock();
                        }
                    }

                    int samplesInChart = _globalInfo.SamplesInChart;
                    if (samplesInChart <= 0)
                    {
                        Thread.Sleep(Constants.FuncWaitTime);
                        continue;
                    }

                    int measureIndex = _parentForm.GetMeasureIndex();
                    if (measureIndex >= 0)
                    {
                        string[] result = Execute(this._dataBuf[measureIndex]);
                        _parentForm.RefreshMeasureResult(result);
                    }
                    Thread.Sleep(Constants.FuncWaitTime);
                }
            }
            catch (ThreadAbortException)
            {
                // ignore
            }
            catch (Exception ex)
            {
            }
        }

        private string[] Execute(double[] data)
        {
            bool getLock = false;
            IEnumerable<MeasureType> measureTypes;
            this._measuredicLock.Enter(ref getLock);
            measureTypes = Measures.Keys;
            if (getLock)
            {
                this._measuredicLock.Exit();
            }
            else
            {
                return new string[0];
            }
            string[] value = new string[Measures.Count];
            int index = 0;
            foreach (MeasureType measureType in measureTypes)
            {
                value[index++] = PerformMeasure(measureType, data);
            }
            return value;
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