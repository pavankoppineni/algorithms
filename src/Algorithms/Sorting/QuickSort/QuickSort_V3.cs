using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.QuickSort
{
    public class QuickSort_V3
    {
        public int[] Sort(int[] values)
        {
            Sort(0, values.Length - 1, values);
            return values;
        }

        private void Sort(int start, int end, int[] values)
        {
            if (start >= end)
            {
                return;
            }
            var partition = FindPartition(start, end - 1, end, values);
            Sort(start, partition - 1, values);
            Sort(partition + 1, end, values);
        }

        private int FindPartition(int start, int end, int pivot, int[] values)
        {
            var currentPartition = start;
            while (start <= end)
            {
                //Case 1 : When start is less than pivot
                if (values[start] <= values[pivot])
                {
                    var temp = values[currentPartition];
                    values[currentPartition] = values[start];
                    values[start] = temp;
                    start += 1;
                    currentPartition += 1;
                }
                else
                {
                    start += 1;
                }
            }

            var t = values[currentPartition];
            values[currentPartition] = values[pivot];
            values[pivot] = t;
            return currentPartition;
        }
    }
}
