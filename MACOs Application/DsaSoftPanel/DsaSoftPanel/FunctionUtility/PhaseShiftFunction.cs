using System.Collections.Generic;
using System.Windows.Forms;
using DsaSoftPanel.FunctionUtility.FunctionConfigView;
using SeeSharpTools.JY.DSP.Utility;
using SeeSharpTools.JY.GUI;

namespace DsaSoftPanel.FunctionUtility
{
    public class PhaseShiftFunction : FunctionBase
    {
        public override string ChartXTitle => "";
        public override string ChartYTitle => "";
        public override string XValueLabelFormat => "{0}";
        public override string YValueLabelFormat => "{0}";
        public override bool HasDetailedData => true;
        public override bool HasPlotData => false;
        public override Form ConfigForm => _configForm;
        public override string[] DetailParameters => new string[] {"Phase shift"};
        public override string[] DetailValues { get; protected set; }

        private readonly PhaseShiftConfigForm _configForm = new PhaseShiftConfigForm();

        public PhaseShiftFunction(List<double> dataBuf) : base(dataBuf)
        {
            DetailValues = new string[DetailParameters.Length];
        }

        protected override void Execute()
        {
            int signal1Index, signal2Index;
            _configForm.GetChannelIndex(out signal1Index, out signal2Index);
            int samplesPerView = GlobalInfo.SamplesInChart;
            if (signal2Index >= 0 && signal1Index >= 0 && signal1Index != signal2Index)
            {
                double[] signal1 = DataBuf.GetRange(signal1Index*samplesPerView, samplesPerView).ToArray();
                double[] signal2 = DataBuf.GetRange(signal2Index*samplesPerView, samplesPerView).ToArray();
                DetailValues[0] = Phase.CalPhaseShift(signal1, signal2).ToString();
            }
            else
            {
                DetailValues[0] = Constants.NotAvailable;
            }
        }

        protected override void PlotData()
        {
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