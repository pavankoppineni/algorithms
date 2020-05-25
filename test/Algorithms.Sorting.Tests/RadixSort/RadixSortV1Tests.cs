using Algorithms.Sorting.RadixSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.Tests.RadixSort
{
    [TestClass]
    public class RadixSortV1Tests
    {
        [TestMethod]
        public void IntegerArray_Sort_ReturnsSortedArray()
        {
            //Arrange
            var values = new int[] { 87, 12, 65, 172, 90};
            var radixSort = new RadixSortV1();
            var expectedArray = new int[] { 12, 65, 87, 90, 172 };

            //Act
            var sortedArray = radixSort.Sort(values);

            //Assert
            for (var i = 0; i < sortedArray.Length; i++)
            {
                Assert.AreEqual(expectedArray[i], sortedArray[i]);
            }
        }
    }
}
