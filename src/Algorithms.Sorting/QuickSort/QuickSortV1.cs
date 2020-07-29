using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.QuickSort
{
    /// <summary>
    /// https://www.programiz.com/dsa/quick-sort
    /// </summary>
    public class QuickSortV1
    {
        public int[] Sort(int[] values)
        {
            QuickSort(values, 0, values.Length - 1);
            return values;
        }

        private void QuickSort(int[] values, int low, int high)
        {
            if (low < high)
            {
                var pivot = Partition(values, low, high);

                //left side
                QuickSort(values, low, pivot - 1);

                //right side
                QuickSort(values, pivot + 1, high);
            }
        }

        private int Partition(int[] values, int start, int end)
        {
            var pivot = end;
            var j = start;
            for (var i = start; i < end - 1; i++)
            {
                if (values[i] < values[pivot])
                {
                    var temp = values[i];
                    values[i] = values[j];
                    values[j] = temp;
                    j++;
                }
            }
            var tempOne = values[pivot];
            values[pivot] = values[j];
            values[j] = tempOne;
            return j;
        }
    }
}
