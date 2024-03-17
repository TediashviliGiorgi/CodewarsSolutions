using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sol23
{
    internal class Solution
    {
        public static BigInteger[] PowersOfTwo(int n)
        {
            BigInteger[] result = new BigInteger[n + 1];

            for (int i = 0; i <= n; i++)
            {
                result[i] = BigInteger.Pow(2, i);
            }

            return result;
    }
    }
}
