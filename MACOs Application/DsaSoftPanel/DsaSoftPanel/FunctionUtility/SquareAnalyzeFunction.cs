using System.Collections.Generic;
using System.Windows.Forms;
using DsaSoftPanel.Common;
using DsaSoftPanel.FunctionUtility.FunctionConfigView;
using SeeSharpTools.JY.DSP.Utility;
using SeeSharpTools.JY.GUI;

namespace DsaSoftPanel.FunctionUtility
{
    public class SquareAnalyzeFunction : FunctionBase
    {
        public override string ChartXTitle => "";
        public override string ChartYTitle => "";
        public override string XValueLabelFormat => "{0}";
        public override string YValueLabelFormat => "{0}";
        public override bool HasDetailedData => true;
        public override bool HasPlotData => false;
        public override Form ConfigForm => _configForm;
        public override string[] DetailParameters => new string[] {"High level", "Low Level", "Frequency(Hz)"};
        public override string[] DetailValues { get; protected set; }

        private readonly SquareAnalyzeConfigForm _configForm;
        private readonly SquarewaveMeasurements _squareMeasurement;

        public SquareAnalyzeFunction(List<double[]> dataBuf) : base(dataBuf)
        {
            this._configForm = new SquareAnalyzeConfigForm();
            this._squareMeasurement = new SquarewaveMeasurements();
            this.DetailValues = new string[DetailParameters.Length];
        }

        protected override void Execute()
        {
            int signalIndex;
            _configForm.GetChannelIndex(out signalIndex);
            if (signalIndex < 0)
            {
                DetailValues[0] = Utility.GetShowValue(Constants.NotAvailable, 0);
                DetailValues[1] = Utility.GetShowValue(Constants.NotAvailable, 0);
                DetailValues[2] = Utility.GetShowValue(Constants.NotAvailable, 0);
            }
            else
            {
                _squareMeasurement.SetWaveform(this.DataBuf[signalIndex]);
                DetailValues[0] = Utility.GetShowValue(this._squareMeasurement.GetHighStateLevel(), 0);
                DetailValues[1] = Utility.GetShowValue(this._squareMeasurement.GetLowStateLevel(), 0);
                DetailValues[2] = Utility.GetShowValue(this.GlobalInfo.SampleRate / this._squareMeasurement.GetPeriod(), 0);
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