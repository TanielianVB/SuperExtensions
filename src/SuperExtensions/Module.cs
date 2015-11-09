using System;
using System.Reflection;

namespace SuperExtensions
{
    public static class ModuleExtensions
    {
        //Attribute
        public static bool IsDefined<T>(Module element) where T : Attribute => Attribute.IsDefined(element, typeof(T));
        public static bool IsDefined<T>(Module element, bool inherit) where T : Attribute => Attribute.IsDefined(element, typeof(T), inherit);
    }
}
