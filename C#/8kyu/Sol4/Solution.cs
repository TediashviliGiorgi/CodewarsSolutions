using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol4
{
    public class Solution
    {
        public static int Sum(int[] numbersArr) 
        {
            if(numbersArr == null || numbersArr.Length <= 1)
            {
                return 0;
            }
            else
            {
                Array.Sort(numbersArr);

                int[] newArr = new int[numbersArr.Length];
                Array.Copy(numbersArr, 1, newArr, 0, numbersArr.Length - 2);
                int sum = newArr.Sum();

                return sum;
            }
        }
    }
}
