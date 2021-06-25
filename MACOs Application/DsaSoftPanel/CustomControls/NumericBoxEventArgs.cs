using System;

namespace CustomControls
{
    public class NumericBoxEventArgs : EventArgs
    {
        public double OriginalValue { get; set; }

        public double NewValue { get; set; }
    }
}