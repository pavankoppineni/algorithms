using Algorithms.Sorting.CountingSort;
using Algorithms.Sorting.RadixSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.RadixSort
{
    [TestClass]
    public class RadixSort_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfintegers_When_Sort_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 17, 14, 18 };
            var countingSort = new RadixSort_V1();
            var expectedResult = new int[] { 17, 32, 71 };

            //When
            var acutalResult = countingSort.Sort(values);

            //Then
            for (var index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(expectedResult[index], acutalResult[index]);
            }
        }
    }
}
