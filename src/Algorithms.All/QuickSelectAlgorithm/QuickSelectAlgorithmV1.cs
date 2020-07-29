using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.All.QuickSelectAlgorithm
{
    /// <summary>
    /// https://www.geeksforgeeks.org/quickselect-algorithm/
    /// </summary>
    public class QuickSelectAlgorithmV1
    {
        public int Select(int[] values, int k)
        {
            return QuickSelect(values, 0, values.Length - 1, k - 1);
        }

        private int QuickSelect(int[] values, int low, int high, int k)
        {
            if(low <= high)
            {
                var partition = GetPartition(values, low, high);

                if(partition == k)
                {
                    return values[partition];
                }

                if (partition > k)
                {
                    return QuickSelect(values, low, partition - 1, k);
                }
                else
                {
                    return QuickSelect(values, partition + 1, high, k);
                }
            }

            return -1;
        }

        private int GetPartition(int[] values, int low, int high)
        {
            var pivot = high;
            var j = low;
            for(var i = low; i < high; i++)
            {
                if (values[i] < values[pivot])
                {
                    var temp = values[i];
                    values[i] = values[j];
                    values[j] = temp;
                    j++;
                }
            }

            var tempOne = values[pivot];
            values[pivot] = values[j];
            values[j] = tempOne;

            return j;
        }
    }
}
