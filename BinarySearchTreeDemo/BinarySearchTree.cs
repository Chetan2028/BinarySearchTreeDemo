using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeDemo
{
    class BinarySearchTree
    {
        Node root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        public void Insert(Node root , int key)
        {
            //Create a new node containing a new element
            Node newNode = new Node(key);

            //Pointer to start traversing from root and traverses downward path to search where the new node to  be inserted
            Node x = root;

            Node y = null;

            while (x != null)
            {

            }

        }
    }
}
