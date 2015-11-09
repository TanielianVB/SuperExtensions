using System;
using System.Reflection;

namespace SuperExtensions
{
    public static class MemberInfoExtensions
    {
        //Attribute
        public static bool IsDefined<T>(MemberInfo element) where T : Attribute => Attribute.IsDefined(element, typeof(T));
        public static bool IsDefined<T>(MemberInfo element, bool inherit) where T : Attribute => Attribute.IsDefined(element, typeof(T), inherit);
    }
}
