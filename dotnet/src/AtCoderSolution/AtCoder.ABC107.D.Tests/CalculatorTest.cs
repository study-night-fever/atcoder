using System.Collections.Generic;
using Xunit;

namespace AtCoder.ABC107.D.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [MemberData(nameof(MedianTestData))]
        public void GetMedian(IEnumerable<long> list, int expected)
        {
            var calc = new Calculator();

            Assert.Equal(expected, calc.GetMedian(list));
        }

        public static IEnumerable<object[]> MedianTestData => new[]
        {
            new object[]{ new long[] { 10 }, 10 },
            new object[]{ new long[] { 10, 30 }, 30 },
            new object[]{ new long[] { 30, 20 }, 30 },
            new object[]{ new long[] { 10, 30, 20 }, 20 },
            new object[]{ new long[] { 5, 9, 5, 9, 8, 9, 3, 5, 4, 3 }, 5 },
        };

        [Theory]
        [MemberData(nameof(MedianOfMediansTestData))]
        public void GetMedianOfMesians(IEnumerable<long> list, int expected)
        {
            var calc = new Calculator();

            Assert.Equal(expected, calc.GetMedianOfMedians(list));
        }

        public static IEnumerable<object[]> MedianOfMediansTestData => new[]
        {
            new object[]{ new long[] { 10, 30, 20 }, 30 },
            new object[]{ new long[] { 10 }, 10 },
            new object[]{ new long[] { 5, 9, 5, 9, 8, 9, 3, 5, 4, 3 }, 8 },
        };

        [Fact]
        public void GetSubListsTest()
        {
            var calc = new Calculator();

            {
                var list = new long[] { 10, 30, 20 };
                var expected = new List<IEnumerable<long>>()
                {
                    new long[]{ 10 },
                    new long[]{ 10, 30 },
                    new long[]{ 10, 30, 20 },
                    new long[]{ 30 },
                    new long[]{ 30, 20 },
                    new long[]{ 20 },
                };
                Assert.Equal(expected, calc.GetSubLists(list));
            }
        }
    }
}
