namespace KyoproStudy.Chapter1
{
    public partial class B04 : ISolveProblem
    {
        public void SolveProblem()
        {
            // 標準入力
            var value = Console.ReadLine();

            var result = BinaryRepresentation2(value);

            // 標準出力
            Console.Write(result);
        }

        public static int BinaryRepresentation2(string strN)
        {
            var result = 0;

            for (int i = 0; i < strN.Length; i++)
            {
                result += int.Parse(strN.Substring(i, 1)) * (1 << strN.Length - 1 - i);
            }
            return result;
        }
    }
}