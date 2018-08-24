namespace MACOs.JY.DAQDevice.AnalogInput
{
    public class AnalogInputChannel
    {
        public int ChannelID { get; set; }

        public double RangeHigh { get; set; }

        public double RangeLow { get; set; }

        public AnalogInputChannel()
        {
            this.ChannelID = 0;
            this.RangeHigh = 1;
            this.RangeLow = -1;
        }
    }
}