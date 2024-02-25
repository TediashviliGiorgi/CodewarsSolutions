using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Sol3
{
    public class Solution
    {
        public static double CloseCompare(double a, double b, double margin = 0)
        {
            double result;
            double distance = a - b;
            if (Math.Abs(distance) < Math.Abs(margin))
            {
                result = 0;
            }
            else if (Math.Abs(distance) < 0)
            {
                result = -1;
            }
            else
            {
                result = 1;
            }
            return result;
        }
    }
}
