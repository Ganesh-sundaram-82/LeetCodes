using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenges
{
/*
Write a function to find the longest common prefix string amongst an array of strings.
If there is no common prefix, return an empty string "".

Example 1:
Input: strs = ["flower","flow","flight"]
Output: "fl"

Example 2:
Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.

Constraints:
    0 <= strs.length <= 200
    0 <= strs[i].length <= 200
    strs[i] consists of only lower-case English letters.

*/
    public class LongestCommonPrefixs
    {
        public LongestCommonPrefixs()
        {
        }

        /// <summary>
        /// Solution #1
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix(string[] strs)
        {
            var response = string.Empty;
            var result = new StringBuilder();
            if (strs.Length > 0)
            {
                response = strs[0];
                for (int i = 1; i < strs.Length; i++)
                {
                    if (response.Length == 0)
                        break;
                    for (int j = 0; j < strs[i].Length; j++)
                    {
                        if (j < response.Length && response[j]== strs[i][j])
                        {
                            result.Append(response[j]);
                        }
                        else
                        {
                            break;
                        }
                    }
                    response = result.ToString();
                    result.Clear();
                }
            }
            return response;
        }
    }
}
