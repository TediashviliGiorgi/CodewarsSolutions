using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol7
{
    public class Solution
    {
        public static int[] InvertValues(int[] input)
        {
            int[] result = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 0)
                {
                    result[i] = Math.Abs(input[i]);
                }
                else if (input[i] > 0)
                {
                    result[i] = input[i] * -1;
                }
                else
                {
                    result[i] = 0;
                }
            }
            return result;
        }
    }
}
