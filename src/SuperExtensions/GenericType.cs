using System;
using System.Linq;

namespace SuperExtensions
{
    public static class GenericTypeExtensions
    {
        public static bool IsIn<T>(this T item, params T[] items) => items.Contains(item);
        public static bool IsBetween<T>(this T actual, T lower, T upper) where T : IComparable<T> => actual.CompareTo(lower) >= 0 && actual.CompareTo(upper) <= 0;
    }
}
