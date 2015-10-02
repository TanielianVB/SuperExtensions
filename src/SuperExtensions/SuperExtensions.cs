using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperExtensions
{
    public static class SuperExtensions
    {
        public static object GetDefaultValue(this Type type)
        {
            if (type.IsValueType) return Activator.CreateInstance(type);
            return null;
        }
    }
}
