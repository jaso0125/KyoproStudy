namespace KyoproStudy
{
    public static partial class A03
    {
        public static string TwoCards(string strN, string strK, string[] strArrayP, string[] strArrayQ)
        {
            var intN = int.Parse(strN);
            var intK = int.Parse(strK);
            var intArrayP = strArrayP.Select(x => int.Parse(x)).ToArray();
            var intArrayQ = strArrayQ.Select(x => int.Parse(x)).ToArray();

            for (var i = 0; i < intN; i++)
            {
                for (var j = 0; j < intN; j++)
                {
                    if (intArrayP[i] + intArrayQ[j] == intK)
                    {
                        return "Yes";
                    }
                }
            }
            return "No";
        }
    }
}