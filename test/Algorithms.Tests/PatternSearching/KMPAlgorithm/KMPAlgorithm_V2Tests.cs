using Algorithms.PatternSearching.KMPAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.PatternSearching.KMPAlgorithm
{
    [TestClass]
    public class KMPAlgorithm_V2Tests
    {
        private static IEnumerable<object[]> GetDataSource()
        {
            var datasource = new List<object[]>();

            //Test case one
            var testCaseOne = new object[]
            {
                "ababab",
                new int[]{ 0, 0, 1, 2, 3, 4}
            };
            datasource.Add(testCaseOne);

            //Test case two
            var testCaseTwo = new object[]
            {
                "abcabc",
                new int[]{ 0, 0, 0, 1, 2, 3}
            };
            datasource.Add(testCaseTwo);

            return datasource;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataSource), DynamicDataSourceType.Method)]
        public void Given_String_When_ConstructLPS_Then_ShoulReturnLPSArray(string pattern, int[] expectedResult)
        {
            //Given
            var algorithm = new KMPAlgorithm_V2();

            //When
            var actualLPS = algorithm.ConstructLPS(pattern);

            //Then
            Assert.AreEqual(expectedResult.Length, actualLPS.Length);
        }

        [TestMethod]
        public void Given_TextAndPattern_When_CheckForPattern_Then_ShouldReturnTrueIfPatternIsFound()
        {
            //Given
            var pattern = "ababe";
            var text = "ababcababe";
            var algorithm = new KMPAlgorithm_V2();
            var expectedResult = true;

            //When
            var actualResult = algorithm.CheckForPattern(text, pattern);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
