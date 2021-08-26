using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.RadixSort
{
    public class RadixSort_V3
    {
        public int[] Sort(int[] values)
        {
            var max = values[0];
            for (var index = 1; index < values.Length; index++)
            {
                if (values[index] > max)
                {
                    max = values[index];
                }
            }

            var denominator = 1;
            while (max > 0)
            {
                values = CountingSort(values, denominator);
                denominator *= 10;
                max /= denominator;
            }

            return values;
        }

        private int[] CountingSort(int[] values, int denominator)
        {
            var tempValues = new int[values.Length];
            var countingArray = new int[10];

            //Fill Count Array
            foreach (var value in values)
            {
                var numerator = value / denominator;
                var unitPlace = numerator % 10;
                countingArray[unitPlace] += 1;
            }

            //Sum Count Array
            for (var index = 1; index < countingArray.Length; index++)
            {
                countingArray[index] += countingArray[index - 1];
            }

            for (var index = values.Length - 1; index >= 0; index--)
            {
                var value = values[index];
                var numerator = values[index] / denominator;
                var unitPlace = numerator % 10;
                var countValue = countingArray[unitPlace];
                tempValues[countValue-1] = value;
                countingArray[unitPlace] -= 1;
            }
            return tempValues;
        }
    }
}
