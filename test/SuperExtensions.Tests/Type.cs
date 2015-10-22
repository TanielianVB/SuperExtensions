using System;
using Xunit;

namespace SuperExtensions.Tests
{
    public class TypeExtensionsTest
    {
        [Theory]
        [InlineData(typeof(int), default(int))]
        [InlineData(typeof(string), default(string))]
        public void GetDefaultValueTest(Type type, object defaultValue) => Assert.Equal(type.GetDefaultValue(), defaultValue);
    }
}
