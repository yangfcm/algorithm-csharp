using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Assorted;

namespace Test.Algo.Assorted
{
    [TestClass]
    public class MinTimeTest
    {
        [TestMethod]
        [DataRow(new int[]{ 2, 2 }, 2, 2)]
        [DataRow(new int[]{ 2, 3 }, 5, 6)]
        [DataRow(new int[]{ 1, 3, 4 }, 10, 7)]
        [DataRow(new int[]{ 4, 5, 6 }, 12, 20)]
        public void Test(int[] machines, int goal, int expected)
        {
            Assert.AreEqual(expected, MinTime.Solution(machines, goal));
        }
    }
}