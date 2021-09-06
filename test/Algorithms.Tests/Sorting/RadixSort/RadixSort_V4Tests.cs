using Algorithms.Sorting.RadixSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.RadixSort
{
    [TestClass]
    public class RadixSort_V4Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_Sort_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 24, 18, 19, 17, 14 };
            var sort = new RadixSort_V4();
            var expectedValues = new int[] { 14, 17, 18, 19, 24 };

            //When
            var actualValues = sort.Sort(values);

            //Then
            for (var index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(expectedValues[index], actualValues[index]);
            }
        }
    }
}
