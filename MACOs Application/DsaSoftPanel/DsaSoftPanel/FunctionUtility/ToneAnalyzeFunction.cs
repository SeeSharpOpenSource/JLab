using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DsaSoftPanel.Common;
using SeeSharpTools.JY.DSP.SoundVibration;
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

        public ToneAnalyzeFunction(List<double[]> dataBuf) : base(dataBuf)
        {
            DetailValues = new string[DetailParameters.Length];
        }

        protected override void Execute()
        {
            int channelCount = GlobalInfo.Channels.Count(item => item.Enabled);
            for (int i = 0; i < DetailValues.Length; i++)
            {
                DetailValues[i] = "";
            }
            for (int i = 0; i < channelCount; i++)
            {
                ToneAnalysisResult result = HarmonicAnalyzer.ToneAnalysis(
                    this.DataBuf[i], 1.0/GlobalInfo.SampleRate);
                DetailValues[0] += Utility.GetShowValue(result.THD);
                DetailValues[1] += Utility.GetShowValue(result.THDplusN);
                DetailValues[2] += Utility.GetShowValue(result.SINAD);
                DetailValues[3] += Utility.GetShowValue(result.SNR);
                DetailValues[4] += Utility.GetShowValue(result.NoiseFloor);
                DetailValues[5] += Utility.GetShowValue(result.ENOB);
            }
        }

        protected override void PlotData() {}

        public override void RefreshConfigForm() {}

        public override void ConfigChart(EasyChartX chart) {}
    }
}