using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Arr;

namespace Test.Algo.Arr
{
  [TestClass]
  public class MovingZeroesTest
  {
    [TestMethod]
    [DataRow(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
    [DataRow(new int[] { -5, 0, 0, 3, 0, 0, 0, 0 }, new int[] { -5, 3, 0, 0, 0, 0, 0, 0 })]
    public void TestMovingZeroes(int[] nums, int[] expectedResult)
    {
      int[] result = MovingZeroes.Run(nums);
      CollectionAssert.AreEqual(result, expectedResult);
    }
  }
}