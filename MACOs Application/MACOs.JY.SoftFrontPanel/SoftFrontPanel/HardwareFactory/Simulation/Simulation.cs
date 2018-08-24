using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using SeeSharpTools.JY.DSP.Fundamental;
using SeeSharpTools.JY.ArrayUtility;

namespace MACOs.JY.SoftFrontPanel
{
    class Simulation : AnalogInputDevices, ISimulation
    {

        double _samplingRate;
        int _samplesToRead;
        List<int> simChList = new List<int>();

        public override int[] SelectedChannels
        {
            get
            {
                return simChList.ToArray();
            }
        }

        public override bool ReadyToFetch
        {
            get { return true; }
        }

        public SimInfo SimulationInfo { get; set; }

        public Simulation(int boardNum)
        {
            SimInfo info = new SimInfo()
            {
                MaxChannels = 2,
                Ranges = new string[] { "1" },
            };
            SimulationInfo = info;

        }

        public override void ConfigChannel(int chID, double range)
        {
            if (simChList.Exists(x => x == chID))
            { }
            else
            {
                simChList.Add(chID);
            }
        }
        public override void ConfigChannel(object chObject)
        {
            SimInfo.ChannelConfig ch = (SimInfo.ChannelConfig)chObject;
            if (ch.EnableCh)
            {
                ConfigChannel(ch.ChNum, 1.0);
            }
            else
            {
                RemoveChannel(ch.ChNum);
            }

        }

        public override void RemoveChannel(int chID)
        {
            simChList.Remove(chID);
        }

        public override void ConfigTiming(double samplingRate, int samplesToRead)
        {
            _samplingRate = samplingRate;
            _samplesToRead = samplesToRead;

        }
        public override void Start()
        {
        }
        public override void Fetch(ref double[,] fetchData)
        {
            double[,] data = new double[_samplesToRead, simChList.Count];
            List<double[]> Data = new List<double[]>();
            for (int i = 0; i < simChList.Count; i++)
            {
                double[] simData = new double[_samplesToRead];
                double[] noise = new double[_samplesToRead];

                Generation.UniformWhiteNoise(ref noise, 0.03);

                if (i==0)
                {
                    Generation.SquareWave(ref simData, 1, 50, 10);
                }
                else
                {
                    Generation.SineWave(ref simData,1,0,10);
                }
                ArrayCalculation.Add(simData, noise, ref simData);
                Data.Add(simData);
            }

            for (int i = 0; i < Data.Count; i++)
            {
                ArrayManipulation.ReplaceArraySubset(Data.ElementAt(i), ref data, i, ArrayManipulation.IndexType.column);
            }


            fetchData = data;
        }
        public override void Stop()
        {
        }
        public override BindingList<object> GetChannelMap()
        {
            BindingList<object> list = new BindingList<object>();

            for (int i = 0; i < SimulationInfo.MaxChannels; i++)
            {
                SimInfo.ChannelConfig ch = new SimInfo.ChannelConfig();
                ch.ConfigureLUT("Range", SimulationInfo.Ranges);

                ch.EnableCh = false;
                ch.ChNum = i;
                ch.Range = SimulationInfo.Ranges[0];

                list.Add(ch);
            }
            return list;
        }

    }


}
