using Algorithms.Traversals.Tree;
using Algorithms.Traversals.Tree.Inorder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Traversals.Tree.Inorder
{
    [TestClass]
    public class InorderTraversalUsingStackV3Tests
    {
        [TestMethod]
        public void Given_Tree_When_Traverse_Then_ShouldReturnNodesInOrder()
        {
            //Given
            var expectedInOrderValues = new List<int>
            {
                2,
                1,
                3
            };
            var node_1 = new Node { Value = 1 };
            var node_21 = new Node { Value = 2 };
            var node_22 = new Node { Value = 3 };
            node_1.Left = node_21;
            node_1.Right = node_22;
            var inorderTraversal = new InorderTraversalUsingStackV3();

            //When
            var actualInOrderValues = inorderTraversal.Traverse(node_1);

            //Then
            Assert.AreEqual(expectedInOrderValues.Count, actualInOrderValues.Count);
            for (var index = 0; index < expectedInOrderValues.Count; index++)
            {
                Assert.AreEqual(expectedInOrderValues[index], actualInOrderValues[index]);
            }
        }
    }
}
