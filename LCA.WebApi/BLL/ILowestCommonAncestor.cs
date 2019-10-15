using LCA.WebApi.Model;
using System.Collections.Generic;

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
        BinaryTree AddBinaryTree(List<long> values);

        /// <summary>
        /// Get Lowest Common Ancestor
        /// </summary>
        /// <param name="values">Binary Tree</param>
        /// <param name="nodeOne">Node one of Lowest Common Ancestor</param>
        /// <param name="nodeTwo">Node two of Lowest Common Ancestor</param>
        /// <returns></returns>
        long GetLowestCommonAncestor(List<long> values, long first, long second);
    }
}
