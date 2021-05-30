using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.QuickSort
{
    public class QuickSort_V2
    {
        public int[] Sort(int[] values)
        {
            Sort(values, 0, values.Length - 1);
            return values;
        }

        private void Sort(int[] values, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            var currentPartition = FindPartition(values, start, end, end);
            Sort(values, start, currentPartition - 1);
            Sort(values, currentPartition + 1, end);
        }

        private int FindPartition(int[] values, int start, int end, int pivot)
        {
            var currentPartition = start;
            while (start < end)
            {
                //Case 1 :  
                //Action :
                if (values[start] <= values[pivot])
                {
                    var temp = values[start];
                    values[start] = values[currentPartition];
                    values[currentPartition] = temp;
                    currentPartition += 1;
                    start += 1;
                }
                //Case 2 : 
                //Action :
                else
                {
                    start += 1;
                }
            }
            var tempPivot = values[pivot];
            values[pivot] = values[currentPartition];
            values[currentPartition] = tempPivot;
            return currentPartition;
        }
    }
}
