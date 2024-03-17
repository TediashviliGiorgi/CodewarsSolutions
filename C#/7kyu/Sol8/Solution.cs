using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sol8
{
    internal class Solution
    {
        public static bool PossiblyPerfect(string[] key, string[] ans)
        {
            bool anyCorrectRevealed = false;
            bool anyIncorrectRevealed = false;

            for (int i = 0; i < key.Length; i++)
            {
                if (key[i] != "_")
                {
                    if (key[i] == ans[i])
                    {
                        anyCorrectRevealed = true;
                    }
                    else
                    {
                        anyIncorrectRevealed = true;
                    }
                }
            }

            // Return true only if not both correct and incorrect answers are revealed.
            return !(anyCorrectRevealed && anyIncorrectRevealed);
        }
    }
}
