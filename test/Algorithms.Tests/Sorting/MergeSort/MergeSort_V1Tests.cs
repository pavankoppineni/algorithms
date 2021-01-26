using Algorithms.Sorting.MergeSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.MergeSort
{
    [TestClass]
    public class MergeSort_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_Sort_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 3, 2, 1, 3, 2, 1 };
            var mergeSort = new MergeSort_V1();
            var expectedResult = new int[] { 1, 1, 2, 2, 3, 3 };

            //When
            var actualResult = mergeSort.Sort(values);

            //Then
            for (var index = 0; index < expectedResult.Length; index++)
            {
                Assert.AreEqual(expectedResult[index], actualResult[index]);
            }
        }
    }
}
