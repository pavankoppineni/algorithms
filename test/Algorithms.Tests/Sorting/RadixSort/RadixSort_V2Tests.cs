using Algorithms.Sorting.RadixSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.RadixSort
{
    [TestClass]
    public class RadixSort_V2Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_Sort_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 17, 24, 18 };
            var radixSort = new RadixSort_V2();
            var expectedValues = new int[] { 17, 18, 24 };

            //When
            var actualValues = radixSort.Sort(values);

            //Then
            for (var index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(expectedValues[index], actualValues[index]);
            }
        }
    }
}
