using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.Tests.BubbleSort
{
    [TestClass]
    public class BubbleSortV2Tests
    {
        [TestMethod]
        public void IntegerArray_Sort_ReturnsArrayWithSortedValues()
        {
            //Arrange
            var values = new int[] { 5, 4, 3, 2, 1 };
            var bubbleSort = new BubbleSortV2();
            var expectedValues = new int[] { 1, 2, 3, 4, 5 };

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
