using Algorithms.Sorting.CountingSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.CountingSort
{
    [TestClass]
    public class CountingSort_V3Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_Sort_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 4, 1, 4, 7 };
            var sort = new CountingSort_V3();
            var expectedValues = new int[] { 1, 4, 4, 7};

            //When
            var actualValues = sort.Sort(values);

            //Then
            for(var index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(expectedValues[index], actualValues[index]);
            }
        }
    }
}
