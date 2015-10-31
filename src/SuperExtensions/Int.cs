using System;

namespace SuperExtensions
{
    public static class IntExtensions
    {
        public static int Pow(this int x, int y) => Math.Pow(x, y).ToInt();

        public static int K(this int value) => value * 1000;
        public static int M(this int value) => value * 1000.Pow(2);
        public static int G(this int value) => value * 1000.Pow(3);
        public static int T(this int value) => value * 1000.Pow(4);

        public static int KiB(this int value) => value * 1024;
        public static int MiB(this int value) => value * 1024.Pow(2);

        public static TimeSpan Milliseconds(this int milliseconds) => TimeSpan.FromMilliseconds(milliseconds);
        public static TimeSpan Seconds(this int seconds) => TimeSpan.FromSeconds(seconds);
        public static TimeSpan Minutes(this int minutes) => TimeSpan.FromMinutes(minutes);
        public static TimeSpan Hours(this int hours) => TimeSpan.FromHours(hours);
        public static TimeSpan Days(this int days) => TimeSpan.FromDays(days);
    }
}
