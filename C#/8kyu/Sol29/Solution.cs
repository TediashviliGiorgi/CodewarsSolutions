using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol29
{
    internal class Solution
    {
        public static int CountSheeps(bool[] sheeps)
        {
            int count = 0;
            for (int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i] == null)
                {
                    continue;
                }
                else if (sheeps[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
