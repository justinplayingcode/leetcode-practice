using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Medium
{
    class CountAndSay
    {
        public string Solution(int n)
        {
            string str = "1";
            int count = 1;
            while (count < n)
            {
                str = NewCountAndSay(str);
                count++;
            }
            return str;
        }
        public string NewCountAndSay(string str)
        {
            int count = 0;
            char curChar = str[0];
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != curChar)
                {
                    result += count.ToString() + curChar;
                    count = 1;
                    curChar = str[i];
                }
                else
                {
                    count++;
                }
                if (i == str.Length - 1)
                {
                    result = result + count.ToString() + str[i];
                }
            }
            return result;
        }
    }
}
