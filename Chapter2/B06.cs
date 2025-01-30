namespace KyoproStudy.Chapter2
{
    public class B06 : ISolveProblem
    {
        public void SolveProblem()
        {
            // 標準入力
            var value1 = Console.ReadLine(); // N
            var value2 = Console.ReadLine().Split(' '); // An
            var value3 = Console.ReadLine(); // Q
            var value5 = new int[int.Parse(value3)]; // Lq
            var value6 = new int[int.Parse(value3)]; // Rq

            string[][] value4 = new string[int.Parse(value3)][];

            for (int i = 0; i < int.Parse(value3); i++)
            {
                value4[i] = Console.ReadLine().Split(' ');
                value5[i] = int.Parse(value4[i][0]);
                value6[i] = int.Parse(value4[i][1]);
            }

            var result = Lottery(int.Parse(value1), value2, int.Parse(value3), value5, value6);

            // 標準出力
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<string> Lottery(int intN, string[] arrayA, int intQ, int[] arrayL, int[] arrayR)
        {
            // アタリ・ハズレの累積和計算
            int[] WinSum = new int[intN];
            int[] LoseSum = new int[intN];
            var intArrayA = arrayA.Select(a => int.Parse(a)).ToArray();

            WinSum[0] = 0;
            LoseSum[0] = 0;

            if (intArrayA[0] == 0)
            {
                LoseSum[0] = 1;
            }
            else
            {
                WinSum[0] = 1;
            }

            for (int i = 1; i < intN; i++)
            {
                if (intArrayA[i] == 1)
                {
                    WinSum[i] = WinSum[i - 1] + 1;
                    LoseSum[i] = LoseSum[i - 1];
                }
                if (intArrayA[i] == 0)
                {
                    LoseSum[i] = LoseSum[i - 1] + 1;
                    WinSum[i] = WinSum[i - 1];
                }
            }

            // 質問の計算
            var resultList = new List<string>();

            for (int i = 0; i < intQ; i++)
            {
                int l = arrayL[i] - 1;
                int r = arrayR[i] - 1;

                var win = WinSum[r] - (l > 0 ? WinSum[l - 1] : 0);
                var lose = LoseSum[r] - (l > 0 ? LoseSum[l - 1] : 0);

                if (win > lose)
                {
                    resultList.Add("win");
                }
                else if (lose > win)
                {
                    resultList.Add("lose");
                }
                else
                {
                    resultList.Add("draw");
                }
            }
            return resultList;
        }
    }
}