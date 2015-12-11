using Newtonsoft.Json;

namespace SuperExtensions
{
    public static class GenericTypeExtensions
    {
        /// <summary>
        /// Serializes the specified object and writes the Json document to a string.
        /// </summary>
        /// <typeparam name="T">The type of the object that will be serialized.</typeparam>
        /// <param name="obj">Object that will be serialized.</param>
        /// <returns>Json representation of the object contained in a string.</returns>
        public static string ToJson<T>(this T obj) where T : class, new()
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
