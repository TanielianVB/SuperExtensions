using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SuperExtensions
{
    public static class ParameterInfoExtensions
    {
        //Attribute
        public static bool IsDefined<T>(ParameterInfo element) where T : Attribute => Attribute.IsDefined(element, typeof(T));
        public static bool IsDefined<T>(ParameterInfo element, bool inherit) where T : Attribute => Attribute.IsDefined(element, typeof(T), inherit);
    }
}
