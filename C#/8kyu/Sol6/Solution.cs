using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol6
{
    public class Solution
    {
        public static string ToCsvText(int[][] array)
        {
            string csv = "";

            for (int i = 0; i < array.Length; i++)
            {
                csv += string.Join(",", array[i]) + "\n";
            }

            
            return csv.TrimEnd('\n');
        }
    }
}
