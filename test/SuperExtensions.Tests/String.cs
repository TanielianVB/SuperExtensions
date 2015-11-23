using Xunit;

namespace SuperExtensions.Tests
{
    public class StringExtensionsTest
    {
        [Theory]
        [InlineData("Test", new object[] { }, "Test")]
        [InlineData("Test {0}", new object[] { 1 }, "Test 1")]
        [InlineData("Test {0} {1} {2}", new object[] { 1, 2, 3 }, "Test 1 2 3")]
        public void FormatWithTest(string value, object[] args, string result) => Assert.Equal(value.FormatWith(args), result);

        [Theory]
        [InlineData(null, new object[] { })]
        [InlineData("Test", null)]
        public void FormatWithArgumentNullExceptionErrorTest(string value, object[] args) => Assert.Throws<System.ArgumentNullException>(() => value.FormatWith(args));

        [Theory]
        [InlineData("Test {0}", new object[] { })]
        public void FormatWithFormatExceptionErrorTest(string value, object[] args) => Assert.Throws<System.FormatException>(() => value.FormatWith(args));

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void IsNullOrEmptyTest(string value) => Assert.True(value.IsNullOrEmpty());

        [Theory]
        [InlineData("value")]
        public void NotIsNullOrEmptyTest(string value) => Assert.False(value.IsNullOrEmpty());

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("   ")]
        public void IsNullOrWhiteSpaceTest(string value) => Assert.True(value.IsNullOrWhiteSpace());

        [Theory]
        [InlineData("value")]
        public void NotIsNullOrWhiteSpaceTest(string value) => Assert.False(value.IsNullOrWhiteSpace());

        [Theory]
        [InlineData("Teste.js", "*.js")]
        [InlineData("Teste.js", "*.*")]
        [InlineData("Teste.cs", "Teste.*")]
        public void IsLikeTest(string input, string wildcardPattern) => Assert.True(input.IsLike(wildcardPattern));

        [Theory]
        [InlineData("Teste.cs", ".js*")]
        public void NotIsLikeTest(string input, string wildcardPattern) => Assert.False(input.IsLike(wildcardPattern));
    }
}
