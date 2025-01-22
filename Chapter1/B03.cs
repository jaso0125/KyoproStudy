using System.Data;

namespace KyoproStudy.Chapter1
{
    public static partial class B03
    {
        public static string Supermarket1(string strN, string[] strArrayA)
        {
            var intN = int.Parse(strN);
            var intArrayA = strArrayA.Select(x => int.Parse(x)).ToArray();

            for (var i = 0; i < intN; i++)
            {
                for (var j = i + 1; j < intN; j++)
                {
                    for (var k = j + 1; k < intN; k++)
                    {
                        if (intArrayA[i] + intArrayA[j] + intArrayA[k] == 1000)
                        {
                            return "Yes";
                        }
                    }
                }
            }
            return "No";
        }
    }
}