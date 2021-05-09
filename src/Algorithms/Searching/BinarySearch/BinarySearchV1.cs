using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching.BinarySearch
{
    public class BinarySearchV1
    {
        public int Find(int[] values, int value)
        {
            return Find(values, 0, values.Length - 1, value);
        }

        private int Find(int[] values, int start, int end, int value)
        {
            if (start > end)
            {
                return -1;
            }

            var mid = start +  ((end - start + 1) >> 1);

            //Case 1 : When value is equal to mid element
            //Action : Return mid index
            if (values[mid] == value)
            {
                return mid;
            }

            //Case 2 : When value is greater than mid element
            //Action : Search right half
            if (value > values[mid])
            {
                return Find(values, mid + 1, end, value);
            }

            //Case 3 : When value is less than mid element
            //Action : Search left half
            return Find(values, start, mid - 1, value);
        }
    }
}
