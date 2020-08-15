using Algorithms.PatternMatching.KmpAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.PatternMatching.Tests.KmpAlgorithm
{
    [TestClass]
    public class KMPAlgorithmV1Tests
    {
        [DataTestMethod]
        [DataRow("abcxyzd", "xyz", true)]
        [DataRow("abcxyd", "xyz", false)]
        [DataRow("abcxd", "cx", true)]
        public void Given_TextAndPattern_When_Find_Then_ShouldReturnTrueIfPatternExistsElseFalse(string text, string pattern, bool expectedResult)
        {
            //Given
            var kmpAlgorithm = new KMPAlgorithmV2();

            //When
            var actualResult = kmpAlgorithm.PatternExists(text, pattern);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
