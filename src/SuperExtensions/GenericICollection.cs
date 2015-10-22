using System.Collections.Generic;

namespace SuperExtensions
{
    public static class GenericICollectionExtensions
    {
        public static void AddRange<T, S>(this ICollection<T> collection, params S[] values) where S : T
        {
            foreach (S value in values) collection.Add(value);
        }
    }
}