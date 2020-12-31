using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenges.Easy
{
   public class PlusOnes
    {
        public PlusOnes()
        {
        }

        public int[] PlusOne(int[] digits)
        {
            int[] result = new int[digits.Length];
            int carryForward = 1;
            for(int i = digits.Length - 1; i>=0; i--)
            {
                if (i == 0)
                {
                    if (digits[i] + carryForward > 9)
                    {
                        Array.Resize(ref result, digits.Length + 1);
                        result[i] = (carryForward + digits[i]) / 10;
                        result[i + 1] = (carryForward + digits[i]) % 10;
                    }
                    else
                    {
                        result[i] = carryForward + digits[i];
                    }
                }
                else
                {
                    if (digits[i] + carryForward > 9)
                    {
                        carryForward = (digits[i] + 1) / 10;
                        result[i] = (digits[i] + 1) % 10;
                    }
                    else
                    {
                        result[i] = digits[i] + carryForward;
                        carryForward = 0;
                    }
                }
            }
            return result;
        }
    }
}
