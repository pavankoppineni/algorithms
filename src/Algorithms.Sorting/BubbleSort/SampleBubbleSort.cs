using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.BubbleSort
{
    public class SampleBubbleSort
    {
        private int[] values;
        public SampleBubbleSort()
        {
            values = new int[5] { 4, 8, 1, 9, 5 };
        }

        public void Sort()
        {
            Console.WriteLine("Array before sorting");
            foreach(var value in values)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();

            for (var i = 0; i < values.Length; i++)
            {
                for (var j = 1; j < values.Length - i; j++)
                {
                    if (values[j - 1] > values[j])
                    {
                        var temp = values[j - 1];
                        values[j - 1] = values[j];
                        values[j] = temp;
                    }
                }
            }

            Console.WriteLine("Array after sorting");
            foreach (var value in values)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
    }
}
