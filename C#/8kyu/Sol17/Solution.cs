using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol17
{
    internal class Solution
    {
        public static int TotalPoints(string[] games)
        {
            int point = 0;
            foreach (var game in games)
            {

                int x = int.Parse(game[0].ToString());
                int y = int.Parse(game[2].ToString());

                point = x > y ? point += 3 : x < y ? point += 0 : point += 1;

            }
            return point;
        }
    }
}
