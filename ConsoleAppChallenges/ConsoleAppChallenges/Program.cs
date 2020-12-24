using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            LongestCommonPrefixs longestCommonPrefixs = new LongestCommonPrefixs();
            //Console.WriteLine(  longestCommonPrefixs.LongestCommonPrefix(new List<string>() {"a", "ab" }.ToArray()));
            Console.WriteLine(longestCommonPrefixs.LongestCommonPrefix(new List<string>() {"flower","flow","flight","Test" }.ToArray()));
            Console.ReadLine();
        }
    }
}
