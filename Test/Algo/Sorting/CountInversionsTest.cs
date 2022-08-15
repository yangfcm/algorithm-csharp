using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Sorting;

namespace Test.Algo.Sorting
{
  [TestClass]
  public class CountInversionsTest
  {
    [TestMethod]
    [DataRow(new int[] { 1, 1, 1, 2, 2, 3, 4, 4, 5 }, 0)]
    [DataRow(new int[] { 2, 1, 3, 1, 2 }, 4)]
    [DataRow(new int[] { 5, 4, 4, 3, 2, 2, 1, 0 }, 26)]
    public void TestSolution1(int[] arr, int expectedCount)
    {
      Assert.AreEqual(expectedCount, CountInversions.Solution1(arr));
    }
  }
}