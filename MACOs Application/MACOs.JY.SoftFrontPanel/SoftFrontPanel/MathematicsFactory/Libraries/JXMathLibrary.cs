using System;
using System.Linq;


namespace MACOs.JY.SoftFrontPanel
{
    public class JXMathLibrary : MathLibraries
    {
        #region Private Fields
        private enum TestItems
        {
            VoltageHigh,
            VoltageLow,
            Period,
            DutyCycle,
            PulseCount,
            PulseWidthHigh,
            PulseWidthLow,
            PeaktoPeak,
            Frequency,
        }//MUST update this enum if new test item is added
        private SquarewaveMeasurements wfmMeasTask;

        #endregion

        #region Constructor
        public JXMathLibrary(string testItem)
        {
            Item = testItem;
            wfmMeasTask = new SquarewaveMeasurements();
        }

        #endregion

        #region Method
        public override void Process()
        {
            wfmMeasTask.SetWaveform(PreData);
            #region Feedback to properties ===> MUST ADD NEW CASE WHEN NEW ITEM IS ADDED
            switch ((TestItems)Enum.Parse(typeof(TestItems), Item))
            {
                case TestItems.VoltageHigh:
                    Result = wfmMeasTask.GetHighStateLevel();
                    break;
                case TestItems.VoltageLow:
                    Result = wfmMeasTask.GetLowStateLevel();
                    break;
                case TestItems.Period:
                    Result = wfmMeasTask.GetPeriod() / SampleRate;
                    break;
                case TestItems.DutyCycle:
                    Result = wfmMeasTask.GetDutyCycle();
                    break;
                case TestItems.PulseCount:
                    Result = wfmMeasTask.GetPulseCount();
                    break;
                case TestItems.PulseWidthHigh:
                    Result = wfmMeasTask.GetPulseMaxLength() / SampleRate;
                    break;
                case TestItems.PulseWidthLow:
                    Result = wfmMeasTask.GetPulseMinLength() / SampleRate;
                    break;
                case TestItems.PeaktoPeak:
                    Result = wfmMeasTask.GetAmplitude();
                    break;
                case TestItems.Frequency:
                    Result = wfmMeasTask.GetFrequency() * SampleRate;
                    break;
                default:
                    break;
            }
            #endregion

        }

        #endregion

        /// <summary>
        /// This class provides the methods to get the amplitude, period and phase of waveform(s)
        /// Data 
        /// includes waveform[] which is the main square wave to be analysised,
        /// waveformRef[] is a reference for phase analysis only
        /// the waveforms are set by the method of SetWaveform() and SetRefWaveform()
        /// Logic
        /// Init method set all results to be Nan
        /// When you call the Get... methods, it calls analysis when the required result is NaN
        /// You MUST SetWaveform be Get results, otherwise the results are not predictable.  
        /// 
        /// Note, this algorithm works for squarewave only, not sine wave
        /// Rev 0.1 JXSH designed structure and amplitude and phase analysis 
        /// Rev 0.5 JXXY added pulse-width analysis in the period analysis, and reviewed by JXSH 2017-Mar 16
        /// </summary>
        internal class SquarewaveMeasurements
        {
            private double[] waveform; //main waveform tobe analysised
            private double highLevel = double.NaN;  // high state level, which is the average of 80% middle high state
            private double lowLevel = double.NaN;  // low state level, which is the average of 80% middle low state
            private double period = double.NaN;     //nunmber of samples between 2 adjecent rising edges, averaged when multiple periods
            private double[] waveformRef;  //the reference  squarewave for phase analysis
            private double phase = double.NaN;    //phase between waveform and waveformRef in degrees
            private double dutyCycleAvg;
            private double amplitude = double.NaN;
            private double frequency = double.NaN;

