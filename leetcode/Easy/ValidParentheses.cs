using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
    class ValidParentheses
    {
        public bool IsValid(string s)
        {
            if (s.Length < 2) return false;
            var stack = new Stack<char>();
            var example = new string[] { "()", "[]", "{}" };
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    string temp = stack.Pop().ToString() + c;
                    if (!example.Contains(temp))
                    {
                        return false;
                    }
                }

            }
            return stack.Count == 0;
        }
    }
}
