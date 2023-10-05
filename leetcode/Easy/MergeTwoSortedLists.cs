using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Easy
{
    class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode? list1, ListNode? list2)
        {
            var arr1 = ConverListNodeToArray(list1);
            var arr2 = ConverListNodeToArray(list2);
            if (arr1 == Array.Empty<int>() && arr2 == Array.Empty<int>()) return null;
            var arr = SortArray(arr1, arr2);
            var result = new ListNode();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                result = new ListNode() { val = arr[i], next = i == arr.Length - 1 ? null : result };
            }
            return result;
        }
        public int[] ConverListNodeToArray(ListNode? list)
        {
            if (list == null) return Array.Empty<int>();
            var _list = new List<int>();
            while (list != null)
            {
                _list.Add(list.val);
                list = list.next;
            }
            return _list.Count > 0 ? _list.ToArray() : Array.Empty<int>();
        }

        public int[] SortArray(int[] a, int[] b)
        {
            var newArray = new int[a.Length + b.Length];
            Array.Copy(a, newArray, a.Length);
            Array.Copy(b, 0, newArray, a.Length, b.Length);
            Array.Sort(newArray);
            return newArray;
        }
    }
}
