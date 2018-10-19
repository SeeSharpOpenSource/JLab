using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SeeSharpTools.JY.DSP.Utility;
using SeeSharpTools.JY.GUI;

namespace DsaSoftPanel.FunctionUtility
{
    public class ToneAnalyzeFunction : FunctionBase
    {
        public override string ChartXTitle => "";
        public override string ChartYTitle => "";
        public override string XValueLabelFormat => "{0}";
        public override string YValueLabelFormat => "{0}";
        public override bool HasDetailedData => true;
        public override bool HasPlotData => false;
        public override Form ConfigForm => null;
        public override string[] DetailParameters => new string[] { "THD(dB)", "THDplusN(dB)", "SINAD(dB)", "SNR(dB)", "NoiseFloor(dB)", "ENOB(dB)" };

        public override string[] DetailValues { get; protected set; }

        public ToneAnalyzeFunction(List<double> dataBuf) : base(dataBuf)
        {
            DetailValues = new string[DetailParameters.Length];
        }

        protected override void Execute()
        {
            int channelCount = GlobalInfo.Channels.Count(item => item.Enabled);
            int sampleCount = GlobalInfo.SamplesInChart;
            for (int i = 0; i < DetailValues.Length; i++)
            {
                DetailValues[i] = "";
            }
            for (int i = 0; i < channelCount; i++)
            {
                ToneAnalysisResult result = HarmonicAnalysis.ToneAnalysis(DataBuf.GetRange(i*sampleCount, sampleCount).ToArray(),
                    1.0/GlobalInfo.SampleRate);
                DetailValues[0] += $"{result.THD:f6} ";
                DetailValues[1] += $"{result.THDplusN:f6} ";
                DetailValues[2] += $"{result.SINAD:f6} ";
                DetailValues[3] += $"{result.SNR:f6} ";
                DetailValues[4] += $"{result.NoiseFloor:f6} ";
                DetailValues[5] += $"{result.ENOB:f6} ";
            }
        }

        protected override void PlotData() {}

        public override void RefreshConfigForm() {}

        public override void ConfigChart(EasyChartX chart) {}
    }
}