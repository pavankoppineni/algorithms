using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms.Sorting.CountingSort
{
    public class CountingSortV2
    {
        public int[] Sort(int[] values)
        {
            //Copy array to new aray
            var tempValues = new int[values.Length];
            for (var i = 0; i < values.Length; i++)
            {
                tempValues[i] = values[i];
            }

            //Get maximum value
            var max = values.Max();
            var countArray = new int[max + 1];

            //Count array
            for (var i = 0; i < values.Length; i++)
            {
                countArray[values[i]] = countArray[values[i]] + 1;
            }

            //Sum all of the values
            for (var i = 1; i < countArray.Length; i++)
            {
                countArray[i] += countArray[i - 1];
            }

            for (var i = 0; i < tempValues.Length; i++)
            {
                var value = tempValues[i];
                var index = countArray[value];
                values[index - 1] = value;
                countArray[value]--;
            }

            return values;
        }
    }
}
