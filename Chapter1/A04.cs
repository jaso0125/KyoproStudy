namespace KyoproStudy.Chapter1
{
    public partial class A04 : ISolveProblem
    {
        public void SolveProblem()
        {
            // 標準入力
            var value = Console.ReadLine();

            var result = BinaryRepresentation1(value);

            // 標準出力
            Console.Write(result);
        }

        public static string BinaryRepresentation1(string strN)
        {
            var intN = int.Parse(strN);
            var result = "";
            for (int i = 0; i < 10; i++)
            {
                result = (intN % 2).ToString() + result;
                intN = intN / 2;
            }
            return result;
        }
    }
}