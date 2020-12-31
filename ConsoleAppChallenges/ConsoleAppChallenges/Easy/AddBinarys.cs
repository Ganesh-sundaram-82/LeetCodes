using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenges.Easy
{
    public class AddBinarys
    {
        public AddBinarys()
        {

        }

        /*
         Given two binary strings a and b, return their sum as a binary string.
Example 1:

Input: a = "11", b = "1"
Output: "100"
Example 2:

Input: a = "1010", b = "1011"
Output: "10101"
 

Constraints:

1 <= a.length, b.length <= 104
a and b consist only of '0' or '1' characters.
Each string does not contain leading zeros except for the zero itself.

         */
        public string AddBinary(string a, string b)
        {
            var loopNeeded = false;
            var iIndex1 = 0;
            var iIndex2 = 0;
            var carryForward = 0;
            StringBuilder sbresult = new StringBuilder();
            while (!loopNeeded)
            {
                if(iIndex1 < a.Length && iIndex2 < b.Length)
                {
                    if(a.Substring(iIndex1, 1) == "1" && b.Substring(iIndex2, 1) == "1")
                    {
                        carryForward = 1;
                        sbresult.Append("0");
                    }
                    else if (a.Substring(iIndex1, 1) == "1" && b.Substring(iIndex2, 1) == "0")
                    {
                        carryForward = 0;
                        sbresult.Append("1");
                    }
                    else if (a.Substring(iIndex1, 1) == "0" && b.Substring(iIndex2, 1) == "1")
                    {
                        carryForward = 0;
                        sbresult.Append("1");
                    }
                    else if (a.Substring(iIndex1, 1) == "0" && b.Substring(iIndex2, 1) == "0")
                    {
                        carryForward = 0;
                        sbresult.Append("1");
                    }
                }
                else if(iIndex1 < a.Length)
                {
                    
                }
                else if(iIndex2 < b.Length)
                {

                }
            }
            return string.Empty;
        }
    }
}
