using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.BubbleSort
{
    public class BubbleSort_V4
    {
        public int[] Sort(int[] values)
        {
            if (values.Length == 1)
            {
                return values;
            }

            for (var i = 0; i < values.Length; i++)
            {
                for (var j = 1; j < values.Length - i; j++)
                {
                    var current = values[j];
                    var previous = values[j - 1];
                    if (current <= previous)
                    {
                        continue;
                    }
                    values[j - 1] = current;
                    values[j] = previous;
                }
            }
            return values;
        }
    }
}
