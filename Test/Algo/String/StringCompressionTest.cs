using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.String;

namespace Test.Algo.String
{
  [TestClass]
  public class StringCompressionTest
  {
    [TestMethod]
    [DataRow("aaaaaaaaaaaa", "a12")]
    [DataRow("xxxxxxyyyxxzzzyz", "x6y3x2z3y1z1")]
    [DataRow("aabcccccaaa", "a2b1c5a3")]
    public void TestStringCompression(string str, string compressedStr)
    {
      string expected = StringCompression.Run(str);
      Assert.AreEqual(expected, compressedStr);
    }
  }
}