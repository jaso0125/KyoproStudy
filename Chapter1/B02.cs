namespace KyoproStudy.Chapter1
{
    public partial class B02 : ISolveProblem
    {
        public void SolveProblem()
        {
            // 標準入力
            var value = Console.ReadLine().Split(' ');

            var result = DivisorCheck(value[0], value[1]);

            // 標準出力
            Console.Write(result);
        }

        public static string DivisorCheck(string strA, string strB)
        {
            var intA = int.Parse(strA);
            var intB = int.Parse(strB);

            var divisorList = new List<int> { 1, 2, 4, 5, 10, 20, 25, 50, 100 };

            for (var i = intA; i <= intB; i++)
            {
                if (divisorList.Contains(i))
                {
                    return "Yes";
                }
            }
            return "No";
        }
    }
}