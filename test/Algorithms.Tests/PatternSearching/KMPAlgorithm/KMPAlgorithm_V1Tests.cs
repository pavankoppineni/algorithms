using Algorithms.PatternSearching.KMPAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.PatternSearching.KMPAlgorithm
{
    [TestClass]
    public class KMPAlgorithm_V1Tests
    {
        [TestMethod]
        public void Given_PatternAndText_When_SearchForPattern_Then_ShouldReturnTrueIfPatternExists()
        {
            //Given
            var text = "ababxababc";
            var pattern = "ababc";
            var problem = new KMPAlgorithm_V1();
            var expectedResult = 5;

            //When
            var actualResult = problem.PatternExists(text, pattern);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
