using System.Drawing;

namespace DsaSoftPanel
{
    public static class Constants
    {
        public const double TimeOutRatio = 2.0;

        public const string DriverExceptionName = "JYDriverException";

        public static Color[] Palette = new Color[]
        {
            Color.Yellow, Color.Cyan, Color.DarkOrange, Color.PaleVioletRed, Color.BlueViolet, Color.Blue,
            Color.LimeGreen, Color.Magenta
        };

        public static string[] TmpSeriesNames = new string[] {"ch1", "ch2" , "ch3" , "ch4" , "ch5" , "ch6" ,
            "ch7" , "ch8"};

        public static Color ChannelLabelDisabled = Color.FromArgb(64, 64, 64);

        public const int MaxChartView = 8;

        public const int MaxChannelCount = 4;

        public const string ChannelTabNameFormat = "tabpage_ch{0}";
        public const string ChannelLabelFormat = "CH{0}";
        public const string EmptyChannelLabel = "";
        public const string RunButtonText = "PAUSE";
        public const string PauseButtonText = "RUN";

        public const double SpectrumResolution = 2;

        public const double MinDoubleValue = 1E-40;

        public const int RestartDelayTime = 100;

        public const int RangePointPrecision = 1;

        public const int MinViewTime = 15;
        public const double MinChartRange = 0.5;

        public const int DefaultDisplayBufSize = 100000;

        public const int FuncWaitTime = 200;

        public const string HarmonicFunction = "Harmonic";
        public const string SpectrumFunction = "Spectrum";

        public const int HarmonicLevel = 10;

        public const string NotAvailable = "N/A";

        public const string NumericFormat = "0.######";

        public const int BufferReadTimeout = 500;
        public const int BufferWriteTimeout = 100;

        public const int MaxPointsPerView = 10000000;
    }
}