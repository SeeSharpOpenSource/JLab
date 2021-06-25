using System.Collections.Generic;
using System.Windows.Forms;
using DsaSoftPanel.Common;
using DsaSoftPanel.FunctionUtility.FunctionConfigView;
using SeeSharpTools.JY.GUI;
using SeeSharpTools.JY.DSP.SoundVibration;

namespace DsaSoftPanel.FunctionUtility
{
    public class HarmonicFunction : FunctionBase
    {
        public override string ChartXTitle => "Harmonic Level";
        public override string ChartYTitle => "Voltage(V/mV)";
        public override string XValueLabelFormat => "HarmonicLevel: {0}";
        public override string YValueLabelFormat => "Voltage: {0:F3}V/mV";
        public override bool HasDetailedData => true;
        public override bool HasPlotData => true;
        public override Form ConfigForm => _configForm;
        public override string[] DetailParameters => new string[] {"THD", "BaseFrequency(Hz)"};
        public override string[] DetailValues { get; protected set; }

        private double[] _harmonicLevel;
        private readonly HarmonicConfigForm _configForm;

        public HarmonicFunction(List<double[]> dataBuf) : base(dataBuf)
        {
            DetailValues = new string[DetailParameters.Length];
            _configForm = new HarmonicConfigForm();
        }

        protected override void Execute()
        {
            double dt = 1.0/GlobalInfo.SampleRate;
            double fundmentalFrequency = 0, thd = 0;
            int index;
            _configForm.GetChannelIndex(out index);
            if (index < 0)
            {
                DetailValues[0] = Utility.GetShowValue(Constants.NotAvailable, 0);
                DetailValues[1] = Utility.GetShowValue(Constants.NotAvailable, 0);
                return;
            }
            int harmonicLevel = _configForm.GetHarmonicLevel();
            if (_harmonicLevel?.Length != harmonicLevel + 1)
            {
                _harmonicLevel = new double[harmonicLevel + 1];
            }
            double[] waveform = this.DataBuf[index];
            HarmonicAnalyzer.ToneAnalysis(waveform, dt, out fundmentalFrequency, out thd, ref _harmonicLevel,
                harmonicLevel);

            DetailValues[0] = Utility.GetShowValue(thd, 0);
            DetailValues[1] = Utility.GetShowValue(fundmentalFrequency, 0);
        }

        protected override void PlotData()
        {
            GlobalInfo.FunctionPlot.Invoke(_harmonicLevel, 0, 1, _harmonicLevel.Length);
        }

        public override void RefreshConfigForm()
        {
            _configForm.RefreshChannelItems();
        }

        public override void ConfigChart(EasyChartX chart)
        {
        }
    }
}