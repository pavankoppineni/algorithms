using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching.BinarySearch
{
    public class BinarySearchV2
    {
        public int Search(int[] values, int number)
        {
            return Search(values, 0, values.Length - 1, number);
        }

        private int Search(int[] values, int start, int end, int number)
        {
            if (start > end)
            {
                return -1;
            }

            if (start == end)
            {
                return start;
            }

            var mid = start + ((end - start) >> 1);
            if (number == values[mid])
            {
                return mid;
            }

            if (values[mid] > number)
            {
                return Search(values, start, mid - 1, number);
            }

            return Search(values, mid + 1, end, number);
        }
    }
}
