using System;
using System.Collections.Generic;
using DsaSoftPanel.Enumeration;

namespace DsaSoftPanel
{
    public class ChannelConfig
    {
        public int ChannelId { get; set; }
        public Coupling Coupling { get; set; }
        public bool Enabled { get; set; }
        public Probe Probe { get; set; }
        public UnitType Unit { get; set; }
        public double Range { get; set; }

        public string ChannelName => $"CH{ChannelId + 1}";

        public ChannelConfig()
        {
            this.ChannelId = 0;
            this.Coupling = Coupling.DC;
            this.Enabled = false;
            this.Probe = Probe.X1;
            this.Unit = UnitType.V;
            this.Range = 10;
        }

        public ChannelConfig(int channelId)
        {
            this.ChannelId = channelId;
            this.Coupling = Coupling.DC;
            this.Enabled = false;
            this.Probe = Probe.X1;
            this.Unit = UnitType.V;
            this.Range = 10;
        } 

        public bool Eqauls(ChannelConfig cmpObj)
        {
            return !NeedRefreshView(cmpObj) && !NeedRestartTask(cmpObj);
        }

        public bool NeedRefreshView(ChannelConfig cmpObj)
        {
            return Enabled != cmpObj.Enabled || Unit != cmpObj.Unit;
        }

        public bool NeedRestartTask(ChannelConfig cmpObj)
        {
            return Coupling != cmpObj.Coupling || Probe != cmpObj.Probe ||
                Enabled != cmpObj.Enabled || Math.Abs(Range - cmpObj.Range) > Constants.MinDoubleValue;
        }

        public void Clone(ChannelConfig dstObj)
        {
            dstObj.ChannelId = this.ChannelId;
            dstObj.Coupling = this.Coupling;
            dstObj.Enabled = this.Enabled;
            dstObj.Probe = this.Probe;
            dstObj.Unit = this.Unit;
        }
    }
}