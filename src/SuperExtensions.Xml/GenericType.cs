using System.IO;
using System.Xml.Serialization;

namespace SuperExtensions
{
    public static class GenericTypeExtensions
    {
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