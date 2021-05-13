using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Traversals.Tree.Inorder
{
    public class InorderTraversalUsingStackV2
    {
        public IList<int> Traverse(Node node)
        {
            var result = new List<int>();
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
                result.Add(currentNode.Value);
                currentNode = currentNode.Right;
            }
            return result;
        }
    }
}
