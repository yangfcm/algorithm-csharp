using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.StackQueue;

namespace Test.Ds.StackQueue
{
    [TestClass]
    public class LargestRectangleTest
    {
        [TestMethod]
        [DataRow(new int[]{1, 2, 3, 4, 5}, 9)]
        [DataRow(new int[]{2, 1, 5, 6, 2, 3}, 10)]
        [DataRow(new int[]{11, 11, 10, 10, 10}, 50)]
        [DataRow(new int[]{1, 3, 5, 9, 11}, 18)]
        public void TestLargestRectangleSolution(int[] heights, int expected)
        {
            Assert.AreEqual(expected, LargestRectangle.Solution(heights));
        }
    }
}