# Graph
**Author**: Benjamin Taylor  
**Version**: 1.0.0

## Overview
A Graph is a data structure similar to a k-ary tree, with the main difference being that it is non-linear (as in, there is no set "start" or "end" to the structure). It is made up of nodes (also called vertices) that can connect many other neighboring nodes (a node can also have no neighbors). Connections between nodes are called "edges", and the number of edges connected to a given node is called its "degree".  
There are many different kinds of graphs (technically, all of my previous data structure implementations can be thought of as graphs). Graphs can be defined by its directionality: each edge in an **undirected** graph can be navigated in both directions, while **directed** graphs only allow edges to be navigated in a single direction. Graphs can also be defined by their degree of connectedness: a graph is considered **complete** when every node within it connects to every other node, a graph that is **connected** has at least one edge for every node, and a **disconnected** graph contains one or more nodes with no edges. Additionally, graphs can be defined by whether or not they are **cyclic**, meaning they have a defined length that starts and ends on the same node (graphs that are not cyclic are called **acyclic** graphs).  
Graphs can be represented in two ways: an adjacency matrix or an adjacency list. An matrix is a square 2-dimensional array where the length of each side corresponds to the number of nodes in the graph, and each square in the matrix holds a flag for whether or not the nodes are connected. A list is simply a collection of lists, where each list held in the collection holds lists nodes that are connected to a given point.  
Additionally, edges in graphs can be assigned numbers or "weights".
![Graph](https://github.com/btaylor93/Data-Structures-and-Algorithms/raw/master/assets/graph.png)
This implementation is a undirected, disconnected, acyclic, non-weighted graph represented as an adjacency list. It is made up of two classes: a Node class and a Graph class. The node class contains a Value, a list of Children, and a Visited flag used for navigation. The Graph class contains a list of nodes, and methods for getting the size of the graph, the number of neighbors for a given node, adding a node to the graph, getting all of the nodes contained in the graph, and for navigating the graph using a breadth-first approach.  
Graphs can be used for a large variety of purposes. A graph could be used to describe the layout of locations in a video game (like a text-based adventure game), where each node in the graph could be considered a location, and the nodes it connects to are locations that can be accessed from that location. You could also use a graph for a social network, where each node is a user and the node's neighbors are that users friends.

## Getting Started
1. Create a fork of this repository, and clone your fork to your device.  
2. Open the solution file (Graphs.sln) in Visual Studio.
3. To run the app, click the green arrow button labeled "Start".
4. For testing, navigate to the GraphTests project using the Solution Explorer.
5. To run the tests, press CTRL+R or navigate to Tests > Run > All Tests in the top-level menu.

## Architecture
**Languages Used**: C# 7.0 (.NET Core 2.1)  

Written with Visual Studio Community 2017.

## Change Log
07-10-2018 12:27am - Initial version.