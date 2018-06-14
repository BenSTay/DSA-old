using System;

namespace LinkedLists.Classes
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        /// <summary>
        /// Creates a new LinkedList with a single node in it.
        /// </summary>
        /// <param name="node">The first node in the LinkedList.</param>
        public LinkedList(Node node)
        {
            Head = node;
        }
        
        /// <summary>
        /// Adds a node to the front of the LinkedList.
        /// </summary>
        /// <param name="node">The node to be added.</param>
        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// Finds the first node that has a given value.
        /// </summary>
        /// <param name="value">The value being searched for.</param>
        /// <returns>The node with the matching value, or null if nothing is found.</returns>
        public Node Find(int value)
        {
            Current = Head;
            while (true)
            {
                if (Current.Value == value) return Current;
                else if (Current.Next == null) return null;
                Current = Current.Next;
            }
        }

        /// <summary>
        /// Prints out the values of all of the nodes in the LinkedList to the console.
        /// </summary>
        public void Print()
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} --> ");
                Current = Current.Next;
            }
            Console.Write($"{Current.Value} --> NULL\n");
        }

        /// <summary>
        /// Adds a new node to the LinkedList before a specified node.
        /// </summary>
        /// <param name="newNode">The node that is being added.</param>
        /// <param name="node">The node that the new node is being added before.</param>
        /// <returns>True or false depending on if the operation is successful.</returns>
        public bool AddBefore(Node newNode, Node node)
        {
            if (node == Head)
            {
                Add(newNode);
                return true;
            }
            else
            {
                Current = Head;
                while (Current.Next != null)
                {
                    if (Current.Next == node)
                    {
                        newNode.Next = Current.Next;
                        Current.Next = newNode;
                        return true;
                    }
                    else Current = Current.Next;
                }
                return false;
            }
        }

        /// <summary>
        /// Adds a new node to the LinkedList after a specified node.
        /// </summary>
        /// <param name="newNode">The node that is being added.</param>
        /// <param name="node">The node that the new node is being added after.</param>
        /// <returns>True or false depending on if the operation is successful.</returns>
        public bool AddAfter(Node newNode, Node node)
        {
            Current = Head;
            while (Current != null)
            {
                if (Current == node)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return true;
                }
                else Current = Current.Next;
            }
            return false;
        }

        /// <summary>
        /// Adds a new node to the end of the LinkedList.
        /// </summary>
        /// <param name="node">The node that is being added.</param>
        public void AddLast(Node node)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = node;
        }

    }
}
