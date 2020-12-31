using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenges.Easy
{
    /*
     Given a sorted array of distinct integers and a target value, return the index if the target is found. 
    If not, return the index where it would be if it were inserted in order.

Example 1:

Input: nums = [1,3,5,6], target = 5
Output: 2
Example 2:

Input: nums = [1,3,5,6], target = 2
Output: 1
Example 3:

Input: nums = [1,3,5,6], target = 7
Output: 4
Example 4:

Input: nums = [1,3,5,6], target = 0
Output: 0
Example 5:

Input: nums = [1], target = 0
Output: 0

Constraints:
1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums contains distinct values sorted in ascending order.
-104 <= target <= 104

*/

    public class SearchInsertPosition
    {

        public int SearchInsert(int[] nums, int target)
        {

            if(nums.Length == 1)
            {
                if (nums[0] == target)
                    return 0;
                else if (target < nums[0])
                    return 0;
                else
                    return 1;
            }

            for(int i =0; i< nums.Length; i++)
            {
                if(nums[i] == target)
                {
                    return i;
                }
                else if ((i + 1) < nums.Length && (target < nums[i]))
                {
                    return i;
                }
                else if ((i + 1) < nums.Length && ((nums[i] < target && nums[i + 1] > target)))
                {
                    return i + 1;
                }
                else if((((i +1) >= nums.Length)))
                {
                    return i + 1;
                }
              
            }

            return -1;
        }


    }
}
