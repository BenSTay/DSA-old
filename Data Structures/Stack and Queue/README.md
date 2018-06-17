Stack and Queue
**Author**: Benjamin Taylor  
**Version**: 1.0.0

## Overview
Stacks and Queues are data structures that store information in a sequential order. Stacks work by adding and removing data from the top of the stack, and therefore data in a stack is in a "First In, Last Out" order. Queues, by constrast, add to the rear of the queue and remove from the front, resulting in a "First In, First Out" ordering.
![Stack and Queue](https://github.com/btaylor93/Data-Structures-and-Algorithms/raw/master/assets/stackandqueue.jpg)
Similar to my implementation of a Linked List, this implementation of Stacks and Queues is made up of Node objects, each holding an integer value and a reference to the next node in the structure (although, in this case "next" could be renamed to "previous", as the next node in both of these structures is the next node back from the front). The stack additionally has a reference to its topmost node, and contains methods for pushing (adding) or popping (removing) nodes to itself. Similarly, the queue contains references to its front node and its rear node, and methods to enqueue (add) or dequeue (remove) nodes from itself. In addition, both the stack and queue contain a method to "peek" at the top/front node in the structure.  
Some uses for stacks include storing previous states of a document for an undo button in a text editor, and for evaluating mathematical expressions using postfix notation. Some uses for queues include making sure that the first printing job a printer recieves is the first that gets processed, and performing breadth-first searches of graphs.


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
06-16-2018 6:02pm - Initial version.
