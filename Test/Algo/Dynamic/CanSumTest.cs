using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Dynamic;

namespace Test.Algo.Dynamic
{
  [TestClass]
  public class CanSumTest
  {
    [TestMethod]
    [DataRow(7, new int[] { 2, 3 }, true)]
    [DataRow(7, new int[] { 5, 3, 4, 7 }, true)]
    [DataRow(7, new int[] { 2, 4 }, false)]
    [DataRow(8, new int[] { 2, 3, 5 }, true)]
    public void TestSolutions(int target, int[] numbers, bool expected)
    {
      bool actual1 = CanSum.Solution1(target, numbers);
      bool actual2 = CanSum.Solution2(target, numbers);
      bool actual3 = CanSum.Solution3(target, numbers);
      Assert.AreEqual(actual1, expected);
      Assert.AreEqual(actual2, expected);
      Assert.AreEqual(actual3, expected);
    }

    [DataRow(300, new int[] { 7, 14 }, false)]
    [DataRow(300, new int[] { 6, 14 }, true)]
    public static void TestSolutionsWithBigNumber(int target, int[] numbers, bool expected)
    {
      bool actual2 = CanSum.Solution2(target, numbers);
      bool actual3 = CanSum.Solution3(target, numbers);
      Assert.AreEqual(actual2, expected);
      Assert.AreEqual(actual3, expected);
    }

  }
}