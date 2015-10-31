using System;
using System.Collections.Generic;

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

        public static DateTime January(this int day, int year) => new DateTime(year, 1, day);
        public static DateTime February(this int day, int year) => new DateTime(year, 2, day);
        public static DateTime March(this int day, int year) => new DateTime(year, 3, day);
        public static DateTime April(this int day, int year) => new DateTime(year, 4, day);
        public static DateTime May(this int day, int year) => new DateTime(year, 5, day);
        public static DateTime June(this int day, int year) => new DateTime(year, 6, day);
        public static DateTime July(this int day, int year) => new DateTime(year, 7, day);
        public static DateTime August(this int day, int year) => new DateTime(year, 8, day);
        public static DateTime September(this int day, int year) => new DateTime(year, 9, day);
        public static DateTime October(this int day, int year) => new DateTime(year, 10, day);
        public static DateTime November(this int day, int year) => new DateTime(year, 11, day);
        public static DateTime December(this int day, int year) => new DateTime(year, 12, day);

        public static TimeSpan Ticks(this int ticks) => TimeSpan.FromTicks(ticks);
        public static TimeSpan Milliseconds(this int milliseconds) => TimeSpan.FromMilliseconds(milliseconds);
        public static TimeSpan Seconds(this int seconds) => TimeSpan.FromSeconds(seconds);
        public static TimeSpan Minutes(this int minutes) => TimeSpan.FromMinutes(minutes);
        public static TimeSpan Hours(this int hours) => TimeSpan.FromHours(hours);
        public static TimeSpan Days(this int days) => TimeSpan.FromDays(days);

        public static IEnumerable<int> Range(this int n)
        {
            for (int i = 0; i < n; i++)
                yield return i;
        }
    }
}
