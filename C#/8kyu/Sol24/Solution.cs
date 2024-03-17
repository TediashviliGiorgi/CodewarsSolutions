using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol24
{
    internal class Solution
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            int[] resultArr = new int[2];

            int countPositiveNumbers = 0;
            int sumNegativeNumbers = 0;
            if (input == null || input.Length == 0)
            {
                return new int[0];
            }
            else
            {
                foreach (var number in input)
                {
                    if (number > 0)
                    {
                        countPositiveNumbers++;
                    }
                    else if (number < 0)
                    {
                        sumNegativeNumbers += number;
                    }
                }

                resultArr[0] = countPositiveNumbers;
                resultArr[1] = sumNegativeNumbers;

                return resultArr;
            }
        }
    }
}
