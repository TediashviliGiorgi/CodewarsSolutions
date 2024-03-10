using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol7
{
    internal class Solution
    {
        public static (int, int) OwnedCatAndDog(int catYears, int dogYears)
        {
            return (catYears < 15 ? 0 : catYears < 24 ? 1 : (catYears - 24) / 4 + 2,
                dogYears < 15 ? 0 : dogYears < 24 ? 1 : (dogYears - 24) / 5 + 2);
        }
    }
}
