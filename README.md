:*******************BinaryTreeImplementation:*******************
This is a simple implementation of a Binary Search Tree (BST) in C#. The program supports inserting new nodes and performing in-order traversal to display the tree’s nodes in ascending order.
**************************************:*************************

:*******************Explanation of the Code:*******************
BinaryTreeNode Class:

This class represents a node in the binary tree. It holds a Value (the data for the node), as well as references to Left and Right child nodes.
The constructor initializes the value and sets both children to null.
BinaryTree Class:

This class represents the binary tree itself. It has a reference to the Root node of the tree.
The Insert method inserts a new value into the tree. It calls a helper method InsertRecursive, which recursively places the new value in the correct location based on comparisons.
The InOrderTraversal method performs an in-order traversal of the tree, which visits the left child, then the current node, then the right child. This results in visiting the nodes in ascending order for a binary search tree.
Program Class:

The Main method creates an instance of the BinaryTree class, inserts several values into the tree, and then performs an in-order traversal to display the values in sorted order.
*******************:*********************************************


*******************Features:**************************************
Insert: Insert a new value into the binary search tree.
In-Order Traversal: Traverse the tree in ascending order and print the values.
How to Use:
Clone or download the project.
Open the project in Visual Studio or your preferred C# IDE.
Run the program. The binary tree will be created with some sample values, and the in-order traversal will display the node values in sorted order.
Example:
The program inserts the following values into the tree: 50, 30, 20, 40, 70, 60, 80.
In-order traversal of the tree will print: 20 30 40 50 60 70 80.
Customization:
You can modify the Insert method to insert other values or create a method for other types of tree traversals (like Pre-order or Post-order).
You can add additional methods like searching for a node, deleting a node, or getting the height of the tree.
Requirements:
C# 9.0 or higher
.NET Core or .NET Framework
How to Build:
Open the project in your IDE and press F5 to build and run the application.
*******************:**************************************


*:**********************************************************
"Traversal" Mean?
Traversal in data structures means visiting each node of a tree or graph in a specific order to process its data.

🔹 Why Do We Need Traversal?
To search for an element in a tree or graph.
To process all nodes (e.g., calculating sum, finding min/max).
To convert a tree into a list (e.g., in-order traversal for BST sorting).
🔹 Types of Tree Traversals
Tree traversal is mainly divided into two categories:

1️⃣ Depth-First Traversal (DFS)
This means going as deep as possible before backtracking.
Three common DFS types:

In-Order (Left → Root → Right)

Used for BST sorting.
Example: 1 → 2 → 3 → 4 → 5 → 6 → 7
Pre-Order (Root → Left → Right)

Used for creating a copy of the tree.
Example: 4 → 2 → 1 → 3 → 6 → 5 → 7
Post-Order (Left → Right → Root)

Used for deleting a tree (bottom-up processing).
Example: 1 → 3 → 2 → 5 → 7 → 6 → 4
2️⃣ Breadth-First Traversal (BFS)
This means visiting nodes level by level (also called Level Order Traversal).

Example: 4 → 2 → 6 → 1 → 3 → 5 → 7
Used in shortest path algorithms.
🔹 Example Tree
markdown

       4
      / \
     2   6
    / \  / \
   1   3 5  7
Traversal Type	Output Sequence
In-Order (Left → Root → Right)	1 → 2 → 3 → 4 → 5 → 6 → 7
Pre-Order (Root → Left → Right)	4 → 2 → 1 → 3 → 6 → 5 → 7
Post-Order (Left → Right → Root)	1 → 3 → 2 → 5 → 7 → 6 → 4
Level-Order (BFS)	4 → 2 → 6 → 1 → 3 → 5 → 7

:*******************************************************************

