using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MACOs.JY.SoftFrontPanel
{
    public interface IDigitizer
    {
        DigitizerInfo DigitizerInformation { get; set; }
    }
}