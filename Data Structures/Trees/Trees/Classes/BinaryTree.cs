using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree<T> : Tree<T> where T : IComparable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        public BinaryTree(Node<T> root)
        {
            Root = root;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        protected Node<T> GetNode(Node<T> root)
        {
            Queue<Node<T>> breadth = new Queue<Node<T>>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node<T> front = breadth.Dequeue();

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
        public override void Add(Node<T> node)
        {
            Node<T> parent = GetNode(Root);
            if (parent.LeftChild == null) parent.LeftChild = node;
            else parent.RightChild = node;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="parent"></param>
        public void Add(Node<T> node, Node<T> parent)
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
        public override Node<T> Search(T value)
        {
            return Search(Root, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        protected override Node<T> Search(Node<T> root, T value)
        {
            Queue<Node<T>> breadth = new Queue<Node<T>>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node<T> front = breadth.Dequeue();

                if (front.Value.Equals(value)) return front;

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
