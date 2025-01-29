namespace KyoproStudy.Chapter1
{
    public partial class A02 : ISolveProblem
    {
        public void SolveProblem()
        {
            // 標準入力
            var value1 = Console.ReadLine().Split(' ');
            var value2 = Console.ReadLine().Split(' ');

            var result = LinearSearch(value1[0], value1[1], value2.ToList());

            // 標準出力
            Console.Write(result);
        }

        public static string LinearSearch(string strN, string strX, List<string> srtListA)
        {
            var intN = int.Parse(strN);
            var intX = int.Parse(strX);
            var intListA = srtListA.Select(a => int.Parse(a)).ToArray();

            for (int i = 0; i < intN; i++)
            {
                if (intX == intListA[i])
                {
                    return "Yes";
                }
            }
            return "No";
        }
    }
}