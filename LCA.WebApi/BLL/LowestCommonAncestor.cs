using LCA.WebApi.Model;
using System.ServiceModel;
using LCA.WebApi.BLL.Exception;
using System.Collections.Generic;

namespace LCA.WebApi.BLL
{
    /// <summary>
    /// LowestCommonAncestor
    /// </summary>
    public class LowestCommonAncestor : ILowestCommonAncestor
    {
        /// <summary>
        /// log4net library
        /// </summary>
        private readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        /// <summary>
        /// Singleton implementation
        /// </summary>
        private static readonly LowestCommonAncestor instance = new LowestCommonAncestor();

        /// <summary>
        /// Contructor principal
        /// </summary>
        private LowestCommonAncestor() { }

        /// <summary>
        /// Unique instance
        /// </summary>
        public static LowestCommonAncestor Instance
        {
            get { return LowestCommonAncestor.instance; }
        }

        /// <summary>
        /// Add Binary Tree
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public BinaryTree AddBinaryTree(List<long> values)
        {
            try
            {
                BinaryTree binaryTree = new BinaryTree();
                foreach (var item in values)
                {
                    binaryTree.Add(item);
                }

                return binaryTree;
            }
            catch (System.Exception ex)
            {
                MessageException error = new MessageException { Text = ex.Message, ID = "100" };
                log.Error(error.ID + ": An error has occurred in AddBinaryTree: " + 
                    ex.Message + "; " + ex.InnerException);
                throw new FaultException<MessageException> (error,
                    error.ID + ": An error has occurred in AddBinaryTree: " + 
                    ex.Message + "; " + ex.InnerException);
            }
            finally
            {
                log.Info("The Binary Tree was created");
            }
        }

        /// <summary>
        /// Get Lowest Common Ancestor
        /// </summary>
        /// <param name="values">Binary Tree</param>
        /// <param name="nodeValueFirst">Node one of Lowest Common Ancestor</param>
        /// <param name="nodeValueSecond">Node two of Lowest Common Ancestor</param>
        /// <returns></returns>
        public long GetLowestCommonAncestor(List<long> values, long nodeValueFirst, long nodeValueSecond)
        {
            try
            {
                BinaryTree binaryTree = AddBinaryTree(values);
                return LCA(binaryTree.Root, nodeValueFirst, nodeValueSecond);
            }
            catch (System.Exception ex)
            {
                MessageException error = new MessageException { Text = ex.Message, ID = "200" };
                log.Error(error.ID + ": An error has occurred in GetLowestCommonAncestor: " + 
                    ex.Message + "; " + ex.InnerException);
                throw new FaultException<MessageException>(error,
                    error.ID + ": An error has occurred in GetLowestCommonAncestor: " + 
                    ex.Message + "; " + ex.InnerException);
            }
            finally
            {
                log.Info("The Binary Tree was created");
            }
            
        }

        /// <summary>
        /// Lowest Common Ancestor Algorithm
        /// </summary>
        /// <param name="root"></param>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public long LCA(Node root, long first, long second)
        {
            long result = default;

            if (root == null)
                return default;

            if (first == second)
                return first;

            this.FindLCA(root, first, second, ref result);

            return result;
        }

        /// <summary>
        /// Find Lowest Common Ancestor
        /// </summary>
        /// <returns></returns>
        public bool FindLCA(Node node, long first, long second, ref long result)
        {
            if (node == null)
                return false;

            // 1. left find and right find; it is lowest common ancestor
            // 2. node equal to one of node, and left or right find it; it is lowest common ancestor too
            var findLeft = this.FindLCA(node.Left, first, second, ref result);
            var findRight = this.FindLCA(node.Right, first, second, ref result);

            if (findLeft && findRight)
            {
                result = node.Value;
            }
            else if ((node.Value == first || node.Value == second) && (findLeft || findRight))
            {
                result = node.Value;
            }

            if (node.Value == first || node.Value == second)
            {
                return true;
            }

            return findLeft || findRight;
        }
    }
}
