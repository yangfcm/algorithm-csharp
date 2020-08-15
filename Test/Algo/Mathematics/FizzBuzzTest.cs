using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Algo.Mathematics;

namespace Test
{
  [TestClass]
  public class FizzBuzzTest
  {
    private StringWriter sw;
    private const string ExpectedOutputWith5 =
@"1
2
fizz
4
buzz";
    private const string ExpectedOutputWith15 =
@"1
2
fizz
4
buzz
fizz
7
8
fizz
buzz
11
fizz
13
14
fizzbuzz";

    [TestInitialize]
    public void Setup()
    {
      this.sw = new StringWriter();
      Console.SetOut(this.sw);
    }

    [TestMethod]
    [DataRow(5, ExpectedOutputWith5)]
    [DataRow(15, ExpectedOutputWith15)]
    public void TestFizzBuzz(int n, string expectedOutput)
    {
      FizzBuzz.Run(n);
      var result = this.sw.ToString().Trim();
      Assert.AreEqual(result, expectedOutput);

    }
  }
}
