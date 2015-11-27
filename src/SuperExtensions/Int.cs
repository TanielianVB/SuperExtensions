using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperExtensions
{
    public static class IntExtensions
    {
        public static int Pow(this int x, int y) => Math.Pow(x, y).ChangeType<int>();
        public static int PercentageOf(this int part, int total) => (part * 100) / total;

        public static int K(this int value) => value * 1000;
        public static int M(this int value) => value * 1000.Pow(2);
        public static int G(this int value) => value * 1000.Pow(3);
        public static int T(this int value) => value * 1000.Pow(4);

        public static int KiB(this int value) => value * 1024;
        public static int MiB(this int value) => value * 1024.Pow(2);

        //DateTime

        /// <summary>
        /// Initializes a new instance of the System.DateTime structure to the specified year, month 1, and day.
        /// </summary>
        /// <param name="year">The year (1 through 9999).</param>
        /// <param name="day">The day (1 through the number of days in month).</param>
        /// <exception cref="System.ArgumentOutOfRangeException">year is less than 1 or greater than 9999.-or- day is less than 1 or greater than the number of days in month.</exception>
        public static DateTime January(this int day, int year) => new DateTime(year, 1, day);
        /// <summary>
        /// Initializes a new instance of the System.DateTime structure to the specified year, month 2, and day.
        /// </summary>
        /// <param name="year">The year (1 through 9999).</param>
        /// <param name="day">The day (1 through the number of days in month).</param>
        /// <exception cref="System.ArgumentOutOfRangeException">year is less than 1 or greater than 9999.-or- day is less than 1 or greater than the number of days in month.</exception>
        public static DateTime February(this int day, int year) => new DateTime(year, 2, day);
        /// <summary>
        /// Initializes a new instance of the System.DateTime structure to the specified year, month 3, and day.
        /// </summary>
        /// <param name="year">The year (1 through 9999).</param>
        /// <param name="day">The day (1 through the number of days in month).</param>
        /// <exception cref="System.ArgumentOutOfRangeException">year is less than 1 or greater than 9999.-or- day is less than 1 or greater than the number of days in month.</exception>
        public static DateTime March(this int day, int year) => new DateTime(year, 3, day);
        /// <summary>
        /// Initializes a new instance of the System.DateTime structure to the specified year, month 4, and day.
        /// </summary>
        /// <param name="year">The year (1 through 9999).</param>
        /// <param name="day">The day (1 through the number of days in month).</param>
        /// <exception cref="System.ArgumentOutOfRangeException">year is less than 1 or greater than 9999.-or- day is less than 1 or greater than the number of days in month.</exception>
        public static DateTime April(this int day, int year) => new DateTime(year, 4, day);
        /// <summary>
        /// Initializes a new instance of the System.DateTime structure to the specified year, month 5, and day.
        /// </summary>
        /// <param name="year">The year (1 through 9999).</param>
        /// <param name="day">The day (1 through the number of days in month).</param>
        /// <exception cref="System.ArgumentOutOfRangeException">year is less than 1 or greater than 9999.-or- day is less than 1 or greater than the number of days in month.</exception>
        public static DateTime May(this int day, int year) => new DateTime(year, 5, day);
        /// <summary>
        /// Initializes a new instance of the System.DateTime structure to the specified year, month 6, and day.
        /// </summary>
        /// <param name="year">The year (1 through 9999).</param>
        /// <param name="day">The day (1 through the number of days in month).</param>
        /// <exception cref="System.ArgumentOutOfRangeException">year is less than 1 or greater than 9999.-or- day is less than 1 or greater than the number of days in month.</exception>
        public static DateTime June(this int day, int year) => new DateTime(year, 6, day);
        /// <summary>
        /// Initializes a new instance of the System.DateTime structure to the specified year, month 7, and day.
        /// </summary>
        /// <param name="year">The year (1 through 9999).</param>
        /// <param name="day">The day (1 through the number of days in month).</param>
        /// <exception cref="System.ArgumentOutOfRangeException">year is less than 1 or greater than 9999.-or- day is less than 1 or greater than the number of days in month.</exception>
        public static DateTime July(this int day, int year) => new DateTime(year, 7, day);
        /// <summary>
        /// Initializes a new instance of the System.DateTime structure to the specified year, month 8, and day.
        /// </summary>
        /// <param name="year">The year (1 through 9999).</param>
        /// <param name="day">The day (1 through the number of days in month).</param>
        /// <exception cref="System.ArgumentOutOfRangeException">year is less than 1 or greater than 9999.-or- day is less than 1 or greater than the number of days in month.</exception>
        public static DateTime August(this int day, int year) => new DateTime(year, 8, day);
        /// <summary>
        /// Initializes a new instance of the System.DateTime structure to the specified year, month 9, and day.
        /// </summary>
        /// <param name="year">The year (1 through 9999).</param>
        /// <param name="day">The day (1 through the number of days in month).</param>
        /// <exception cref="System.ArgumentOutOfRangeException">year is less than 1 or greater than 9999.-or- day is less than 1 or greater than the number of days in month.</exception>
        public static DateTime September(this int day, int year) => new DateTime(year, 9, day);
        /// <summary>
        /// Initializes a new instance of the System.DateTime structure to the specified year, month 10, and day.
        /// </summary>
        /// <param name="year">The year (1 through 9999).</param>
        /// <param name="day">The day (1 through the number of days in month).</param>
        /// <exception cref="System.ArgumentOutOfRangeException">year is less than 1 or greater than 9999.-or- day is less than 1 or greater than the number of days in month.</exception>
        public static DateTime October(this int day, int year) => new DateTime(year, 10, day);
        /// <summary>
        /// Initializes a new instance of the System.DateTime structure to the specified year, month 11, and day.
        /// </summary>
        /// <param name="year">The year (1 through 9999).</param>
        /// <param name="day">The day (1 through the number of days in month).</param>
        /// <exception cref="System.ArgumentOutOfRangeException">year is less than 1 or greater than 9999.-or- day is less than 1 or greater than the number of days in month.</exception>
        public static DateTime November(this int day, int year) => new DateTime(year, 11, day);
        /// <summary>
        /// Initializes a new instance of the System.DateTime structure to the specified year, month 12, and day.
        /// </summary>
        /// <param name="year">The year (1 through 9999).</param>
        /// <param name="day">The day (1 through the number of days in month).</param>
        /// <exception cref="System.ArgumentOutOfRangeException">year is less than 1 or greater than 9999.-or- day is less than 1 or greater than the number of days in month.</exception>
        public static DateTime December(this int day, int year) => new DateTime(year, 12, day);

        //TimeSpan

        /// <summary>
        /// Returns a System.TimeSpan that represents a specified time, where the specification is in units of ticks.
        /// </summary>
        /// <param name="value">A number of ticks that represent a time.</param>
        /// <returns>An object that represents value.</returns>
        public static TimeSpan Ticks(this int value) => TimeSpan.FromTicks(value);
        /// <summary>
        /// Returns a System.TimeSpan that represents a specified number of milliseconds.
        /// </summary>
        /// <param name="value">A number of milliseconds.</param>
        /// <returns>An object that represents value.</returns>
        /// <exception cref="System.OverflowException">value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.-or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.</exception>
        /// <exception cref="System.ArgumentException">value is equal to System.Double.NaN.</exception>
        public static TimeSpan Milliseconds(this int value) => TimeSpan.FromMilliseconds(value);
        /// <summary>
        /// Returns a System.TimeSpan that represents a specified number of seconds, where the specification is accurate to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of seconds, accurate to the nearest millisecond.</param>
        /// <returns>An object that represents value.</returns>
        /// <exception cref="System.OverflowException">value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.-or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.</exception>
        /// <exception cref="System.ArgumentException">value is equal to System.Double.NaN.</exception>
        public static TimeSpan Seconds(this int value) => TimeSpan.FromSeconds(value);
        /// <summary>
        /// Returns a System.TimeSpan that represents a specified number of minutes, where the specification is accurate to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of minutes, accurate to the nearest millisecond.</param>
        /// <returns>An object that represents value.</returns>
        /// <exception cref="System.OverflowException">value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.-or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.</exception>
        /// <exception cref="System.ArgumentException">value is equal to System.Double.NaN.</exception>
        public static TimeSpan Minutes(this int value) => TimeSpan.FromMinutes(value);
        /// <summary>
        /// Returns a System.TimeSpan that represents a specified number of hours, where the specification is accurate to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of hours accurate to the nearest millisecond.</param>
        /// <returns>An object that represents value.</returns>
        /// <exception cref="System.OverflowException">value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue. -or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.</exception>
        /// <exception cref="System.ArgumentException">value is equal to System.Double.NaN.</exception>
        public static TimeSpan Hours(this int value) => TimeSpan.FromHours(value);
        /// <summary>
        /// Returns a System.TimeSpan that represents a specified number of days, where the specification is accurate to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of days, accurate to the nearest millisecond.</param>
        /// <returns>An object that represents value.</returns>
        /// <exception cref="System.OverflowException">value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue. -or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.</exception>
        /// <exception cref="System.ArgumentException">value is equal to System.Double.NaN.</exception>
        public static TimeSpan Days(this int value) => TimeSpan.FromDays(value);

        //Enumerable

        /// <summary>
        /// Generates a sequence of integral numbers within a specified range.
        /// </summary>
        /// <param name="start">The value of the first integer in the sequence.</param>
        /// <param name="count">The number of sequential integers to generate.</param>
        /// <returns>An IEnumerable&lt;Int32&gt; in C# or IEnumerable(Of Int32) in Visual Basic that contains a range of sequential integral numbers.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">count is less than 0.-or-start + count -1 is larger than System.Int32.MaxValue.</exception>
        public static IEnumerable<int> Range(this int start, int count) => Enumerable.Range(start, count);
    }
}
