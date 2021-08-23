using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Dynamic;
using System;
using System.Linq;

namespace Test.Algo.Dynamic
{
  [TestClass]
  public class BestSumTest
  {
    [TestMethod]
    [DataRow(7, new int[] { 2, 3 }, new int[] { 2, 2, 3 })]
    [DataRow(7, new int[] { 5, 3, 4, 7 }, new int[] { 7 })]
    [DataRow(8, new int[] { 2, 3, 5 }, new int[] { 3, 5 })]
    public void TestSolutions_ShortestCombinationReturned(int target, int[] numbers, int[] expected)
    {
      var actual1 = BestSum.Solution1(target, numbers).ToArray();
      var actual2 = BestSum.Solution2(target, numbers).ToArray();
      var actual3 = BestSum.Solution3(target, numbers).ToArray();
      Array.Sort(actual1);
      Array.Sort(actual2);
      Array.Sort(actual3);
      CollectionAssert.AreEqual(actual1, expected);
      CollectionAssert.AreEqual(actual2, expected); 
      CollectionAssert.AreEqual(actual3, expected);
    }

    [DataRow(100, new int[] { 2, 4, 5, 10, 25, 49, 51 }, new int[] { 49, 51 })]
    public static void TestSolutions_WithBigNumber_ShortestCombinationReturned(int target, int[] numbers, int[] expected) 
    {

      var actual2 = BestSum.Solution2(target, numbers).ToArray();
      var actual3 = BestSum.Solution3(target, numbers).ToArray(); 
      Array.Sort(actual2);
      Array.Sort(actual3); 
      CollectionAssert.AreEqual(actual2, expected); 
      CollectionAssert.AreEqual(actual3, expected);
    }
  }
}