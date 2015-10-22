using System.Linq;
using System.Linq.Expressions;
using Xunit;

namespace SuperExtensions.Tests
{
    public class GenericTypeExtensionsTest
    {
        [Theory]
        [InlineData(1, new object[] { 0, 1, 2, 3, 4, 5 })]
        [InlineData("1", new object[] { "0", "1", "2", "3", "4", "5" })]
        public void IsInTest(object item, object[] items)
        {
            Assert.True(item.IsIn(items));
        }
    }
}
