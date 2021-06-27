using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Traversals.Tree.Inorder
{
    public class InorderTraversalUsingStackV3
    {
        public IList<int> Traverse(Node node)
        {
            var nodesOrder = new List<int>();
            var stack = new Stack<Node>();
            Node current = node;
            while (current != null || stack.Count > 0)
            {
                if (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }
                else
                {
                    current = stack.Pop();
                    nodesOrder.Add(current.Value);
                    current = current.Right;
                }
            }
            return nodesOrder;
        }
    }
}
