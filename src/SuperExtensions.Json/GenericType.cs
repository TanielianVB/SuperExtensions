using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SuperExtensions
{
    public static class GenericTypeExtensions
    {
        /// <summary>
        /// Serializes the specified object to a JSON string.
        /// </summary>
        /// <typeparam name="T">The type of the object that will be serialized.</typeparam>
        /// <param name="value">The object to serialize.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJson<T>(this T value) => JsonConvert.SerializeObject(value);
        /// <summary>
        /// Serializes the specified object to a JSON string using a collection of Newtonsoft.Json.JsonConverter.
        /// </summary>
        /// <typeparam name="T">The type of the object that will be serialized.</typeparam>
        /// <param name="value">The object to serialize.</param>
        /// <param name="converters">A collection converters used while serializing.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJson<T>(this T value, params JsonConverter[] converters) => JsonConvert.SerializeObject(value, converters);
        /// <summary>
        /// Serializes the specified object to a JSON string using Newtonsoft.Json.JsonSerializerSettings.
        /// </summary>
        /// <typeparam name="T">The type of the object that will be serialized.</typeparam>
        /// <param name="value">The object to serialize.</param>
        /// <param name="settings">The Newtonsoft.Json.JsonSerializerSettings used to serialize the object. If this is null, default serialization settings will be used.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJson<T>(this T value, JsonSerializerSettings settings) => JsonConvert.SerializeObject(value, settings);
        /// <summary>
        /// Serializes the specified object to a JSON string using formatting.
        /// </summary>
        /// <typeparam name="T">The type of the object that will be serialized.</typeparam>
        /// <param name="value">The object to serialize.</param>
        /// <param name="formatting">Indicates how the output is formatted.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJson<T>(this T value, Formatting formatting) => JsonConvert.SerializeObject(value, formatting);
        /// <summary>
        /// Serializes the specified object to a JSON string using formatting and a collection of Newtonsoft.Json.JsonConverter.
        /// </summary>
        /// <typeparam name="T">The type of the object that will be serialized.</typeparam>
        /// <param name="value">The object to serialize.</param>
        /// <param name="formatting">Indicates how the output is formatted.</param>
        /// <param name="converters">A collection converters used while serializing.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJson<T>(this T value, Formatting formatting, params JsonConverter[] converters) => JsonConvert.SerializeObject(value, formatting, converters);
        /// <summary>
        /// Serializes the specified object to a JSON string using a type, formatting and Newtonsoft.Json.JsonSerializerSettings.
        /// </summary>
        /// <typeparam name="T">The type of the object that will be serialized.</typeparam>
        /// <param name="value">The object to serialize.</param>
        /// <param name="settings">The Newtonsoft.Json.JsonSerializerSettings used to serialize the object. If this is null, default serialization settings will be used.</param>
        /// <param name="type">The type of the value being serialized. This parameter is used when Newtonsoft.Json.TypeNameHandling is Auto to write out the type name if the type of the value does not match. Specifing the type is optional.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJson<T>(this T value, Type type, JsonSerializerSettings settings) => JsonConvert.SerializeObject(value, type, settings);
        /// <summary>
        /// Serializes the specified object to a JSON string using formatting and Newtonsoft.Json.JsonSerializerSettings.
        /// </summary>
        /// <typeparam name="T">The type of the object that will be serialized.</typeparam>
        /// <param name="value">The object to serialize.</param>
        /// <param name="formatting">Indicates how the output is formatted.</param>
        /// <param name="settings">The Newtonsoft.Json.JsonSerializerSettings used to serialize the object. If this is null, default serialization settings will be used.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJson<T>(this T value, Formatting formatting, JsonSerializerSettings settings) => JsonConvert.SerializeObject(value, formatting, settings);
        /// <summary>
        /// Serializes the specified object to a JSON string using a type, formatting and Newtonsoft.Json.JsonSerializerSettings.
        /// </summary>
        /// <typeparam name="T">The type of the object that will be serialized.</typeparam>
        /// <param name="value">The object to serialize.</param>
        /// <param name="formatting">Indicates how the output is formatted.</param>
        /// <param name="settings">The Newtonsoft.Json.JsonSerializerSettings used to serialize the object. If this is null, default serialization settings will be used.</param>
        /// <param name="type">The type of the value being serialized. This parameter is used when Newtonsoft.Json.TypeNameHandling is Auto to write out the type name if the type of the value does not match. Specifing the type is optional.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJson<T>(this T value, Type type, Formatting formatting, JsonSerializerSettings settings) => JsonConvert.SerializeObject(value, type, formatting, settings);

        /// <summary>
        /// Asynchronously serializes the specified object to a JSON string. Serialization will happen on a new thread.
        /// </summary>
        /// <typeparam name="T">The type of the object that will be serialized.</typeparam>
        /// <param name="value">The object to serialize.</param>
        /// <returns>A task that represents the asynchronous serialize operation. The value of the TResult parameter contains a JSON string representation of the object.</returns>
        [Obsolete("ToJsonAsync is obsolete. Use the Task.Factory.StartNew method to serialize JSON asynchronously: Task.Factory.StartNew(() => value.ToJson())")]
        public static Task<string> ToJsonAsync<T>(this T value) => JsonConvert.SerializeObjectAsync(value);
        /// <summary>
        /// Asynchronously serializes the specified object to a JSON string using formatting. Serialization will happen on a new thread.
        /// </summary>
        /// <typeparam name="T">The type of the object that will be serialized.</typeparam>
        /// <param name="value">The object to serialize.</param>
        /// <param name="formatting">Indicates how the output is formatted.</param>
        /// <returns>A task that represents the asynchronous serialize operation. The value of the TResult parameter contains a JSON string representation of the object.</returns>
        [Obsolete("ToJsonAsync is obsolete. Use the Task.Factory.StartNew method to serialize JSON asynchronously: Task.Factory.StartNew(() => value.ToJson(formatting))")]
        public static Task<string> ToJsonAsync<T>(this T value, Formatting formatting) => JsonConvert.SerializeObjectAsync(value, formatting);
        /// <summary>
        /// Asynchronously serializes the specified object to a JSON string using formatting and a collection of Newtonsoft.Json.JsonConverter. Serialization will happen on a new thread.
        /// </summary>
        /// <typeparam name="T">The type of the object that will be serialized.</typeparam>
        /// <param name="value">The object to serialize.</param>
        /// <param name="formatting">Indicates how the output is formatted.</param>
        /// <param name="settings">The Newtonsoft.Json.JsonSerializerSettings used to serialize the object. If this is null, default serialization settings will be used.</param>
        /// <returns>A task that represents the asynchronous serialize operation. The value of the TResult parameter contains a JSON string representation of the object.</returns>
        [Obsolete("ToJsonAsync is obsolete. Use the Task.Factory.StartNew method to serialize JSON asynchronously: Task.Factory.StartNew(() => value.ToJson(formatting, settings))")]
        public static Task<string> ToJsonAsync<T>(this T value, Formatting formatting, JsonSerializerSettings settings) => JsonConvert.SerializeObjectAsync(value, formatting, settings);
    }
}
