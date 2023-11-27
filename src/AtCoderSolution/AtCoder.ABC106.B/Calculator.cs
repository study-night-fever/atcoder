using System.Collections.Generic;
using System.Linq;

namespace AtCoder.ABC106.B
{
    public class Calculator
    {
        /// <summary>
        /// 奇数かつ指定した約数の個数を持つ数のコレクションを取得します。
        /// </summary>
        /// <param name="max">最大値</param>
        /// <param name="divisorsCount">約数の個数</param>
        public IEnumerable<int> GetAnswers(int max, int divisorsCount)
        {
            return Enumerable.Range(1, max).Where(i =>
            {
                return i % 2 == 1 && GetDivisors(i).Count() == divisorsCount;
            });
        }

        /// <summary>
        /// 約数のコレクションを取得します。
        /// </summary>
        public IEnumerable<int> GetDivisors(int value)
            => Enumerable.Range(1, value).Where(i => value % i == 0);
    }
}
