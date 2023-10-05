using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Medium
{
    class MaximizeNumberOfSubsequencesInAString
    {
        public long MaximumSubsequenceCount(string text, string pattern)
        {
            long total = 0, count1 = 0, count2 = 0;
            if (pattern[0] == pattern[1])
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == pattern[1])
                    {
                        count1++;
                        total += count1;
                    }
                }
                return total;
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == pattern[1])
                    {
                        total += count1;
                        count2++;
                    }
                    else if (text[i] == pattern[0])
                    {
                        count1++;
                    }
                }
                return total + Math.Max(count1, count2);
            }
        }
    }
}
