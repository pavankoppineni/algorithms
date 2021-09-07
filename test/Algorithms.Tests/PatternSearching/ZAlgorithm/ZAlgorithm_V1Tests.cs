using Algorithms.PatternSearching.ZAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.PatternSearching.ZAlgorithm
{
    [TestClass]
    public class ZAlgorithm_V1Tests
    {
        [TestMethod]
        public void Given_TextAndPattern_When_SearchPattern_Then_ShouldReturnIndexOfPattern()
        {
            //Given
            var text = "ababcababx";
            var pattern = "ababx";
            var problem = new ZAlgorithm_V1();
            var expectedResult = 5;    

            //When
            var actualResult = problem.SearchPattern(text, pattern);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
