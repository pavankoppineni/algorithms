using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.CountingSort
{
    public class CountingSort_V3
    {
        public int[] Sort(int[] values)
        {
            if (values.Length == 1)
            {
                return values;
            }

            var max = values[0];
            foreach (var value in values)
            {
                if (value > max)
                {
                    max = value;
                }
            }

            var countingArray = new int[max];
            for (var index = 0; index < values.Length; index++)
            {
                var value = values[index];
                countingArray[value - 1] += 1;
            }

            for (var index = 1; index < countingArray.Length; index++)
            {
                countingArray[index] += countingArray[index - 1];
            }

            var newArray = new int[values.Length];
            for (var index = 0; index < values.Length; index++)
            {
                var value = values[index];
                var position = countingArray[value - 1];
                countingArray[value - 1] -= 1;
                newArray[position - 1] = value;
            }

            return newArray;
        }
    }
}
