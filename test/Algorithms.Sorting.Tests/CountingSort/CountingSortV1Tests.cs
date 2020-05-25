using Algorithms.Sorting.CountingSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Sorting.Tests.CountingSort
{
    [TestClass]
    public class CountingSortV1Tests
    {
        [TestMethod]
        public void ArrayWithIntegers_Sort_ReturnsSortedArray()
        {
            //Arrange
            var values = new int[] { 4, 2, 2, 8, 3, 3, 1 };
            var countingSort = new CountingSortV1();
            var expectedArray = new int[] { 1, 2, 2, 3, 3, 4, 8 };
            //Act
            var sortedArray = countingSort.Sort(values);

            //Assert
            for (var i = 0; i < values.Length; i++)
            {
                Assert.AreEqual(expectedArray[i], sortedArray[i]);
            }
        }
    }
}
