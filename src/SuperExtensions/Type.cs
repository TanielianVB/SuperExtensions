using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SuperExtensions
{
    public static class TypeExtensions
    {
        private static readonly Lazy<Dictionary<Type, string>> _dicAliases = new Lazy<Dictionary<Type, string>>(() => new Dictionary<Type, string>
        {
            [typeof(byte)] = "byte",
            [typeof(sbyte)] = "sbyte",
            [typeof(short)] = "short",
            [typeof(ushort)] = "ushort",
            [typeof(int)] = "int",
            [typeof(uint)] = "uint",
            [typeof(long)] = "long",
            [typeof(ulong)] = "ulong",
            [typeof(float)] = "float",
            [typeof(double)] = "double",
            [typeof(decimal)] = "decimal",
            [typeof(object)] = "object",
            [typeof(bool)] = "bool",
            [typeof(char)] = "char",
            [typeof(string)] = "string",
            [typeof(void)] = "void"
        });

        public static string GetAlias(this Type type) => _dicAliases.Value.GetValueOrDefault(type);

        public static string GetSignature(this Type type, bool fullName = false, bool baseType = false, bool interfaces = false)
        {
            Type[] genericTypeParameters = null;

            if (type.GenericTypeArguments.Any())
            {
                genericTypeParameters = type.GenericTypeArguments;
            }
            else if (type.ContainsGenericParameters && !type.IsGenericParameter && type is TypeInfo)
            {
                genericTypeParameters = (type as TypeInfo).GenericTypeParameters;
                if (!genericTypeParameters.Any()) genericTypeParameters = null;
            }

            string typeName;

            if (genericTypeParameters != null)
            {
                typeName = type.Name.Replace("`" + genericTypeParameters.Count(), "");
                if (fullName) typeName = type.Namespace + "." + typeName;
                typeName += "<" + genericTypeParameters.Select(t => t.GetSignature(fullName: fullName)).Join(", ") + ">";
            }
            else
            {
                typeName = fullName ? (type.FullName ?? type.Name) : (type.GetAlias() ?? type.Name);
            }

            if (baseType && type.BaseType != null && type.BaseType != typeof(object))
            {
                typeName += " : " + type.BaseType.GetSignature(fullName: fullName);
            }

            if (interfaces && type.GetInterfaces().Any())
            {
                var intefaceTypes = type.GetInterfaces();

                var immediateInterfaces = new HashSet<Type>(intefaceTypes);

                foreach (Type i in intefaceTypes)
                    immediateInterfaces.ExceptWith(i.GetInterfaces());

                if (type.BaseType != null && type.BaseType != typeof(object))
                {
                    immediateInterfaces.ExceptWith(type.BaseType.GetInterfaces());
                }

                if (immediateInterfaces.Any())
                {
                    typeName += typeName.Contains(" : ") ? ", " : " : ";

                    typeName += immediateInterfaces.Select(t => t.GetSignature(fullName: fullName)).Join(", ");
                }
            }

            return typeName;
        }

        public static bool InheritsFrom(this Type c, Type type) => type.IsAssignableFrom(c);
        public static bool InheritsFrom<T>(this Type c) => c.InheritsFrom(typeof(T));
        public static bool IsNullable(this Type type) => !type.IsValueType || (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>));
        public static object GetDefaultValue(this Type type) => type.IsValueType ? Activator.CreateInstance(type) : null;
    }
}
