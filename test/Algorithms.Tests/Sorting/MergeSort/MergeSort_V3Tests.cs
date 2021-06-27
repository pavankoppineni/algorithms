using Algorithms.Sorting.MergeSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.MergeSort
{
    [TestClass]
    public class MergeSort_V3Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_MergeSort_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 1, 3, 2 };
            var mergeSort = new MergeSort_V3();
            var expectedValues = new int[] { 1, 2, 3 };

            //When
            var actualValues = mergeSort.Sort(values);

            //Then
            for (var index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(expectedValues[index], actualValues[index]);
            }
        }
    }
}
