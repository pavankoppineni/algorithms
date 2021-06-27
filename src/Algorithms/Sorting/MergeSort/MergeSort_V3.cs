using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.MergeSort
{
    public class MergeSort_V3
    {
        public int[] Sort(int[] values)
        {
            Divide(values, 0, values.Length - 1);
            return values;
        }

        private void Divide(int[] values, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            var mid = start + ((end - start) >> 1);
            Divide(values, start, mid);
            Divide(values, mid + 1, end);
            Merge(values, start, end);
        }

        private void Merge(int[] values, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            var mid = start + ((end - start) >> 1);
            var arrayOneLen = mid - start + 1;
            var arrayTwoLen = (end - start + 1) - arrayOneLen;
            var arrayOne = new int[arrayOneLen];
            var arrayTwo = new int[arrayTwoLen];
            Array.Copy(values, start, arrayOne, 0, arrayOneLen);
            Array.Copy(values, mid + 1, arrayTwo, 0, arrayTwoLen);
            var indexOne = 0;
            var indexTwo = 0;
            while (indexOne < arrayOneLen && indexTwo < arrayTwoLen)
            {
                //Case 1 : When indexOne is less than indexTwo
                if (arrayOne[indexOne] <= arrayTwo[indexTwo])
                {
                    values[start] = arrayOne[indexOne];
                    indexOne += 1;
                    start += 1;
                    continue;
                }

                values[start] = arrayTwo[indexTwo];
                indexTwo += 1;
                start += 1;
            }

            while(indexOne < arrayOneLen)
            {
                values[start] = arrayOne[indexOne];
                indexOne += 1;
                start += 1;
            }

            while (indexTwo < arrayTwoLen)
            {
                values[start] = arrayTwo[indexTwo];
                indexTwo += 1;
                start += 1;
            }
        }
    }
}
