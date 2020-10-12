using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.String;

namespace Test.Algo.String
{
  [TestClass]
  public class OneAwayTest
  {
    [TestMethod]
    [DataRow("pale", "pales")]
    [DataRow("pale", "pal")]
    [DataRow("pale", "bale")]
    [DataRow("pales", "pals")]
    [DataRow("pales", "pales")]
    public void TestOneAwayTrue(string str1, string str2)
    {
      bool testResult = OneAway.Run(str1, str2);
      Assert.IsTrue(testResult);
    }

    [TestMethod]
    [DataRow("pale", "bake")]
    [DataRow("johnson", "john")]
    [DataRow("pale", "pad")]
    public void TestOneAwayFalse(string str1, string str2)
    {
      bool testResult = OneAway.Run(str1, str2);
      Assert.IsFalse(testResult);
    }
  }
}