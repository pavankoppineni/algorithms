using Algorithms.All.QuickSelectAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.All.Tests.QuickSelectAlgorithm
{
    [TestClass]
    public class QuickSelectAlgorithmV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegersAndIntegerK_When_Select_Then_ShouldReturnKthSmallestElementFromArray()
        {
            //Given
            var values = new int[] { 9, 1, 0, 8, 2, 3 };
            var quickSelect = new QuickSelectAlgorithmV1();
            var k = 2;
            var expectedResult = 1;

            //When
            var actualResult = quickSelect.Select(values, k);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
