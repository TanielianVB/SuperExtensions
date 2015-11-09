using System.Collections.Generic;

namespace SuperExtensions
{
    public static class GenericIDictionaryExtensions
    {
        public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dic, TKey key) => dic.ContainsKey(key) ? dic[key] : default(TValue);
    }
}
