using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.BubbleSort
{
    public class BubbleSort_V1
    {
        public int[] Sort(int[] values)
        {
            for (var index = 0; index < values.Length; index++)
            {
                for (var compareIndex = 1; compareIndex < values.Length - index; compareIndex++)
                {
                    var previousValue = values[compareIndex - 1];
                    var currentValue = values[compareIndex];
                    if (previousValue > currentValue)
                    {
                        values[compareIndex] = previousValue;
                        values[compareIndex - 1] = currentValue;
                    }
                }
            }

            return values;
        }
    }
}
