namespace KyoproStudy.Chapter2
{
    public partial class A06 : ISolveProblem
    {
        public void SolveProblem()
        {
            // 標準入力
            var value1 = Console.ReadLine().Split(' ');
            var value2 = Console.ReadLine().Split(' ');
            string[][] value3 = new string[int.Parse(value1[1])][];

            for (int i = 0; i < int.Parse(value1[1]); i++)
            {
                value3[i] = Console.ReadLine().Split(' ');
            }

            var result = A06.HowManyGuests(value1[0], value1[1], value2, value3);

            // 標準出力
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<int> HowManyGuests(string strN, string strQ, string[] arrayA, string[][] arrayLR)
        {
            var intN = int.Parse(strN);
            var intQ = int.Parse(strQ);
            var intArrayA = arrayA.Select(a => int.Parse(a)).ToArray();

            // arrayLRをint型の配列に変換
            int[][] intArrayLR = new int[intQ][];
            for (var i = 0; i < intQ; i++)
            {
                intArrayLR[i] = new int[2];
                for (var j = 0; j < 2; j++)
                {
                    intArrayLR[i][j] = int.Parse(arrayLR[i][j]);
                }
            }

            // 累積和の計算
            var total = new int[intN];
            total[0] = intArrayA[0];
            for (var i = 1; i < intN; i++)
            {
                total[i] = total[i - 1] + intArrayA[i];
            }

            // クエリ処理
            var result = new List<int>();
            for (var i = 0; i < intQ; i++)
            {
                int l = intArrayLR[i][0] - 1;
                int r = intArrayLR[i][1] - 1;

                // 累積和から区間和を計算
                int sum = total[r] - (l > 0 ? total[l - 1] : 0);
                result.Add(sum);
            }
            return result;
        }
    }
}