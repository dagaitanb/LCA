using System.Web.Http;
using LCA.WebApi.BusinessLogic;

namespace LCA.WebApi.Controllers
{
    public class BinaryTreeController : ApiController
    {
        [HttpPost]
        public IHttpActionResult AddBinaryTree(long[] values)
        {
            return Ok(LowestCommonAncestor.Instancia.AddBinaryTree(values));
        }

        [HttpGet]
        public IHttpActionResult getLowestCommonAncestor(long[] tree, long nodeValueFirst, long nodeValueSecond)
        {
            return Ok(LowestCommonAncestor.Instancia.GetLowestCommonAncestor(tree, nodeValueFirst, nodeValueSecond));
        }
    }
}
