using System;
using System.Globalization;
using System.Threading;

namespace SuperExtensions
{
    public static class DoubleExtensions
    {
        /// <summary>
        /// Returns a specified number raised to the specified power.
        /// </summary>
        /// <param name="x">A double-precision floating-point number to be raised to a power.</param>
        /// <param name="y">A double-precision floating-point number that specifies a power.</param>
        /// <returns>The number x raised to the power y.</returns>
        public static double Pow(this double x, double y) => Math.Pow(x, y);
        public static double PercentageOf(this double part, double total) => (part * 100) / total;

        public static string ToCurrency(this double value) => (string.Format(Thread.CurrentThread.CurrentCulture, "{0:C}", value));
        public static string ToCurrency(this double value, string cultureName) => (string.Format(new CultureInfo(cultureName), "{0:C}", value));

        //TimeSpan

        /// <summary>
        /// Returns a System.TimeSpan that represents a specified number of milliseconds.
        /// </summary>
        /// <param name="value">A number of milliseconds.</param>
        /// <returns>An object that represents value.</returns>
        /// <exception cref="System.OverflowException">value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.-or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.</exception>
        /// <exception cref="System.ArgumentException">value is equal to System.Double.NaN.</exception>
        public static TimeSpan Milliseconds(this double value) => TimeSpan.FromMilliseconds(value);
        /// <summary>
        /// Returns a System.TimeSpan that represents a specified number of seconds, where the specification is accurate to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of seconds, accurate to the nearest millisecond.</param>
        /// <returns>An object that represents value.</returns>
        /// <exception cref="System.OverflowException">value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.-or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.</exception>
        /// <exception cref="System.ArgumentException">value is equal to System.Double.NaN.</exception>
        public static TimeSpan Seconds(this double value) => TimeSpan.FromSeconds(value);
        /// <summary>
        /// Returns a System.TimeSpan that represents a specified number of minutes, where the specification is accurate to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of minutes, accurate to the nearest millisecond.</param>
        /// <returns>An object that represents value.</returns>
        /// <exception cref="System.OverflowException">value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.-or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.</exception>
        /// <exception cref="System.ArgumentException">value is equal to System.Double.NaN.</exception>
        public static TimeSpan Minutes(this double value) => TimeSpan.FromMinutes(value);
        /// <summary>
        /// Returns a System.TimeSpan that represents a specified number of hours, where the specification is accurate to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of hours accurate to the nearest millisecond.</param>
        /// <returns>An object that represents value.</returns>
        /// <exception cref="System.OverflowException">value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue. -or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.</exception>
        /// <exception cref="System.ArgumentException">value is equal to System.Double.NaN.</exception>
        public static TimeSpan Hours(this double value) => TimeSpan.FromHours(value);
        /// <summary>
        /// Returns a System.TimeSpan that represents a specified number of days, where the specification is accurate to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of days, accurate to the nearest millisecond.</param>
        /// <returns>An object that represents value.</returns>
        /// <exception cref="System.OverflowException">value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue. -or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.</exception>
        /// <exception cref="System.ArgumentException">value is equal to System.Double.NaN.</exception>
        public static TimeSpan Days(this double value) => TimeSpan.FromDays(value);
    }
}
