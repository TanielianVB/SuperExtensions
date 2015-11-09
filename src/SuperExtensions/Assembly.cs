using System;
using System.Reflection;

namespace SuperExtensions
{
    public static class AssemblyExtensions
    {
        //Attribute
        public static bool IsDefined<T>(Assembly element) where T : Attribute => Attribute.IsDefined(element, typeof(T));
        public static bool IsDefined<T>(Assembly element, bool inherit) where T : Attribute => Attribute.IsDefined(element, typeof(T), inherit);
    }
}
