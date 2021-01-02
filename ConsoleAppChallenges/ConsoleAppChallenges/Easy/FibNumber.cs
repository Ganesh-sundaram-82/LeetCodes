using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenges.Easy
{
    public class FibNumber
    {
        public FibNumber()
        {
        }

        public void FibNum(int n)
        {
            int a = -1, b = 1;

            for(int i = 0;i < n; i++)
            {
                var c = a + b;
                Console.Write($" {c}");
                a = b;
                b = c;
            }
        }
    }
}
