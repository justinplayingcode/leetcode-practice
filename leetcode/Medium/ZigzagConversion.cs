using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Medium
{
    class ZigzagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;
            int column = 0, currentRow = 0, maxRows = numRows;
            var arr = new char[numRows, s.Length];
            var result = new StringBuilder();
            foreach (char c in s)
            {
                arr[currentRow, column] = c;
                if (currentRow == maxRows - 1)
                {
                    column++;
                    if (column % numRows != 0)
                    {
                        currentRow--;
                        maxRows = currentRow + 1;
                        continue;
                    }
                    else
                    {
                        currentRow = 0;
                        maxRows = numRows;
                    }
                }
                currentRow++;
            }
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < s.Length; col++)
                {
                    if (arr[row, col] > 0)
                    {
                        result.Append(arr[row, col]);
                    }
                }
            }
            return result.ToString();
        }
    }
}
