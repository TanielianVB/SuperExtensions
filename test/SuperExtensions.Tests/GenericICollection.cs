using System.Collections.Generic;
using Xunit;

namespace SuperExtensions.Tests
{
    public class GenericICollectionExtensionsTest
    {
        [Theory]
        [InlineData(new object[] { 0, 1, 2 }, new object[] { 3, 4, 5 }, new object[] { 0, 1, 2, 3, 4, 5 })]
        [InlineData(new object[] { "1", "2", "3" }, new object[] { "4", "5", "6" }, new object[] { "1", "2", "3", "4", "5", "6" })]
        public void AddRangeTest(object[] collection, object[] values, object[] result)
        {
            var list = new List<object>(collection);
            (list as ICollection<object>).AddRange(values);
            Assert.Equal(list, result);
        }
    }
}
