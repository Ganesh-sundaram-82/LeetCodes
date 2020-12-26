using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenges.Easy
{
    public class strStr
    {
        /// <summary>
        /// Write the detail code, instead of using .NET library functions
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrStr(string haystack, string needle)
        {
            if (needle.Trim().Length == 0 || haystack.Trim().Length == 0)
                return 0;

            return haystack.IndexOf(needle);
        }
    }
}
