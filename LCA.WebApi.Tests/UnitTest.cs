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
        private readonly LowestCommonAncestor LCA = LowestCommonAncestor.Instance;

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

        [TestMethod]
        public void TestMethod2()
        {
            long test1 = LCA.GetLowestCommonAncestor(values, 29, 44);
            long test2 = LCA.GetLowestCommonAncestor(values, 44, 85);
            long test3 = LCA.GetLowestCommonAncestor(values, 83, 87);

            Assert.AreEqual(test1, 39);
            Assert.AreEqual(test2, 67);
            Assert.AreEqual(test3, 85);
        }
    }
}
