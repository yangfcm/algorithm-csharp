using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Greedy;

namespace Test.Algo.Greedy
{
    [TestClass]
    public class LuckBalanceTest
    {

        [TestMethod]
        public void TestSolutionCase1()
        {
            var contests = new int[][] {
                new int[] {5,1}, new int[] {2,1}, new int[] {1,1}, new int[] {8,1}, new int[] {10,0}, new int[] {5,0}
            };
            Assert.AreEqual(29, LuckBalance.Solution(3, contests));
        }

        [TestMethod]
        public void TestSolutionCase2()
        {
            var contests = new int[][] {
                new int[] {13,1}, new int[] {10,1}, new int[] {9,1}, new int[] {8,1}, new int[] {13,1}, new int[] {12,1}, new int[] {18,1}, new int[] {13,1}
            };
            Assert.AreEqual(42, LuckBalance.Solution(5, contests));
        }

        [TestMethod]
        public void TestSolutionCase3()
        {
            var contests = new int[][] {
                new int[] {5,1}, new int[] {4,0}, new int[] {6,1}, new int[] {2,1}, new int[] {8,0}
            };
            Assert.AreEqual(21, LuckBalance.Solution(2, contests));
        }
    }
}