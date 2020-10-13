using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.String;

namespace Test.Algo.String
{
  [TestClass]
  public class PalindromePermutationTest
  {
    [TestMethod]
    [DataRow("Tact coa")]
    [DataRow("aaaabbbbbbccdde")]
    public void TestPalindromePermutationTrue(string str)
    {
      bool testResult = CheckPalindromePermutation.Run(str);
      Assert.IsTrue(testResult);
    }

    [TestMethod]
    [DataRow("Tact coaa")]
    [DataRow("abcdabcdcd")]
    public void TestPalindromePermutationFasle(string str)
    {
      bool testResult = CheckPalindromePermutation.Run(str);
      Assert.IsFalse(testResult);
    }
  }
}