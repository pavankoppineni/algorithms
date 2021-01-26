using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.MergeSort
{
    public class MergeSort_V1
    {
        private int[] values;

        public int[] Sort(int[] values)
        {
            this.values = values;
            Divide(0, values.Length - 1);
            return values;
        }

        private void Divide(int startInclusive, int endInclusive)
        {
            if (startInclusive == endInclusive)
            {
                return;
            }

            var mid = (startInclusive + endInclusive) >> 1;
            Divide(startInclusive, mid);
            Divide(mid + 1, endInclusive);
            Merge(startInclusive, mid, mid + 1, endInclusive);
        }

        private void Merge(int startOne, int endOne, int startTwo, int endTwo)
        {
            var pointerOne = 0;
            var pointerTwo = 0;
            var arrayOneLength = endOne - startOne + 1;
            var arrayTwoLength = endTwo - startTwo + 1;
            var arrayOne = new int[arrayOneLength];
            var arrayTwo = new int[arrayTwoLength];
            Array.Copy(values, startOne, arrayOne, 0, arrayOneLength);
            Array.Copy(values, startTwo, arrayTwo, 0, arrayTwoLength);
            var valuesPointer = startOne;

            while (pointerOne < arrayOne.Length && pointerTwo < arrayTwo.Length)
            {
                //Case 1 : Values of pointer one and two are equal
                //Action : Increment pointer one
                if (arrayOne[pointerOne] == arrayTwo[pointerTwo])
                {
                    values[valuesPointer] = arrayOne[pointerOne];
                    pointerOne += 1;
                    valuesPointer += 1;
                }

                //Case 2 : Pointer one is greater than pointer two
                //Action : Increment pointer two
                else if (arrayOne[pointerOne] > arrayTwo[pointerTwo])
                {
                    values[valuesPointer] = arrayTwo[pointerTwo];
                    pointerTwo += 1;
                    valuesPointer += 1;
                }

                //Case 3 : Pointer one is less than pointer two
                //Action : Increment pointer one
                else
                {
                    values[valuesPointer] = arrayOne[pointerOne];
                    pointerOne += 1;
                    valuesPointer += 1;
                }
            }

            while (pointerOne < arrayOne.Length)
            {
                values[valuesPointer] = arrayOne[pointerOne];
                pointerOne++;
                valuesPointer++;
            }

            while (pointerTwo < arrayTwo.Length)
            {

                values[valuesPointer] = arrayTwo[pointerTwo];
                pointerTwo++;
                valuesPointer++;
            }
        }
    }
}
