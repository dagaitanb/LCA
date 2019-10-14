using Microsoft.VisualStudio.TestTools.UnitTesting;
using LCA.WebApi.BLL;
using LCA.WebApi.Model;

namespace LCA.WebApi.Tests
{
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// Lowest Common Ancestor instance
        /// </summary>
        private readonly LowestCommonAncestor LCA = LowestCommonAncestor.Instancia;

        /// <summary>
        /// Values of the binary tree
        /// </summary>
        private readonly long[] values = { 67, 39, 76, 28, 44, 74, 85, 29, 83, 87 };

        [TestMethod]
        public void TestMethod1()
        {
            BinaryTree bt = LCA.AddBinaryTree(values);

            Assert.IsNotNull(bt);
        }
    }
}
