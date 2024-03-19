using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol25
{
    internal class Solution
    {
        public static int[] GenerateRange(int min, int max, int step)
        {
            List<int> list = new List<int>();
            for (int i = min; i <= max;)
            {
                list.Add(i);

                i+= step;
            }

            return list.ToArray();
        }
    }
}
