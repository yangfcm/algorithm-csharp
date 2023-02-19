using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Assorted;
using System;
using System.IO;

namespace Test.Algo.Assorted
{
  [TestClass]
  public class PyramidTest
  {
    private StringWriter sw;
    private const string ExpectedOutputWith2 = " # \n###\n";
    private const string ExpectedOutputWith3 = "  #  \n ### \n#####\n";
    private const string ExpectedOutputWith4 = "   #   \n  ###  \n ##### \n#######\n";

    [TestInitialize]
    public void Setup()
    {
      this.sw = new StringWriter();
      Console.SetOut(this.sw);
    }

    [TestMethod]
    [DataRow(2, ExpectedOutputWith2)]
    [DataRow(3, ExpectedOutputWith3)]
    [DataRow(4, ExpectedOutputWith4)]
    public void TestPyramid(int n, string expectedOutput)
    {
      Pyramid.Run(n);
      var result = this.sw.ToString();
      Assert.AreEqual(result, expectedOutput);
    }

  }
}