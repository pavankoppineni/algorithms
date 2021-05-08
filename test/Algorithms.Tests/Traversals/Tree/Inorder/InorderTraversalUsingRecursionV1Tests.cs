using Algorithms.Traversals.Tree;
using Algorithms.Traversals.Tree.Inorder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Traversals.Tree.Inorder
{
    [TestClass]
    public class InorderTraversalUsingRecursionV1Tests
    {
        [TestMethod]
        public void Given_BinaryTree_When_InorderTraversal_Then_ShouldReturnAllValuesInOrder()
        {
            //Given
            var rootNode = new Node { Value = 10 };
            var node_21 = new Node { Value = 12 };
            var node_22 = new Node { Value = 13 };
            rootNode.Left = node_21;
            rootNode.Right = node_22;

            var node_31 = new Node { Value = 20 };
            var node_32 = new Node { Value = 25 };
            node_21.Left = node_31;
            node_21.Right = node_32;

            var node_33 = new Node { Value = 36 };
            var node_34 = new Node { Value = 45 };
            node_22.Left = node_33;
            node_22.Right = node_34;

            var node_41 = new Node { Value = 98 };
            var node_42 = new Node { Value = 56 };
            node_31.Left = node_41;
            node_31.Right = node_42;

            var inorderTraversal = new InorderTraversalUsingRecursionV1();
            var expectedInorderList = new List<int> { 98, 20, 56, 12, 25, 10, 36, 13, 45 };

            //When
            var actulInorderList = inorderTraversal.Traverse(rootNode);

            //Then
            Assert.AreEqual(expectedInorderList.Count, actulInorderList.Count);
            for (var index = 0; index < actulInorderList.Count; index++)
            {
                Assert.AreEqual(expectedInorderList[index], actulInorderList[index]);
            }
        }
    }
}
