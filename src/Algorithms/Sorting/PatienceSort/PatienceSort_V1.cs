using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.PatienceSort
{
    /// <summary>
    /// https://www.geeksforgeeks.org/patience-sorting/
    /// </summary>
    public class PatienceSort_V1
    {
        public int[] Sort(int[] values)
        {
            var piles = new List<Stack<int>>();
            var pile = new Stack<int>();
            pile.Push(values[0]);
            piles.Add(pile);
            for (var i = 1; i < values.Length; i++)
            {
                var valueAdded = false;
                var value = values[i];
                for (var j = 0; j < piles.Count; j++)
                {
                    var currentPile = piles[j];
                    if (value < currentPile.Peek())
                    {
                        currentPile.Push(value);
                        valueAdded = true;
                        break;
                    }
                }
                if (!valueAdded)
                {
                    var newPile = new Stack<int>();
                    newPile.Push(value);
                    piles.Add(newPile);
                }
            }
            return MergePiles(piles, values.Length);
        }

        private int[] MergePiles(IList<Stack<int>> piles, int length)
        {
            var sortedValues = new int[length];
            var currentIndex = 0;
            var index = 0;
            var minValue = piles[index].Peek();
            while (currentIndex < length)
            {
                for (var i = 0; i < piles.Count; i++)
                {
                    var currentPile = piles[0];
                    if (minValue > currentPile.Peek())
                    {
                        minValue = currentPile.Peek();
                        index = i;
                    }
                }
                var pile = piles[index];
                sortedValues[currentIndex] = pile.Pop();
                if (pile.Count == 0)
                {
                    piles.RemoveAt(index);
                }
                currentIndex += 1;
            }
            return sortedValues;
        }
    }
}
