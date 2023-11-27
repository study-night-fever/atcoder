using System;
using System.Linq;

namespace AtCoder.ABC107.D
{
    public class Program
    {
        private static void Main()
        {
            // 入力値の検証は割愛
            var N = int.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            var calculator = new Calculator();

            var answer = calculator.GetMedianOfMedians(list);

            Console.WriteLine(answer);
        }
    }
}
