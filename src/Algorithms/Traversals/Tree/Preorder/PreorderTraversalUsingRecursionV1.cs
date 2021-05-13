using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Traversals.Tree.Preorder
{
    public class PreorderTraversalUsingRecursionV1
    {
        public IList<int> Traverse(Node node)
        {
            return Traverse(node, new List<int>());
        }

        private IList<int> Traverse(Node node, IList<int> values)
        {
            if (node == null)
            {
                return values;
            }
            values.Add(node.Value);
            Traverse(node.Right, values);
            Traverse(node.Left, values);
            return values;
        }
    }
}
