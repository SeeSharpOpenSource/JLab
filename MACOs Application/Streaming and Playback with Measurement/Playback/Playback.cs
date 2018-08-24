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
        long playbackPosition;
        double sampleRate;
        int samplesPerChannel;
        bool refreshRequested;
        #endregion

        #region Public Property

        private int frameLength;
        /// <summary>
        /// Step length when auto playing with unit of microsecond
        /// </summary>
        public int FrameLength
        {
            get
            {
                return frameLength;
            }
            set
            {
                frameLength = value;   
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
            //if (!sp[0].Trim().ToLower().Equals("signalrate"))
            //{
            //    throw new Exception("No Frequency Information");
            //}
            //streamingInfo.SignalRate = double.Parse(sp[1].Trim());
            //s = txtReader.ReadLine();
            //sp = s.Split('=');

            if (!sp[0].Trim().ToLower().Equals("samplerate"))
            {
                throw new Exception("No SampleRate Information");
            }
            streamingInfo.SampleRate = double.Parse(sp[1].Trim());
            sampleRate = streamingInfo.SampleRate;
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
            streamingInfo.SamplesPerChannel = (int)binaryStream.Length / streamingInfo.DataSize / chnCount;
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
            streamingInfo.AcquisitionTime= (int)((double)streamingInfo.SamplesPerChannel * 1000 / streamingInfo.SampleRate);
            acquisitionTime = streamingInfo.AcquisitionTime;

            playbackPosition = 0;

            txtReader.Close();
            txtStream.Close();

            refreshRequested = true;
        }

        /// <summary>
        /// Read frame data form file and update trackBar
        /// <para> Note: if remaining data is less than frameLength, it will not be displayed.</para>
        /// </summary>
        /// <param name="playing">whether it is still playing</param>
        /// <param name="originalTrackBarValue">original trackBar value</param>
        /// <param name="playbackBuffer">current frame data for display</param>
        /// <param name="updatedTrackBarValue">updated trackBar value</param>
        public void ReadFrame(bool playing, int originalTrackBarValue, ref double[,] playbackBuffer,out int updatedTrackBarValue)
        {
            updatedTrackBarValue = 0;
            bool autoToTail = false; //whether file end has been reached
            if (playing || refreshRequested)
            {
                ReadCurrentFrame(ref playbackBuffer);
                if(playing)
                {
                    if (autoToTail)
                    {
                        autoToTail = false;
                        updatedTrackBarValue = originalTrackBarValue;
                    }
                    else
                    {
                        DriveNextPosition(ref updatedTrackBarValue, ref autoToTail);
                    }
                }
                else
                {
                    updatedTrackBarValue = originalTrackBarValue;
                }
                refreshRequested = false;
            }
            else
            {
                updatedTrackBarValue = originalTrackBarValue;
            }
            updatedTrackBarValue= Math.Min(updatedTrackBarValue, acquisitionTime);
        }

        /// <summary>
        /// Get trackBar value when it is moving
        /// </summary>
        /// <param name="originalTrackBarValue">original trackBar value</param>
        /// <param name="updatedTrackBarValue">updated trackBar value</param>
        public void UpdateTrackBar(int originalTrackBarValue, ref int updatedTrackBarValue)
        {
            playbackPosition = (long)(originalTrackBarValue * sampleRate / 1000);
            //If the subtract of file length and current playbackPosition is less than frame length, file end has been reached
            if (samplesPerChannel - playbackPosition <= frameLength)
            {
                playbackPosition = samplesPerChannel - frameLength;
                updatedTrackBarValue = (int)(playbackPosition * 1000 / sampleRate);
            }
            else
            {
                updatedTrackBarValue = originalTrackBarValue;
            }

            refreshRequested = true;
        }
        /// <summary>
        /// Close the bin file handler that is currently reading
        /// </summary>
        public void CloseFile()
        {
            if (binaryStream!=null)
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
            _playbackUintBuffer = new uint[frameLength * chnCount];
            _playbackIntBuffer = new int[frameLength * chnCount];
            _playbackShortBuffer = new short[frameLength * chnCount];
            _playbackUshortBuffer = new ushort[frameLength * chnCount];
            _playbackByteBuffer = new byte[frameLength * chnCount];

            binaryStream.Position = playbackPosition * Marshal.SizeOf(dataType) * chnCount;

            if (dataType == typeof(int))
            {
                //Cofficient = 2^24
                var buf = binaryReader.ReadBytes(frameLength * chnCount * sizeof(int));
                Buffer.BlockCopy(buf, 0, _playbackIntBuffer, 0, buf.Length);
                for (int row = 0; row < chnCount; row++)
                {
                    for (int col = 0; col < frameLength; col++)
                    {
                        if (range == 0.2)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = (double)(_playbackIntBuffer[frameLength * row + col] * 256 )/ int.MaxValue * 0.2;
                        }
                        else if (range == 0.5)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = (double)(_playbackIntBuffer[frameLength * row + col] * 256) / int.MaxValue * 0.5;
                        }
                        else if (range == 1.0)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = (double)(_playbackIntBuffer[frameLength * row + col] * 256) / int.MaxValue * 1.0;
                        }
                        else if (range == 2.0)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = (double)(_playbackIntBuffer[frameLength * row + col] * 256) / int.MaxValue * 2.0;
                        }
                        else if (range == 5.0)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = (double)(_playbackIntBuffer[frameLength * row + col] * 256) / int.MaxValue * 5.0;
                        }
                        else
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = (double)(_playbackIntBuffer[frameLength * row + col] * 256) / int.MaxValue * 10.0;
                        }
                    }
                }
            }
            else if (dataType == typeof(uint))
            {
                var buf = binaryReader.ReadBytes(frameLength * chnCount * sizeof(uint));
                Buffer.BlockCopy(buf, 0, _playbackUintBuffer, 0, buf.Length);
                for (int row = 0; row < chnCount; row++)
                {
                    for (int col = 0; col < frameLength; col++)
                    {
                        if (range == 0.2)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackUintBuffer[frameLength * row + col] / 16777216.0 * 0.4 - 0.2;
                        }
                        else if (range == 0.5)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackUintBuffer[frameLength * row + col] / 16777216.0 * 1.0 - 0.5;
                        }
                        else if (range == 1.0)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackUintBuffer[frameLength * row + col] / 16777216.0 * 2.0 - 1.0;
                        }
                        else if (range == 2.0)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackUintBuffer[frameLength * row + col] / 16777216.0 * 4.0 - 2.0;
                        }
                        else if (range == 5.0)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackUintBuffer[frameLength * row + col] / 16777216.0 * 10.0 - 5.0;
                        }
                        else
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackUintBuffer[frameLength * row + col] / 16777216.0 * 20.0 - 10.0;
                        }
                    }
                }
            }
            else if (dataType == typeof(short))
            {
                var buf = binaryReader.ReadBytes(frameLength * chnCount * sizeof(short));
                Buffer.BlockCopy(buf, 0, _playbackShortBuffer, 0, buf.Length);
                for (int row = 0; row < chnCount; row++)
                {
                    for (int col = 0; col < frameLength; col++)
                    {
                        if (range == 0.2)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackShortBuffer[frameLength * row + col] / 32768.0 * 0.2;
                        }
                        else if (range == 0.5)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackShortBuffer[frameLength * row + col] / 32768.0 * 0.5;
                        }
                        else if (range == 1.0)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackShortBuffer[frameLength * row + col] / 32768.0 * 1.0;
                        }
                        else if (range == 2.0)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackShortBuffer[frameLength * row + col] / 32768.0 * 2.0;
                        }
                        else if (range == 5.0)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackShortBuffer[frameLength * row + col] / 32768.0 * 5.0;
                        }
                        else
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackShortBuffer[frameLength * row + col] / 32768.0 * 10.0;
                        }
                    }
                }
            }
            else if (dataType == typeof(ushort))
            {
                var buf = binaryReader.ReadBytes(frameLength * chnCount * sizeof(ushort));
                Buffer.BlockCopy(buf, 0, _playbackUshortBuffer, 0, buf.Length);
                for (int row = 0; row < chnCount; row++)
                {
                    for (int col = 0; col < frameLength; col++)
                    {
                        if (range == 0.2)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackUshortBuffer[frameLength * row + col] / 65536.0 * 0.4 - 0.2;
                        }
                        else if (range == 0.5)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackUshortBuffer[frameLength * row + col] / 65536.0 * 1.0 - 0.5;
                        }
                        else if (range == 1.0)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackUshortBuffer[frameLength * row + col] / 65536.0 * 2.0 - 1.0;
                        }
                        else if (range == 2.0)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackUshortBuffer[frameLength * row + col] / 65536.0 * 4.0 - 2.0;
                        }
                        else if (range == 5.0)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackUshortBuffer[frameLength * row + col] / 65536.0 * 10.0 - 5.0;
                        }
                        else
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackUshortBuffer[frameLength * row + col] / 65536.0 * 20.0 - 10.0;
                        }
                    }
                }
            }
            else if (dataType == typeof(byte))
            {
                var buf = binaryReader.ReadBytes(frameLength * chnCount * sizeof(byte));
                Buffer.BlockCopy(buf, 0, _playbackByteBuffer, 0, buf.Length);
                for (int row = 0; row < chnCount; row++)
                {
                    for (int col = 0; col < frameLength; col++)
                    {
                        if (range == 0.2)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackByteBuffer[frameLength * row + col] / 32768.0 * 0.2;
                        }
                        else if (range == 0.5)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackByteBuffer[frameLength * row + col] / 32768.0 * 0.5;
                        }
                        else if (range == 1.0)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackByteBuffer[frameLength * row + col] / 32768.0 * 1.0;
                        }
                        else if (range == 2.0)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackByteBuffer[frameLength * row + col] / 32768.0 * 2.0;
                        }
                        else if (range == 5.0)
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackByteBuffer[frameLength * row + col] / 32768.0 * 5.0;
                        }
                        else
                        {
                            playbackBuffer[(frameLength * row + col) % chnCount, (row * frameLength + col) / chnCount] = _playbackByteBuffer[frameLength * row + col] / 32768.0 * 10.0;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Drive to next position
        /// </summary>
        /// <param name="trackBarValue"></param>
        /// <param name="isDone"></param>
        private void DriveNextPosition(ref int trackBarValue, ref bool isDone)
        {
            if (playbackPosition + frameLength >= binaryStream.Length / Marshal.SizeOf(dataType) / chnCount)
            {
                isDone = true;
                playbackPosition = binaryStream.Length / Marshal.SizeOf(dataType) / chnCount - frameLength;
            }
            else
            {
                playbackPosition += frameLength;
            }
            trackBarValue = (int)(playbackPosition * 1000 / sampleRate);
        }
        #endregion
    }

    /// <summary>
    /// Information about streaming header file, such as SampleRate, SignalFrequency, DataSize etc.
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

        //private double signalRate;
        ///// <summary>
        ///// SignalRate
        ///// </summary>
        //public double SignalRate
        //{
        //    get
        //    {
        //        return signalRate;
        //    }
        //    set
        //    {
        //        signalRate = value;
        //    }
        //}

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

        private int samplesPerChannel;
        /// <summary>
        /// number of total samples in selected file
        /// </summary>
        public int SamplesPerChannel
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
