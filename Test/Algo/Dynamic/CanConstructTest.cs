using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Dynamic;
using System;
using System.Collections.Generic;

namespace Test.Algo.Dynamic
{ 
  [TestClass]
  public class CanConstructTest
  {
    private readonly string[] strs1 =  new string[]{ "ab", "abc", "cd", "def", "abcd"};
    private readonly string target1 = "abcdef";

    private readonly string[] strs2 = new string[]{"bo", "rd", "ate", "t", "ska", "sk", "boar"};
    private readonly string target2 = "skateboard";

    private readonly string[] strs3 = new string[]{
      "e",
      "ee",
      "eee",
      "eeee",
      "eeeee",
      "eeeeee",
    };
    private readonly string target3 = "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef";

    [TestMethod]  
    public void TestSolutions_ReturnTrueOnCanConstruct(){ 
      var actual1 = CanConstruct.Solution1(target1, strs1);
      var actual2 = CanConstruct.Solution2(target1, strs1);
      var actual3 = CanConstruct.Solution3(target1, strs1);

      Assert.IsTrue(actual1);
      Assert.IsTrue(actual2);
      Assert.IsTrue(actual3);
    }

    [TestMethod]
    public void TestSolutions_ReturnFalseOnCannotConstruct() {
      var actual1 = CanConstruct.Solution1(target2, strs2);
      var actual2 = CanConstruct.Solution2(target2, strs2);
      var actual3 = CanConstruct.Solution3(target2, strs2);

      Assert.IsFalse(actual1);
      Assert.IsFalse(actual2);
      Assert.IsFalse(actual3);

    } 
    [TestMethod]
    public void TestSolutions_WithBigString_ReturnFalseOnCannotConstruct() {
      var actual2 = CanConstruct.Solution2(target3, strs3);
      var actual3 = CanConstruct.Solution3(target3, strs3);
 
      Assert.IsFalse(actual2);
      Assert.IsFalse(actual3);
    }
  }
}