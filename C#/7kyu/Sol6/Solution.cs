using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol6
{
    public class Solution
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> numbers = new List<int>();
            foreach (object item in listOfItems)
            {
                if (item is int) numbers.Add((int)item);
            }

            return numbers;
        }
    }
}
