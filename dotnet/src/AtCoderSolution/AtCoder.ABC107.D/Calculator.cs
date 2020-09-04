using System;
using System.Collections.Generic;
using System.Linq;

namespace AtCoder.ABC107.D
{
    public class Calculator
    {
        public long GetMedian(IEnumerable<long> list)
        {
            // 中央
            var index = (int)Math.Floor((decimal)list.Count() / 2);

            // 中央値
            return list.OrderBy(i => i).ElementAt(index);
        }

        public long GetMedianOfMedians(IEnumerable<long> list)
        {
            // 部分列のコレクションを取得
            var subLists = GetSubLists(list);

            // 各部分列の中央値のコレクションを生成
            var medians = subLists.Select(GetMedian);

            // その中央値を返す
            return GetMedian(medians);
        }

        public IEnumerable<IEnumerable<long>> GetSubLists(IEnumerable<long> list)
        {
            var subLists = new List<IEnumerable<long>>();
            for (var i = 0; i < list.Count(); i++)
            {
                for (var j = i; j < list.Count(); j++)
                {
                    subLists.Add(list.Skip(i).Take(j - i + 1));
                }
            }
            return subLists;
        }
    }
}
