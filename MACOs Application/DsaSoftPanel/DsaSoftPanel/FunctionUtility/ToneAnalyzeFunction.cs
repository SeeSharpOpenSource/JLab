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
            for (int i = 0; i < DetailValues.Length; i++)
            {
                DetailValues[i] = "";
            }
            for (int i = 0; i < this.DataBuf.Count; i++)
            {
                ToneAnalysisResult result = HarmonicAnalyzer.ToneAnalysis(
                    this.DataBuf[i], 1.0/GlobalInfo.SampleRate);
                DetailValues[0] += Utility.GetShowValue(result.THD, i);
                DetailValues[1] += Utility.GetShowValue(result.THDplusN, i);
                DetailValues[2] += Utility.GetShowValue(result.SINAD, i);
                DetailValues[3] += Utility.GetShowValue(result.SNR, i);
                DetailValues[4] += Utility.GetShowValue(result.NoiseFloor, i);
                DetailValues[5] += Utility.GetShowValue(result.ENOB, i);
            }
        }

        protected override void PlotData() {}

        public override void RefreshConfigForm() {}

        public override void ConfigChart(EasyChartX chart) {}
    }
}