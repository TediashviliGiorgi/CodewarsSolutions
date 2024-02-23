using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol8
{
    public class Solution
    {
        public static string HowMuchILoveYou(int nb_petals)
        {
            if(nb_petals > 0)
            {
                List<string> list = new List<string>() { "I love you", "a little", "a lot", "passionately", "madly", "not at all" };

                int index = nb_petals % (list.Count);

                if(index == 0)
                {
                    return list[list.Count - 1];                }

                return list[index - 1];
            }
            return "Useless flower";
        }
    }
}
