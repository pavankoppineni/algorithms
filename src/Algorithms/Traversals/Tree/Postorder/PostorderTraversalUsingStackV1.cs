using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Traversals.Tree.Postorder
{
    public class PostorderTraversalUsingStackV1
    {
        public IList<int> Traverse(Node node)
        {
            var values = new List<int>();
            var stackOne = new Stack<Node>();
            var stackTwo = new Stack<Node>();
            stackOne.Push(node);
            while (stackOne.Count > 0)
            {
                var currentNode = stackOne.Pop();
                stackTwo.Push(currentNode);

                if (currentNode.Left != null)
                {
                    stackOne.Push(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    stackOne.Push(currentNode.Right);
                }
            }

            while (stackTwo.Count > 0)
            {
                var currentNode = stackTwo.Pop();
                values.Add(currentNode.Value);
            }

            return values;
        }
    }
}
