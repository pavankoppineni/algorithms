using Algorithms.Sorting.CountingSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.CountingSort
{
    [TestClass]
    public class CountingSort_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_Sort_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 3, 2, 1, 3, 2, 1 };
            var countingSort = new CountingSort_V1();
            var expectedResult = new int[] { 1, 1, 2, 2, 3, 3 };

            //When
            var actualResult = countingSort.Sort(values);

            //Then
            for (var index = 0; index < expectedResult.Length; index++)
            {
                Assert.AreEqual(expectedResult[index], actualResult[index]);
            }
        }
    }
}
