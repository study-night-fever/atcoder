using System.Collections.Generic;
using Xunit;

namespace AtCoder.ABC106.B.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [MemberData(nameof(AnswersTestData))]
        public void GetAnswers(int N, int divisorsCount, IEnumerable<int> expected)
        {
            var calc = new Calculator();

            Assert.Equal(expected, calc.GetAnswers(N, divisorsCount));
        }

        public static IEnumerable<object[]> AnswersTestData => new[]
        {
            new object[]{ 105, 8, new[] { 105 } },
            new object[]{ 7, 8, new int[] { } },
        };

        [Theory]
        [MemberData(nameof(DivisorsTestData))]
        public void GetDivisors(int value, IEnumerable<int> expected)
        {
            var calc = new Calculator();

            Assert.Equal(expected, calc.GetDivisors(value));
        }

        public static IEnumerable<object[]> DivisorsTestData => new[]
        {
            new object[]{ 99, new[] { 1, 3, 9, 11, 33, 99 } },
            new object[]{ 105, new[] { 1, 3, 5, 7, 15, 21, 35, 105 } },
        };
    }
}
