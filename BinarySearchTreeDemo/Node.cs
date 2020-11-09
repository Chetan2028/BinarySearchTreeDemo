using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeDemo
{
    class Node
    {
        public int key;
        public Node left;
        public Node right;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="key">The key.</param>
        public Node(int key)
        {
            this.key = key;
            this.left = null;
            this.right = null;
        }
    }
}
