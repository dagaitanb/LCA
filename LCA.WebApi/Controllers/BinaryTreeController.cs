using System.Web.Http;
using LCA.WebApi.BLL;
using LCA.WebApi.Model;

namespace LCA.WebApi.Controllers
{
    /// <summary>
    /// BinaryTreeController
    /// </summary>
    [RoutePrefix("api/BinaryTreeController")]
    public class BinaryTreeController : ApiController
    {
        /// POST: api/Binarytree
        /// <summary>
        /// Add Binary Tree
        /// </summary>
        /// <remarks>
        /// Create Binary Tree with values
        /// </remarks>
        /// <param name="values">All values of binary tree</param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddBinaryTree")]
        public BinaryTree AddBinaryTree(long[] values)
        {
            return LowestCommonAncestor.Instance.AddBinaryTree(values);
        }

        /// GET: api/BinaryTree
        /// <summary>
        /// Get Lowest Common Ancestor
        /// </summary>
        /// <remarks>
        /// Get Lowest Common Ancestor of Binary Tree with two nodes
        /// </remarks>
        /// <param name="values">Values of Binary Tree</param>
        /// <param name="nodeOne">First Node</param>
        /// <param name="nodeTwo">Second node</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetLowestCommonAncestor")]
        public long GetLowestCommonAncestor(long[] values, long nodeOne, long nodeTwo)
        {
            return LowestCommonAncestor.Instance.GetLowestCommonAncestor(values, nodeOne, nodeTwo);
        }
    }
}
