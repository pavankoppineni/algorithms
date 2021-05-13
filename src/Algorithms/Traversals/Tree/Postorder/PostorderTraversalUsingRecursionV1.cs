using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Traversals.Tree.Postorder
{
    public class PostorderTraversalUsingRecursionV1
    {
        public IList<int> Traverse(Node node)
        {
            IList<int> values = new List<int>();
            values = Traverse(node, values);
            return values;
        }

        private IList<int> Traverse(Node node, IList<int> values)
        {
            if (node == null)
            {
                return values;
            }
            Traverse(node.Left, values);
            Traverse(node.Right, values);
            values.Add(node.Value);
            return values;
        }
    }
}
