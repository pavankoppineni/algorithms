using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.MergeSort
{
    public class MergeSort_V4
    {
        public int[] Sort(int[] values)
        {
            Divide(0, values.Length - 1, values);
            return values;
        }

        private void Divide(int start, int end, int[] values)
        {
            if (start >= end)
            {
                return;
            }
            var mid = start + ((end - start) >> 1);
            Divide(start, mid, values);
            Divide(mid + 1, end, values);
            Merge(start, mid, mid + 1, end, values);
        }

        private void Merge(int startOne, int endOne, int startTwo, int endTwo, int[] values)
        {
            var arrayOnePointer = 0;
            var arrayTwoPointer = 0;
            var arrayOneLength = endOne - startOne + 1;
            var arrayTwoLength = endTwo - startTwo + 1;
            var arrayOne = new int[arrayOneLength];
            var arrayTwo = new int[arrayTwoLength];
            Array.Copy(values, startOne, arrayOne, arrayOnePointer, arrayOneLength);
            Array.Copy(values, startTwo, arrayTwo, arrayTwoPointer, arrayTwoLength);

            while (arrayOnePointer < arrayOneLength && arrayTwoPointer < arrayTwoLength)
            {
                //Case 1 : When arrayOnePointer is less than arrayTwoPointer
                //Action : Increase arrayOnePointer
                if (arrayOne[arrayOnePointer] < arrayTwo[arrayTwoPointer])
                {
                    values[startOne] = arrayOne[arrayOnePointer];
                    startOne += 1;
                    arrayOnePointer += 1;
                    continue;
                }

                //Case 2 : When arrayOnePointer is greater than arrayTwoPointer
                //Action : Increase arrayTwoPointer
                if (arrayOne[arrayOnePointer] > arrayTwo[arrayTwoPointer])
                {
                    values[startOne] = arrayTwo[arrayTwoPointer];
                    startOne += 1;
                    arrayTwoPointer += 1;
                    continue;
                }

                if (arrayOne[arrayOnePointer] == arrayTwo[arrayTwoPointer])
                {
                    values[startOne] = arrayOne[arrayOnePointer];
                    startOne += 1;
                    values[startOne] = arrayTwo[arrayTwoPointer];
                    startOne += 1;
                    arrayOnePointer += 1;
                    arrayTwoPointer += 1;
                }
            }

            while (arrayOnePointer < arrayOneLength)
            {
                values[startOne] = arrayOne[arrayOnePointer];
                startOne += 1;
                arrayOnePointer += 1;
            }

            while (arrayTwoPointer < arrayTwoLength)
            {
                values[startOne] = arrayTwo[arrayTwoPointer];
                startOne += 1;
                arrayTwoPointer += 1;
            }
        }
    }
}
