using Xunit;

namespace AtCoder.ABC106.C.Tests
{
    public class MrInfinityTest
    {
        [Theory]
        [InlineData("1", 1, "1")]
        [InlineData("1", 2, "1")]
        [InlineData("11112", 5, "2")]
        [InlineData("11112", 6, "2")]
        [InlineData("1214", 4, "2")]
        [InlineData("3", 157, "3")]
        [InlineData("299792458", 9460730472580800, "2")]
        public void AnswerTest(string S, long K, string expected)
        {
            var mr = new MrInfinity();

            Assert.Equal(expected, mr.Answer(S, K));
        }
    }
}
