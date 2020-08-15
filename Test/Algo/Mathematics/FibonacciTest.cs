using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Mathematics;
namespace Test
{
  [TestClass]
  public class FibonacciTest
  {

    [TestMethod]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 2)]
    [DataRow(4, 3)]
    [DataRow(39, 63245986)]
    public void TestFibonacciAllSolutions(int n, int output)
    {
      var result1 = Fibonacci.RunSolution1(n);
      var result2 = Fibonacci.RunSolution2(n);
      var result3 = Fibonacci.RunSolution3(n);
      Assert.AreEqual(result1, output);
      Assert.AreEqual(result2, output);
      Assert.AreEqual(result3, output);
    }

  }
}