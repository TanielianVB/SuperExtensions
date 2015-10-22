using System;
using Xunit;

namespace SuperExtensions.Tests
{
    public class StringExtensionsTest
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void IsNullOrEmptyTest(string value)
        {
            Assert.True(value.IsNullOrEmpty());
        }

        [Theory]
        [InlineData("value")]
        public void NotIsNullOrEmptyTest(string value)
        {
            Assert.False(value.IsNullOrEmpty());
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("   ")]
        public void IsNullOrWhiteSpaceTest(string value)
        {
            Assert.True(value.IsNullOrWhiteSpace());
        }

        [Theory]
        [InlineData("value")]
        public void NotIsNullOrWhiteSpaceTest(string value)
        {
            Assert.False(value.IsNullOrWhiteSpace());
        }
    }
}
