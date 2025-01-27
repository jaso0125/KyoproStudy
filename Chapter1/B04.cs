namespace KyoproStudy.Chapter1
{
    public static partial class B04
    {
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