using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Dynamic;

namespace Test
{
  [TestClass]
  public class MaxProfitTest
  {
    [TestMethod]
    [DataRow(new int[] { 7, 1, 5, 3, 4, 6, 4 }, 7)]
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, 4)]
    [DataRow(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void Test(int[] prices, int expectedProfit)
    {
      int profit = MaxProfit.Run(prices);
      Assert.AreEqual(profit, expectedProfit);
    }
  }
}