using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyoproStudy.Chapter1
{
    public static partial class A01
    {
        public static int CalculateSquareArea(string x)
        {
            var length = int.Parse(x);

            return length * length;
        }
    }
}