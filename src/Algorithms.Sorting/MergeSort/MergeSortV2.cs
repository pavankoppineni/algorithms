using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.MergeSort
{
    public class MergeSortV2
    {
        public int[] Sort(int[] values)
        {
            Divide(values, 0, values.Length - 1);
            return values;
        }

        private void Divide(int[] values, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            var mid = (low + high) / 2;
            Divide(values, low, mid);
            Divide(values, mid + 1, high);

            Merge(values, low, mid, high);
        }

        private void Merge(int[] values, int low, int mid, int high)
        {
            var leftValues = new int[mid - low + 1];
            var rightValues = new int[high - mid];
            var i = 0;
            var j = 0;
            var k = 0;
            Array.Copy(values, low, leftValues, 0, leftValues.Length);
            Array.Copy(values, mid + 1, rightValues, 0, rightValues.Length);
            while (i < leftValues.Length && j < rightValues.Length)
            {
                if (leftValues[i] > rightValues[j])
                {
                    values[low + k] = leftValues[i];
                    i++;
                    k++;
                }
                else
                {
                    values[low + k] = rightValues[j];
                    j++;
                    k++;
                }
            }

            while(i < leftValues.Length)
            {
                values[low + k] = leftValues[i];
                i++;
                k++;
            }

            while (j < rightValues.Length)
            {
                values[low + k] = rightValues[j];
                j++;
                k++;
            }
        }
    }
}
