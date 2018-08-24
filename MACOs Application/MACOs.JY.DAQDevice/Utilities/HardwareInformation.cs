using SeeSharpTools.JY.File;
using System;
using System.Collections;
using System.Linq;

namespace MACOs.JY.DAQDevice.Utilities
{
    public static class Utility
    {
        public static HardwareInformation GetHardwareInfo(string infoFilePath, string hwName)
        {
            var data = IniHandler.ReadIniFile(infoFilePath);
            var section = data.Sections.ToList().Find(x => x.SectionName == hwName);
            HardwareInformation info = new HardwareInformation();
            info.MaxChannel = int.Parse(data[hwName]["MaxChannel"]);
            info.MaxSampleRate = double.Parse(data[hwName]["MaxSampleRate"]);
            info.Coupling = data[hwName]["Coupling"].Split(',');
            info.Terminal = data[hwName]["Terminal"].Split(',');
            info.Ranges = data[hwName]["Ranges"].Split(',').ToList().ConvertAll(new Converter<string, double>(x => double.Parse(x))).ToArray();
            info.IsSimultaneous = bool.Parse(data[hwName]["IsSimultaneous"]);
            info.SupportDifferential = bool.Parse(data[hwName]["SupportDifferential"]);
            return info;
        }

        public static object TypeCast(object parameter, Type prototype)
        {
            string param = parameter.ToString().Trim();
            if (prototype.IsEnum)
            {
                Array arr = prototype.GetEnumValues();
                int index = prototype.GetEnumNames().ToList().FindIndex(x => x == param);
                return arr.GetValue(index);
            }
            else if (prototype.IsValueType)
            {
                switch (prototype.Name)
                {
                    case "Int32":
                        return Int32.Parse(param);

                    case "Double":
                        return Double.Parse(param);

                    case "UInt32":
                        return UInt32.Parse(param);

                    case "Single":
                        return float.Parse(param);

                    case "Boolean":
                        return Boolean.Parse(param.ToLower());

                    default:
                        return null;
                }
            }
            else
            {
                return null;
            }
        }

    }
    public class ChannelMap
    {
        public IList ChannelList { get; set; }

        public string[] PropertyOrders { get; set; }
    }
    public struct HardwareInformation
    {
        public int MaxChannel;
        public double MaxSampleRate;
        public string[] Coupling;
        public string[] Terminal;
        public string[] Impedance;
        public double[] Ranges;
        public bool IsSimultaneous;
        public bool SupportDifferential;
    }
}