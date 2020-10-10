using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Arr;

namespace Test.Algo.Arr
{
  [TestClass]
  public class RotateImageTest
  {
    [TestMethod]
    public void TestCase1()
    {
      int[,] result = RotateImage.Run(new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
      int[,] expectedResult = new int[3, 3] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } };
      CollectionAssert.AreEqual(result, expectedResult);
    }

    [TestMethod]
    public void TestCase2()
    {
      int[,] result = RotateImage.Run(new int[4, 4] { { 5, 1, 9, 11 }, { 2, 4, 8, 10 }, { 13, 3, 6, 7 }, { 15, 14, 12, 16 } });
      int[,] expectedResult = new int[4, 4] { { 15, 13, 2, 5 }, { 14, 3, 4, 1 }, { 12, 6, 8, 9 }, { 16, 7, 10, 11 } };
      CollectionAssert.AreEqual(result, expectedResult);
    }

    [TestMethod]
    public void TestCase3()
    {
      int[,] result = RotateImage.Run(new int[5, 5] { { 5, 1, 9, 11, 58 }, { 2, 4, 8, 10, 32 }, { 13, 3, 6, 7, 77 }, { 15, 14, 12, 16, 99 }, { 0, 1, 5, 7, 9 } });
      int[,] expectedResult = new int[5, 5] { { 0, 15, 13, 2, 5 }, { 1, 14, 3, 4, 1 }, { 5, 12, 6, 8, 9 }, { 7, 16, 7, 10, 11 }, { 9, 99, 77, 32, 58 } };
      CollectionAssert.AreEqual(result, expectedResult);
    }
  }
}