using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenges.Easy
{
    public class strStr
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Trim().Length == 0 || haystack.Trim().Length == 0)
                return 0;

            return haystack.IndexOf(needle);
        }
    }
}
