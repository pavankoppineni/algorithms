using Algorithms.Traversals.Tree;
using Algorithms.Traversals.Tree.Preorder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Traversals.Tree.Preorder
{
    [TestClass]
    public class PreorderTraversalUsingStackV2Tests
    {
        [TestMethod]
        public void Given_Tree_When_Traverse_Should_ReturnNodesInPreorder()
        {
            //Given
            var expectedPreorder = new List<int>
            {
                1, 2, 3
            };
            var node_1 = new Node { Value = 1 };
            var node_21 = new Node { Value = 2 };
            var node_22 = new Node { Value = 3 };
            node_1.Left = node_21;
            node_1.Right = node_22;
            var problem = new PreorderTraversalUsingStackV2();

            //When
            var actualPreorder = problem.Traverse(node_1);

            //Then
            Assert.AreEqual(expectedPreorder.Count, actualPreorder.Count);
            for (var index = 0; index < expectedPreorder.Count; index++)
            {
                Assert.AreEqual(expectedPreorder[index], actualPreorder[index]);
            }
        }
    }
}
