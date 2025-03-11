using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeImplementation
{
    // BinaryTreeNode class represents a single node in the binary tree
    internal class BinaryTreeNode
    {
        public int Value;       // Value of the node
        public BinaryTreeNode Left;  // Left child node
        public BinaryTreeNode Right; // Right child node

        // Constructor to create a new node with a given value
        public BinaryTreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
