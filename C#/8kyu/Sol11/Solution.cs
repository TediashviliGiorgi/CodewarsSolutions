using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol11
{
    public class Solution
    {
        public static int Multiply(int number)
        {
            var numLength = Math.Abs(number).ToString().Length;

            var multiplier = Math.Pow(5, numLength);

            var result = number * multiplier;
            return (int)result;
        }
    }
}
