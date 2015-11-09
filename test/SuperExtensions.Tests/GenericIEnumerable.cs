using Xunit;

namespace SuperExtensions.Tests
{
    public class GenericIEnumerableExtensionsTest
    {
        [Theory]
        [InlineData(new object[] { 0, 1, 2 }, ",", "0,1,2")]
        [InlineData(new object[] { 1, 2, 3 }, ", ", "1, 2, 3")]
        public void JoinTest(object[] values, string separator, string result) => Assert.Equal(values.ToString(separator), result);
    }
}
