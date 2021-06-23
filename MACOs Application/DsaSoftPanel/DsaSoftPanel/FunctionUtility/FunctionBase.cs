using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DsaSoftPanel.Enumeration;
using SeeSharpTools.JY.GUI;

namespace DsaSoftPanel.FunctionUtility
{
    public abstract class FunctionBase
    {
        public abstract string ChartXTitle { get; }
        public abstract string ChartYTitle { get; }

        public abstract string XValueLabelFormat { get; }
        public abstract string YValueLabelFormat { get; }

        public abstract bool HasDetailedData { get; }
        public abstract bool HasPlotData { get; }

        public abstract Form ConfigForm { get; }

        public abstract string[] DetailParameters { get; } 
        public abstract string[] DetailValues { get; protected set; } 

        protected abstract void Execute();
        protected abstract void PlotData();

        public abstract void RefreshConfigForm();

        protected readonly SoftPanelGlobalInfo GlobalInfo;
        protected readonly List<double[]> DataBuf;

        public static FunctionBase CreateFunction(FunctionType type, List<double[]> dataBuf)
        {
            switch (type)
            {
                case FunctionType.None:
                    return null;
                    break;
                case FunctionType.Harmonic:
                    return new HarmonicFunction(dataBuf);
                    break;
                case FunctionType.Spectrum:
                    return new SpectrumFunction(dataBuf);
                    break;
                case FunctionType.ToneAnalyze:
                    return new ToneAnalyzeFunction(dataBuf);
                    break;
                case FunctionType.Filter:
                    return new FilterFunction(dataBuf);
                case FunctionType.SquaureAnalyze:
                    return new SquareAnalyzeFunction(dataBuf);
                    break;
                case FunctionType.PhaseShift:
                    return new PhaseShiftFunction(dataBuf);
                default:
                    return null;
                    break;
            }
        }

        public bool IsTypeFit(FunctionType type)
        {
            switch (type)
            {
                case FunctionType.None:
                    return false;
                    break;
                case FunctionType.Harmonic:
                    return this is HarmonicFunction;
                    break;
                case FunctionType.Spectrum:
                    return this is SpectrumFunction;
                case FunctionType.ToneAnalyze:
                    return this is ToneAnalyzeFunction;
                case FunctionType.Filter:
                    return this is FilterFunction;
                case FunctionType.SquaureAnalyze:
                    return this is SquareAnalyzeFunction;
                case FunctionType.PhaseShift:
                    return this is PhaseShiftFunction;
                default:
                    throw new ArgumentException($"Invalid function type: {type}.");
            }
        }

        protected FunctionBase(List<double[]> dataBuf)
        {
            this.GlobalInfo = SoftPanelGlobalInfo.GetInstance();
            this.DataBuf = dataBuf;
        }

        public void ExecuteAndShow()
        {
            this.Execute();
            this.GlobalInfo.MainForm.Invoke(new Action(() =>
            {
                if (HasPlotData)
                {
                    PlotData();
                }
                if (HasDetailedData)
                {
                    this.GlobalInfo.MainForm.RefreshFunctionDetailResult(this);
                }
            }));
        }

        public abstract void ConfigChart(EasyChartX chart);


        protected static string GetShowValue(double value)
        {
            return !double.IsNaN(value) ? value.ToString(Constants.NumericFormat) : Constants.NotAvailable;
        }
    }
}