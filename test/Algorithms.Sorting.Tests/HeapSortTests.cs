using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.Tests
{
    [TestClass]
    public class HeapSortTests
    {
        [TestMethod]
        public void IntegerArray_Sort_ReturnsSortedArray()
        {
            //Arrange
            var values = new int[] { 1, 8, 5, 4, 9, 10 };
            var heapSort = new HeapSort();
            var expectedArray = new int[] { 1, 4, 5, 8, 9, 10 };

            //Act
            var sortedArray = heapSort.Sort(values);

            //Assert
            for (var i = 0; i < values.Length; i++)
            {
                Assert.AreEqual(expectedArray[i], sortedArray[i]);
            }
        }
    }
}
