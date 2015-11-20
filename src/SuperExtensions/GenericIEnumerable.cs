using System.Collections.Generic;
using System.Linq;

namespace SuperExtensions
{
    public static class GenericIEnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source) => source == null || !source.Any();
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> items) => items ?? Enumerable.Empty<T>();
        public static string Join<T>(this IEnumerable<T> values, string separator) => string.Join(separator, values);
        public static Dictionary<TKey, List<TElement>> ToDictionary<TKey, TElement>(this IEnumerable<IGrouping<TKey, TElement>> source) => source.ToDictionary(group => group.Key, group => group.ToList());
    }
}
