namespace KyoproStudy.Chapter1
{
    public partial class B01 : ISolveProblem
    {
        public void SolveProblem()
        {
            // 標準入力
            var value = Console.ReadLine().Split(' ');

            var result = SumAandB(value[0], value[1]);

            // 標準出力
            Console.Write(result);
        }

        public static int SumAandB(string a, string b)
        {
            var intA = int.Parse(a);
            var intB = int.Parse(b);

            return intA + intB;
        }
    }
}