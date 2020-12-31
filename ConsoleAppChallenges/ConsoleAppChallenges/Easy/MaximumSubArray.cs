using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenges.Easy
{
    public class MaximumSubArray
    {
        public MaximumSubArray()
        {

        }

        public int MaxSubArray(int[] nums)
        {
            if (nums.Length <= 1)
                return nums[0];


            int ArraySet = nums.Length / 2;
            bool iDone = false;
            int iIndex = 0;
            while (!iDone)
            {
                if(iIndex < nums.Length && (iIndex+ArraySet) < nums.Length)
                {
                    Console.WriteLine($"{nums[iIndex]} - {nums[iIndex + ArraySet]}");
                    iIndex++;
                }else
                {
                    iDone = true;
                }
            }

            return int.MaxValue;
        }
    }
}