            const int intervals = 50;  //Y intervals for histogram analyiss, for state level analysis
            double[] _levelHistogramY = new double[intervals];
            double[] _levelHistogramX = new double[intervals];
            double[] _dutyCycleHistogramY = new double[intervals];
            double[] _dutyCycleHistogramX = new double[intervals];
            double[] dutyCycleCount = new double[intervals];
            private double pulseCount = double.NaN;
            private double pulseMaxWidth = double.NaN;
            private double pulseMinWidth = double.NaN;

            //this property MUST be get after the AmplitudeAnalysis
            //this is the intermediate result of the amplitude analysis
            public double[] LevelHistogramY
            {
                get
                {
                    return _levelHistogramY;
                }
            }

            //this property MUST be get after the AmplitudeAnalysis
            //this is the intermediate result of the amplitude analysis
            public double[] LevelHistogramX
            {
                get
                {
                    return _levelHistogramX;
                }
            }
            //this property MUST be get after the PeriodAnalysis
            //this is the intermediate result of the period analysis
            public double[] DutyCycleHistogramY
            {
                get
                {
                    return _dutyCycleHistogramY;
                }
            }
            //this property MUST be get after the PeriodAnalysis
            //this is the intermediate result of the period analysis
            public double[] DutyCycleHistogramX
            {
                get
                {
                    return _dutyCycleHistogramX;
                }
            }

            /// <summary>
            /// 复制输入的波形数据到该Class内部
            /// </summary>
            /// <param name="inputWaveform"></param>
            public void SetWaveform(double[] inputWaveform)
            {
                waveform = new double[inputWaveform.Length];
                Array.Copy(inputWaveform, waveform, inputWaveform.Length);
                //waveform = inputWaveform will be buggy as the waveform points to the inputwaveform;
                InitStatus();
            }
            public double GetHighStateLevel()
            {
                if (double.IsNaN(highLevel))
                {
                    AmplitudeAnalysis();
                }
                return (highLevel);
            }
            public double GetLowStateLevel()
            {
                if (double.IsNaN(lowLevel))
                {
                    AmplitudeAnalysis();
                }
                return (lowLevel);
            }
            public double GetPeriod() // units=point
            {
                if (double.IsNaN(period))
                {
                    PeriodAnalysis();
                }
                return (period);
            }
            public double GetDutyCycle()
            {
                if (double.IsNaN(dutyCycleAvg))
                {
                    PeriodAnalysis();
                }
                return dutyCycleAvg;
            }
            public double GetPulseCount()
            {
                if (double.IsNaN(pulseCount))
                {
                    PeriodAnalysis();
                }
                return pulseCount;
            }
            public double GetPulseMaxLength()
            {
                if (double.IsNaN(pulseMaxWidth))
                {
                    PeriodAnalysis();
                }
                return pulseMaxWidth;
            }
            public double GetPulseMinLength()
            {
                if (double.IsNaN(pulseMinWidth))
                {
                    PeriodAnalysis();
                }
                return pulseMinWidth;
            }
            public double GetAmplitude()
            {
                if (double.IsNaN(amplitude))
                {
                    AmplitudeAnalysis();
                }
                return (amplitude);

            }
            public double GetFrequency() //units=1/point
            {
                if (double.IsNaN(frequency))
                {
                    PeriodAnalysis();
                }
                return (frequency);

            }

