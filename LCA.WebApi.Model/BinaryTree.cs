using System;
using System.Collections.Generic;
using System.Text;

namespace LCA.WebApi.Model
{
    class BinaryTree
    {
        /// <summary>
        /// Root node
        /// </summary>
        public Node Root { get; set; }

        /// <summary>
        /// Constructor principal
        /// </summary>
        public BinaryTree()
        {
            Root = null;
        }

        /// <summary>
        /// Method to add nodes
        /// </summary>
        /// <param name="value"></param>
        public void add (long value)
        {
            if (Root == null)
            {
                Root = new Node(value);
                return;
            }

            addRecursively(Root, new Node(value));
        }

        /// <summary>
        /// Method to add nodes recursively from the root node
        /// </summary>
        /// <param name="root">Root Node</param>
        /// <param name="newNode">New Node to add</param>
        public void addRecursively(Node root, Node newNode)
        {
            if (root == null)
                root = newNode;

            if(newNode.Value < Root.Value)
            {
                if (Root.Left == null)
                    Root.Left = newNode;
                else
                    addRecursively(Root.Left, newNode);
            }
            else
            {
                if(Root.Right == null)
                    Root.Right = newNode;
                else
                    addRecursively(Root.Right, newNode);
            }
        }

    }
}
