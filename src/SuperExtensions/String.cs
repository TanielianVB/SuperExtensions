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

        //string
        public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);
        public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);

        //Regex
        public static bool IsMatch(this string input, string pattern) => Regex.IsMatch(input, pattern);
        public static bool IsMatch(this string input, string pattern, RegexOptions options) => Regex.IsMatch(input, pattern, options);
        public static bool IsMatch(this string input, string pattern, RegexOptions options, TimeSpan matchTimeout) => Regex.IsMatch(input, pattern, options, matchTimeout);
        public static Match Match(this string input, string pattern) => Regex.Match(input, pattern);
        public static Match Match(this string input, string pattern, RegexOptions options) => Regex.Match(input, pattern, options);
        public static Match Match(this string input, string pattern, RegexOptions options, TimeSpan matchTimeout) => Regex.Match(input, pattern, options, matchTimeout);
        public static MatchCollection Matches(this string input, string pattern) => Regex.Matches(input, pattern);
        public static MatchCollection Matches(this string input, string pattern, RegexOptions options) => Regex.Matches(input, pattern, options);
        public static MatchCollection Matches(this string input, string pattern, RegexOptions options, TimeSpan matchTimeout) => Regex.Matches(input, pattern, options, matchTimeout);
        public static string Replace(this string input, string pattern, MatchEvaluator evaluator) => Regex.Replace(input, pattern, evaluator);
        public static string Replace(this string input, string pattern, string replacement) => Regex.Replace(input, pattern, replacement);
        public static string Replace(this string input, string pattern, MatchEvaluator evaluator, RegexOptions options) => Regex.Replace(input, pattern, evaluator, options);
        public static string Replace(this string input, string pattern, string replacement, RegexOptions options) => Regex.Replace(input, pattern, replacement, options);
        public static string Replace(this string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) => Regex.Replace(input, pattern, evaluator, options, matchTimeout);
        public static string Replace(this string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) => Regex.Replace(input, pattern, replacement, options, matchTimeout);
        public static string[] Split(this string input, string pattern) => Regex.Split(input, pattern);
        public static string[] Split(this string input, string pattern, RegexOptions options) => Regex.Split(input, pattern, options);
        public static string[] Split(this string input, string pattern, RegexOptions options, TimeSpan matchTimeout) => Regex.Split(input, pattern, options, matchTimeout);

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
    }
}
