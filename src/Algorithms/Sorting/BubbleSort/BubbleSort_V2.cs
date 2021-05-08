using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.BubbleSort
{
    public class BubbleSort_V2
    {
        public int[] Sort(int[] values)
        {
            for (var lastPosition = 0; lastPosition < values.Length; lastPosition++)
            {
                for (var index = 1; index < values.Length - lastPosition; index++)
                {
                    var currentIndex = index;
                    var previousIndex = index - 1;

                    //Case 1 : When current < previous
                    //Action : No swap
                    if (values[currentIndex] < values[previousIndex])
                    {
                        continue;
                    }

                    //Case 2 : When current > previous
                    //Action : Swap
                    else if (values[currentIndex] > values[previousIndex])
                    {
                        var temp = values[currentIndex];
                        values[currentIndex] = values[previousIndex];
                        values[previousIndex] = temp;
                    }
                }
            }

            return values;
        }
    }
}
