using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LCA.WebApi.Controllers
{
    public class BinaryTreeController : ApiController
    {
        [HttpPost]
        public IHttpActionResult addBinaryTree(long[] values)
        {
            return Ok(0);
        }

        [HttpGet]
        public IHttpActionResult getLowestCommonAncestor(long[] tree, long nodeLeft, long nodeRight)
        {
            return Ok(0);
        }
    }
}
