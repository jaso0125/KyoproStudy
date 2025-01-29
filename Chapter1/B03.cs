using System.Data;

namespace KyoproStudy.Chapter1
{
    public partial class B03 : ISolveProblem
    {
        public void SolveProblem()
        {
            // 標準入力
            var value1 = Console.ReadLine();
            var value2 = Console.ReadLine().Split(' ');

            var result = Supermarket1(value1!, value2);

            // 標準出力
            Console.Write(result);
        }

        public static string Supermarket1(string strN, string[] strArrayA)
        {
            var intN = int.Parse(strN);
            var intArrayA = strArrayA.Select(x => int.Parse(x)).ToArray();

            for (var i = 0; i < intN; i++)
            {
                for (var j = i + 1; j < intN; j++)
                {
                    for (var k = j + 1; k < intN; k++)
                    {
                        if (intArrayA[i] + intArrayA[j] + intArrayA[k] == 1000)
                        {
                            return "Yes";
                        }
                    }
                }
            }
            return "No";
        }
    }
}