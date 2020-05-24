using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.BubbleSort
{
    public class BubbleSortV1
    {
        public int[] Sort(int[] values)
        {
            for (var i = 0; i < values.Length; i++)
            {
                for (var j = 1; j < values.Length - i; j++)
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
