using System;
using System.Linq;

namespace AtCoder.ABC106.B
{
    public class Program
    {
        private static void Main()
        {
            // 入力値の検証は割愛
            var N = int.Parse(Console.ReadLine());

            var calculator = new Calculator();

            var answer = calculator.GetAnswers(N, divisorsCount: 8);

            Console.WriteLine(answer.Count());
        }
    }
}
