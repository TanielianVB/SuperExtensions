using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace SuperExtensions
{
    public static class StringExtensions
    {
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

        /// <summary>
        /// Replaces one or more format items in a specified string with the string representation of a specified object.
        /// </summary>
        /// <param name="value">A composite format string.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <returns>A copy of format in which the format items have been replaced by the string representation of the corresponding objects in args.</returns>
        /// <exception cref="System.ArgumentNullException">format or args is null.</exception>
        /// <exception cref="System.FormatException">format is invalid.-or- The index of a format item is less than zero, or greater than or equal to the length of the args array.</exception>
        public static string FormatWith(this string value, params object[] args) => string.Format(value, args);
        /// <summary>
        /// Indicates whether the specified string is null or an System.String.Empty string.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or an empty string (""); otherwise, false.</returns>
        public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);
        /// <summary>
        /// Indicates whether a specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or System.String.Empty, or if value consists exclusively of white-space characters.</returns>
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
