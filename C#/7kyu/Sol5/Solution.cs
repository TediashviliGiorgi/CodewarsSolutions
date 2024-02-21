using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol5
{
    public class Solution
    {
        public static string FlipNumber(string n)
        {
            char[] chars = n.ToCharArray();
            int length = chars.Length;

            for (int i = 0; i < length; i++)
            {
                Array.Reverse(chars, i, length - i);
            }

            var result = new string(chars);
            return result;
        }
    }
}
