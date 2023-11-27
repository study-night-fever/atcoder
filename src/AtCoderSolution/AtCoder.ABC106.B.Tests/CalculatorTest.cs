using System.Collections.Generic;
using Xunit;

namespace AtCoder.ABC106.B.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [MemberData(nameof(AnswersTestDatas))]
        public void GetAnswers(int N, int divisorsCount, IEnumerable<int> expected)
        {
            var calc = new Calculator();

            Assert.Equal(expected, calc.GetAnswers(N, divisorsCount));
        }

        public static TheoryData<int, int, IEnumerable<int>> AnswersTestDatas => new TheoryData<int, int, IEnumerable<int>>
        {
            { 105, 8, new[] { 105 } },
            { 7, 8, new int[] { } },
        };

        [Theory]
        [MemberData(nameof(DivisorsTestDatas))]
        public void GetDivisors(int value, IEnumerable<int> expected)
        {
            var calc = new Calculator();

            Assert.Equal(expected, calc.GetDivisors(value));
        }

        public static TheoryData<int, IEnumerable<int>> DivisorsTestDatas => new TheoryData<int, IEnumerable<int>>
        {
            { 99, new[] { 1, 3, 9, 11, 33, 99 } },
            { 105, new[] { 1, 3, 5, 7, 15, 21, 35, 105 } },
        };
    }
}
