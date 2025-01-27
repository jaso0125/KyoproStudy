namespace KyoproStudy.Chapter1
{
    public static partial class A04
    {
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