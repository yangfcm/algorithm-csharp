using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Searching;

namespace Test.Algo.Searching
{
  [TestClass]
  public class ExponentialSearchTest
  {
    readonly int[] testArr = new int[] { 10, 12, 13, 16, 18, 19, 20, 21, 22, 23, 24, 33, 35, 42, 47 };

    [TestMethod]
    public void TestSearchFound()
    {
      Assert.AreEqual(ExponentialSearch.Run(testArr, 10), 0);
      Assert.AreEqual(ExponentialSearch.Run(testArr, 16), 3);
      Assert.AreEqual(ExponentialSearch.Run(testArr, 23), 9);
      Assert.AreEqual(ExponentialSearch.Run(testArr, 42), 13);
      Assert.AreEqual(ExponentialSearch.Run(testArr, 47), 14);
    }

    [TestMethod]
    public void TestSearchNotFound()
    {
      Assert.AreEqual(ExponentialSearch.Run(testArr, 0), -1);
      Assert.AreEqual(ExponentialSearch.Run(testArr, 34), -1);
      Assert.AreEqual(ExponentialSearch.Run(testArr, 99), -1);
    }
  }
}