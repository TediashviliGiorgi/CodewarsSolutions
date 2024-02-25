using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sol15
{
    internal class Solution
    {
        public static int[] Maps(int[] x)
        {
            //LINQ
            int[] doubledNumbers = x.Select(x => x * 2).ToArray();

            //loop
            //int[] doubledNumbers = new int[x.Length];

            //for (int i = 0; i < x.Length; i++ )
            //{
            //    doubledNumbers[i] = x[i] * 2;
            //}
            return doubledNumbers;
        }
    }
}
