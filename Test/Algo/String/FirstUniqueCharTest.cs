using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.String;

namespace Test.Algo.String;

[TestClass]
public class FirstUniqueCharTest
{
  [TestMethod]
  [DataRow("leetcode", 0)]
  [DataRow("loveleetcode", 2)]
  [DataRow("aabbccc", -1)]
  public void TestFirstUniqueChar(string str, int expected)
  {
    int firstUniqueCharIndex = FirstUniqueChar.Solution(str);
    Assert.AreEqual(firstUniqueCharIndex, expected);
  }
}