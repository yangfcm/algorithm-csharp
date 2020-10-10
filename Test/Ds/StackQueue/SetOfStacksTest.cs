using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.StackQueue;

namespace Test.Ds.StackQueue
{
  [TestClass]
  public class SetOfStacksTest
  {
    SetOfStacks<int> stacks;
    [TestInitialize]
    public void TestInitialize()
    {
      stacks = new SetOfStacks<int>(4);
      stacks.Push(1);
      stacks.Push(2);
      stacks.Push(3);
      stacks.Push(4);
      stacks.Push(5);
      stacks.Push(6);
      stacks.Push(7);
      stacks.Push(8);
      stacks.Push(9);
    }

    [TestCleanup]
    public void TestCleanup()
    {
      stacks = null;
    }

    [TestMethod]
    public void TestStacksPop()
    {
      Assert.AreEqual(stacks.Pop(), 9);
      Assert.AreEqual(stacks.Pop(), 8);
      Assert.AreEqual(stacks.Pop(), 7);
      Assert.AreEqual(stacks.Pop(), 6);
      Assert.AreEqual(stacks.Pop(), 5);
      Assert.AreEqual(stacks.Pop(), 4);
      Assert.AreEqual(stacks.Pop(), 3);
      Assert.AreEqual(stacks.Pop(), 2);
      Assert.AreEqual(stacks.Pop(), 1);
    }

    [TestMethod]
    public void TestStacksPopAt()
    {
      Assert.AreEqual(stacks.PopAt(0), 4);
      Assert.AreEqual(stacks.PopAt(0), 3);
      Assert.AreEqual(stacks.PopAt(0), 2);
      Assert.AreEqual(stacks.PopAt(0), 1);
      Assert.AreEqual(stacks.PopAt(0), 8);  // The first stack is empty so popo the first element in next stack.
    }
  }
}