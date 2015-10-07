using System.Linq;

namespace SuperExtensions
{
    public static class GenericTypeExtensions
    {
        public static bool IsIn<T>(this T item, params T[] items) => items.Contains(item);
    }
}
