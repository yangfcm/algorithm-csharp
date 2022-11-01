using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Arr;

namespace Test.Algo.Arr
{
    [TestClass]
    public class MaxSubArraySumTest
    {
        [TestMethod]
        [DataRow(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        [DataRow(new int[] { 5, 4, -1, 7, 8 }, 23)]
        [DataRow(new int[] { 38, -9, 23, -13, 9, 5, 12, -8, 90, -32, 53, -85, 34, 59, -12, -93 }, 176)]
        [DataRow(new int[] { -9, -3, 5, -10, 3 }, 5)]
        public void TestSolution1(int[] arr, int expected)
        {
            Assert.AreEqual(expected, MaxSubArraySum.Solution1(arr));
            Assert.AreEqual(expected, MaxSubArraySum.Solution2(arr));
            Assert.AreEqual(expected, MaxSubArraySum.Solution3(arr));
        }
    }
}
