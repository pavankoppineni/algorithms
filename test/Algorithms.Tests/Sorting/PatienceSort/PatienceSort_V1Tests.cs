using Algorithms.Sorting.PatienceSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.PatienceSort
{
    [TestClass]
    public class PatienceSort_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Sort_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 2, 3, 1, 7, 5, 90, 77 };
            var sort = new PatienceSort_V1();
            var expectedValues = new int[] { 1, 2, 3, 5, 7, 77, 90 };

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
