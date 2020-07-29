using Algorithms.Sorting.QuickSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.Tests.QuickSort
{
    [TestClass]
    public class QuickSortV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_QuickSort_Then_ShouldSortArrayOfIntegers()
        {
            //Given
            var values = new int[] { 8, 7, 6, 1, 0, 9, 2 };
            var quickSort = new QuickSortV1();
            var expectedValues = new int[] { 0, 1, 2, 6, 7, 8, 9 };

            //When
            var actualValues = quickSort.Sort(values);

            //Then
            for(var i = 0; i < values.Length; i++)
            {
                Assert.AreEqual(expectedValues[i], actualValues[i]);
            }
        }
    }
}
