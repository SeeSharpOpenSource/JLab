namespace MACOs.JY.Streaming
{
    /// <summary>
    /// Streaming task class
    /// </summary>
    public abstract class StreamingTask
    {
        /// <summary>
        /// Create streaming task
        /// </summary>
        public StreamingTask()
        {
            TerminalCfg = AITerminalCfg.NRSE;
            Coupling = AIInputCoupling.DC;
            InputImpedance = AIInputImpedance.ImpedanceHigh;
        }

        /// <summary>
        /// Number of channels in each board
        /// </summary>
        public int NumOfChannels{ get; set; }

       /// <summary>
        /// Folder path that stores the streaming data
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Input terminal configuration (available on DAQ)
        /// </summary>
        public AITerminalCfg TerminalCfg { get; set; }

        /// <summary>
        /// Input coupling (available on digitizers)
        /// </summary>
        public AIInputCoupling Coupling { get; set;}

        /// <summary>
        /// Input impedance (available on digitizers)
        /// </summary>
        public AIInputImpedance InputImpedance { get; set; }

        /// <summary>
        /// Enable IEPE (available on DSA)
        /// </summary>
        public bool IEPEEnable { get; set; }

        /// <summary>
        /// Add single channel
        /// </summary>
        /// <param name="chnID">physical channel ID</param>
        /// <param name="sampleRate">sampleRate per channel</param>
        /// <param name="recordLength">record time in unit of second (s)</param>
        /// <param name="rangelow">range low</param>
        /// <param name="rangeHigh">range high</param>
        public abstract void Record(int chnID, double sampleRate, double recordLength, double rangelow = -10, double rangeHigh = 10);

        /// <summary>
        /// Add multiple channels
        /// </summary>
        /// <param name="chnsID">physical channel ID</param>
        /// <param name="sampleRate">sampleRate per channel</param>
        /// <param name="recordLength">record time in unit of second (s)</param>
        /// <param name="rangelow">range low</param>
        /// <param name="rangeHigh">range high</param>
        public abstract void Record(int[] chnsID, double sampleRate, double recordLength, double rangelow = -10, double rangeHigh = 10);

        /// <summary>
        /// Start streaming task
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// Stop streaming task
        /// </summary>
        public abstract void Stop();

        /// <summary>
        /// Fetch latest record data
        /// </summary>
        /// <param name="buf">用户定义返回数据的缓冲区</param>
        /// <param name="timeout">超时时间，单位ms，-1为无限等待</param>
        /// <returns></returns>
        public abstract void ReadLatestData(ref double[] buf, int timeout = -1);

        /// <summary>
        /// Fetch latest record data
        /// </summary>
        /// <param name="buf">record data buffer array</param>
        /// <param name="samplesPerChannel">samples to read per channel</param>
        /// <param name="timeout">timeout in unit of millisecond (ms), -1 means infinite wait</param>
        public abstract void ReadLatestData(ref double[] buf, int samplesPerChannel, int timeout);

        /// <summary>
        /// Fetch latest record data
        /// </summary>
        /// <param name="buf">record data buffer array</param>
        /// <param name="timeout">timeout in unit of millisecond (ms), -1 means infinite wait</param>
        /// <returns></returns>
        public abstract void ReadLatestData(ref double[,] buf, int timeout = -1);

        /// <summary>
        /// Fetch latest record data
        /// </summary>
        /// <param name="buf">record data buffer array</param>
        /// <param name="samplesPerChannel">samples to read per channel</param>
        /// <param name="timeout">timeout in unit of millisecond (ms), -1 means infinite wait</param>
        /// <returns></returns>
        public abstract void ReadLatestData(ref double[,] buf, int samplesPerChannel, int timeout);

        /// <summary>
        /// Get record status
        /// </summary>
        /// <param name="recordedLength">Finished record time in unit of second (s)</param>
        /// <param name="recordDone">whether record is finished</param>
        public abstract void GetRecordStatus(out double recordedLength, out bool recordDone);

        /// <summary>
        /// Wait until current task is finished
        /// </summary>
        /// <param name="timeout">wait time in unit of millisecond (ms) </param>
        /// <returns></returns>
        public abstract void WaitUntilDone(int timeout = -1);

        /// <summary>
        /// Match vendor range with input rangeLow and rangeHigh
        /// </summary>
        /// <param name="rangeLow">range low</param>
        /// <param name="rangeHigh">range high</param>
        /// <returns>vendor range</returns>
        public abstract double GetVendorRange(double rangeLow, double rangeHigh);
    }

    /// <summary>
    /// Input terminal configuration (available on DAQ and DSA)
    /// </summary>
    public enum AITerminalCfg
    {
        /// <summary>
        /// Reference-Single-Ended
        /// </summary>
        RSE,

        /// <summary>
        /// Non-Reference-Single-Ended
        /// </summary>
        NRSE,

        /// <summary>
        /// Differential
        /// </summary>
        Differential,

        /// <summary>
        /// Pseudodifferential
        /// </summary>
        Pseudodifferential,
    }

    /// <summary>
    /// Input coupling (available on DSA and digitizers)
    /// </summary>
    public enum AIInputCoupling
    {
        /// <summary>
        /// DC Coupling
        /// </summary>
        DC,

        ///AC Coupling
        AC,
    }

    /// <summary>
    /// Input impedance (available on digitizers)
    /// </summary>
    public enum AIInputImpedance
    {
        /// <summary>
        /// High input impedance
        /// </summary>
        ImpedanceHigh,

        /// <summary>
        /// 50Ohm input impedance
        /// </summary>
        Impedance50Ohm,
    }
}
