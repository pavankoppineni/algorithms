using Algorithms.Traversals.Tree;
using Algorithms.Traversals.Tree.Preorder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Traversals.Tree.Preorder
{
    [TestClass]
    public class PreorderTraversalUsingRecursionV1Tests
    {
        [TestMethod]
        public void Given_BinaryTree_When_TraversePreorder_Then_ShouldReturnListInPreorderFashion()
        {
            //Given
            var root = new Node() { Value = 1 };

            var node_21 = new Node() { Value = 2 };
            var node_22 = new Node { Value = 3 };
            root.Left = node_21;
            root.Right = node_22;

            var node_31 = new Node { Value = 4 };
            var node_32 = new Node { Value = 5 };
            node_21.Left = node_31;
            node_21.Right = node_32;

            var problem = new PreorderTraversalUsingRecursionV1();
            var expectedResult = new List<int> { 1, 3, 2, 5, 4 };

            //When
            var actualResult = problem.Traverse(root);

            //Then
            Assert.AreEqual(expectedResult.Count, actualResult.Count);
            for (var index = 0; index < expectedResult.Count; index++)
            {
                Assert.AreEqual(expectedResult[index], actualResult[index]);
            }
        }
    }
}
