using LCA.WebApi.Model;

namespace LCA.WebApi.BLL
{
    /// <summary>
    /// Interface ILowestCommonAncestor
    /// </summary>
    public interface ILowestCommonAncestor
    {
        /// <summary>
        /// Add Binary Tree
        /// </summary>
        /// <param name="values">All values of binary tree</param>
        /// <returns></returns>
        BinaryTree AddBinaryTree(long[] values);

        /// <summary>
        /// Get Lowest Common Ancestor
        /// </summary>
        /// <param name="tree">Binary Tree</param>
        /// <param name="nodeOne">Node one of Lowest Common Ancestor</param>
        /// <param name="nodeTwo">Node two of Lowest Common Ancestor</param>
        /// <returns></returns>
        long GetLowestCommonAncestor(long[] tree, long nodeOne, long nodeTwo);
    }
}
