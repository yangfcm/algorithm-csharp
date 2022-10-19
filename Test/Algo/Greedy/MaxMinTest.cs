using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Greedy;

namespace Test.Algo.Greedy
{
    [TestClass]
    public class MaxMinTest
    {
        [TestMethod]
        [DataRow(new int[]{10, 100, 300, 200, 1000, 20, 30}, 3, 20)]
        [DataRow(new int[]{1, 2, 3, 4, 10, 20, 30, 40, 100, 200}, 4, 3)]
        [DataRow(new int[]{2, 1, 2, 1, 2, 1}, 2, 0)]
        public void TestSolution(int[] arr, int k, int expected)
        {
            Assert.AreEqual(expected, MaxMin.Solution(arr, k));
        }        
    }
}