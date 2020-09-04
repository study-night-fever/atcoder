using System.Collections.Generic;
using Xunit;

namespace AtCoder.ABC106.D.Tests
{
    public class TakahashiTest
    {
        [Theory]
        [MemberData(nameof(AnswerTestData))]
        public void Answer(AnswerTestInput input, IEnumerable<int> expected)
        {
            var takahashi = new Takahashi();

            Assert.Equal(expected, takahashi.Answer(input.Trains, input.Problems));
        }

        public struct AnswerTestInput
        {
            public IEnumerable<Train> Trains;
            public IEnumerable<Problem> Problems;
        }

        public static TheoryData<AnswerTestInput, IEnumerable<int>> AnswerTestData => new TheoryData<AnswerTestInput, IEnumerable<int>>
        {
            {
                new AnswerTestInput
                {
                    Trains = new[]
                    {
                        new Train(1, 1),
                        new Train(1, 2),
                        new Train(2, 2),
                    },
                    Problems = new[]
                    {
                        new Problem(1, 2),
                    },
                },
                new[]
                {
                    3,
                }
            },
            {
                new AnswerTestInput
                {
                    Trains = new[]
                    {
                        new Train(1, 5),
                        new Train(2, 8),
                        new Train(7, 10),
                    },
                    Problems = new[]
                    {
                        new Problem(1, 7),
                        new Problem(3, 10),
                    },
                },
                new[]
                {
                    1,
                    1,
                }
            },
            {
                new AnswerTestInput
                {
                    Trains = new[]
                    {
                        new Train(1, 5),
                        new Train(2, 8),
                        new Train(7, 10),
                    },
                    Problems = new[]
                    {
                        new Problem(1, 7),
                        new Problem(3, 10),
                    },
                }
                ,new[]
                {
                    1,
                    1,
                }
            },
        };
    }
}
