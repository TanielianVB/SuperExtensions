using System.IO;
using System.Xml.Serialization;

namespace SuperExtensions
{
    public static class StringExtensions
    {
        public static string FormatWith(this string value, params object[] args) => string.Format(value, args);
        public static T FromXml<T>(this string xml) where T : class, new()
        {
            xml.ThrowIfArgumentIsNull(nameof(xml));

            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(xml))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
        public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);
        public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);
    }
}
