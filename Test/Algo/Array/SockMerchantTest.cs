using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Arr;

namespace Test.Algo.Arr
{
  [TestClass]
  public class SockMerchantTest
  {
    [TestMethod]
    [DataRow(new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, 3)]
    [DataRow(new int[] { 1, 2, 1, 2, 1, 3, 2 }, 2)]
    [DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 0)]
    public void TestSockMerchant(int[] arr, int expected)
    {
      Assert.AreEqual(SockMerchant.Run(arr), expected);
    }
  }
}