using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Dynamic;
using System;

namespace Test.Algo.Dynamic
{
  [TestClass]
  public class HowSumTest
  {

    [TestMethod]
    [DataRow(7, new int[] { 2, 3 }, new int[] { 3, 2, 2 })]
    [DataRow(7, new int[] { 5, 3, 4, 7 }, new int[] { 4, 3 })]
    [DataRow(8, new int[] { 2, 3, 5 }, new int[] { 2, 2, 2, 2 })]
    [DataRow(7, new int[] { 2, 4 }, null)]
    public void TestSolutions(int target, int[] numbers, int[] expected)
    {
      var actual1 = HowSum.Solution1(target, numbers)?.ToArray();
      var actual2 = HowSum.Solution2(target, numbers)?.ToArray();
      var actual3 = HowSum.Solution3(target, numbers)?.ToArray();
      CollectionAssert.AreEqual(actual1, expected);
      CollectionAssert.AreEqual(actual2, expected);
      CollectionAssert.AreEqual(actual3, expected);
    }

    [TestMethod]
    [DataRow(300, new int[] { 7, 14 }, null)]
    [DataRow(300, new int[] { 286, 14 }, new int[] { 14, 286 })]
    public void TestSolutionsWithBigNumber(int target, int[] numbers, int[] expected)
    {
      var actual2 = HowSum.Solution2(target, numbers)?.ToArray();
      var actual3 = HowSum.Solution3(target, numbers)?.ToArray();
      if (actual2 != null)
      {
        Array.Sort(actual2);
      }
      if (actual3 != null)
      {
        Array.Sort(actual3);
      }
      CollectionAssert.AreEqual(actual2, expected);
      CollectionAssert.AreEqual(actual3, expected);
    }
  }
}