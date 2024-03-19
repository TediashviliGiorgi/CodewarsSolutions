using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol30
{
    internal class Solution
    {
        public static int[] Flip(char dir, int[] arr)
        {
            return dir == 'R' ? arr.OrderBy(x => x).ToArray() : arr.OrderByDescending(x => x).ToArray();
        }
    }
}
