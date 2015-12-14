using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SuperExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Deserializes the JSON to a .NET object.
        /// </summary>
        /// <param name="value">The JSON to deserialize.</param>
        /// <returns>The deserialized object from the JSON string.</returns>
        public static object FromJson(this string value) => JsonConvert.DeserializeObject(value);
        /// <summary>
        /// Deserializes the JSON to a .NET object using Newtonsoft.Json.JsonSerializerSettings.
        /// </summary>
        /// <param name="value">The JSON to deserialize.</param>
        /// <param name="settings">The Newtonsoft.Json.JsonSerializerSettings used to deserialize the object. If this is null, default serialization settings will be used.</param>
        /// <returns>The deserialized object from the JSON string.</returns>
        public static object FromJson(this string value, JsonSerializerSettings settings) => JsonConvert.DeserializeObject(value, settings);
        /// <summary>
        /// Deserializes the JSON to the specified .NET type.
        /// </summary>
        /// <param name="value">The JSON to deserialize.</param>
        /// <param name="type">The System.Type of object being deserialized.</param>
        /// <returns>The deserialized object from the JSON string.</returns>
        public static object FromJson(this string value, Type type) => JsonConvert.DeserializeObject(value, type);
        /// <summary>
        /// Deserializes the JSON to the specified .NET type using a collection of Newtonsoft.Json.JsonConverter.
        /// </summary>
        /// <param name="value">The JSON to deserialize.</param>
        /// <param name="type">The type of the object to deserialize.</param>
        /// <param name="converters">Converters to use while deserializing.</param>
        /// <returns>The deserialized object from the JSON string.</returns>
        public static object FromJson(this string value, Type type, params JsonConverter[] converters) => JsonConvert.DeserializeObject(value, type, converters);
        /// <summary>
        /// Deserializes the JSON to the specified .NET type using Newtonsoft.Json.JsonSerializerSettings.
        /// </summary>
        /// <param name="value">The JSON to deserialize.</param>
        /// <param name="type">The type of the object to deserialize to.</param>
        /// <param name="settings">The Newtonsoft.Json.JsonSerializerSettings used to deserialize the object. If this is null, default serialization settings will be used.</param>
        /// <returns>The deserialized object from the JSON string.</returns>
        public static object FromJson(this string value, Type type, JsonSerializerSettings settings) => JsonConvert.DeserializeObject(value, type, settings);
        /// <summary>
        /// Deserializes the JSON to the specified .NET type.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize to.</typeparam>
        /// <param name="value">The JSON to deserialize.</param>
        /// <returns>The deserialized object from the JSON string.</returns>
        public static T FromJson<T>(this string value) => JsonConvert.DeserializeObject<T>(value);
        /// <summary>
        /// Deserializes the JSON to the specified .NET type using Newtonsoft.Json.JsonSerializerSettings.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize to.</typeparam>
        /// <param name="value">The object to deserialize.</param>
        /// <param name="settings">The Newtonsoft.Json.JsonSerializerSettings used to deserialize the object. If this is null, default serialization settings will be used.</param>
        /// <returns>The deserialized object from the JSON string.</returns>
        public static T FromJson<T>(this string value, JsonSerializerSettings settings) => JsonConvert.DeserializeObject<T>(value, settings);
        /// <summary>
        /// Deserializes the JSON to the specified .NET type using a collection of Newtonsoft.Json.JsonConverter.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize to.</typeparam>
        /// <param name="value">The JSON to deserialize.</param>
        /// <param name="converters">Converters to use while deserializing.</param>
        /// <returns>The deserialized object from the JSON string.</returns>
        public static T FromJson<T>(this string value, params JsonConverter[] converters) => JsonConvert.DeserializeObject<T>(value, converters);

        /// <summary>
        /// Asynchronously deserializes the JSON to the specified .NET type. Deserialization will happen on a new thread.
        /// </summary>
        /// <param name="value">The JSON to deserialize.</param>
        /// <returns>A task that represents the asynchronous deserialize operation. The value of the TResult parameter contains the deserialized object from the JSON string.</returns>
        [Obsolete("FromJsonAsync is obsolete. Use the Task.Factory.StartNew method to deserialize JSON asynchronously: Task.Factory.StartNew(() => value.FromJsonAsync())")]
        public static Task<object> FromJsonAsync(this string value) => JsonConvert.DeserializeObjectAsync(value);
        /// <summary>
        /// Asynchronously deserializes the JSON to the specified .NET type using Newtonsoft.Json.JsonSerializerSettings. Deserialization will happen on a new thread.
        /// </summary>
        /// <param name="value">The JSON to deserialize.</param>
        /// <param name="type">The type of the object to deserialize to.</param>
        /// <param name="settings">The Newtonsoft.Json.JsonSerializerSettings used to deserialize the object. If this is null, default serialization settings will be used.</param>
        /// <returns>A task that represents the asynchronous deserialize operation. The value of the TResult parameter contains the deserialized object from the JSON string.</returns>
        [Obsolete("FromJsonAsync is obsolete. Use the Task.Factory.StartNew method to deserialize JSON asynchronously: Task.Factory.StartNew(() => value.FromJsonAsync(type, settings))")]
        public static Task<object> FromJsonAsync(this string value, Type type, JsonSerializerSettings settings) => JsonConvert.DeserializeObjectAsync(value, type, settings);
        /// <summary>
        /// Asynchronously deserializes the JSON to the specified .NET type. Deserialization will happen on a new thread.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize to.</typeparam>
        /// <param name="value">The JSON to deserialize.</param>
        /// <returns>A task that represents the asynchronous deserialize operation. The value of the TResult parameter contains the deserialized object from the JSON string.</returns>
        [Obsolete("FromJsonAsync is obsolete. Use the Task.Factory.StartNew method to deserialize JSON asynchronously: Task.Factory.StartNew(() => value.FromJsonAsync<T>())")]
        public static Task<T> FromJsonAsync<T>(this string value) => JsonConvert.DeserializeObjectAsync<T>(value);
        /// <summary>
        /// Asynchronously deserializes the JSON to the specified .NET type using Newtonsoft.Json.JsonSerializerSettings. Deserialization will happen on a new thread.
        /// </summary>
        /// <param name="value">The JSON to deserialize.</param>
        /// <param name="settings">The Newtonsoft.Json.JsonSerializerSettings used to deserialize the object. If this is null, default serialization settings will be used.</param>
        /// <returns>A task that represents the asynchronous deserialize operation. The value of the TResult parameter contains the deserialized object from the JSON string.</returns>
        [Obsolete("FromJsonAsync is obsolete. Use the Task.Factory.StartNew method to deserialize JSON asynchronously: Task.Factory.StartNew(() => value.FromJsonAsync<T>(settings))")]
        public static Task<T> FromJsonAsync<T>(this string value, JsonSerializerSettings settings) => JsonConvert.DeserializeObjectAsync<T>(value, settings);
    }
}
