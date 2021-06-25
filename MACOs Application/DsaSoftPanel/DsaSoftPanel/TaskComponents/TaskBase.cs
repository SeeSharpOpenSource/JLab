using System;
using System.Collections.Generic;
using DsaSoftPanel.Data;

namespace DsaSoftPanel.TaskComponents
{
    public class TaskBase
    {
        private long _lastUsedVersion;

        protected readonly List<double[]> DataCache;

        protected readonly SoftPanelGlobalInfo _globalInfo;

        public TaskBase()
        {
            _lastUsedVersion = long.MinValue;
            this.DataCache = new List<double[]>(8);
            _globalInfo = SoftPanelGlobalInfo.GetInstance();
        }

        protected void InitialDataBufferCache()
        {
            int channelCount = this._globalInfo.EnableChannelCount;
            // 更新DataCache中每个通道的数据缓存
            if (this.DataCache.Count != channelCount)
            {
                while (this.DataCache.Count > channelCount)
                {
                    this.DataCache.RemoveAt(this.DataCache.Count - 1);
                }

                while (channelCount > this.DataCache.Count)
                {
                    this.DataCache.Add(null);
                }
            }
        }

        protected bool UpdateDataCache()
        {
            
            bool getLock = _globalInfo.BufferLock.TryEnterReadLock(Constants.BufferReadTimeout);
            if (!getLock)
            {
                return false;
            }
            try
            {
                ReadDataBuffer readDataBuffer = this._globalInfo.ReadDataBuffer;
                int samplesPerView = readDataBuffer.SamplesPerView;
                // 数据缓存中没有有效的数据或者当前数据已经执行过计算则判定更新失败
                if (samplesPerView <= 0 || _lastUsedVersion == readDataBuffer.DataVersion)
                {
                    return false;
                }
                for (int i = 0; i < this.DataCache.Count; i++)
                {
                    if (null == this.DataCache[i] || this.DataCache[i].Length != samplesPerView)
                    {
                        this.DataCache[i] = new double[samplesPerView];
                    }
                }
                // 拷贝最新的数据到每个缓存
                this._lastUsedVersion = readDataBuffer.DataVersion;
                int startIndex = 0;
                int singleChannelLength = samplesPerView*sizeof(double);
                foreach (double[] singleChannelCache in this.DataCache)
                {
                    Buffer.BlockCopy(readDataBuffer.DataBuffer, startIndex, singleChannelCache, 0, singleChannelLength);
                    startIndex += singleChannelLength;
                }
                return true;
            }
            finally
            {
                this._globalInfo.BufferLock.ExitReadLock();
            }
        }
    }
}