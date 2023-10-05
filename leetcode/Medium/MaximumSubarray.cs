using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace leetcode.Medium
{
    class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int max = nums[0], sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = Math.Max(nums[i], nums[i] + sum);
                max = Math.Max(sum, max);
            }
            return max;
        }
    }
}
