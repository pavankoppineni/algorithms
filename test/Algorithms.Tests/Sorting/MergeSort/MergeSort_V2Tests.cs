using Algorithms.Sorting.MergeSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.MergeSort
{
    [TestClass]
    public class MergeSort_V2Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Sort_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 1, 7, 8, 2, 3, 4};
            var mergeSort = new MergeSort_V2();
            var expectedResult = new int[] { 1, 2, 3, 4, 7, 8 };

            //When
            var actualResult = mergeSort.Sort(values);

            //Then
            for (var index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(expectedResult[index], actualResult[index]);
            }
        }
    }
}
