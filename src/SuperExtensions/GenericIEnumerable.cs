using System.Collections.Generic;

namespace SuperExtensions
{
    public static class GenericIEnumerableExtensions
    {
        public static string Join<T>(this IEnumerable<T> values, string separator) => string.Join(separator, values);
    }
}
