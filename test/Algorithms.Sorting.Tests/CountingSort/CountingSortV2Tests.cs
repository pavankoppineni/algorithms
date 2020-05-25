using Algorithms.Sorting.CountingSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.Tests.CountingSort
{
    [TestClass]
    public class CountingSortV2Tests
    {
        [TestMethod]
        public void ArrayOfIntegers_Sort_ReturnsSortedArray()
        {
            //Arrange
            var values = new int[] { 1, 10, 8, 6, 4, 9, 9, 10, 11 };
            var expectedValues = new int[] { 1, 4, 6, 8, 9, 9, 10, 10, 11 };
            var sort = new CountingSortV2();

            //Act
            var actualValues = sort.Sort(values);

            //Assert
            for (var i = 0; i < values.Length; i++)
            {
                Assert.AreEqual(expectedValues[i], actualValues[i]);
            }
        }
    }
}
