# Binary Tree
**Author**: Benjamin Taylor  
**Version**: 1.0.0

## Overview
A Binary Tree is a data structure that is similar to a Linked List, but each node in the list contains references for two child nodes, a "Left Child" and a "Right Child". A Binary Search Tree is a type of Binary tree where nodes are sorted in such a way that a Left Child always has a lesser value than its parent, and a Right Child always has a greater value than its parent.
![Binary Tree](https://github.com/btaylor93/Data-Structures-and-Algorithms/raw/master/assets/binarytree.jpg)
This implementation utilizes four classes: a node class, an abstract tree class, and two concrete tree classes (BinaryTree and BinarySearchTree) that inherit from the abstract tree class. The values that can be held in the nodes in this implementation are integers, although any numerical data type could be used (Perhaps generics could be used to increase the flexibility of this implementation). The add and search methods for the BinaryTree class use a breadth-first approach, resulting in a time efficiency of O(n). Because the BinarySearchTree is sorted, its add and search methods don't need to check every node, and have a time efficiency of O(log(n)).
Binary trees can be used in a variety of situations. For example, binary trees are used in the Huffman compression algorithm. Another use for binary trees is a Binary Space Partition, used in 3D video games to determine which objects need to be rendered, reducing the time required to render a scene.


## Getting Started
1. Create a fork of this repository, and clone your fork to your device.  
2. Open the solution file (Stack and Queue.sln) in Visual Studio.
3. To run the app, click the green arrow button labeled "Start".
4. For testing, navigate to the "Stack and Queue Tests" project using the Solution Explorer.
5. To run the tests, press CTRL+R or navigate to Tests > Run > All Tests in the top-level menu.

## Architecture
**Languages Used**: C# 7.0 (.NET Core 2.1)  

Written with Visual Studio Community 2017.

## Change Log
06-23-2018 10:41pm - Initial version.