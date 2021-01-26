using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.QuickSort
{
    public class QuickSort_V1
    {
        private int[] values;
        public int[] Sort(int[] values)
        {
            this.values = values;
            Sort(0, values.Length - 1);
            return values;
        }

        private void Sort(int startIndexInclusive, int endIndexInclusive)
        {
            if (startIndexInclusive >= endIndexInclusive)
            {
                return;
            }

            var partition = FindPartition(startIndexInclusive, endIndexInclusive - 1, endIndexInclusive);
            Sort(startIndexInclusive, partition - 1);
            Sort(partition + 1, startIndexInclusive);
        }

        private int FindPartition(int startIndex, int endIndex, int pivotIndex)
        {
            var currentParition = startIndex;
            while (startIndex <= endIndex)
            {
                //Case 1 : When value at start index is less than pivot index
                if (values[startIndex] <= values[pivotIndex])
                {
                    var tempValue = values[currentParition];
                    values[currentParition] = values[startIndex];
                    values[startIndex] = tempValue;
                    currentParition++;
                    startIndex++;
                }
                else
                {
                    startIndex++;
                }
            }
            var temp = values[currentParition];
            values[currentParition] = values[pivotIndex];
            values[pivotIndex] = temp;
            return currentParition;
        }
    }
}
