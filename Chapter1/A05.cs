using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyoproStudy.Chapter1
{
    public static partial class A05
    {
        public static int ThreeCards(string strN, string strK)
        {
            var intN = int.Parse(strN);
            var intK = int.Parse(strK);

            var count = 0;

            for (var i = 1; i < intN + 1; i++)
            {
                for (var j = 1; j < intN + 1; j++)
                {
                    {
                        var k = intK - i - j;
                        if (k >= 1 && k <= intN)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}