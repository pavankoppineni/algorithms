using Algorithms.PatternSearching;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.PatternSearching.ZAlgorithm
{
    [TestClass]
    public class ZArrayFactoryV1Tests
    {
        [TestMethod]
        public void Given_StringPattern_When_CreateZArray_Then_ShouldReturnZArrayOfPattern()
        {
            //Given
            var pattern = "ababababab";
            var zArrayFactory = new ZArrayFactoryV1();
            var expectedResult = new int[] { -1, 0, 8, 0, 6, 0, 4, 0, 2, 0 };

            //When
            var actualResult = zArrayFactory.CreateZArray(pattern);

            //Then
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            for (var i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
