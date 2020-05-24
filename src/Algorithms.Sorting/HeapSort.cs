using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class HeapSort
    {
        public int[] Sort(int[] values)
        {
            var length = values.Length;
            for (var i = (length / 2) - 1; i >= 0; i--)
            {
                Heapify(values, i, values.Length);
            }
            for (var i = length - 1; i >= 0; i--)
            {
                var temp = values[0];
                values[0] = values[i];
                values[i] = temp;
                Heapify(values, 0, i);
            }
            return values;
        }

        private void Heapify(int[] values, int root, int length)
        {
            var max = root;
            var leftChild = 2 * root + 1;
            var rightChild = 2 * root + 2;

            if (leftChild < length)
            {
                if (values[leftChild] > values[max])
                {
                    max = leftChild;
                }
            }

            if (rightChild < length)
            {
                if (values[rightChild] > values[max])
                {
                    max = rightChild;
                }
            }

            if (root != max)
            {
                var temp = values[max];
                values[max] = values[root];
                values[root] = temp;

                Heapify(values, max, length);
            }
        }
    }
}
