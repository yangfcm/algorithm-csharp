using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algo.Ds.StackQueue;

namespace Test.Ds.StackQueue
{
  [TestClass]
  public class SortStackTest
  {
    Stack<int> stack;

    [TestInitialize]
    public void TestInitialize()
    {
      stack = new Stack<int>();
      stack.Push(10);
      stack.Push(5);
      stack.Push(7);
      stack.Push(12);
      stack.Push(-2);
      stack.Push(0);
    }

    [TestCleanup]
    public void TestCleanup()
    {
      stack = null;
    }

    [TestMethod]
    public void TestSortStack()
    {
      SortStack.Run(stack);
      Assert.AreEqual(stack.Pop(), -2);
      Assert.AreEqual(stack.Pop(), 0);
      Assert.AreEqual(stack.Pop(), 5);
      Assert.AreEqual(stack.Pop(), 7);
      Assert.AreEqual(stack.Pop(), 10);
      Assert.AreEqual(stack.Pop(), 12);
    }
  }
}