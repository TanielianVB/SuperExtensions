using System;

namespace SuperExtensions
{
    public static class IConvertibleExtensions
    {
        public static T ChangeType<T>(this IConvertible obj) => (T)Convert.ChangeType(obj, typeof(T));
        public static T ChangeType<T>(this IConvertible obj, IFormatProvider provider) => (T)Convert.ChangeType(obj, typeof(T), provider);
    }
}
