using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Arr;

namespace Test
{
  [TestClass]
  public class MissingTest
  {
    [TestMethod]
    [DataRow(new int[] { 1, 4, 3, 5, 6 }, 2)]
    [DataRow(new int[] { 2, 5, 4, 3, 1 }, null)]
    [DataRow(new int[] { }, null)]
    public void TestMissing(int[] array, int? expectedMissing)
    {
      int? missing1 = Missing.RunSolution1(array);
      int? missing2 = Missing.RunSolution2(array);
      Assert.AreEqual(expectedMissing, missing1);
      Assert.AreEqual(expectedMissing, missing2);
    }
  }
}