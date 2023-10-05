using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Medium
{
    class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int max = 0,
                 begin = 0,
                 end = height.Length - 1,
                 temp;
            while (begin < end)
            {
                int _height;
                if (height[begin] < height[end])
                {
                    _height = height[begin];
                    begin++;
                }
                else
                {
                    _height = height[end];
                    end--;
                }
                temp = _height * (end - begin + 1);
                max = Math.Max(max, temp);
            }
            return max;
        }
    }
}
