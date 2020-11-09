using BinarySearchTreeDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace BinarySearchTreeTest
{
    [TestClass]
    public class BSTUnitTest
    {
        /// <summary>
        /// Givens the size of the number when added to binary search tree should return.
        /// </summary>
        [TestMethod]
        public void GivenNumber_WhenAddedToBinarySearchTree_ShouldReturnSize()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            //Arrange
            int expected = 13;

            //Act
            Node root = null;
            int[] keys = { 56, 30, 22, 11, 3, 16, 40, 70, 60, 65, 63, 67, 95 };
            foreach (var key in keys)
            {
                root = BinarySearchTree.Insert(root, key);
            }
            int actual = binarySearchTree.getSize(root);
            //Assert
            Assert.AreEqual(expected,actual);
        }

        /// <summary>
        /// Checks for appropriate value should return true.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public void CheckForAppropriateValue_ShouldReturnTrue()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            Node root = null;
            int[] keys = { 56, 30, 22, 11, 3, 16, 40, 70, 60, 65, 63, 67, 95 };
            foreach (var key in keys)
            {
                root = BinarySearchTree.Insert(root, key);
            }
            bool actual = binarySearchTree.Search(root, 40);

            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Checks for in appropriate value should return false.
        /// </summary>
        [TestMethod]
        public void CheckForInAppropriateValue_ShouldReturnFalse()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            Node root = null;
            int[] keys = { 56, 30, 22, 11, 3, 16, 40, 70, 60, 65, 63, 67, 95 };
            foreach (var key in keys)
            {
                root = BinarySearchTree.Insert(root, key);
            }
            bool actual = binarySearchTree.Search(root, 50);

            Assert.IsFalse(actual);
        }
    }
}
