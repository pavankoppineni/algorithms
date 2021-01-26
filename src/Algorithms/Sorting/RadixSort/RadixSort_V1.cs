using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms.Sorting.RadixSort
{
    public class RadixSort_V1
    {
        public int[] Sort(int[] values)
        {
            var max = values.Max();
            var place = 1;
            while(max / place > 0)
            {
                values = Sort(values, place);
                place *= 10;
            }

            return values;
        }

        private int[] Sort(int[] values, int place)
        {
            var tempValues = new int[values.Length];
            var countArray = new int[10];
            for (var index = 0; index < values.Length; index++)
            {
                var reminder = (values[index] / place) % 10;
                countArray[reminder] += 1;
            }

            for (var index = 1; index < countArray.Length; index++)
            {
                countArray[index] += countArray[index - 1];
            }

            for (var index = 0; index < values.Length; index++)
            {
                var reminder = (values[index] / place) % 10;
                var position = countArray[reminder] - 1;
                tempValues[position] = values[index];
                countArray[reminder] -= 1;
            }

            return tempValues;
        }
    }
}
