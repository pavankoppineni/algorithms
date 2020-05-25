using Algorithms.Sorting.RadixSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.Tests.RadixSort
{
    [TestClass]
    public class RadixSortV2Tests
    {
        [TestMethod]
        public void IntegerArray_Sort_ReturnsSortedIntegers()
        {
            //Arrange
            var values = new int[] { 141, 121, 131 };
            var expectedValues = new int[] { 121, 131, 141 };
            var sort = new RadixSortV2();

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
