using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms.Sorting.RadixSort
{
    public class RadixSortV2
    {
        public int[] Sort(int[] values)
        {
            var max = values.Max();
            for (var i = 1; (max / i) > 0; i *= 10)
            {
                Sort(values, i);
            }
            return values;
        }

        private int[] Sort(int[] values, int divisor)
        {
            var tempValues = new int[values.Length];
            for (var i = 0; i < values.Length; i++)
            {
                tempValues[i] = values[i];
            }

            var divisorArray = new int[values.Length];
            for (var i = 0; i < values.Length; i++)
            {
                divisorArray[i] = (values[i] / divisor) % 10;
            }

            var max = divisorArray.Max();
            var countArray = new int[max + 1];
            for (var i = 0; i < divisorArray.Length; i++)
            {
                var value = divisorArray[i];
                countArray[value] = countArray[value] + 1;
            }

            for (var i = 1; i < countArray.Length; i++)
            {
                countArray[i] += countArray[i - 1];
            }

            
            for (var i = tempValues.Length - 1; i >= 0; i--)
            {
                var tempValue = tempValues[i];
                var divisorValue = (tempValue / divisor) % 10;
                if (countArray[divisorValue] > 0)
                {
                    var index = countArray[divisorValue];
                    values[index - 1] = tempValue;
                    countArray[divisorValue]--;
                }
            }

            return values;
        }
    }
}
