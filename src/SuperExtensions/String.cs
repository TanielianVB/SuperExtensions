using System;
using System.Text.RegularExpressions;

namespace SuperExtensions
{
    public static class StringExtensions
    {
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

        /// <summary>
        /// Indicates whether the specified regular expression finds a match in the specified input string.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <returns>true if the regular expression finds a match; otherwise, false.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input or pattern is null.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
        public static bool IsMatch(this string input, string pattern) => Regex.IsMatch(input, pattern);
        /// <summary>
        /// Indicates whether the specified regular expression finds a match in the specified input string, using the specified matching options.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>true if the regular expression finds a match; otherwise, false.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input or pattern is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">options is not a valid System.Text.RegularExpressions.RegexOptions value.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
        public static bool IsMatch(this string input, string pattern, RegexOptions options) => Regex.IsMatch(input, pattern, options);
        /// <summary>
        /// Indicates whether the specified regular expression finds a match in the specified input string, using the specified matching options and time-out interval.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <param name="matchTimeout">A time-out interval, or System.Text.RegularExpressions.Regex.InfiniteMatchTimeout to indicate that the method should not time out.</param>
        /// <returns>true if the regular expression finds a match; otherwise, false.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input or pattern is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">options is not a valid System.Text.RegularExpressions.RegexOptions value.-or-matchTimeout is negative, zero, or greater than approximately 24 days.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
        public static bool IsMatch(this string input, string pattern, RegexOptions options, TimeSpan matchTimeout) => Regex.IsMatch(input, pattern, options, matchTimeout);
        /// <summary>
        /// Searches the specified input string for the first occurrence of the specified regular expression.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <returns>An object that contains information about the match.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input or pattern is null.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
        public static Match Match(this string input, string pattern) => Regex.Match(input, pattern);
        /// <summary>
        /// Searches the input string for the first occurrence of the specified regular expression, using the specified matching options.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>An object that contains information about the match.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input or pattern is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">options is not a valid bitwise combination of System.Text.RegularExpressions.RegexOptions values.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
        public static Match Match(this string input, string pattern, RegexOptions options) => Regex.Match(input, pattern, options);
        /// <summary>
        /// Searches the input string for the first occurrence of the specified regular expression, using the specified matching options and time-out interval.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <param name="matchTimeout">A time-out interval, or System.Text.RegularExpressions.Regex.InfiniteMatchTimeout to indicate that the method should not time out.</param>
        /// <returns>An object that contains information about the match.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input or pattern is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">options is not a valid bitwise combination of System.Text.RegularExpressions.RegexOptions values.-or-matchTimeout is negative, zero, or greater than approximately 24 days.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
        public static Match Match(this string input, string pattern, RegexOptions options, TimeSpan matchTimeout) => Regex.Match(input, pattern, options, matchTimeout);
        /// <summary>
        /// Searches the specified input string for all occurrences of a specified regular expression.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <returns>A collection of the System.Text.RegularExpressions.Match objects found by the search. If no matches are found, the method returns an empty collection object.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input or pattern is null.</exception>
        public static MatchCollection Matches(this string input, string pattern) => Regex.Matches(input, pattern);
        /// <summary>
        /// Searches the specified input string for all occurrences of a specified regular expression, using the specified matching options.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
        /// <returns>A collection of the System.Text.RegularExpressions.Match objects found by the search. If no matches are found, the method returns an empty collection object.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input or pattern is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">options is not a valid bitwise combination of System.Text.RegularExpressions.RegexOptions values.</exception>
        public static MatchCollection Matches(this string input, string pattern, RegexOptions options) => Regex.Matches(input, pattern, options);
        /// <summary>
        /// Searches the specified input string for all occurrences of a specified regular expression, using the specified matching options and time-out interval.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
        /// <param name="matchTimeout">A time-out interval, or System.Text.RegularExpressions.Regex.InfiniteMatchTimeout to indicate that the method should not time out.</param>
        /// <returns>A collection of the System.Text.RegularExpressions.Match objects found by the search. If no matches are found, the method returns an empty collection object.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input or pattern is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">options is not a valid bitwise combination of System.Text.RegularExpressions.RegexOptions values.-or-matchTimeout is negative, zero, or greater than approximately 24 days.</exception>
        public static MatchCollection Matches(this string input, string pattern, RegexOptions options, TimeSpan matchTimeout) => Regex.Matches(input, pattern, options, matchTimeout);
        /// <summary>
        /// In a specified input string, replaces all strings that match a specified regular expression with a string returned by a System.Text.RegularExpressions.MatchEvaluator delegate.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="evaluator">A custom method that examines each match and returns either the original matched string or a replacement string.</param>
        /// <returns>A new string that is identical to the input string, except that a replacement string takes the place of each matched string. If pattern is not matched in the current instance, the method returns the current instance unchanged.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input, pattern, or evaluator is null.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
        public static string ReplacePattern(this string input, string pattern, MatchEvaluator evaluator) => Regex.Replace(input, pattern, evaluator);
        /// <summary>
        /// In a specified input string, replaces all strings that match a specified regular expression with a specified replacement string.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="replacement">The replacement string.</param>
        /// <returns>A new string that is identical to the input string, except that the replacement string takes the place of each matched string. If pattern is not matched in the current instance, the method returns the current instance unchanged.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input, pattern, or replacement is null.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
        public static string ReplacePattern(this string input, string pattern, string replacement) => Regex.Replace(input, pattern, replacement);
        /// <summary>
        /// In a specified input string, replaces all strings that match a specified regular expression with a string returned by a System.Text.RegularExpressions.MatchEvaluator delegate. Specified options modify the matching operation.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="evaluator">A custom method that examines each match and returns either the original matched string or a replacement string.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>A new string that is identical to the input string, except that a replacement string takes the place of each matched string. If pattern is not matched in the current instance, the method returns the current instance unchanged.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input, pattern, or evaluator is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">options is not a valid bitwise combination of System.Text.RegularExpressions.RegexOptions values.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section. </exception>
        public static string ReplacePattern(this string input, string pattern, MatchEvaluator evaluator, RegexOptions options) => Regex.Replace(input, pattern, evaluator, options);
        /// <summary>
        /// In a specified input string, replaces all strings that match a specified regular expression with a specified replacement string. Specified options modify the matching operation.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="replacement">The replacement string.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>A new string that is identical to the input string, except that the replacement string takes the place of each matched string. If pattern is not matched in the current instance, the method returns the current instance unchanged.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input, pattern, or replacement is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">options is not a valid bitwise combination of System.Text.RegularExpressions.RegexOptions values.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section. </exception>
        public static string ReplacePattern(this string input, string pattern, string replacement, RegexOptions options) => Regex.Replace(input, pattern, replacement, options);
        /// <summary>
        /// In a specified input string, replaces all substrings that match a specified regular expression with a string returned by a System.Text.RegularExpressions.MatchEvaluator delegate. Additional parameters specify options that modify the matching operation and a time-out interval if no match is found.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="evaluator">A custom method that examines each match and returns either the original matched string or a replacement string.</param>
        /// <param name="options">A bitwise combination of enumeration values that provide options for matching.</param>
        /// <param name="matchTimeout">A time-out interval, or System.Text.RegularExpressions.Regex.InfiniteMatchTimeout to indicate that the method should not time out.</param>
        /// <returns>A new string that is identical to the input string, except that the replacement string takes the place of each matched string. If pattern is not matched in the current instance, the method returns the current instance unchanged.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input, pattern, or evaluator is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">options is not a valid bitwise combination of System.Text.RegularExpressions.RegexOptions values.-or-matchTimeout is negative, zero, or greater than approximately 24 days.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section. </exception>
        public static string ReplacePattern(this string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) => Regex.Replace(input, pattern, evaluator, options, matchTimeout);
        /// <summary>
        /// In a specified input string, replaces all strings that match a specified regular expression with a specified replacement string. Additional parameters specify options that modify the matching operation and a time-out interval if no match is found.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="replacement">The replacement string.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <param name="matchTimeout">A time-out interval, or System.Text.RegularExpressions.Regex.InfiniteMatchTimeout to indicate that the method should not time out.</param>
        /// <returns>A new string that is identical to the input string, except that the replacement string takes the place of each matched string. If pattern is not matched in the current instance, the method returns the current instance unchanged.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input, pattern, or replacement is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">options is not a valid bitwise combination of System.Text.RegularExpressions.RegexOptions values.-or-matchTimeout is negative, zero, or greater than approximately 24 days.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section. </exception>
        public static string ReplacePattern(this string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) => Regex.Replace(input, pattern, replacement, options, matchTimeout);
        /// <summary>
        /// Splits an input string into an array of substrings at the positions defined by a regular expression pattern.
        /// </summary>
        /// <param name="input">The string to split.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <returns>An array of strings.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input or pattern is null.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section. </exception>
        public static string[] Split(this string input, string pattern) => Regex.Split(input, pattern);
        /// <summary>
        /// Splits an input string into an array of substrings at the positions defined by a specified regular expression pattern. Specified options modify the matching operation.
        /// </summary>
        /// <param name="input">The string to split.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>An array of strings.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input or pattern is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">options is not a valid bitwise combination of System.Text.RegularExpressions.RegexOptions values.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section. </exception>
        public static string[] Split(this string input, string pattern, RegexOptions options) => Regex.Split(input, pattern, options);
        /// <summary>
        /// Splits an input string into an array of substrings at the positions defined by a specified regular expression pattern. Additional parameters specify options that modify the matching operation and a time-out interval if no match is found.
        /// </summary>
        /// <param name="input">The string to split.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <param name="matchTimeout">A time-out interval, or System.Text.RegularExpressions.Regex.InfiniteMatchTimeout to indicate that the method should not time out.</param>
        /// <returns>A string array.</returns>
        /// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="System.ArgumentNullException">input or pattern is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">options is not a valid bitwise combination of System.Text.RegularExpressions.RegexOptions values.-or-matchTimeout is negative, zero, or greater than approximately 24 days.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section. </exception>
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
