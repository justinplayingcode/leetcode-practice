using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
    class LongestCommonPrefix
    {
        public string LongestCommon(string[] strs)
        {
            if (strs.Length == 0) return "";
            string firstStr = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(firstStr) != 0)
                {
                    firstStr = firstStr[..^1];
                    if (String.IsNullOrEmpty(firstStr)) return "";
                }
            }
            return firstStr;
        }
    }
}
