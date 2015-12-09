using System.Globalization;
using System.Threading;

namespace SuperExtensions
{
    public static class DecimalExtensions
    {
        #region Math

        public static string ToCurrency(this decimal value) => (string.Format(Thread.CurrentThread.CurrentCulture, "{0:C}", value));
        public static string ToCurrency(this decimal value, string cultureName) => (string.Format(new CultureInfo(cultureName), "{0:C}", value));

        #endregion
    }
}
