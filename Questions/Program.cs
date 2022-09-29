using System;

namespace Questions
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // 標準入力
            var value = int.Parse(Console.ReadLine());

            var area = A01_TheFirstProblem.GetArea(value);

            // 標準出力
            Console.Write(area);
        }
    }
}