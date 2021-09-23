using Algorithms.Sorting.BubbleSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.BubbleSort
{
    [TestClass]
    public class BubbleSort_V5Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Sort_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 1, 2, 3 };
            var bubbleSort = new BubbleSort_V5();
            var expectedValues = new int[] { 3, 2, 1 };

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
