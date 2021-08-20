using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Dynamic;

namespace Test.Algo.Dynamic
{
  [TestClass]
  public class GridTravelerTest
  {
    [TestMethod]
    [DataRow(1, 1, 1)]
    [DataRow(2, 3, 3)]
    [DataRow(3, 2, 3)]
    [DataRow(3, 3, 6)]
    [DataRow(12, 13, 1352078)]
    public void TestSolutions(int m, int n, long expected)
    {
      long actual1 = GridTraveler.Solution1(m, n);
      long actual2 = GridTraveler.Solution2(m, n);
      long actual3 = GridTraveler.Solution3(m, n);
      Assert.AreEqual(actual1, expected);
      Assert.AreEqual(actual2, expected);
      Assert.AreEqual(actual3, expected);
    }

    [TestMethod]
    [DataRow(18, 18, 2333606220)]
    public void TestSolutionsWithBigNumber(int m, int n, long expected)
    {
      long actual2 = GridTraveler.Solution2(m, n);
      long actual3 = GridTraveler.Solution3(m, n);
      Assert.AreEqual(actual2, expected);
      Assert.AreEqual(actual3, expected);
    }
  }
}