using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.MergeSort
{
    public class MergeSort_V5
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
            var arrayOne = CopyArray(values, startOne, endOne - startOne + 1);
            var arrayTwo = CopyArray(values, startTwo, endTwo - startTwo + 1);
            var pointerOne = 0;
            var pointerTwo = 0;
            var pointer = startOne;
            while (pointerOne < arrayOne.Length && pointerTwo < arrayTwo.Length)
            {
                var valueOne = arrayOne[pointerOne];
                var valueTwo = arrayTwo[pointerTwo];

                //Case 1 : When valueOne is less than valueTwo
                if (valueOne < valueTwo)
                {
                    values[pointer] = valueOne;
                    pointerOne += 1;
                    pointer += 1;
                    continue;
                }

                //Case 2 : When valueOne is greater than valueTwo
                if (valueOne > valueTwo)
                {
                    values[pointer] = valueTwo;
                    pointerTwo += 1;
                    pointer += 1;
                    continue;
                }

                //Case 3 : When valueOne is equal to valueTwo
                if (valueOne == valueTwo)
                {
                    values[pointer] = valueOne;
                    pointer += 1;
                    pointerOne += 1;
                }
            }

            while (pointerOne < arrayOne.Length)
            {
                values[pointer] = arrayOne[pointerOne];
                pointer += 1;
                pointerOne += 1;
            }

            while (pointerTwo < arrayTwo.Length)
            {
                values[pointer] = arrayTwo[pointerTwo];
                pointer += 1;
                pointerTwo += 1;
            }
        }

        private int[] CopyArray(int[] values, int index, int length)
        {
            var arr = new int[length];
            var count = 0;
            while (count < length)
            {
                arr[count] = values[index];
                index++;
                count++;
            }
            return arr;
        }
    }
}
