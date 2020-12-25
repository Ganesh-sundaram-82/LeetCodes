using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenges.Easy
{
    /*
     Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
 

Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
Example 4:

Input: s = "([)]"
Output: false
Example 5:

Input: s = "{[]}"
Output: true
 

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.

     */

    public class ValidParenthesis
    {
        public ValidParenthesis()
        {
            
        }

        public bool IsValid(string s)
        {
            Stack<char> vs = new Stack<char>();
            var paraenthsis = "(){}[]";
            foreach (var par in s)
            {
                if (true)
                {
                    if (par == '}')
                    {
                        if (vs.Count == 0 || vs.Pop() != '{')
                            return false;
                    }
                    else if (par == ']')
                    {
                        if (vs.Count == 0 || vs.Pop() != '[')
                            return false;
                    }
                    else if (par == ')')
                    {
                        if (vs.Count == 0 || vs.Pop() != '(')
                            return false;
                    }
                    else
                        vs.Push(par);
                }
            }

            return vs.Count ==0;
        }
    }
}
