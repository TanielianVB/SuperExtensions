﻿using System.Collections.Generic;
using System.Linq;

namespace SuperExtensions
{
    public static class GenericIEnumerableExtensions
    {
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> items) => items ?? Enumerable.Empty<T>();
        public static string Join<T>(this IEnumerable<T> values, string separator) => string.Join(separator, values);
    }
}
