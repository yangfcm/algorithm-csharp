using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Searching;

namespace Test.Algo.Searching
{
  [TestClass]
  public class LinearSearchTest
  {
    int[] testArr = new int[] { 10, 20, 80, 30, 60, 50, 11, 100, 130, 170 };
    [TestMethod]
    public void TestSearchFound()
    {
      Assert.AreEqual(LinearSearch.Run(testArr, 10), 0);
      Assert.AreEqual(LinearSearch.Run(testArr, 170), testArr.Length - 1);
      Assert.AreEqual(LinearSearch.Run(testArr, 30), 3);
    }

    [TestMethod]
    public void TestSearchNotFound()
    {
      Assert.AreEqual(LinearSearch.Run(testArr, 55), -1);
    }
  }
}