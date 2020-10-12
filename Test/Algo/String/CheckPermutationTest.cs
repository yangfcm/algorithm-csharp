using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.String;

namespace Test.Algo.String
{
  [TestClass]
  public class CheckPermutationTest
  {
    [TestMethod]
    [DataRow("abcdefg", "dgfebca")]
    [DataRow("abcdabcd", "ccaabbdd")]
    public void CheckPermutationAsTrue(string str1, string str2)
    {
      bool checkResult = CheckPermutation.Run(str1, str2);
      Assert.IsTrue(checkResult, $"{str1} should be permutation of {str2}");
    }

    [TestMethod]
    [DataRow("abcdefg", "dgfebcac")]
    [DataRow("aabbcc", "bbccdd")]
    public void CheckPermutationAsFalse(string str1, string str2)
    {
      bool checkResult = CheckPermutation.Run(str1, str2);
      Assert.IsFalse(checkResult, $"{str1} should NOT be permutation of {str2}");
    }
  }
}