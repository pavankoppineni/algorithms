using Algorithms.Sorting.BubbleSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.BubbleSort
{
    [TestClass]
    public class BubbleSort_V3Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Sort_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 8, 1, 3 };
            var problem = new BubbleSort_V3();
            var expectedValues = new int[] { 1, 3, 8 };

            //When
            var actualValues = problem.Sort(values);

            //Then
            for (var index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(expectedValues[index], actualValues[index]);
            }
        }
    }
}
