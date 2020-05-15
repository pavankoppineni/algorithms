using Algorithms.Sorting;
using Algorithms.Sorting.BubbleSort;
using Algortithms.Strings.Problems;
using System;

namespace Algorithms.Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new int[] { 121, 123, 141, 890 };
            var radixSort = new RadixSort();
            radixSort.Sort(values);
        }
    }
}
