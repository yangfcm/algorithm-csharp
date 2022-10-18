using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Greedy;

namespace Test.Algo.Greedy
{
    [TestClass]
    public class GreedyFloristTest
    {
        [TestMethod]
        [DataRow(new int[] {2, 5, 6}, 3, 13)]
        [DataRow(new int[] {2, 5, 6}, 2, 15)]
        [DataRow(new int[] {3, 7, 9, 5, 1}, 3, 29)]
        public void TestSolution(int[] costs, int k, int expected)
        {
            Assert.AreEqual(expected, GreedyFlorist.Solution(costs, k));
        }
    }
}