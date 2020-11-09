using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace BinarySearchTreeDemo
{
    public class BinarySearchTree
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
        /// Searches the specified root.
        /// </summary>
        /// <param name="root">The root.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public bool Search(Node root , int key)
        {
            root = SearchRecursive(root, key);

            if (root != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Searches the specified root.
        /// </summary>
        /// <param name="root">The root.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public Node SearchRecursive(Node root , int key)
        {
            //Base Cases : Root is null or key is present at root
            if (root == null || root.key == key)
            {
                return root;
            }

            //If key is greater than root's key,search on right side
            if (key > root.key)
            {
                return SearchRecursive(root.right, key);
            }

            //If key is less than root's key,search on left side
            return SearchRecursive(root.left, key);
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
