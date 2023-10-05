using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Hard
{
    class RegularExpressionMatching
    {
        public bool Solution(string s, string p)
        {
            if (p.Length == 0 && s.Length == 0)
            {
                return true;
            }

            if (p.Length == 0 && s.Length > 0)
            {
                return false;
            }

            var isAny = p[0] == '.';
            var isMulti = p.Length > 1 && p[1] == '*';

            if (s.Length == 0 && !isMulti)
            {
                return false;
            }

            if (!isAny && !isMulti)
            {
                if (s[0] == p[0])
                {
                    return Solution(s.Substring(1, s.Length - 1), p.Substring(1, p.Length - 1));
                }
                return false;
            }

            if (isAny && !isMulti)
            {
                return Solution(s.Substring(1, s.Length - 1), p.Substring(1, p.Length - 1));
            }

            var count = 0;
            while (count < s.Length && (isAny || s[count] == p[0]))
            {
                count++;
            }

            while (count >= 0)
            {
                var nextResult = Solution(s.Substring(count, s.Length - count), p.Substring(2, p.Length - 2));
                if (nextResult)
                {
                    return true;
                }

                count--;
            }

            return false;
        }
    }
}
