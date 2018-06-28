using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree<T> : Tree<T> where T : IComparable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        public BinarySearchTree(Node<T> root)
        {
            Root = root;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public override void Add(Node<T> node)
        {
            Add(node, Root);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="parent"></param>
        protected void Add(Node<T> node, Node<T> parent)
        {
            if (node.Value.CompareTo(parent.Value) < 0)
            {
                if (parent.LeftChild is null) parent.LeftChild = node;
                else Add(node, parent.LeftChild);
            }
            else if (node.Value.CompareTo(parent.Value) > 0)
            {
                if (parent.RightChild is null) parent.RightChild = node;
                else Add(node, parent.RightChild);
            }
            else throw new Exception("This node already exists!");
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
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        protected override Node<T> Search(Node<T> node, T value)
        {
            if (node is null) return null;
            if (node.Value.CompareTo(value) == 0) return node;
            if (node.Value.CompareTo(value) > 0) return Search(node.LeftChild, value);
            else return Search(node.RightChild, value);
        }
    }
}
