using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Medium
{
    class ReverseInteger
    {
        public int Reverse(int x)
        {
            if (x == 0) return 0;
            string s = x.ToString();
            if (Int32.TryParse(s, out _))
            {
                string str = "";
                int result = 0;
                int start = x < 0 ? 1 : 0;
                Stack<char> stack = new Stack<char>();
                for (int i = start; i < s.Length; i++)
                {
                    stack.Push(s[i]);
                }
                for (int i = start; i < s.Length; i++)
                {
                    char c = stack.Pop();
                    if (c == '0' && i == start)
                    {
                        continue;
                    }
                    else
                    {
                        str += c;
                    }
                }
                if (!Int32.TryParse(str, out _)) return 0;
                return x < 0 ? result - Int32.Parse(str) : result + Int32.Parse(str);
            }
            else
            {
                return 0;
            }
        }
    }
}
