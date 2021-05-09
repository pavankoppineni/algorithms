using Algorithms.Searching.BinarySearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Searching.BinarySearch
{
    [TestClass]
    public class BinarySearchV1Tests
    {
        [TestMethod]
        public void Given_IntegerArrayAndValue_When_SearchIntegerArray_Then_ReturnIndexOfValue()
        {
            //Given
            var values = new int[] { 2, 5, 8, 10, 12, 15 };
            var value = -2;
            var expectedIndex = -1;
            var binarySearch = new BinarySearchV1();

            //When
            var actualIndex = binarySearch.Find(values, value);

            //Then
            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}
