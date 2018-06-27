using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree : Tree
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        public BinaryTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        protected Node GetNode(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();

                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                else return front;
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
                else return front;
            }
            throw new Exception("This tree is empty!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public override void Add(Node node)
        {
            Node parent = GetNode(Root);
            if (parent.LeftChild == null) parent.LeftChild = node;
            else parent.RightChild = node;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="parent"></param>
        public void Add(Node node, Node parent)
        {
            if (parent.LeftChild == null)
            {
                parent.LeftChild = node;
                return;
            }
            if (parent.RightChild == null)
            {
                parent.RightChild = node;
                return;
            }
            else throw new Exception("Node already has two children!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override Node Search(int value)
        {
            return Search(Root, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        protected override Node Search(Node root, int value)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();

                if (front.Value == value) return front;

                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
            return null;
        }
    }
}
