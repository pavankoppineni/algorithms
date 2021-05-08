using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Traversals.Tree.Inorder
{
    /// <summary>
    /// https://www.geeksforgeeks.org/inorder-tree-traversal-without-recursion/
    /// </summary>
    public class InorderTraversalUsingStackV1
    {
        public IList<int> Traverse(Node node)
        {
            var inorderList = new List<int>();
            var stack = new Stack<Node>();
            var currentNode = node;
            while (currentNode != null || stack.Count > 0)
            {
                while (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }

                currentNode = stack.Pop();
                inorderList.Add(currentNode.Value);
                currentNode = currentNode.Right;
            }
            return inorderList;
        }
    }
}
