using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DsaSoftPanel.FunctionUtility.FunctionConfigView;
using SeeSharpTools.JY.DSP.Fundamental;
using SeeSharpTools.JY.GUI;

namespace DsaSoftPanel.FunctionUtility
{
    public class SpectrumFunction : FunctionBase
    {
        public override string ChartXTitle => "Frequency(Hz)";
        public override string ChartYTitle => "Amplitude(dBV/dBmV)";
        public override string XValueLabelFormat => "Frequency: {0:F2}Hz";
        public override string YValueLabelFormat => "Amplitude: {0:F3}dBV/dBmV";
        public override bool HasDetailedData => false;
        public override bool HasPlotData => true;

        private readonly SpectrumConfigForm _configForm = new SpectrumConfigForm();
        public override Form ConfigForm => _configForm;
        public override string[] DetailParameters => null;

        public override string[] DetailValues { get; protected set; }

        private List<double> _spectrumDatas;
        private double[] _spectrum;
        private double _df;

        public SpectrumFunction(List<double> dataBuf) : base(dataBuf)
        {
            int spectrumLength = (int)(GlobalInfo.SampleRate / (2 * Constants.SpectrumResolution));
            _spectrumDatas = new List<double>(spectrumLength * 4);
            _spectrum = new double[spectrumLength];
        }

        protected override void Execute()
        {
            _spectrumDatas.Clear();
            int dataStartIndex = 0;
            int samplesPerView = this.GlobalInfo.SamplesPerView;
            for (int i = 0; i < GlobalInfo.EnableChannelCount; i++)
            {
                double[] showData = DataBuf.GetRange(dataStartIndex, samplesPerView).ToArray();
                double para = this._configForm.WindowPara;
                Spectrum.PowerSpectrum(showData, GlobalInfo.SampleRate, ref _spectrum, out _df, 
                    SpectrumUnits.dBV, _configForm.Window, para);
                bool any = showData.Any(item => item > 1 || item < -1);
                _spectrumDatas.AddRange(_spectrum);
                dataStartIndex += samplesPerView;
            }
        }

        protected override void PlotData()
        {
            GlobalInfo.FunctionPlot.Invoke(_spectrumDatas, 0, _df, _spectrum.Length);
        }

        public override void RefreshConfigForm()
        {
        }

        public override void ConfigChart(EasyChartX chart)
        {
            chart.AxisX.InitWithScaleView = true;
            chart.AxisX.ViewMaximum = 10000;
            chart.AxisX.ViewMinimum = 0;
        }
    }
}