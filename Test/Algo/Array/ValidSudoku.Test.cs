using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Arr;

namespace Test
{
  [TestClass]
  public class ValidSudokuTest
  {
    [TestMethod]
    public void TestValid()
    {
      var validSudoku = new string[,] {
      {"5", "3", ".", ".", "7", ".", ".", ".", "."},
      {"6", ".", ".", "1", "9", "5", ".", ".", "."},
      {".", "9", "8", ".", ".", ".", ".", "6", "."},
      {"8", ".", ".", ".", "6", ".", ".", ".", "3"},
      {"4", ".", ".", "8", ".", "3", ".", ".", "1"},
      {"7", ".", ".", ".", "2", ".", ".", ".", "6"},
      {".", "6", ".", ".", ".", ".", "2", "8", "."},
      {".", ".", ".", "4", "1", "9", ".", ".", "5"},
      {".", ".", ".", ".", "8", ".", ".", "7", "9"}
    };
      Assert.IsTrue(ValidSudoku.Run(validSudoku));
    }

    [TestMethod]
    public void TestInvalid()
    {
      var invalidSudoku1 = new string[,] {
      {"5", "3", ".", ".", "7", ".", ".", ".", "."},
      {"6", ".", ".", "1", "9", "5", ".", ".", "."},
      {".", "9", "8", ".", ".", ".", ".", "6", "."},
      {"8", ".", ".", ".", "6", ".", ".", ".", "3"},
      {"4", ".", ".", "8", ".", "3", ".", ".", "1"},
      {"7", ".", ".", ".", "9", ".", ".", ".", "6"},
      {".", "6", ".", ".", ".", ".", "2", "8", "."},
      {".", ".", ".", "4", "1", "9", ".", ".", "5"},
      {".", ".", ".", ".", "8", ".", ".", "7", "9"}
    };
      var invalidSudoku2 = new string[,] {
      {"5", "3", ".", ".", "7", ".", ".", ".", "."},
      {"6", ".", ".", "1", "9", "5", ".", ".", "."},
      {".", "9", "8", ".", ".", ".", ".", "6", "."},
      {"8", ".", ".", ".", "6", ".", ".", ".", "3"},
      {"4", ".", ".", "8", ".", "3", ".", ".", "1"},
      {"7", ".", ".", ".", "2", ".", ".", ".", "6"},
      {".", "6", ".", ".", ".", ".", "2", "8", "."},
      {".", ".", ".", "4", "1", "9", ".", ".", "5"},
      {".", ".", ".", ".", "8", ".", ".", "2", "9"}
    };
      Assert.IsFalse(ValidSudoku.Run(invalidSudoku1));
      Assert.IsFalse(ValidSudoku.Run(invalidSudoku2));
    }

  }
}