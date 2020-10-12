using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.String;

namespace Test.Algo.String
{
  [TestClass]
  public class AnagramsTest
  {
    [TestMethod]
    [DataRow("abcde", "debca")]
    [DataRow("HELLO", "llohe")]
    [DataRow("Whoa!    Hi!", "hi!whoa!")]
    public void TestAnagramsReturnTrue(string str1, string str2)
    {
      var result = Anagrams.Main(str1, str2);
      Assert.IsTrue(result, $"{str1} should be an anagram of {str2}");
    }

    [TestMethod]
    [DataRow("One One", "Two Two")]
    public void TestAnagramsReturnFalse(string str1, string str2)
    {
      var result = Anagrams.Main(str1, str2);
      Assert.IsFalse(result, $"{str1} should NOT be an anagram of {str2}");
    }
  }
}
