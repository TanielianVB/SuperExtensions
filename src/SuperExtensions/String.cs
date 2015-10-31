using System;
using System.IO;
using System.Text.RegularExpressions;
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
        public static bool IsLike(this string input, string wildcardPattern)
        {
            if (input == null || wildcardPattern.IsNullOrEmpty()) return false;

            // turn into regex pattern, and match the whole string with ^$
            var regexPattern = $"^{Regex.Escape(wildcardPattern)}$";
            // add support for ?, #, *, [], and [!]
            regexPattern = regexPattern.Replace(@"\[!", "[^").Replace(@"\[", "[").Replace(@"\]", "]").Replace(@"\?", ".").Replace(@"\*", ".*").Replace(@"\#", @"\d");

            var result = false;
            try
            {
                result = Regex.IsMatch(input, regexPattern);
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException($"Invalid pattern: {wildcardPattern}", ex);
            }
            return result;
        }
        public static bool IsMatch(this string input, string pattern) => Regex.IsMatch(input, pattern);
        public static MatchCollection Matches(this string input, string pattern) => Regex.Matches(input, pattern);
        public static MatchCollection Matches(this string input, string pattern, RegexOptions options) => Regex.Matches(input, pattern, options);
        public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);
        public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);
    }
}
