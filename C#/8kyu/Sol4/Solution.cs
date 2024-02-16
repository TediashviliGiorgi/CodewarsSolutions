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
            Array.Sort(numbersArr);
            
            int highestNumber = numbersArr[numbersArr.Length - 1];
            int lowestNumber = numbersArr[0];

            int[] newArr = new int[numbersArr.Length];
            Array.Copy(numbersArr, 1, newArr, 0, numbersArr.Length - 2);
            int sum = newArr.Sum();

            return sum;
        }
    }
}
