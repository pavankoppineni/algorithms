using Algorithms.Sorting.QuickSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.QuickSort
{
    [TestClass]
    public class QuickSort_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Sort_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 3, 3, 1, 1, 2, 2 };
            var quickSort = new QuickSort_V1();
            var expectedResult = new int[] { 1, 1, 2, 2, 3, 3 };

            //When
            var actualResult = quickSort.Sort(values);

            //Then
            for(var index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(expectedResult[index], actualResult[index]);
            }
        }
    }
}
