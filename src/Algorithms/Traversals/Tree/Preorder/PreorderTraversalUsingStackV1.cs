using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Traversals.Tree.Preorder
{
    public class PreorderTraversalUsingStackV1
    {
        public IList<int> Traverse(Node node)
        {
            var values = new List<int>();
            var stack = new Stack<Node>();
            stack.Push(node);
            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                values.Add(currentNode.Value);
                if (currentNode.Right != null)
                {
                    stack.Push(currentNode.Right);
                }
                if (currentNode.Left != null)
                {
                    stack.Push(currentNode.Left);
                }
            }
            return values;
        }
    }
}
