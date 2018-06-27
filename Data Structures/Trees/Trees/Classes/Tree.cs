using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public abstract class Tree
    {
        protected Node Root { get; set; }

        public void PreOrder()
        {
            PreOrder(Root);
        }

        protected void PreOrder(Node node)
        {
            Console.Write(node.Value);

            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PreOrder(node.RightChild);
            }
        }

        public void InOrder()
        {
            InOrder(Root);
        }

        protected void InOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild);
            }

            Console.Write(node.Value);

            if (node.RightChild != null)
            {
                InOrder(node.RightChild);
            }
        }

        public void PostOrder()
        {
            PostOrder(Root);
        }

        protected void PostOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                PostOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PostOrder(node.RightChild);
            }

            Console.Write(node.Value);
        }

        public void BreadthFirst()
        {
            BreadthFirst(Root);
        }

        protected void BreadthFirst(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                Console.Write(front.Value);

                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
        }

        abstract public void Add(Node node);
        abstract public Node Search(int value);
        abstract protected Node Search(Node root, int value);
    }
}
