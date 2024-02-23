using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol12
{
    internal class Solution
    {
        public static bool IsCube(double volume, double side)
        {

            if (volume <= 0 || side <= 0)
            {
                return false;
            }
            else if(Math.Pow(volume, 1.0 / 3.0) == side)
            {
                return true;
            }
            return false;           
        }
    }
}
