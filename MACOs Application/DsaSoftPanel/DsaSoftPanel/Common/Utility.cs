namespace DsaSoftPanel.Common
{
    public static class Utility
    {
        public static string GetShowValue(double value)
        {
            return !double.IsNaN(value) ? value.ToString(Constants.NumericFormat) : Constants.NotAvailable;
        }

    }
}