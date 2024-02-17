using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol3
{
    internal class Solution
    {
        public static int[] minMax(int[] lst)
        {   
            List<int> result = new List<int>();

            var minValue = lst.Min();
            var maxValue = lst.Max();

            result.Add(minValue);
            result.Add(maxValue);

            return result.ToArray();

        }
    }    
}
