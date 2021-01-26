using Algorithms.Sorting.BubbleSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.BubbleSort
{
    [TestClass]
    public class BubbleSort_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_Sort_Then_ShouldReturnSortedArray()
        {
            //Given
            var bubbleSort = new BubbleSort_V1();
            var values = new int[] { 3, 2, 1 };
            var expectedResult = new int[] { 1, 2, 3 };

            //When
            var actualResult = bubbleSort.Sort(values);

            //Then
            for (var index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(expectedResult[index], actualResult[index]);
            }
        }
    }
}
