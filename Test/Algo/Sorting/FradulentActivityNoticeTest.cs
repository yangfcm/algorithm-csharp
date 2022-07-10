using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Sorting;

namespace Test.Algo.Sorting
{
  [TestClass]
  public class FradulentActivityNoticeTest
  {
    [TestMethod]
    [DataRow(new int[] { 2, 3, 4, 2, 3, 6, 8, 4, 5 }, 5 , 2)]
    [DataRow(new int[] { 1, 2, 3, 4, 4 }, 4 , 0)]
    [DataRow(new int[] { 10, 20, 30, 40, 50 }, 3 , 1)]
    public void TestSolution(int[] expenditure, int d, int expectedCount)
    {
      Assert.AreEqual(expectedCount, FradulentActivityNotice.Solution(expenditure, d));
    }
  }
}