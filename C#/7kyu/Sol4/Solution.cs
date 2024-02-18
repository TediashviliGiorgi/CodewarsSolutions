using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol4
{
    public class Solution
    {
        public static int Rounders(int Value)
        {
            string numberString = Value.ToString();

            List<int> digits = new List<int>();

            foreach(char digitChar in numberString)
            {
                digits.Add(int.Parse(digitChar.ToString()));
            }

            for (int i = digits.Count - 1; i > 0; i--)
            {
                var digit = digits[i];
                if (digit < 5)
                {
                    digits[i] = 0;
                }
                else if(digit >= 5)
                {
                    digits[i] = 0;
                    digits[i - 1] = digits[i - 1] + 1;
                }
            }
            
            int number = 0;
            foreach (int digit in digits)
            {
                number = number * 10 + digit;
            }

            return number;
        }
    }
}
