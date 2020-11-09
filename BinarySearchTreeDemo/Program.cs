using System;

namespace BinarySearchTreeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");
            Node root = null;
            int[] keys = { 56, 30, 70 };
            foreach (var key in keys)
            {
                root = BinarySearchTree.Insert(root, key);
            }
            BinarySearchTree.InorderTraversal(root);
        }
    }
}
