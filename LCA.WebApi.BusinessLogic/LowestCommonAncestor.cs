using System;
using System.Collections.Generic;
using System.Text;
using LCA.WebApi.Model;

namespace LCA.WebApi.BusinessLogic
{
    public class LowestCommonAncestor : ILowestCommonAncestor
    {
        private readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly LowestCommonAncestor instancia = new LowestCommonAncestor();

        private LowestCommonAncestor() { }

        public static LowestCommonAncestor Instancia
        {
            get { return LowestCommonAncestor.instancia; }
        }

        /// <summary>
        /// Add Binary Tree
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public BinaryTree AddBinaryTree(long[] values)
        {
            BinaryTree binaryTree = new BinaryTree();
            foreach (var item in values)
            {
                binaryTree.Add(item);
            }
            log.Info("The Binary Tree was created");

            return binaryTree;
        }

        public long GetLowestCommonAncestor(long[] values, long nodeValueFirst, long nodeValueSecond)
        {
            BinaryTree binaryTree = AddBinaryTree(values);
            Node root = binaryTree.Root;
            return LCA(root, nodeValueFirst, nodeValueSecond);
        }

        public long LCA(Node root, long first, long second)
        {
            if (root == null)
                return default;

            if (root.Value == first)
                return root.Value;

            if (root.Value == second)
                return root.Value;

            if (root.Value.CompareTo(first) < 0 && root.Value.CompareTo(second) < 0)
                return LCA(root.Left, first, second);
            else if (root.Value.CompareTo(first) > 0 && root.Value.CompareTo(second) > 0)
                return LCA(root.Right, first, second);
            return root.Value;
        }
    }
}
