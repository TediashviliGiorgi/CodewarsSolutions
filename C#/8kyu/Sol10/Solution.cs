using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol10
{
    public class Solution
    {
        public static int[] MonkeyCount(int n)
        {
            int[] monkeys = new int[n];
            if (n > 0)
            {
                for (int i = 0; i < n; i++) monkeys[i] = i + 1;
                return monkeys;
            }
            return monkeys;
        } 
    }
}
