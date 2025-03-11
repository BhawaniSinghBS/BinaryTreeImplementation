using System;

namespace BinaryTreeImplementation
{
    
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree Implementation Example");

            // Create a binary tree
            BinaryTree tree = new BinaryTree();

            // Insert some nodes into the binary tree
            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

            // Perform in-order traversal and print the result
            Console.WriteLine("In-order Traversal of Binary Tree:");
            tree.InOrderTraversal(tree.Root);
        }
    }
}
