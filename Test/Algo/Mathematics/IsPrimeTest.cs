using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Mathematics;

namespace Test
{
  [TestClass]
  public class IsPrimeTest
  {
    [TestMethod]
    [DataRow(2)]
    [DataRow(3)]
    [DataRow(17)]
    public void TestIsPrimeReturnTrue(int num)
    {
      var isPrimeResult = IsPrime.Run(num);
      Assert.IsTrue(isPrimeResult, $"{num} should be a prime");
    }

    [TestMethod]
    [DataRow(0)]
    [DataRow(1)]
    [DataRow(4)]
    [DataRow(33)]
    [DataRow(10000)]
    public void TestIsPrimeReturnFalse(int num)
    {
      var isPrimeResult = IsPrime.Run(num);
      Assert.IsFalse(isPrimeResult, $"{num} should NOT be a prime");
    }
  }
}
