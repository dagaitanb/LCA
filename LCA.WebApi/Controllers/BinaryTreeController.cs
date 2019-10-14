using System.Collections.Generic;
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
        /// <returns>Binary Tree</returns>
        [HttpPost]
        [Route("AddBinaryTree")]
        public BinaryTree AddBinaryTree([FromUri] List<long> values)
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
        /// <param name="nodeValueFirst">First Node</param>
        /// <param name="nodeValueSecond">Second node</param>
        /// <returns>Lowest Common Ancestor</returns>
        [HttpGet]
        [Route("GetLowestCommonAncestor/{nodeValueFirst}/{nodeValueSecond}")]
        public string GetLowestCommonAncestor([FromUri] List<long> values, long nodeValueFirst, long nodeValueSecond)
        {
            return LowestCommonAncestor.Instance.GetLowestCommonAncestor(values, nodeValueFirst, nodeValueSecond).ToString();
        }
    }
}
