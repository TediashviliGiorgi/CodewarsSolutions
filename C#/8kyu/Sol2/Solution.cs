using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol2
{
    public class Solution
    {
        public static int StrCount(string str, char letter)
        {
            List<char> ListChars = new List<char>();

            if (letter != '\0')
            {
                foreach (char symbol in str)
                {
                    if(char.ToLower(symbol) == char.ToLower(letter))
                    {
                        ListChars.Add(symbol); 
                    }
                }
            }

            return ListChars.Count();
        }
    }
}
