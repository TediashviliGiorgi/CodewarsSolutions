using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol1
{
    public class Solution
    {
        public static string toTime(int seconds)
        {
            var secondsAfterDovide = seconds % 3600;
            var hours = (seconds - secondsAfterDovide) / 3600;
            var minutes = Math.Floor((double)secondsAfterDovide / 60);

            return $"{hours} hour(s) and {minutes} minute(s)";
        }
    }
}
