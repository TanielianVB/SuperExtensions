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
    }
}
