using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.StackQueue;

namespace Test.Ds.StackQueue
{
    [TestClass]
    public class IsBalancedTest
    {
        [TestMethod]
        [DataRow("{[()]}")]
        [DataRow("{{[[(())]]}}")]
        [DataRow("{(([])[])[]}")]
        [DataRow("{(([])[])[]}[]")]
        [DataRow("abcd")]
        public void TestIsBalancedTrue(string str)
        {
            Assert.IsTrue(IsBalanced.Solution(str));
        }

        [TestMethod]
        [DataRow("{abcd")]
        [DataRow("{[(])}")]
        [DataRow("{(([])[])[]]}")]
        public void TestIsBalancedFalse(string str)
        {
            Assert.IsFalse(IsBalanced.Solution(str));
        }
    }
}