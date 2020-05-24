using Algorithms.Sorting.MergeSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.Tests.MergeSort
{
    [TestClass]
    public class MergeSortV2Tests
    {
        [TestMethod]
        public void ArrayWithIntegers_Sort_ReturnsSortedIntegers()
        {
            //Arrange
            var values = new int[] { 1, 5, 2, 4, 9, 8, 6 };
            var expectedValues = new int[] { 9, 8, 6, 5, 4, 2, 1 };
            var mergeSort = new MergeSortV2();

            //Act
            var actualValues = mergeSort.Sort(values);

            //Assert
            for (var i = 0; i < values.Length; i++)
            {
                Assert.AreEqual(expectedValues[i], actualValues[i]);
            }
        }
    }
}
