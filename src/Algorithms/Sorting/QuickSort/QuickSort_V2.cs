using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.QuickSort
{
    public class QuickSort_V2
    {
        public int[] Sort(int[] values)
        {
            Sort(values, 0, values.Length - 1);
            return values;
        }

        private void Sort(int[] values, int startInclusive, int endInclusive)
        {
        }
    }
}
