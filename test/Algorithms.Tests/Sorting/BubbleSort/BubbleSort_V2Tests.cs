using Algorithms.Sorting.BubbleSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.BubbleSort
{
    [TestClass]
    public class BubbleSort_V2Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Sort_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 3, 2, 7, 5, 8, 1, 9 };
            var bubbleSort = new BubbleSort_V2();
            var expectedValues = new int[] { 9, 8, 7, 5, 3, 2, 1 };

            //When
            var actualValues = bubbleSort.Sort(values);

            //Then
            for (var index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(expectedValues[index], actualValues[index]);
            }
        }
    }
}
