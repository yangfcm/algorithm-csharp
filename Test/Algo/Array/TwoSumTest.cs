using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Arr;

namespace Test.Algo.Arr
{

  [TestClass]
  public class TwoSumTest
  {
    [TestMethod]
    [DataRow(
      new int[] { 2, 7, 11, 15, 99 },
      110,
      new int[] { 2, 4 }
    )]
    public void TestSolution1(int[] nums, int target, int[] expectedResult)
    {
      var result = TwoSum.RunSolution1(nums, target);
      CollectionAssert.AreEqual(result, expectedResult);
    }

    [TestMethod]
    [DataRow(
      new int[] { 2, 7, 11, 15, 99 },
      110,
      new int[] { 2, 4 }
    )]
    public void TestSolution2(int[] nums, int target, int[] expectedResult)
    {
      var result = TwoSum.RunSolution2(nums, target);
      CollectionAssert.AreEqual(result, expectedResult);
    }
  }
}