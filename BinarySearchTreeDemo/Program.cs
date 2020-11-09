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
            int[] keys = { 56, 30, 22,11,3,16,40,70,60 ,65,63,67,95};
            foreach (var key in keys)
            {
                root = BinarySearchTree.Insert(root, key);
            }
            BinarySearchTree.InorderTraversal(root);

            int size = binarySearchTree.getSize(root);
            Console.WriteLine("\nSize of Binary Search Tree : " + size);
        }
    }
}
