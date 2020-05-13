using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.Tests
{
    [TestClass]
    public class MergerSortTests
    {
        [TestMethod]
        public void IntegerArray_Sort_ReturnsSortedArray()
        {
            //Arrange
            var values = new int[] { 1, 8, 4, 9, 5 };
            var mergeSort = new MergeSort();
            var expectedArray = new int[] { 9, 8, 5, 4, 1 };

            //Act
            var sortedValues = mergeSort.Sort(values);

            //Assset
            for (var i = 0; i < expectedArray.Length; i++)
            {
                Assert.AreEqual(expectedArray[i], sortedValues[i]);
            }
        }
    }
}
