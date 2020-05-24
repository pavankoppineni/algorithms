using Algorithms.Sorting.BubbleSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.Tests.BubbleSort
{
    [TestClass]
    public class BubbleSortV1Tests
    {
        [TestMethod]
        public void ArrayWithIntegers_Sort_ReturnsSortedIntegers()
        {
            //Arrange
            var values = new int[] { 2, 4, 1, 8, 9, 3 };
            var expectedValues = new int[] { 1, 2, 3, 4, 8, 9 };
            var bubbleSort = new BubbleSortV1();

            //Act
            var actualValues = bubbleSort.Sort(values);

            //Assert
            for (var i = 0; i < values.Length; i++)
            {
                Assert.AreEqual(expectedValues[i], actualValues[i]);
            }
        }
    }
}
