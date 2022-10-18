using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Dynamic;


namespace Test.Algo.Dynamic
{
  [TestClass]
  public class CommonChildTest
  {
    [TestMethod]
    [DataRow("AA", "BB", 0)]
    [DataRow("HARRY", "SALLY", 2)]
    [DataRow("SHINCHAN", "NOHARAAA", 3)]
    [DataRow("OUDFRMYMAW", "AWHYFCCMQX", 2)]
    [DataRow("WEWOUCUIDGCGTRMEZEPXZFEJWISRSBBSYXAYDFEJJDLEBVHHKS", "FDAGCXGKCTKWNECHMRXZWMLRYUCOCZHJRRJBOAJOQJZZVUYXIC", 15)]
    public void TestSolution(string s1, string s2, int expected) 
    {
      Assert.AreEqual(expected, CommonChild.Solution(s1, s2));
    }
  }
}