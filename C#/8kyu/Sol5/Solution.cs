using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Sol5
{
    public class Solution
    {
        public static string[] FixTheMeerkat(string[] arr)
        {
            if(arr != null || arr.Length == 3)
            {
                var realTail = arr[0];
                var realHead = arr[arr.Length - 1];
                arr[arr.Length - 1] = realTail;
                arr[0] = realHead;
            }

            return arr;
        }
    }
}
