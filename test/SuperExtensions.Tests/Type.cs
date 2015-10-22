using Xunit;

namespace SuperExtensions.Tests
{
    public class TypeExtensionsTest
    {
        [Fact]
        public void GetDefaultValueTest()
        {
            var typeInt = typeof(int);
            Assert.Equal(typeInt.GetDefaultValue(), 0);

            var typeString = typeof(string);
            Assert.Equal(typeString.GetDefaultValue(), null);
        }
    }
}
