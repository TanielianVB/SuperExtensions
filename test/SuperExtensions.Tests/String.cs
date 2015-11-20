using Xunit;

namespace SuperExtensions.Tests
{
    public class StringExtensionsTest
    {
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
