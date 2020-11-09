using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeDemo
{
    class BinarySearchTree
    {
        /// <summary>
        /// Inserts the specified root.
        /// Root is passed by reference to the function
        /// </summary>
        /// <param name="root">The root.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        /// 
        public static void InorderTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }
            InorderTraversal(root.left);
            Console.Write(root.key + "  ");
            InorderTraversal(root.right);
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name="root">The root.</param>
        /// <returns></returns>
        public int getSize(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            return getSize(root.left) + 1 + getSize(root.right);
        }

        /// <summary>
        /// Inserts the element in Tree
        /// </summary>
        /// <param name="root">The root.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public static Node Insert(Node root , int key)
        {
            //start with root node
            Node current = root;

            //pointer to store parent node of current node
            Node parent = null;

            //If tree is empty , create a node and set root
            if (root == null)
            {
                return new Node(key);
            }

            //Traverse the tree and find the parent node of key
            while (current != null)
            {
                //Update parent node as current node
                parent = current;

                //if key is less than current node , go to left subtree else right subtree
                if (key < current.key)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
            }

            //Construct a new node and assign to appropriate parent pointer
            if (key < parent.key)
            {
                parent.left = new Node(key);
            }
            else
            {
                parent.right = new Node(key);
            }

            return root;
        }
    }
}
