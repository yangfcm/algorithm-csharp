using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Arr;

namespace Test.Algo.Arr
{
  [TestClass]
  public class PlusOneTest
  {
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
    [DataRow(new int[] { 1, 9, 9, 9 }, new int[] { 2, 0, 0, 0 })]
    [DataRow(new int[] { 9, 9 }, new int[] { 1, 0, 0 })]
    [DataRow(new int[] { 2, 3, 0, 5, 4, 9, 3, 6, 1, 2, 2, 9 }, new int[] { 2, 3, 0, 5, 4, 9, 3, 6, 1, 2, 3, 0 })]
    public void Test(int[] digits, int[] expectedResult)
    {
      int[] result = PlusOne.Run(digits);
      CollectionAssert.AreEqual(result, expectedResult);
    }
  }
}