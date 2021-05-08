﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.MergeSort
{
    public class MergeSort_V2
    {
        public int[] Sort(int[] values)
        {
            return values;
        }


        private void Divide(int[] values, int start, int end)
        {
        }

        private void Merge(int[] values, int start, int end)
        {
            var mid = (start + end) >> 1;
            var leftArray = CopyArray(values, start, mid);
            var rightArray = CopyArray(values, mid + 1, end);
            var currentIndex = 0;
            var leftPosition = 0;
            var rightPosition = 0;
            while (leftPosition < leftArray.Length && rightPosition < rightArray.Length)
            {
                var leftValue = leftArray[leftPosition];
                var rightValue = rightArray[rightPosition];

                //Case 1 : When left value is less than or equal to right value
                //Action : Increment left position
                if (leftValue <= rightValue)
                {
                    values[currentIndex] = leftArray[leftPosition];
                    leftPosition++;
                    currentIndex++;
                    continue;
                }

                //Case 2 : When left value is greater than right value
                //Action : Increment right position
                if (leftValue > rightValue)
                {
                    values[currentIndex] = rightArray[rightPosition];
                    rightPosition++;
                    currentIndex++;
                    continue;
                }
            }

            while (leftPosition < leftArray.Length)
            {
                values[currentIndex] = leftArray[leftPosition];
                leftPosition++;
                currentIndex++;
            }

            while (rightPosition < rightArray.Length)
            {
                values[currentIndex] = rightArray[rightPosition];
                rightPosition++;
                currentIndex++;
            }
        }

        private int[] CopyArray(int[] values, int start, int end)
        {
            var len = end - start + 1;
            var array = new int[len];
            var index = 0;
            while (start <= end)
            {
                array[index] = values[start];
                index++;
                start++;
            }

            return array;
        }
    }
}
