using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms.Sorting
{
    public class RadixSort
    {
        public int[] Sort(int[] values)
        {
            var max = values.Max();
            for (var i = 1; i < max; i = i * 10)
            {
                Sort(values, i);
            }
            return values;
        }

        private void Sort(int[] values, int place)
        {
            //Temp array
            var temp = new int[values.Length];
            for (var i = 0; i < values.Length; i++)
            {
                temp[i] = values[i];
            }

            //Count array
            var max = values.Select(i => (i / place) % 10)
                .Max();
            var countArray = new int[max + 1];
            for (var i = 0; i < values.Length; i++)
            {
                var value = (values[i] / place) % 10;
                countArray[value]++;
            }

            //Cumulative sum
            for(var i = 1; i<countArray.Length; i++)
            {
                countArray[i] = countArray[i] + countArray[i - 1];
            }

            //Counting sort
            for (var i = values.Length - 1; i >= 0; i--)
            {
                var value = (temp[i] / place) % 10;
                var index = countArray[value] - 1;
                values[index] = temp[i];
                countArray[value]--;
            }
        }
    }
}
