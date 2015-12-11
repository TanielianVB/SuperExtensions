using Newtonsoft.Json;

namespace SuperExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Deserializes the Json contained in the string.
        /// </summary>
        /// <typeparam name="T">The type of the object that this json string represents.</typeparam>
        /// <param name="json">Json string.</param>
        /// <returns>Object contained in the Json string.</returns>
        public static T FromJson<T>(this string json) where T : class, new()
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
