using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Traversals.Tree.Inorder
{
    /// <summary>
    /// https://www.geeksforgeeks.org/tree-traversals-inorder-preorder-and-postorder/
    /// </summary>
    public class InorderTraversalUsingRecursionV1
    {
        public IList<int> Traverse(Node node)
        {
            var inorderList = new List<int>();
            return Traverse(node, inorderList);
        }

        private IList<int> Traverse(Node node, IList<int> values)
        {
            if (node == null)
            {
                return values;
            }
            Traverse(node.Left, values);
            values.Add(node.Value);
            Traverse(node.Right, values);
            return values;
        }
    }
}
