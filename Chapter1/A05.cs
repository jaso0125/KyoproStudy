namespace KyoproStudy.Chapter1
{
    public partial class A05 : ISolveProblem
    {
        public void SolveProblem()
        {
            // 標準入力
            var value = Console.ReadLine().Split(' ');

            var result = ThreeCards(value[0], value[1]);

            // 標準出力
            Console.Write(result);
        }

        public static int ThreeCards(string strN, string strK)
        {
            var intN = int.Parse(strN);
            var intK = int.Parse(strK);

            var count = 0;

            for (var i = 1; i < intN + 1; i++)
            {
                for (var j = 1; j < intN + 1; j++)
                {
                    {
                        var k = intK - i - j;
                        if (k >= 1 && k <= intN)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}