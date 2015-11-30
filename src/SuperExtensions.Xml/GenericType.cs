using System;
using System.IO;
using System.Xml.Serialization;

namespace SuperExtensions
{
    public static class GenericTypeExtensions
    {
        public static string ToXml<T>(this T obj) where T : class, new()
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj) + " is not allowed to be null");

            var serializer = new XmlSerializer(typeof(T));
            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);
                return writer.ToString();
            }
        }
    }
}