using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.String;

namespace Test.Algo.String
{
  [TestClass]
  public class MakeAnagramsTest
  {
    [TestMethod]
    [DataRow("cde", "abc", 4)]
    [DataRow("showman", "woman", 2)]
    [DataRow("fcrxzwscanmligyxyvym", "jxwtrhvujlmrpdoqbisbwhmgpmeoke", 30)]
    public void TestMakeAnagrams(string str1, string str2, int expected)
    {
      var actual = MakeAnagrams.Solution(str1, str2);
      Assert.AreEqual(actual, expected);
    }
  }
}