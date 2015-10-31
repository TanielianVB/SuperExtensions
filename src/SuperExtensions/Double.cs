using System;
using System.Globalization;
using System.Threading;

namespace SuperExtensions
{
    public static class DoubleExtensions
    {
        public static double Pow(this double x, double y) => Math.Pow(x, y);

        public static string ToCurrency(this double value) => (string.Format(Thread.CurrentThread.CurrentCulture, "{0:C}", value));
        public static string ToCurrency(this double value, string cultureName) => (string.Format(new CultureInfo(cultureName), "{0:C}", value));

        public static TimeSpan Milliseconds(this double milliseconds) => TimeSpan.FromMilliseconds(milliseconds);
        public static TimeSpan Seconds(this double seconds) => TimeSpan.FromSeconds(seconds);
        public static TimeSpan Minutes(this double minutes) => TimeSpan.FromMinutes(minutes);
        public static TimeSpan Hours(this double hours) => TimeSpan.FromHours(hours);
        public static TimeSpan Days(this double days) => TimeSpan.FromDays(days);
    }
}
