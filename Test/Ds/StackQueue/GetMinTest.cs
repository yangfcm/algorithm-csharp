using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algo.Ds.StackQueue;

namespace Test.Ds.StackQueue
{
  [TestClass]
  public class StackQueueTest
  {
    Stack<int> stack;

    [TestInitialize]
    public void TestInitialize()
    {
      stack = new Stack<int>();
      stack.Push(3);
      stack.Push(9);
      stack.Push(7);
      stack.Push(-3);
      stack.Push(0);
      stack.Push(22);
    }

    [TestCleanup]
    public void TestCleanup()
    {
      stack = null;
    }

    [TestMethod]
    public void TestGetMin()
    {
      Assert.AreEqual(GetMinInStack.Run(stack), -3);
      Assert.AreEqual(stack.Peek(), 22);  // Make sure the stack is intact.
    }
  }
}