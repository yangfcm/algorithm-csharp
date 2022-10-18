using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Searching;

namespace Test.Algo.Searching
{
  [TestClass]
  public class JumpSearchTest
  {
    readonly int[] testArr = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 };
    [TestMethod]
    public void TestSearchFound()
    {
      Assert.AreEqual(JumpSearch.Run(testArr, 0), 0);
      Assert.AreEqual(JumpSearch.Run(testArr, 1), 1);
      Assert.AreEqual(JumpSearch.Run(testArr, 55), 10);
      Assert.AreEqual(JumpSearch.Run(testArr, 610), 15);
    }

    [TestMethod]
    public void TestSearchNotFound()
    {
      Assert.AreEqual(JumpSearch.Run(testArr, 9), -1);
      Assert.AreEqual(JumpSearch.Run(testArr, -5), -1);
      Assert.AreEqual(JumpSearch.Run(testArr, 1000), -1);
    }
  }
}