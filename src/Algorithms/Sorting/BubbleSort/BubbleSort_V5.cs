using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.BubbleSort
{
    public class BubbleSort_V5
    {
        public int[] Sort(int[] values)
        {
            for (var i = 0; i < values.Length; i++)
            {
                for (var j = 1; j < values.Length - i; j++)
                {
                    var prev = values[j - 1];
                    var current = values[j];
                    if (prev < current)
                    {
                        values[j] = prev;
                        values[j - 1] = current;
                    }
                }
            }
            return values;
        }
    }
}
