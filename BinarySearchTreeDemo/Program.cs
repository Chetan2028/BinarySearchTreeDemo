using System;

namespace BinarySearchTreeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            Console.WriteLine("Welcome to Binary Search Tree");
            Node root = null;
            int[] keys = { 56, 30, 22, 11, 3, 16, 40, 70, 60, 65, 63, 67, 95 };
            foreach (var key in keys)
            {
                root = BinarySearchTree.Insert(root, key);
            }
            BinarySearchTree.InorderTraversal(root);

            int size = binarySearchTree.getSize(root);
            Console.WriteLine("\nSize of Binary Search Tree : " + size);

            Console.WriteLine(binarySearchTree.Search(root, 63));
        }
    }
}

/**
 *---> INORDER TRAVERSAL : 
 * Algorithm Inorder(tree)
   1. Traverse the left subtree, i.e., call Inorder(left-subtree)
   2. Visit the root.
   3. Traverse the right subtree, i.e., call Inorder(right-subtree)
 * 
 * --->PREORDER TRAVERSAL :
 * Algorithm Preorder(tree)
   1. Visit the root.
   2. Traverse the left subtree, i.e., call Preorder(left-subtree)
   3. Traverse the right subtree, i.e., call Preorder(right-subtree) 
 * 
 * 
 * --->POSTORDER TRAVERSAL : 
 * Algorithm Postorder(tree)
   1. Traverse the left subtree, i.e., call Postorder(left-subtree)
   2. Traverse the right subtree, i.e., call Postorder(right-subtree)
   3. Visit the root.
 */