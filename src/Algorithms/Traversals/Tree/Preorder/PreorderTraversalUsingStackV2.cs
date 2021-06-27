using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Traversals.Tree.Preorder
{
    public class PreorderTraversalUsingStackV2
    {
        public IList<int> Traverse(Node node)
        {
            var preOrderNodes = new List<int>();
            var stack = new Stack<Node>();
            stack.Push(node);
            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                preOrderNodes.Add(currentNode.Value);
                if (currentNode.Right != null)
                {
                    stack.Push(currentNode.Right);
                }
                if (currentNode.Left != null)
                {
                    stack.Push(currentNode.Left);
                }
            }
            return preOrderNodes;
        }
    }
}
