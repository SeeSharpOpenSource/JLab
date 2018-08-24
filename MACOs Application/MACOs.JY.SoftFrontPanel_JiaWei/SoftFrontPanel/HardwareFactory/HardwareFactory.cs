

namespace MACOs.JY.SoftFrontPanel
{
    public class HardwareFactory
    {
        public static AnalogInputDevices Create(int boardNum, InstrumentsType type)
        {
            //if new Digitizer is added, MUST add new case here!!!!!!!!!

            switch (type)
            {
                case InstrumentsType.JYPXIe69848H:
                    return new JYPXIe69848H(boardNum);
                case InstrumentsType.JYPXIe69852:
                    return new JYPXIe69852(boardNum);
                case InstrumentsType.JYUSB62405:
                    return new JYUSB62405(boardNum);
                case InstrumentsType.JYUSB61902:
                    return new JYUSB61902(boardNum);
                case InstrumentsType.JYPXI69527:
                    return new JYPXI69527(boardNum);
                case InstrumentsType.JYUSB101:
                    return new JYUSB101(boardNum);
                case InstrumentsType.Simulation:
                    return new Simulation(0);
                default:
                    return null;
            }

        }

        public enum InstrumentsType
        {
            //if new Digitizer is added, MUST add new item here!!!!!!!!!
            JYPXIe69848H,
            JYPXIe69852,
            JYPXI69527,
            JYUSB62405,
            JYUSB61902,
            JYUSB101,
            Simulation
            
        }
    }

    #region Necessary information for each type of device
    public class DAQInfo
    {

        public string[] Terminals { get; set; }

        public int MaxChannels { get; set; }

        public int MaxSampleRate { get; set; }

        public string[] Ranges { get; set; }

        internal class ChannelConfig : DGVLookUpTable
        {
            public bool EnableCh { get; set; }

            public int ChNum { get; set; }

            public string Range { get; set; }

            public string Terminal { get; set; }

        }
    }

    public class DigitizerInfo
    {

        public string[] Couplings { get; set; }

        public int MaxChannels { get; set; }

        public int MaxSampleRate { get; set; }

        public string[] Ranges { get; set; }

        public string[] Impedances { get; set; }

        internal class ChannelConfig : DGVLookUpTable
        {
            public bool EnableCh { get; set; }

            public int ChNum { get; set; }

            public string Range { get; set; }

            public string Impedance { get; set; }

            public string Coupling { get; set; }
        }
    }

    public class DSAInfo
    {
        public int MaxChannels { get; set; }

        public int MaxSampleRate { get; set; }

        public string[] Ranges { get; set; }

        public string[] Terminals { get; set; }

        public string[] Couplings { get; set; }

        internal class ChannelConfig : DGVLookUpTable
        {
            public bool EnableCh { get; set; }

            public int ChNum { get; set; }

            public string Range { get; set; }

            public bool EnableIEPE { get; set; }

            public string Terminal { get; set; }

            public string Coupling { get; set; }
        }
    }

    public class SimInfo
    {
        public int MaxChannels { get; set; }

        public string[] Ranges { get; set; }
        internal class ChannelConfig : DGVLookUpTable
        {
            public bool EnableCh { get; set; }

            public int ChNum { get; set; }

            public string Range { get; set; }
        }
    }

    #endregion


}
