using System.Text;

namespace DsaSoftPanel.Common
{
    public static class Utility
    {
        public static string GetShowValue(double value, int valueIndex)
        {
            return GetShowValue(!double.IsNaN(value) ? value.ToString(Constants.NumericFormat) : Constants.NotAvailable,
                valueIndex);
        }

        public static string GetShowValue(string value, int valueIndex)
        {
            const int defaultValueLength = 15;
            StringBuilder builder = new StringBuilder(defaultValueLength);
            builder.Append(value);
            int valueLength = builder.Length;
            int alignedLength = defaultValueLength;
            while (alignedLength - valueLength < 2)
            {
                alignedLength += defaultValueLength;
            }
            for (int i = valueLength; i < alignedLength; i++)
            {
                builder.Insert(0, ' ');
            }
            return builder.ToString();
        }

        public static string GetShowValue(double value)
        {
            return !double.IsNaN(value) ? value.ToString(Constants.NumericFormat) : Constants.NotAvailable;
        }
    }
}