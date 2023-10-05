using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Medium
{
    class MajorityElementII
    {
        public IList<int> Solution(int[] nums)
        {
            var result = new List<int>();
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], 1);
                }
                else
                {
                    dic[nums[i]]++;
                }
            }
            foreach (int i in dic.Keys)
            {
                if (dic[i] > (nums.Length / 3))
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
