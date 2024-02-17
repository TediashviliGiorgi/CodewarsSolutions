using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol2
{
    public class Solution
    {
        public static string HighAndLow(string numbers)
        {
            List<string> numList =  numbers.Split(' ').ToList();
            List<int> convertedList = numList.Select(int.Parse).ToList();

            var maxValue = convertedList.Max();
            var minValue = convertedList.Min();

            return $"{maxValue} {minValue}";
        }
    }
}
