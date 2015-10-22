using System;
using Xunit;

namespace SuperExtensions.Tests
{
    public class TypeExtensionsTest
    {
        [Theory]
        [InlineData(typeof(int), 0)]
        [InlineData(typeof(string), null)]
        public void GetDefaultValueTest(Type type, object defaultValue)
        {
            Assert.Equal(type.GetDefaultValue(), defaultValue);
        }
    }
}
