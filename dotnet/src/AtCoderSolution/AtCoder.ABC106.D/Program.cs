using System;
using System.Collections.Generic;
using System.Linq;

namespace AtCoder.ABC106.D
{
    public class Program
    {
        private static void Main()
        {
            // 入力値の検証は割愛
            var parameters = Console.ReadLine().Split(' ');
            var N = int.Parse(parameters[0]);
            var M = int.Parse(parameters[1]);
            var Q = int.Parse(parameters[2]);

            var trains = new List<Train>();
            for (var i = 0; i < M; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var l = int.Parse(tokens[0]);
                var r = int.Parse(tokens[1]);
                trains.Add(new Train(l, r));
            }

            var problems = new List<Problem>();
            for (var i = 0; i < Q; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var p = int.Parse(tokens[0]);
                var q = int.Parse(tokens[1]);
                problems.Add(new Problem(p, q));
            }

            var takahashi = new Takahashi();

            var answers = takahashi.Answer(trains, problems);

            answers.ToList().ForEach(answer =>
            {
                Console.WriteLine(answer);
            });
        }
    }
}
