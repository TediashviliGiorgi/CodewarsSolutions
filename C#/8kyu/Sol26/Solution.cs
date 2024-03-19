using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol26
{
    internal class Solution
    {
        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            var dividables = numbers.Where(number => number % divisor == 0).ToArray();
            return dividables;
        }
    }
}
