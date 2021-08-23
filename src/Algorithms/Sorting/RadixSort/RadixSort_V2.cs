using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.RadixSort
{
    public class RadixSort_V2
    {
        public int[] Sort(int[] values)
        {
            if (values.Length == 1)
            {
                return values;
            }

            var max = values[0];
            for (var index = 1; index < values.Length; index++)
            {
                var value = values[index];
                if (value > max)
                {
                    max = value;
                }
            }

            var denominator = 1;
            while (max / denominator > 0)
            {
                values = CountingSort(values, denominator);
                denominator = denominator * 10;
            }
            return values;
        }

        private int[] CountingSort(int[] values, int denominator)
        {
            var tempValues = new int[values.Length];
            var countArray = new int[10];
            for (var index = 0; index < values.Length; index++)
            {
                var quotient = values[index] / denominator;
                var reminder = quotient % 10;
                countArray[reminder] += 1;
            }

            for (var index = 1; index < 10; index++)
            {
                countArray[index] += countArray[index - 1];
            }

            for (var index = values.Length - 1; index >= 0; index--)
            {
                var quotient = values[index] / denominator;
                var reminder = quotient % 10;
                var position = countArray[reminder];
                tempValues[position - 1] = values[index];
                countArray[reminder] -= 1;
            }
            return tempValues;
        }
    }
}
