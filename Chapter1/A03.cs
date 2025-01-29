namespace KyoproStudy.Chapter1
{
    public partial class A03 : ISolveProblem
    {
        public void SolveProblem()
        {
            // 標準入力
            var value1 = Console.ReadLine().Split(' ');
            var value2 = Console.ReadLine().Split(' ').ToArray();
            var value3 = Console.ReadLine().Split(' ').ToArray();

            var result = TwoCards(value1[0], value1[1], value2, value3);

            // 標準出力
            Console.Write(result);
        }

        public static string TwoCards(string strN, string strK, string[] strArrayP, string[] strArrayQ)
        {
            var intN = int.Parse(strN);
            var intK = int.Parse(strK);
            var intArrayP = strArrayP.Select(x => int.Parse(x)).ToArray();
            var intArrayQ = strArrayQ.Select(x => int.Parse(x)).ToArray();

            for (var i = 0; i < intN; i++)
            {
                for (var j = 0; j < intN; j++)
                {
                    if (intArrayP[i] + intArrayQ[j] == intK)
                    {
                        return "Yes";
                    }
                }
            }
            return "No";
        }
    }
}