using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SuperExtensions
{
    public static class ModuleExtensions
    {
        //Attribute
        public static T GetCustomAttribute<T>(this Module element, bool inherit) where T : Attribute => (T)Attribute.GetCustomAttribute(element, typeof(T), inherit);
        public static IEnumerable<T> GetCustomAttributes<T>(this Module element, bool inherit) where T : Attribute => Attribute.GetCustomAttributes(element, typeof(T), inherit).Cast<T>();
        public static bool IsDefined<T>(Module element) where T : Attribute => Attribute.IsDefined(element, typeof(T));
        public static bool IsDefined<T>(Module element, bool inherit) where T : Attribute => Attribute.IsDefined(element, typeof(T), inherit);
    }
}
