using Algorithms.Sorting.MergeSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting.MergeSort
{
    [TestClass]
    public class MergeSort_V4Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_Sort_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 3, 2, 1, 3, 2 };
            var problem = new MergeSort_V4();
            var expectedValues = new int[] { 1, 2, 2, 3, 3 };

            //When
            var actualValues = problem.Sort(values);

            //Then
            for (int i = 0; i < values.Length; i++)
            {
                Assert.AreEqual(expectedValues[i], actualValues[i]);
            }
        }
    }
}
