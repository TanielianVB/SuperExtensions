using System;
using System.IO;
using System.Xml.Serialization;

namespace SuperExtensions
{
    public static class GenericTypeExtensions
    {
        /// <summary>
        /// Serializes the specified object and writes the XML document to a string.
        /// </summary>
        /// <typeparam name="T">The type of the object that will be serialized.</typeparam>
        /// <param name="obj">Object that will be serialized.</param>
        /// <returns>XML representation of the object contained in a string.</returns>
        public static string ToXml<T>(this T obj) where T : new()
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