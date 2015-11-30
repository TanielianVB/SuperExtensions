using System;
using System.Linq;

namespace SuperExtensions
{
    public static class GenericTypeExtensions
    {
        public static bool IsAny<T>(this T item, params T[] items) => items.Contains(item);
        public static bool IsBetween<T>(this T actual, T lower, T upper) where T : IComparable<T> => actual.CompareTo(lower) >= 0 && actual.CompareTo(upper) <= 0;
        public static bool IsNullOrDefault<T>(this T? nullable) where T : struct => nullable == null || nullable.Value.Equals(default(T));

        public static void ThrowIfArgumentIsNull<T>(this T argument, string argumentName) where T : class
        {
            if (argument == null) throw new ArgumentNullException(argumentName + " is not allowed to be null");
        }
    }
}
