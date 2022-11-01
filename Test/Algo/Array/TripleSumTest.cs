using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Arr;

namespace Test.Algo.Arr
{
  [TestClass]
  public class TripleSumTest
  {
    [TestMethod]
    [DataRow(new int[]{1, 3, 5}, new int[]{2, 3}, new int[]{1, 2, 3}, 8)]
    [DataRow(new int[]{1, 4, 5}, new int[]{2, 3, 3}, new int[]{1, 2, 3}, 5)]
    [DataRow(new int[]{1, 5, 7, 3}, new int[]{5, 9, 7}, new int[]{13, 11 ,9, 7}, 12)]
    public void TestSolution(int[] a, int[] b, int[] c, int expected)
    {
      Assert.AreEqual(expected, TripleSum.Solution(a, b, c));
    }
  }
}