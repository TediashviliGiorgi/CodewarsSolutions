using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol16
{
    internal class Solution
    {
        public static int Pillars(int numPill, int dist, int width)
        {
            if (numPill == 1)
            {
                return 0;
            }
            else if (numPill >= 1 && dist <=30 && dist >= 10 && width >= 10 && width <= 50)
            {                
                var totalWidth = (numPill - 2) * width;
                var totalDistance = dist * 100 * (numPill - 1) + totalWidth;

                return totalDistance;
            }

            return -1;
        }
    }
}
