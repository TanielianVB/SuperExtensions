using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace SuperExtensions
{
    public static class GenericTypeExtensions
    {
        public static bool IsBetween<T>(this T actual, T lower, T upper) where T : IComparable<T> => actual.CompareTo(lower) >= 0 && actual.CompareTo(upper) <= 0;
        public static bool IsIn<T>(this T item, params T[] items) => items.Contains(item);
        public static void ThrowIfArgumentIsNull<T>(this T argument, string argumentName) where T : class
        {
            if (argument == null) throw new ArgumentNullException(argumentName + " not allowed to be null");
        }
        public static string ToXml<T>(this T obj) where T : class, new()
        {
            obj.ThrowIfArgumentIsNull(nameof(obj));

            var serializer = new XmlSerializer(typeof(T));
            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);
                return writer.ToString();
            }
        }
    }
}
