using LCA.WebApi.Model;
using System.ServiceModel;
using LCA.WebApi.BLL.Exception;

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
        private static readonly LowestCommonAncestor instancia = new LowestCommonAncestor();

        /// <summary>
        /// Contructor principal
        /// </summary>
        private LowestCommonAncestor() { }

        /// <summary>
        /// Unique instance
        /// </summary>
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
                log.Error(error.ID + ": An error has occurred in AddBinaryTree: \n" + ex);
                throw new FaultException<MessageException> (error,
                    "100: An error has occurred in AddBinaryTree: \n" + ex.Message + "\n" + ex.InnerException);
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
        public long GetLowestCommonAncestor(long[] values, long nodeValueFirst, long nodeValueSecond)
        {
            try
            {
                BinaryTree binaryTree = AddBinaryTree(values);
                Node root = binaryTree.Root;
                return LCA(root, nodeValueFirst, nodeValueSecond);
            }
            catch (System.Exception ex)
            {
                MessageException error = new MessageException { Text = ex.Message, ID = "200" };
                log.Error(error.ID + 
                    ": An error has occurred in GetLowestCommonAncestor: \n" + 
                    ex.Message + "\n" + 
                    ex.InnerException);
                throw new FaultException<MessageException>(error,
                    "100: An error has occurred in GetLowestCommonAncestor: \n" + 
                    ex.Message + "\n" + 
                    ex.InnerException);
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
