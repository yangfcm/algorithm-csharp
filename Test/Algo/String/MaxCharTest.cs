using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.String;

namespace Test.Algo.String
{
  [TestClass]
  public class MaxCharTest
  {
    [TestMethod]
    [DataRow("abcccccdd", 'c')]
    [DataRow("hello", 'l')]
    public void TestMaxChar(string str, char maxChar)
    {
      var max = MaxChar.Run(str);
      Assert.AreEqual(max, maxChar);
    }
  }
}