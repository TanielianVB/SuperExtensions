using System;
using System.Linq;
using System.Reflection;

namespace SuperExtensions
{
    public static class ParameterInfoExtensions
    {
        //Attribute
        public static T GetCustomAttribute<T>(this ParameterInfo element) where T : Attribute => (T)Attribute.GetCustomAttribute(element, typeof(T));
        public static T GetCustomAttribute<T>(this ParameterInfo element, bool inherit) where T : Attribute => (T)Attribute.GetCustomAttribute(element, typeof(T), inherit);
        public static T[] GetCustomAttributes<T>(this ParameterInfo element) where T : Attribute => Attribute.GetCustomAttributes(element, typeof(T)).Cast<T>().ToArray();
        public static T[] GetCustomAttributes<T>(this ParameterInfo element, bool inherit) where T : Attribute => Attribute.GetCustomAttributes(element, typeof(T), inherit).Cast<T>().ToArray();
        public static bool IsDefined<T>(ParameterInfo element) where T : Attribute => Attribute.IsDefined(element, typeof(T));
        public static bool IsDefined<T>(ParameterInfo element, bool inherit) where T : Attribute => Attribute.IsDefined(element, typeof(T), inherit);
    }
}
