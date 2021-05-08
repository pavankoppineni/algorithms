using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.CountingSort
{
    public class CountingSort_V2
    {
        public int[] Sort(int[] values)
        {
            var newArray = new int[values.Length];
            var countingArray = CreateCountingArray(values);
            for (var index = 0; index < values.Length; index++)
            {
                var value = values[index];
                var position = countingArray[value] - 1;
                newArray[position] = value;
                countingArray[value] -= 1;
            }
            return newArray;
        }

        private int[] CreateCountingArray(int[] values)
        {
            var maxValue = GetMaxValue(values);
            var countingArray = new int[maxValue + 1];
            foreach (var value in values)
            {
                countingArray[value] += 1;
            }

            var previousCountValue = 0;
            for (var countIndex = 0; countIndex < countingArray.Length; countIndex++)
            {
                countingArray[countIndex] += previousCountValue;
                previousCountValue = countingArray[countIndex];
            }

            return countingArray;
        }

        private int GetMaxValue(int[] values)
        {
            var max = values[0];
            for (var index = 1; index < values.Length; index++)
            {
                if (values[index] > max)
                {
                    max = values[index];
                }
            }

            return max;
        }
    }
}
