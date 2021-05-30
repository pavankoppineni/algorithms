using Algorithms.Sorting.QuickSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.QuickSort
{
    [TestClass]
    public class QuickSort_V2Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_QuickSort_Then_ShouldReturnSortedArray()
        {
            //Given
            var array = new int[] { 1, 2, 7, 8, 1, 2, 5 };
            var quickSort = new QuickSort_V2();
            var expectedArray = new int[] { 1, 1, 2, 2, 5, 7, 8 };

            //When
            var actualArray = quickSort.Sort(array);

            //Then
            Assert.AreEqual(expectedArray.Length, actualArray.Length);
            for (var index = 0; index < expectedArray.Length; index++)
            {
                Assert.AreEqual(expectedArray[index], actualArray[index]);
            }
        }
    }
}
