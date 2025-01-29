namespace KyoproStudy.Chapter1
{
    public partial class A01 : ISolveProblem
    {
        public void SolveProblem()
        {
            // 標準入力
            var value = Console.ReadLine();

            var result = CalculateSquareArea(value!);

            // 標準出力
            Console.Write(result);
        }

        public static int CalculateSquareArea(string x)
        {
            var length = int.Parse(x);

            return length * length;
        }
    }
}