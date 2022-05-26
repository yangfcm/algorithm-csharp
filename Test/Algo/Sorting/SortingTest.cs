using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Sorting;

namespace Test.Algo.Sorting
{
  [TestClass]
  public class SortingTest
  {
    [TestMethod]
    [DataRow(
      new int[] { 100, -40, 500, -124, 0, 21, 7 },
      new int[] { -124, -40, 0, 7, 21, 100, 500 }
    )]
    public void TestBubble(int[] arr, int[] expectedSortedArr)
    {
      var sortedArr = Sort.Bubble(arr);
      CollectionAssert.AreEqual(sortedArr, expectedSortedArr);
    }

    [TestMethod]
    [DataRow(
      new int[] { 100, -40, 500, -124, 0, 21, 7 },
      new int[] { -124, -40, 0, 7, 21, 100, 500 }
    )]
    public void TestSelection(int[] arr, int[] expectedSortedArr)
    {
      var sortedArr = Sort.Selection(arr);
      CollectionAssert.AreEqual(sortedArr, expectedSortedArr);
    }

    [TestMethod]
    [DataRow(
      new int[] { 100, -40, 500, -124, 0, 21, 7 },
      new int[] { -124, -40, 0, 7, 21, 100, 500 }
    )]
    public void TestMerge(int[] arr, int[] expectedSortedArr)
    {
      var sortedArr = Sort.Merge(arr);
      CollectionAssert.AreEqual(sortedArr, expectedSortedArr);
    }
  }
}