using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms.Sorting.CountingSort
{
    public class CountingSort_V1
    {
        public int[] Sort(int[] values)
        {
            var max = values.Max();
            var countArray = new int[max + 1];

            for (var index = 0; index < values.Length; index++)
            {
                var value = values[index];
                countArray[value] += 1;
            }

            for (var index = 1; index < countArray.Length; index++)
            {
                countArray[index] += countArray[index - 1];
            }

            var newArray = new int[values.Length];
            for (var index = 0; index < newArray.Length; index++)
            {
                var value = values[index];
                newArray[countArray[value] - 1] = value;
                countArray[value] -= 1;
            }

            return newArray;
        }
    }
}
