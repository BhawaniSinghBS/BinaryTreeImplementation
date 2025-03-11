using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeImplementation
{
    // BinaryTree class that represents the binary tree
    internal class BinaryTree
    {
        public BinaryTreeNode Root;  // Root node of the tree

        // Constructor to create a new binary tree
        public BinaryTree()
        {
            Root = null;
        }

        // Insert a new value into the binary tree
        public void Insert(int value)
        {
            Root = InsertRecursive(Root, value);
        }

        // Helper method for recursive insertion
        private BinaryTreeNode InsertRecursive(BinaryTreeNode node, int value)
        {
            // If the current node is null, create a new node and return it
            if (node == null)
            {
                return new BinaryTreeNode(value);
            }

            // If value is less than the current node's value, go left
            if (value < node.Value)
            {
                node.Left = InsertRecursive(node.Left, value);
            }
            // If value is greater than the current node's value, go right
            else
            {
                node.Right = InsertRecursive(node.Right, value);
            }

            return node; // Return the (unchanged) node pointer
        }

        // In-order traversal: Left, Root, Right
        public void InOrderTraversal(BinaryTreeNode node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);      // Visit left subtree
                Console.Write(node.Value + " ");  // Visit root node
                InOrderTraversal(node.Right);     // Visit right subtree
            }
        }
    }
}
