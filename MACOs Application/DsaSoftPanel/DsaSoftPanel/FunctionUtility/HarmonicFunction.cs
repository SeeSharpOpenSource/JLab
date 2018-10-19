using System.Collections.Generic;
using System.Windows.Forms;
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

        public HarmonicFunction(List<double> dataBuf) : base(dataBuf)
        {
            DetailValues = new string[DetailParameters.Length];
            _configForm = new HarmonicConfigForm();
        }

        protected override void Execute()
        {
            int samplesPerView = GlobalInfo.SamplesInChart;
            double dt = 1.0/GlobalInfo.SampleRate;
            double fundmentalFrequency = 0, thd = 0;
            int index;
            _configForm.GetChannelIndex(out index);
            if (index < 0)
            {
                return;
            }
            int harmonicLevel = _configForm.GetHarmonicLevel();
            if (_harmonicLevel?.Length != harmonicLevel)
            {
                _harmonicLevel = new double[harmonicLevel];
            }
            double[] waveform = DataBuf.GetRange(samplesPerView*index, samplesPerView).ToArray();
            HarmonicAnalyzer.ToneAnalysis(waveform, dt, out fundmentalFrequency, out thd, ref _harmonicLevel,
                harmonicLevel);

            DetailValues[0] = thd.ToString();
            DetailValues[1] = fundmentalFrequency.ToString();
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