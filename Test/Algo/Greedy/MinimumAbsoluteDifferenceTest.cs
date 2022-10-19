using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Greedy;

namespace Test.Algo.Greedy
{
    [TestClass]
    public class MinimumAbsoluteDifferenceTest
    {
        [TestMethod]
        [DataRow(new int[]{3, -7 ,0}, 3)]
        [DataRow(new int[]{-59, -36, -13, 1, -53, -92, -2, -96, -54, 75}, 1)]
        [DataRow(new int[]{1, -3, 71, 68, 17}, 3)]
        public void TestSolution(int[] arr, int expected)
        {
            Assert.AreEqual(expected, MinimumAbsoluteDifference.Solution(arr));
        }
    }
}