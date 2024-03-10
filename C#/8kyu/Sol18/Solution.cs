using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sol18
{
    internal class Solution
    {
        public static List<int> FindMultiples(int integer, int limit)
        {
            List<int> multiplies = new List<int>(); 
            for (int i = limit; i > 0; i--)
            {
                if(i % integer == 0)
                {
                    multiplies.Add(i);
                }
            }
            return multiplies;
        }
    }
}
