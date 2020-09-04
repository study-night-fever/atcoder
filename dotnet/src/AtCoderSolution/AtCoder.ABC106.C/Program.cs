using System;

namespace AtCoder.ABC106.C
{
    public class Program
    {
        private static void Main()
        {
            // 入力値の検証は割愛
            var S = Console.ReadLine();
            var K = long.Parse(Console.ReadLine());

            var mrInfinity = new MrInfinity();

            var answer = mrInfinity.Answer(S, K);

            Console.WriteLine(answer);
        }
    }
}
