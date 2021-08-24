
using Algo.Dynamic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algo.Dynamic
{
  [TestClass]
  public class CountConstructTest
  {
    private readonly string[] strs1 =  new string[]{"ab", "abc", "cd", "def", "abcd"};
    private readonly string target1 = "abcdef"; // 1
    private readonly string[] strs2 =  new string[]{"purp", "p", "ur", "le", "purpl"};
    private readonly string target2 = "purple"; // 2
    private readonly string[] strs3 =  new string[]{"a", "p", "ent", "enter", "ot", "o", "t"};
    private readonly string target3 = "enterapotentpot";  // 4
    private readonly string[] strs4 =  new string[]{"bo", "rd", "ate", "t", "ska", "sk", "boar"};
    private readonly string target4 = "skateboard"; // 0
    private readonly string[] strs5 = new string[] {"e",
      "ee",
      "eee",
      "eeee",
      "eeeee",
      "eeeeee"
    };
    private readonly string target5 = "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef";  // Big and 0
    
    [TestMethod] 
    public void TestSolution1() 
    {
      Assert.AreEqual(1, countConstruct.Solution1(target1, strs1));
      Assert.AreEqual(2, countConstruct.Solution1(target2, strs2));
      Assert.AreEqual(4, countConstruct.Solution1(target3, strs3));
      Assert.AreEqual(0, countConstruct.Solution1(target4, strs4));
    }

    [TestMethod]
    public void TestSolution2() {
      Assert.AreEqual(1, countConstruct.Solution2(target1, strs1));
      Assert.AreEqual(2, countConstruct.Solution2(target2, strs2));
      Assert.AreEqual(4, countConstruct.Solution2(target3, strs3));
      Assert.AreEqual(0, countConstruct.Solution2(target4, strs4));
      Assert.AreEqual(0, countConstruct.Solution2(target5, strs5));
    }

    [TestMethod]
    public void TestSolution3() {
      Assert.AreEqual(1, countConstruct.Solution3(target1, strs1));
      Assert.AreEqual(2, countConstruct.Solution3(target2, strs2));
      Assert.AreEqual(4, countConstruct.Solution3(target3, strs3));
      Assert.AreEqual(0, countConstruct.Solution3(target4, strs4));
      Assert.AreEqual(0, countConstruct.Solution3(target5, strs5));
    }
  }
}