using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Sorting;

namespace Test.Algo.Sorting
{
  [TestClass]
  public class CountingSortTest
  {
    [TestMethod]
    [DataRow(
      new int[] {4, 20, 1, 1, 12, 6, 24, 12, 8, 9},
      new int[] {1, 1, 4, 6, 8, 9, 12, 12, 20, 24}
    )]
    public void TestCountSort(int[] arr, int[] expectedSortedArr)
    {
      var sortedArr = CountingSort.Sort(arr);
      CollectionAssert.AreEqual(sortedArr, expectedSortedArr);
    }
  }
}