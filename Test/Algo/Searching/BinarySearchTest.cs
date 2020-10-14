using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Searching;

namespace Test.Algo.Searching
{
  [TestClass]
  public class BinarySearchTest
  {
    int[] testArr = new int[] { -5, -1, 0, 2, 12, 23, 38, 72, 91, 1001 };

    [TestMethod]
    public void TestSearchFound()
    {
      Assert.AreEqual(BinarySearch.Run(testArr, -5), 0);
      Assert.AreEqual(BinarySearch.Run(testArr, 1001), testArr.Length - 1);
      Assert.AreEqual(BinarySearch.Run(testArr, 12), 4);
      Assert.AreEqual(BinarySearch.Run(testArr, 72), 7);
    }

    [TestMethod]
    public void TestSearchNotFound()
    {
      Assert.AreEqual(BinarySearch.Run(testArr, 100), -1);
    }
  }
}