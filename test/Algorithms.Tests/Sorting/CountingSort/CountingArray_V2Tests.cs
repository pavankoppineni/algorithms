using Algorithms.Sorting.CountingSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.CountingSort
{
    [TestClass]
    public class CountingArray_V2Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Sort_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 4, 1, 2, 7, 8, 9, 8 };
            var countingSort = new CountingSort_V2();
            var expectedValues = new int[] { 1, 2, 4, 7, 8, 8, 9 };

            //When
            var actualValues = countingSort.Sort(values);

            //Then
            for (var index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(expectedValues[index], actualValues[index]);
            }
        }
    }
}
