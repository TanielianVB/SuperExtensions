using System;
using Xunit;

namespace SuperExtensions.Tests
{
    public class GenericTypeExtensionsTest
    {
        [Theory]
        [InlineData(1, new[] { 0, 1, 2, 3, 4, 5 })]
        [InlineData("1", new[] { "0", "1", "2", "3", "4", "5" })]
        public void IsInTest<T>(T item, T[] items) => Assert.True(item.IsAny(items));

        [Theory]
        [InlineData(100, new[] { 0, 1, 2, 3, 4, 5 })]
        [InlineData("100", new[] { "0", "1", "2", "3", "4", "5" })]
        public void NotIsInTest<T>(T item, T[] items) => Assert.False(item.IsAny(items));

        [Theory]
        [InlineData(1, 0, 2)]
        [InlineData(0, 0, 2)]
        [InlineData(2, 0, 2)]
        [InlineData('b', 'a', 'c')]
        public void IsBetweenTest<T>(T actual, T lower, T upper) where T : IComparable<T> => Assert.True(actual.IsBetween(lower, upper));

        [Theory]
        [InlineData(-1, 0, 2)]
        [InlineData(100, 0, 2)]
        [InlineData('z', 'a', 'c')]
        public void NotIsBetweenTest<T>(T actual, T lower, T upper) where T : IComparable<T> => Assert.False(actual.IsBetween(lower, upper));
    }
}
