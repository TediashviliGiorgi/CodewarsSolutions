using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol9
{
    internal class Solution
    {

        public static double GCD(double a, double b)
        { 
            if (b == 0)
                return a;

            return GCD(b, a % b);
        }

        public static double LCMm2n(int m, int n)
        {
          
            List<double> numbers = new List<double>();
            if (m != 0 || n != 0)
            {
                int range = Math.Abs(m - n);
                int minInRange = Math.Min(m, n);
                int maxInRange = Math.Max(m, n);
                for (int i = minInRange; i <= maxInRange; i++) 
                {
                       numbers.Add(i);
                }    
            }

            if (numbers.Count == 0)
                return 0;

            double lcm = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                int gcd = (int)GCD(lcm, numbers[i]);

                lcm = (lcm * numbers[i]) / gcd;
            }

            return lcm;

        }
    }
}
