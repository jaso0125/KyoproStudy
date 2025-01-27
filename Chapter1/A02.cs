using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyoproStudy.Chapter1
{
    public static partial class A02
    {
        public static string linearSearch(string strN, string strX, List<string> srtListA)
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