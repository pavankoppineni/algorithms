using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Counting sort
    /// </summary>
    public class CountingSort
    {
        public int[] Sort(int[] values)
        {
            var tempArray = new int[values.Length];
            var max = values[0];
            for (var i = 0; i < values.Length; i++)
            {
                tempArray[i] = values[i];
                max = Math.Max(max, values[i]);
            }

            var countArray = new int[max + 1];
            foreach (var value in values)
            {
                countArray[value]++;
            }

            for (var i = 1; i < countArray.Length; i++)
            {
                countArray[i] += countArray[i - 1];
            }

            for (var i = 0; i < values.Length; i++)
            {
                var value = tempArray[i];
                if (countArray[value] > 0)
                {
                    var element = countArray[value];
                    countArray[value]--;
                    values[element - 1] = value;
                }
            }

            return values;
        }
    }
}
