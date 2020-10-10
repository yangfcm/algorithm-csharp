using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Arr;

namespace Test.Algo.Arr
{
  [TestClass]
  public class IsSortedTest
  {
    [TestMethod]
    [DataRow(new int[] { 1, 2, 5, 7, 12, 100 })]
    public void TestIsSortedTrue(int[] array)
    {
      var isSorted = IsSorted.Run(array);
      Assert.IsTrue(isSorted, "Array should be a sorted array");
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 5, 0, 12, 100 })]
    public void TestIsSortedFalse(int[] array)
    {
      var isSorted = IsSorted.Run(array);
      Assert.IsFalse(isSorted, "Array should NOT be a sorted array");
    }
  }
}