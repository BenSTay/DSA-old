using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree : Tree
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        public BinarySearchTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public override void Add(Node node)
        {
            Add(node, Root);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="parent"></param>
        protected void Add(Node node, Node parent)
        {
            if (node.Value < parent.Value)
            {
                if (parent.LeftChild is null) parent.LeftChild = node;
                else Add(node, parent.LeftChild);
            }
            else if (node.Value > parent.Value)
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
        public override Node Search(int value)
        {
            return Search(Root, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        protected override Node Search(Node node, int value)
        {
            if (node is null) return null;
            if (node.Value == value) return node;
            if (node.Value > value) return Search(node.LeftChild, value);
            else return Search(node.RightChild, value);
        }
    }
}
