namespace KyoproStudy.Chapter2
{
    public static partial class A06
    {
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