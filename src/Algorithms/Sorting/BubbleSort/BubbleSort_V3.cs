using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.BubbleSort
{
    public class BubbleSort_V3
    {
        public int[] Sort(int[] values)
        {
            for (var i = 0; i < values.Length; i++)
            {
                for (var j = i; j < values.Length; j++)
                {
                    if (values[i] > values[j])
                    {
                        var temp = values[i];
                        values[i] = values[j];
                        values[j] = temp;
                    }
                }
            }
            return values;
        }
    }
}
