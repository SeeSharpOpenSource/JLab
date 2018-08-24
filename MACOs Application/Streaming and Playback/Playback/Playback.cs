using System;
using System.IO;
using System.Runtime.InteropServices;

namespace MACOs.JY.Playback
{
    /// <summary>
    /// Playback class
    /// </summary>
    public class PlaybackTask
    {
        #region Private Property 
        uint[] _playbackUintBuffer;
        int[] _playbackIntBuffer;
        short[] _playbackShortBuffer;
        ushort[] _playbackUshortBuffer;
        byte[] _playbackByteBuffer;
        FileStream binaryStream = null;
        BinaryReader binaryReader = null;
        int acquisitionTime;
        Type dataType;
        int chnCount;
        double range;
        double _sampleRate;
        long samplesPerChannel;

        #endregion

        #region Public Property
        private long _playBackPosition;
        /// <summary>
        /// Read data position
        /// </summary>
        public long PlayBackPosition
        {
            get
            {
                return _playBackPosition;
            }
            set
            {
                _playBackPosition = value;
            }
        }
        private int _frameLength;
        /// <summary>
        /// Step length when auto playing with unit of microsecond
        /// </summary>
        public int FrameLength
        {
            get
            {
                return _frameLength;
            }
            set
            {
                _frameLength = value;
            }
        }
        /// <summary>
        /// SampleRate
        /// </summary>
        public double SampleRate
        {
            get
            {
                return _sampleRate;
            }
        }
        private long _totalLength;
        /// <summary>
        /// Total length of samples
        /// </summary>
        public long TotalLength
        {
            get
            {
                return _totalLength;
            }
        }
        #endregion

        #region Construct
        #endregion

        #region Public Methods
        /// <summary>
        /// Open file and read information related to streaming
        /// </summary>
        /// <param name="fileName">binary file path</param>
        /// <param name="streamingInfo">streaming information including SignalFrequency, SampleRate, dataType, NumofChannels and TotalTime</param>
        public void OpenFile(string fileName, ref StreamingInfo streamingInfo)
        {
            streamingInfo = new StreamingInfo();
            string filenameTxt = fileName.Substring(0, fileName.Length - 4) + ".txt";

            FileStream txtStream = new FileStream(filenameTxt, FileMode.Open);
            StreamReader txtReader = new StreamReader(txtStream);
            binaryStream = new FileStream(fileName, FileMode.Open);
            binaryReader = new BinaryReader(binaryStream);

            var s = txtReader.ReadLine();
            var sp = s.Split('=');

            if (!sp[0].Trim().ToLower().Equals("samplerate"))
            {
                throw new Exception("No SampleRate Information");
            }
            streamingInfo.SampleRate = double.Parse(sp[1].Trim());
            _sampleRate = streamingInfo.SampleRate;
            s = txtReader.ReadLine();
            sp = s.Split('=');

            if (!sp[0].Trim().ToLower().Equals("range"))
            {
                throw new Exception("No Frequency Information");
            }
            streamingInfo.Range = double.Parse(sp[1].Trim());
            range = streamingInfo.Range;
            s = txtReader.ReadLine();
            sp = s.Split('=');

            if (!sp[0].Trim().ToLower().Equals("datatype"))
            {
                throw new Exception("No DataType Information");
            }
            dataType = Type.GetType(sp[1].Trim(), true, true);
            streamingInfo.DataSize = Marshal.SizeOf(dataType);
            s = txtReader.ReadLine();
            sp = s.Split('=');

            if (!sp[0].Trim().ToLower().Equals("channelcount"))
            {
                throw new Exception("No ChannelCount Information");
            }
            chnCount = int.Parse(sp[1].Trim());
            streamingInfo.Channels = new int[chnCount];
            streamingInfo.SamplesPerChannel = binaryStream.Length / streamingInfo.DataSize / chnCount;
            samplesPerChannel = streamingInfo.SamplesPerChannel;
            for (int i = 0; i < chnCount; i++)
            {
                s = txtReader.ReadLine();
                sp = s.Split(new[] { '[', ']' });
                streamingInfo.Channels[i] = int.Parse(sp[1].Trim());
            }
            s = txtReader.ReadLine();
            sp = s.Split('=');
            if (!sp[0].Trim().ToLower().Equals("elapsedtime"))
            {
                throw new Exception("No StreamingTime Information");
            }
            streamingInfo.StreamingTime = (int)double.Parse(sp[1].Trim());
            streamingInfo.AcquisitionTime = (int)((double)streamingInfo.SamplesPerChannel * 1000 / streamingInfo.SampleRate);
            acquisitionTime = streamingInfo.AcquisitionTime;

            _playBackPosition = 0;

            txtReader.Close();
            txtStream.Close();

            _totalLength = binaryStream.Length / Marshal.SizeOf(dataType) / chnCount;
        }

