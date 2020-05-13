using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class MergeSort
    {
        public int[] Sort(int[] values)
        {
            var low = 0;
            var high = values.Length - 1;
            Divide(values, low, high);
            return values;
        }

        private void Divide(int[] values, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            var mid = (low + high) / 2;
            Divide(values, low, mid);
            Divide(values, mid + 1, high);

            Merge(values, low, high, mid);
        }

        private void Merge(int[] values, int low, int high, int mid)
        {
            //Array one
            var array_length_one = mid - low + 1;
            var array_one = new int[array_length_one];
            var i = 0;
            while (i < array_length_one)
            {
                array_one[i] = values[low + i];
                i++;
            }

            var array_length_two = high - (mid + 1) + 1;
            var array_two = new int[array_length_two];
            var j = 0;
            while (j < array_length_two)
            {
                array_two[j] = values[mid + 1 + j];
                j++;
            }

            var x = 0;
            var y = 0;
            var z = low;
            while (x < array_length_one && y < array_length_two)
            {
                if (array_one[x] > array_two[y])
                {
                    values[z] = array_one[x];
                    x++;
                }
                else
                {
                    values[z] = array_two[y];
                    y++;
                }
                z++;
            }

            while(x < array_length_one)
            {
                values[z] = array_one[x];
                x++;
                z++;
            }

            while (y < array_length_two)
            {
                values[z] = array_two[y];
                y++;
                z++;
            }
        }
    }
}
