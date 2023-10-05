using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Medium
{
    class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            var list = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!list.Contains(s[i]))
                {
                    list.Add(s[i]);
                }
                else
                {
                    max = Math.Max(max, list.Count);
                    list = list.GetRange(list.IndexOf(s[i]) + 1, list.Count - list.IndexOf(s[i]) - 1);
                    list.Add(s[i]);
                };
            }
            return Math.Max(max, list.Count);
        }
    }
}