        /// <summary>
        /// Read playback data
        /// </summary>
        /// <param name="buffer">data buffer</param>
        /// <param name="readyForNext">ready for next time read</param>
        public void ReadPlayBackData(ref double[,] buffer, ref bool readyForNext)
        {
            if (_playBackPosition + buffer.GetLength(1) < TotalLength)
            {
                ReadCurrentFrame(ref buffer);
                _playBackPosition += buffer.GetLength(1);
            }
            if (_playBackPosition + buffer.GetLength(1) < TotalLength)
            {
                readyForNext = true;
            }
            else
            {
                readyForNext = false;
            }

        }


        /// <summary>
        /// Close the bin file handler that is currently reading
        /// </summary>
        public void CloseFile()
        {
            if (binaryStream != null)
            {
                binaryReader.Close();
                binaryStream.Close();
            }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// ReadCurrentFrame
        /// </summary>
        /// <param name="playbackBuffer"></param>
        private void ReadCurrentFrame(ref double[,] playbackBuffer)
        {
            _playbackUintBuffer = new uint[_frameLength * chnCount];
            _playbackIntBuffer = new int[_frameLength * chnCount];
            _playbackShortBuffer = new short[_frameLength * chnCount];
            _playbackUshortBuffer = new ushort[_frameLength * chnCount];
            _playbackByteBuffer = new byte[_frameLength * chnCount];

            binaryStream.Position = _playBackPosition * Marshal.SizeOf(dataType) * chnCount;

            if (dataType == typeof(int))
            {
                //Cofficient = 2^24
                var buf = binaryReader.ReadBytes(_frameLength * chnCount * sizeof(int));
                Buffer.BlockCopy(buf, 0, _playbackIntBuffer, 0, buf.Length);
                for (int row = 0; row < chnCount; row++)
                {
                    for (int col = 0; col < _frameLength; col++)
                    {
                        if (range == 0.2)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = (double)(_playbackIntBuffer[_frameLength * row + col] * 256) / int.MaxValue * 0.2;
                        }
                        else if (range == 0.316)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = (double)(_playbackIntBuffer[_frameLength * row + col] * 256) / int.MaxValue * 0.316;
                        }
                        else if (range == 0.5)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = (double)(_playbackIntBuffer[_frameLength * row + col] * 256) / int.MaxValue * 0.5;
                        }
                        else if (range == 1.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = (double)(_playbackIntBuffer[_frameLength * row + col] * 256) / int.MaxValue * 1.0;
                        }
                        else if (range == 2.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = (double)(_playbackIntBuffer[_frameLength * row + col] * 256) / int.MaxValue * 2.0;
                        }
                        else if (range == 3.16)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = (double)(_playbackIntBuffer[_frameLength * row + col] * 256) / int.MaxValue * 3.16;
                        }
                        else if (range == 5.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = (double)(_playbackIntBuffer[_frameLength * row + col] * 256) / int.MaxValue * 5.0;
                        }
                        else if (range == 10.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = (double)(_playbackIntBuffer[_frameLength * row + col] * 256) / int.MaxValue * 10.0;
                        }
                        else if (range == 40.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = (double)(_playbackIntBuffer[_frameLength * row + col] * 256) / int.MaxValue * 40.0;
                        }
                        else
                        {
                            throw new Exception("Invalid Input Range!");
                        }
                    }
                }
            }
            else if (dataType == typeof(uint))
            {
                var buf = binaryReader.ReadBytes(_frameLength * chnCount * sizeof(uint));
                Buffer.BlockCopy(buf, 0, _playbackUintBuffer, 0, buf.Length);
                for (int row = 0; row < chnCount; row++)
                {
                    for (int col = 0; col < _frameLength; col++)
                    {
                        if (range == 0.2)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackUintBuffer[_frameLength * row + col] / 16777216.0 * 0.4 - 0.2;
                        }
                        else if (range == 0.5)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackUintBuffer[_frameLength * row + col] / 16777216.0 * 1.0 - 0.5;
                        }
                        else if (range == 1.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackUintBuffer[_frameLength * row + col] / 16777216.0 * 2.0 - 1.0;
                        }
                        else if (range == 2.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackUintBuffer[_frameLength * row + col] / 16777216.0 * 4.0 - 2.0;
                        }
                        else if (range == 5.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackUintBuffer[_frameLength * row + col] / 16777216.0 * 10.0 - 5.0;
                        }
                        else
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackUintBuffer[_frameLength * row + col] / 16777216.0 * 20.0 - 10.0;
                        }
                    }
                }
            }
            else if (dataType == typeof(short))
            {
                var buf = binaryReader.ReadBytes(_frameLength * chnCount * sizeof(short));
                Buffer.BlockCopy(buf, 0, _playbackShortBuffer, 0, buf.Length);
                for (int row = 0; row < chnCount; row++)
                {
                    for (int col = 0; col < _frameLength; col++)
                    {
                        if (range == 0.2)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackShortBuffer[_frameLength * row + col] / 32768.0 * 0.2;
                        }
                        else if (range == 0.5)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackShortBuffer[_frameLength * row + col] / 32768.0 * 0.5;
                        }
                        else if (range == 1.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackShortBuffer[_frameLength * row + col] / 32768.0 * 1.0;
                        }
                        else if (range == 2.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackShortBuffer[_frameLength * row + col] / 32768.0 * 2.0;
                        }
                        else if (range == 5.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackShortBuffer[_frameLength * row + col] / 32768.0 * 5.0;
                        }
                        else
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackShortBuffer[_frameLength * row + col] / 32768.0 * 10.0;
                        }
                    }
                }
            }
            else if (dataType == typeof(ushort))
            {
                var buf = binaryReader.ReadBytes(_frameLength * chnCount * sizeof(ushort));
                Buffer.BlockCopy(buf, 0, _playbackUshortBuffer, 0, buf.Length);
                for (int row = 0; row < chnCount; row++)
                {
                    for (int col = 0; col < _frameLength; col++)
                    {
                        if (range == 0.2)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackUshortBuffer[_frameLength * row + col] / 65536.0 * 0.4 - 0.2;
                        }
                        else if (range == 0.5)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackUshortBuffer[_frameLength * row + col] / 65536.0 * 1.0 - 0.5;
                        }
                        else if (range == 1.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackUshortBuffer[_frameLength * row + col] / 65536.0 * 2.0 - 1.0;
                        }
                        else if (range == 2.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackUshortBuffer[_frameLength * row + col] / 65536.0 * 4.0 - 2.0;
                        }
                        else if (range == 5.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackUshortBuffer[_frameLength * row + col] / 65536.0 * 10.0 - 5.0;
                        }
                        else
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackUshortBuffer[_frameLength * row + col] / 65536.0 * 20.0 - 10.0;
                        }
                    }
                }
            }
            else if (dataType == typeof(byte))
            {
                var buf = binaryReader.ReadBytes(_frameLength * chnCount * sizeof(byte));
                Buffer.BlockCopy(buf, 0, _playbackByteBuffer, 0, buf.Length);
                for (int row = 0; row < chnCount; row++)
                {
                    for (int col = 0; col < _frameLength; col++)
                    {
                        if (range == 0.2)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackByteBuffer[_frameLength * row + col] / 32768.0 * 0.2;
                        }
                        else if (range == 0.5)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackByteBuffer[_frameLength * row + col] / 32768.0 * 0.5;
                        }
                        else if (range == 1.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackByteBuffer[_frameLength * row + col] / 32768.0 * 1.0;
                        }
                        else if (range == 2.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackByteBuffer[_frameLength * row + col] / 32768.0 * 2.0;
                        }
                        else if (range == 5.0)
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackByteBuffer[_frameLength * row + col] / 32768.0 * 5.0;
                        }
                        else
                        {
                            playbackBuffer[(_frameLength * row + col) % chnCount, (row * _frameLength + col) / chnCount] = _playbackByteBuffer[_frameLength * row + col] / 32768.0 * 10.0;
                        }
                    }
                }
            }
        }

        #endregion
    }

    /// <summary>
    /// Information about streaming header file, such as SampleRate, DataSize etc.
    /// </summary>
    public class StreamingInfo
    {
        private double sampleRate;
        /// <summary>
        /// SampleRate
        /// </summary>
        public double SampleRate
        {
            get
            {
                return sampleRate;
            }

            set
            {
                sampleRate = value;
            }
        }

        private double range;

        /// <summary>
        /// AI input range
        /// </summary>
        public double Range
        {
            get
            {
                return range;
            }
            set
            {
                range = value;
            }
        }

        private int dataSize;
        /// <summary>
        /// Data size
        /// </summary>
        public int DataSize
        {
            get
            {
                return dataSize;
            }
            set
            {
                dataSize = value;
            }
        }

        private int[] channels;
        /// <summary>
        /// Channel List
        /// </summary>
        public int[] Channels
        {
            get
            {
                return channels;
            }
            set
            {
                channels = value;
            }
        }

        private int streamingTime;
        /// <summary>
        /// Streaming time in unit of ms and should be near to acquisition time, otherwise some data is lost
        /// </summary>
        public int StreamingTime
        {
            get
            {
                return streamingTime;
            }
            set
            {
                streamingTime = value;
            }
        }

        private int acquisitionTime;
        /// <summary>
        /// Acquisition time in unit of ms, calculated by the file size
        /// </summary>
        public int AcquisitionTime
        {
            get
            {
                return acquisitionTime;
            }
            set
            {
                acquisitionTime = value;
            }
        }

        private long samplesPerChannel;
        /// <summary>
        /// number of total samples in selected file
        /// </summary>
        public long SamplesPerChannel
        {
            get
            {
                return samplesPerChannel;
            }
            set
            {
                samplesPerChannel = value;
            }
        }

    }
}
