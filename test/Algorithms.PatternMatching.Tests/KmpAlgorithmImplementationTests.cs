using Algorithms.PatternMatching.KmpAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.PatternMatching.Tests
{
    [TestClass]
    public class KmpAlgorithmImplementationTests
    {

        [DataTestMethod]
        [DataRow("abcabceabcabcd", "abcabcd", true)]
        [DataRow("abxabxabx", "xyz", false)]
        [DataRow("xyz", "x", true)]
        public void GivenTextAndInalidPattern_Match_ReturnsFalse(string text, string pattern, bool expectedResult)
        {
            //Arrange
            var kmpAlgorithm = new KmpAlgorithmImplementation(text);

            //Act
            var result = kmpAlgorithm.Match(pattern);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