            /// <summary>
            /// 输入参考波形，用于计算相位
            /// </summary>
            /// <param name="inputWaveform"></param>
            public void SetRefWaveform(double[] inputWaveform)
            {
                waveformRef = new double[inputWaveform.Length];
                Array.Copy(inputWaveform, waveformRef, inputWaveform.Length);
                phase = double.NaN;
            }
            public double GetPhase()
            {
                if (double.IsNaN(phase))
                {
                    PhaseAnalysis();
                }
                return (phase);
            }
            private void InitStatus()
            {
                highLevel = double.NaN;
                lowLevel = double.NaN;
                period = double.NaN;
                phase = double.NaN;
                _levelHistogramY[0] = double.NaN;
                dutyCycleAvg = double.NaN;
                dutyCycleCount[0] = double.NaN;
                pulseCount = double.NaN;
                pulseMaxWidth = double.NaN;
                pulseMinWidth = double.NaN;
                amplitude = double.NaN;
                frequency = double.NaN;

        }
            private void AmplitudeAnalysis()
            {
                //devide the absolute max to min by 'intervals'
                //count the waveform levels within each interval
                //find the high level in the peak count from above
                //find the low level in the peak cout from bellow
                //get high and low levels by calculating the average of each peak interval;
                double intervalTopScale = 0.99;
                double[] intervalIntegrator = new double[intervals];
                int[] intervalCounter = new int[intervals];
                double waveformMax = waveform.Max();
                double waveformMin = waveform.Min();
                double waveformPeakPeak = waveformMax - waveformMin;
                int i = 0;
                int intervalIndex = 0;
                try
                {
                    for (i = 0; i < waveform.Length; i++)
                    {
                        intervalIndex = (int)((waveform[i] - waveformMin) / waveformPeakPeak * intervals * intervalTopScale);
                        intervalIntegrator[intervalIndex] += waveform[i];
                        intervalCounter[intervalIndex]++;
                    }
                    //Export the histogram to class property
                    for (int levelCount_i = 0; levelCount_i < intervals; levelCount_i++)
                    {
                        _levelHistogramY[levelCount_i] = (double)intervalCounter[levelCount_i];
                        _levelHistogramX[levelCount_i] = (double)levelCount_i / intervals * waveformPeakPeak;
                    }
                    //find the peak interval
                    int peakIndex = intervals - 1;
                    while (intervalCounter[peakIndex] < waveform.Length / intervals
                    || intervalCounter[peakIndex - 1] >= intervalCounter[peakIndex])
                    {
                        peakIndex--;
                    }
                    highLevel = intervalIntegrator[peakIndex] / intervalCounter[peakIndex];
                    //find the valley interval
                    int valleyIndex = 0;
                    while (intervalCounter[valleyIndex] < waveform.Length / intervals
                        || intervalCounter[valleyIndex + 1] >= intervalCounter[valleyIndex])
                    {
                        valleyIndex++;
                    }
                    lowLevel = intervalIntegrator[valleyIndex] / intervalCounter[valleyIndex];
                    amplitude = highLevel - lowLevel;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                
            }
            private void PeriodAnalysis()
            {
                // make sure amplitude analysis is done
                GetHighStateLevel();
                // use high low levels to analysis the period
                double amplitude = highLevel - lowLevel;
                double stateTollerance = 0.1 * amplitude;
                double highTreshold = highLevel - stateTollerance;
                double lowThreshold = lowLevel + stateTollerance;
                bool enteringHigh = false;
                bool enteredLow = false;
                bool enteringLow = false;
                bool enteredHigh = false;
                int lastFallingEdge = 0;
                double dutyCycle = 0;
                int[] intervalCounter = new int[intervals];
                int intervalIndex = 0;
                double[] intervalIntegrator = new double[intervals];
                double pulseMaxWidth2 = 0;
                double pulseMinWidth2 = 100000000;
                int edgeCount = 0;
                int lastEdge = 0;
                int periodCount = 0;
                double periodIntegrator = 0;

                try
                {
                    for (int i = 1; i < waveform.Length; i++)
                    {

                        enteredLow = enteredLow ||
                            (waveform[i - 1] > lowThreshold && waveform[i] <= lowThreshold);//处于低电压段
                        enteringHigh = waveform[i - 1] < highTreshold && waveform[i] >= highTreshold;//上升沿
                        if (enteringHigh && enteredLow)
                        {
                            enteredLow = false;
                            edgeCount++;//上升沿计数
                            if (edgeCount > 1)
                            {
                                periodCount++;//周期数计数
                                periodIntegrator += i - lastEdge;//计算所有完整周期内所包含的点数之和
                                if ((lastFallingEdge - lastEdge) > pulseMaxWidth2)//获取最大脉宽
                                {
                                    pulseMaxWidth2 = lastFallingEdge - lastEdge;
                                }
                                if ((lastFallingEdge - lastEdge) < pulseMinWidth2)//获取最小脉宽
                                {
                                    pulseMinWidth2 = lastFallingEdge - lastEdge;
                                }
                                dutyCycle = (double)(lastFallingEdge - lastEdge) / (i - lastEdge);//计算该周期的占空比
                                intervalIndex = (int)((dutyCycle - 0.0) / (1 - 0.0) * intervals);//
                                intervalIntegrator[intervalIndex] += dutyCycle;
                                intervalCounter[intervalIndex]++;//
                            }

                            lastEdge = i;//记录该次上升沿所对应的索引
                        }
                        //  捕获下降沿
                        enteredHigh = enteredHigh || (waveform[i - 1] < highTreshold && waveform[i] >= highTreshold);//处于高电压段
                        enteringLow = waveform[i - 1] > lowThreshold && waveform[i] <= lowThreshold;//下降沿
                        if (enteringLow && enteredHigh)
                        {

                            enteredHigh = false;
                            lastFallingEdge = i;
                        }
                    }
                    period = periodIntegrator / periodCount;
                    frequency = 1.0 / period;

                    pulseMaxWidth = pulseMaxWidth2;
                    pulseMinWidth = pulseMinWidth2;
                    pulseCount = (double)periodCount + 1;//由以上算法可知，计算出来的periodCount比实际的周期数要少1个，故在此做加1
                    double dutyCycleValue = 0;
                    int maxIndex = 0;
                    double dutyCycleMax = 0;
                    double dutyCycleMin = 100;
                    for (int i = 0; i < intervals; i++)
                    {
                        dutyCycleValue = intervalIntegrator[i] / intervalCounter[i];//当出现0/0时，计算结果是非数字
                        if (!double.IsNaN(dutyCycleValue))
                        {
                            if (dutyCycleValue > dutyCycleMax)
                            {
                                dutyCycleMax = dutyCycleValue;
                                maxIndex = i;
                            }

                            if (dutyCycleValue < dutyCycleMin)
                            {
                                dutyCycleMin = dutyCycleValue;

                            }
                        }

                    }
                    dutyCycleAvg = intervalIntegrator[maxIndex] / intervalCounter[maxIndex];//占空比的平均值
                    for (int dutyCycle_i = 0; dutyCycle_i < intervals; dutyCycle_i++)
                    {
                        dutyCycleCount[dutyCycle_i] = intervalCounter[dutyCycle_i];
                        _dutyCycleHistogramY[dutyCycle_i] = intervalCounter[dutyCycle_i];
                        _dutyCycleHistogramX[dutyCycle_i] = (double)dutyCycle_i / intervals * (dutyCycleMax - dutyCycleMin);
                    }

                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
                
            }
            private void PhaseAnalysis()
            {
                double productSum = 0;
                double maxProductSum = 0;
                double offsetOfMax = 0;
                //make sure amplitude and period are calculated
                GetHighStateLevel();
                GetPeriod();
                try
                {
                    if (Math.Min(waveform.Length, waveformRef.Length) > 2 * period)
                    {
                        int compareLength = Math.Min((int)(waveform.Length - period), waveformRef.Length);
                        for (int indexOffset = 0; indexOffset < period; indexOffset++)//当输入的波形长度很大时，计算量会很大
                        {
                            productSum = 0;
                            for (int i = 0; i < compareLength; i++)
                            {
                                productSum += waveform[i] * waveformRef[i + indexOffset];
                            }
                            if (productSum > maxProductSum)
                            {
                                maxProductSum = productSum;
                                offsetOfMax = indexOffset;
                            }
                        }
                        phase = 360 * offsetOfMax / period;
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
                
            }
        }
    }
}
