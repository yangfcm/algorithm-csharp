using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.String;

namespace Test
{
  [TestClass]
  public class ReverseStrTest
  {
    [TestMethod]
    [DataRow("abcde", "edcba")]
    [DataRow("bye", "eyb")]
    public void TestReverseStr(string str, string expectedReverseStr)
    {
      var reverseStr = ReverseStr.Run(str);
      Assert.AreEqual(reverseStr, expectedReverseStr);
    }

  }
}