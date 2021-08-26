using Algorithms.Searching.BinarySearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Searching.BinarySearch
{
    [TestClass]
    public class BinarySearchV2Tests
    {
        [TestMethod]
        public void Given_SortedArrayAndNumber_When_Search_Then_ShouldReturnIndexOfNumber()
        {
            //Given
            var values = new int[] { 1, 2, 3, 4, 5 };
            var binarySearch = new BinarySearchV2();
            var number = 1;
            var expectedIndex = 0;

            //When
            var actualIndex = binarySearch.Search(values, number);

            //Then
            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}
