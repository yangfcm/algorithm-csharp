using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.String;

namespace Test.Algo.String;

[TestClass]
public class DefangingIPTest
{
  [TestMethod]
  [DataRow("1.1.1.1", "1[.]1[.]1[.]1")]
  [DataRow("255.100.50.0", "255[.]100[.]50[.]0")]
  public void TestDefangingIP(string ipAddress, string expected)
  {
    string defangedIP = DefangingIP.Solution(ipAddress);
    Assert.AreEqual(expected, defangedIP);
  }
}