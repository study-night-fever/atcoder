using System.Collections.Generic;
using Xunit;

namespace AtCoder.ABC106.D.Tests
{
    public class TakahashiTest
    {
        [Theory]
        [MemberData(nameof(AnswerTestData))]
        public void Answer(IEnumerable<Train> trains, IEnumerable<Problem> problems, IEnumerable<int> expected)
        {
            var takahashi = new Takahashi();

            Assert.Equal(expected, takahashi.Answer(trains, problems));
        }

        // å©Ç√ÇÁÇ¢ÅcÅc
        public static IEnumerable<object[]> AnswerTestData()
        {
            return new[]
            {
                new object[]
                {
                    new[]
                    {
                        new Train(1, 1),
                        new Train(1, 2),
                        new Train(2, 2),
                    },
                    new[]
                    {
                        new Problem(1, 2),
                    },
                    new[]
                    {
                        3,
                    },
                },
                new object[]
                {
                    new[]
                    {
                        new Train(1, 5),
                        new Train(2, 8),
                        new Train(7, 10),
                    },
                    new[]
                    {
                        new Problem(1, 7),
                        new Problem(3, 10),
                    },
                    new[]
                    {
                        1,
                        1,
                    },
                },
                new object[]
                {
                    new[]
                    {
                        new Train(1, 5),
                        new Train(2, 8),
                        new Train(7, 10),
                    },
                    new[]
                    {
                        new Problem(1, 7),
                        new Problem(3, 10),
                    },
                    new[]
                    {
                        1,
                        1,
                    },
                },
            };
        }
    }
}
