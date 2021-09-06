using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.RadixSort
{
    public class RadixSort_V4
    {
        public int[] Sort(int[] values)
        {
            var maxValue = values[0];
            for (var index = 1; index < values.Length; index++)
            {
                if (maxValue < values[index])
                {
                    maxValue = values[index];
                }
            }

            var unitPlace = 1;
            while (maxValue > 0)
            {
                values = CountingSort(values, unitPlace);
                unitPlace *= 10;
                maxValue /= 10;
            }

            return values;
        }

        private int[] CountingSort(int[] values, int unit)
        {
            var tempValues = new int[values.Length];
            var countingArray = new int[10];
            foreach (var value in values)
            {
                var countItem = (value / unit) % 10;
                countingArray[countItem] += 1;
            }

            for (var index = 1; index < countingArray.Length; index++)
            {
                countingArray[index] += countingArray[index - 1];
            }

            for (var index = values.Length - 1; index >= 0; index--)
            {
                var value = values[index];
                var unitValue = (value / unit) % 10;
                var countingIndex = countingArray[unitValue];
                tempValues[countingIndex - 1] = value;
                countingArray[unitValue] -= 1;
            }
            return tempValues;
        }
    }
}
