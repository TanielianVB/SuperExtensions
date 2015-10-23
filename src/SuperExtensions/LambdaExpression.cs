using System.Linq.Expressions;
using System.Reflection;

namespace SuperExtensions
{
    public static class LambdaExpressionExtensions
    {
        public static MethodInfo GetMethod(this LambdaExpression expression) => (expression.Body as MethodCallExpression).Method;
        public static PropertyInfo GetProperty(this LambdaExpression expression) => (expression.Body as MemberExpression).Member as PropertyInfo;
    }
}
