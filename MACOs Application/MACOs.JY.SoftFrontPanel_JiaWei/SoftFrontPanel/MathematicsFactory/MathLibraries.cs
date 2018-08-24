using SeeSharpTools.JY.ArrayUtility;

namespace MACOs.JY.SoftFrontPanel
{

    public abstract class MathLibraries
    {
        #region Pricate Fields
        private double[] _preData;
        private string _analysisItem;
        private double _result;
        private int _chID;
        private double[] tempData;
        private int _dataLength = 0;
        private double _sampleRate;


        #endregion

        #region Public Properties
        /// <summary>
        /// 通道数组
        /// </summary>
        protected double[] PreData { get; set; }
        /// <summary>
        /// 采样率
        /// </summary>
        protected double SampleRate { get; set; }

        public int ChNum { get; set; }

        public string Item { get; set; }

        public double Result { get; set; }

        #endregion

        #region Methods
        public virtual void Process() { }

        public void SubsetData(double[,] readData, int index, double samplingRate)
        {
            SampleRate = samplingRate;

            //If the size of the data length is the same, don't create new array to save the memory usage
            if (_dataLength != readData.GetLength(0))
            {
                _dataLength = readData.GetLength(0);
                tempData = new double[100000];
            }

            ArrayManipulation.GetArraySubset(readData, index, ref tempData, ArrayManipulation.IndexType.column);
            PreData = tempData;
        }

        #endregion

    }
}
