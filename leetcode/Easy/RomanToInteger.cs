using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
    class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int result = 0, tmp = 0;
            var dic = new Dictionary<char, int>();
            dic.Add('I', 1);
            dic.Add('V', 5);
            dic.Add('X', 10);
            dic.Add('L', 50);
            dic.Add('C', 100);
            dic.Add('D', 500);
            dic.Add('M', 1000);
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (dic[s[i]] >= tmp)
                {
                    result += dic[s[i]];
                }
                else
                {
                    result -= dic[s[i]];
                }
                tmp = dic[s[i]];
            }
            return result;
        }
    }
}
