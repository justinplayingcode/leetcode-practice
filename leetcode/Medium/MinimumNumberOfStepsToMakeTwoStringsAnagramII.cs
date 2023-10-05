using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Medium
{
    class MinimumNumberOfStepsToMakeTwoStringsAnagramII
    {
        public int MinSteps(string s, string t)
        {
            var dic = new Dictionary<char, int>();
            int temp = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], 1);
                }
                else
                {
                    dic[s[i]]++;
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (dic.ContainsKey(t[i]) && dic[t[i]] != 0)
                {
                    dic[t[i]]--;
                }
                else
                {
                    temp++;
                }
            }
            foreach (int c in dic.Values)
            {
                temp += c;
            }

            return temp;
        }
    }
}
