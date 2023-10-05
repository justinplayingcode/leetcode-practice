using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Hard
{
    class LongestValidParentheses
    {
        public int Solution(string s)
        {
            var stringValided = ValidString(s);
            if (stringValided.Length < 2) return 0;
            var a = stringValided.Length;
            var listRes = new List<int>();
            for (int i = 0; i < stringValided.Length; i++)
            {
                if (stringValided[i] == ')')
                {
                    listRes.Add(0);
                    continue;
                }
                var count = 0;
                var lenght = 0;
                for (int temp = i; temp < stringValided.Length; temp++)
                {

                    if (stringValided[temp] == '(')
                    {
                        count++;
                        lenght++;
                    }
                    if (stringValided[temp] == ')')
                    {
                        count--;
                        lenght++;
                    }
                    if (count < 0)
                    {
                        listRes.Add(lenght - 1);
                        break;
                    }
                    else if (count == 0)
                    {
                        listRes.Add(lenght);
                    }
                    if (temp == (stringValided.Length - 1)) listRes.Add(count == 0 ? lenght : 0);
                }
            }
            return listRes.ToArray().Max();
        }
        public string ValidString(string s)
        {
            if (s.Length <= 1) return "";
            if (s[0] == ')') return ValidString(s.Substring(1, s.Length - 1));
            if (s[s.Length - 1] == '(') return ValidString(s.Substring(0, s.Length - 1));
            return s;
        }
    }
}
