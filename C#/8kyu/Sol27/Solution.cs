using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol27
{
    internal class Solution
    {
        public static int CloseCompare(double a, double b, double margin = 0)
        {
            int result;
            double distance = a - b;
            if (Math.Abs(distance) <= Math.Abs(margin))
            {
                result = 0;
            }
            else if (distance < 0)
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
