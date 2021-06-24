using System;
using System.Threading;

namespace DsaSoftPanel.Data
{
    public class ReadDataBuffer
    {
        public double[] DataBuffer { get; private set; }

        public int SamplesPerView { get; private set; }

        public int ChannelCount { get; private set; }

        private long _dataVersion;
        public long DataVersion => this._dataVersion;

        public ReadDataBuffer()
        {
            this.DataBuffer = null;
            this.SamplesPerView = 0;
            this.ChannelCount = 0;
        }

        public void Reset(double sampleRate, int channelCount)
        {
            int expectDataBufferSize = (int)sampleRate * channelCount;
            int samplesPerView = (int) sampleRate;
            if (expectDataBufferSize > Constants.MaxPointsPerView)
            {
                expectDataBufferSize = Constants.MaxPointsPerView/channelCount*channelCount;
            }
            if (null == DataBuffer || DataBuffer.Length != expectDataBufferSize)
            {
                DataBuffer = new double[expectDataBufferSize];
            }
            this.SamplesPerView = 0;
            this.ChannelCount = channelCount;
        }

        public void UpdateDataBuffer(double[,] readData)
        {
            int sampleCount = readData.GetLength(0);
            if (ChannelCount == 1)
            {
                Buffer.BlockCopy(readData, 0, DataBuffer, 0,
                    readData.Length * sizeof(double));
            }
            else
            {
                int channelCount = readData.GetLength(1);
                for (int i = 0; i < sampleCount; i++)
                {
                    int dataBufferIndex = i;
                    for (int j = 0; j < channelCount; j++)
                    {
                        DataBuffer[dataBufferIndex] = readData[i, j];
                        dataBufferIndex += sampleCount;
                    }
                }
            }
            Interlocked.Increment(ref _dataVersion);
            this.SamplesPerView = sampleCount;
        }
    }
}