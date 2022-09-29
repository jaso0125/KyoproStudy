using System;

namespace Questions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 標準入力
            var values = Console.ReadLine().Split(' ');

            var result = B01_A_B_Problem.Addition(int.Parse(values[0]), int.Parse(values[1]));

            // 標準出力
            Console.Write(result);
        }
    }
}