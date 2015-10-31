using System;

namespace SuperExtensions
{
    public static class TypeExtensions
    {
        public static bool InheritsFrom(this Type c, Type type) => type.IsAssignableFrom(c);
        public static bool InheritsFrom<T>(this Type c) => c.InheritsFrom(typeof(T));
        public static bool IsNullable(this Type type) => !type.IsValueType || (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>));
        public static object GetDefaultValue(this Type type) => type.IsValueType ? Activator.CreateInstance(type) : null;
    }
}
