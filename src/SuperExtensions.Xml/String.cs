using System;
using System.IO;
using System.Xml.Serialization;

namespace SuperExtensions
{
    public static class StringExtensions
    {
        public static T FromXml<T>(this string xml) where T : class, new()
        {
            if (xml == null) throw new ArgumentNullException(nameof(xml) + " is not allowed to be null");

            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(xml))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}