using Algorithms.Sorting.QuickSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.QuickSort
{
    [TestClass]
    public class QuickSort_V3Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Sort_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 3, 2, 1, 5, 2 };
            var quickSort = new QuickSort_V3();
            var expectedValues = new int[] { 1, 2, 2, 3, 5 };

            //When
            var actualValues = quickSort.Sort(values);

            //Then
            for (var index = 0; index < actualValues.Length; index++)
            {
                Assert.AreEqual(expectedValues[index], actualValues[index]);
            }
        }
    }
}
