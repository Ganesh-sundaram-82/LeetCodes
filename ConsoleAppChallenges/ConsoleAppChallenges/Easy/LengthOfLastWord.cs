using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenges.Easy
{
    public class LengthOfLastWords
    {
        public LengthOfLastWords()
        {
        }

        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            if (s != "")
            {
                var data = s.Trim().Split(' ');
                return data[data.Length - 1].Length;
            }

            return 0;

           //// if (s.Trim().Length == 0)
           ////     return 0;

           //// string lastdata = string.Empty;
           ////foreach(var data in s.Split(' '))
           //// {
           ////     if (data != "")
           ////         lastdata = data;
           //// }
           //// return lastdata.Length;
        }
    }
}
