using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeeSharpTools.JY.DSP.Fundamental;

namespace MACOs.JY.SoftFrontPanel
{
    class JYMathLibrary : MathLibraries
    {
        #region Private Fields
        private double peakFreq;
        private double peakAmp;
        private double maxValue = double.NaN;
        private double minValue = double.NaN;
        private double rootMeanSquare = double.NaN;
        private double average = double.NaN;
        private double stdDeviation = double.NaN;


        private enum TestItems
        {
            PeakFreq,
            PeakAmp,
            VoltageMax,
            VoltageMin,
            VoltageRMS,
            VoltageMean,
            VoltageStdDev,

        }//MUST update this enum if new test item is added

        #endregion

        public double GetMaximum()
        {
            if (double.IsNaN(maxValue))
            {
                StaticAnalysis();
            }
            return (maxValue);
        }
        public double GetMinimum()
        {
            if (double.IsNaN(minValue))
            {
                StaticAnalysis();
            }
            return (minValue);
        }
        public double GetRootMeanSquare()
        {
            if (double.IsNaN(rootMeanSquare))
            {
                StaticAnalysis();
            }
            return (rootMeanSquare);

        }
        public double GetAverage()
        {
            if (double.IsNaN(average))
            {
                StaticAnalysis();
            }
            return (average);

        }
        public double GetStdDeviation()
        {
            if (double.IsNaN(stdDeviation))
            {
                StaticAnalysis();
            }
            return (stdDeviation);
        }


        #region Constructor
        public JYMathLibrary(string testItem)
        {
            Item = testItem;
        }

        #endregion

        #region Methods
        public override void Process()
        {

            Parallel.Invoke(SpectrumAnalysis, StaticAnalysis);

            #region Feedback to properties ===> MUST ADD NEW CASE WHEN NEW ITEM IS ADDED
            switch ((TestItems)Enum.Parse(typeof(TestItems), Item))
            {
                case TestItems.PeakFreq:
                    Result = peakFreq;
                    break;
                case TestItems.PeakAmp:
                    Result = peakAmp;
                    break;
                case TestItems.VoltageMax:
                    Result = GetMaximum();
                    break;
                case TestItems.VoltageMin:
                    Result = GetMinimum();
                    break;
                case TestItems.VoltageRMS:
                    Result = GetRootMeanSquare();
                    break;
                case TestItems.VoltageMean:
                    Result = GetAverage();
                    break;
                case TestItems.VoltageStdDev:
                    Result = GetStdDeviation();
                    break;
                default:
                    break;
            }

            #endregion
        }

        #endregion

        private void SpectrumAnalysis()
        {
            try
            {
                Spectrum.PeakSpectrumAnalysis(PreData, (1.0 / SampleRate), out peakFreq, out peakAmp);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        private void StaticAnalysis()
        {
            double sumOfSquaresOfDifferences = double.NaN;
            try
            {
                maxValue = PreData.Max();
                minValue = PreData.Min();
                rootMeanSquare = Math.Sqrt(PreData.Select(x => x * x).Sum() / PreData.Length);
                average = PreData.Average();
                sumOfSquaresOfDifferences = PreData.Select(val => (val - average) * (val - average)).Sum();
                stdDeviation = Math.Sqrt(sumOfSquaresOfDifferences / PreData.Length);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }


    }
}
