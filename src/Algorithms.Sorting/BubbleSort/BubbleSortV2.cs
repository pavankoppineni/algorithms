using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.BubbleSort
{
    public class BubbleSortV2
    {
        public int[] Sort(int[] values)
        {
            var length = values.Length;
            for (var i = 0; i < length; i++)
            {
                for (var j = 1; j < length - i; j++)
                {
                    if (values[j - 1] > values[j])
                    {
                        var temp = values[j - 1];
                        values[j - 1] = values[j];
                        values[j] = temp;
                    }
                }
            }
            return values;
        }
    }
}
