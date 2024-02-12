using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summation
{
    public class Solution
    {
        public static int summation(int num)
        {
            int sum = 0;
            int increment = 1;
       

            while (increment != num + 1)
            {
                sum += increment;
                increment++;
            }

            return sum;
        }
    }
}
