using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Arr;

namespace Test
{
  [TestClass]
  public class RotateArrayTest
  {
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
    [DataRow(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
    public void Test(int[] nums, int k, int[] expectedResult)
    {
      int[] result = RotateArray.Run(nums, k);
      CollectionAssert.AreEqual(result, expectedResult);
    }
  }
}