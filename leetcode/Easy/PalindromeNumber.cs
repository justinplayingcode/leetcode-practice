using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
    class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            string str = x.ToString();
            string result = "";
            Stack stack = new Stack();
            foreach (char c in str)
            {
                stack.Push(c);
            }
            for (int i = 0; i < str.Length; i++)
            {
                result += stack.Pop();
            }

            return str == result;
        }
    }
}
