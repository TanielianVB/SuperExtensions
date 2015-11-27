using System.Collections.Generic;
using System.Linq;

namespace SuperExtensions
{
    public static class GenericIEnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source) => source == null || !source.Any();
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> items) => items ?? Enumerable.Empty<T>();
        /// <summary>
        /// Concatenates the elements of an object array, using the specified separator between each element.
        /// </summary>
        /// <param name="separator">The string to use as a separator. separator is included in the returned string only if values has more than one element.</param>
        /// <param name="values">An array that contains the elements to concatenate.</param>
        /// <returns>A string that consists of the elements of values delimited by the separator string. If values is an empty array, the method returns System.String.Empty.</returns>
        /// <exception cref="System.ArgumentNullException">values is null. [ComVisible(false)]</exception>
        public static string Join<T>(this IEnumerable<T> values, string separator) => string.Join(separator, values);
        /// <summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.Collections.Generic.IEnumerable`1 according to specified key selector and element selector functions.
        /// </summary>
        /// <param name="source">An System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.Dictionary`2 from.</param>
        /// <returns>A System.Collections.Generic.Dictionary`2 that contains values of type TElement selected from the input sequence.</returns>
        /// <exception cref="System.ArgumentNullException">source or keySelector or elementSelector is null.-or-keySelector produces a key that is null.</exception>
        /// <exception cref="System.ArgumentException">keySelector produces duplicate keys for two elements.</exception>
        public static Dictionary<TKey, List<TElement>> ToDictionary<TKey, TElement>(this IEnumerable<IGrouping<TKey, TElement>> source) => source.ToDictionary(group => group.Key, group => group.ToList());
    }
}
