using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.String;

namespace Test.Algo.String
{
  [TestClass]
  public class IsBalancedTest
  {
    [TestMethod]
    [DataRow("{abc} {def}")]
    [DataRow("{abc {def}}")]
    [DataRow("{ {abc} {d {ef}} }")]
    public void TestIsBalancedTrue(string str)
    {
      var isBalanced = IsBalanced.Run(str);
      Assert.IsTrue(isBalanced, $"{str} should be balanced");
    }

    [TestMethod]
    [DataRow("}{")]
    [DataRow("{abc {{def}}")]
    public void TestIsBalancedFalse(string str)
    {
      var isBalanced = IsBalanced.Run(str);
      Assert.IsFalse(isBalanced, $"{str} should NOT be balanced");
    }
  }
}