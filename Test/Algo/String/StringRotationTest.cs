using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.String;

namespace Test.Algo.String
{
  [TestClass]
  public class StringRotationTest
  {
    [TestMethod]
    [DataRow("waterbottle", "erbottlewat")]
    [DataRow("abcdefg", "defgabc")]
    public void TestStringRotationTrue(string str1, string str2)
    {
      bool testResult = CheckStringRotation.Run(str1, str2);
      Assert.IsTrue(testResult);
    }

    [TestMethod]
    [DataRow("waterbottle", "erbotllewat")]
    [DataRow("waterbottlee", "erbottlewat")]
    [DataRow("waterbottle", "")]
    public void TestStringRotationFalse(string str1, string str2)
    {
      bool testResult = CheckStringRotation.Run(str1, str2);
      Assert.IsFalse(testResult);
    }
  }
}