using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.String;

namespace Test.Algo.String
{
  [TestClass]
  public class IsUniqueTest
  {
    [TestMethod]
    [DataRow("abcdefg")]
    [DataRow("AaBbCc")]
    [DataRow("holiday")]
    [DataRow("澳大利亚")]
    public void TestIsUniqueTrue(string str)
    {
      bool testResult = IsUnique.Run(str);
      Assert.IsTrue(testResult);
    }

    [TestMethod]
    [DataRow("abcda")]
    [DataRow("mississippi")]
    [DataRow("密西西比")]
    public void TestIsUniqueFalse(string str)
    {
      bool testResult = IsUnique.Run(str);
      Assert.IsFalse(testResult);
    }
  }
}