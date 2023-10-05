using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Medium
{
    class AddTwoNumbers
    {
        public ListNode Solution(ListNode l1, ListNode l2, int remainder = 0)
        {
            if (l1 == null && l2 == null && remainder == 0) return null;
            int val1 = l1 != null ? l1.val : 0;
            int val2 = l2 != null ? l2.val : 0;
            int newVal = val1 + val2 + remainder;
            remainder = newVal / 10;
            return new ListNode(newVal % 10, Solution(l1?.next, l2?.next, remainder));
        }
    }
}
