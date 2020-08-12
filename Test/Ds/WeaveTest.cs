using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algo;

namespace Test
{
  [TestClass]
  public class WeaveTest
  {
    [TestMethod]
    public void TestWeaveTwoQueues1()
    {
      var q1 = new Queue<int>();
      var q2 = new Queue<int>();
      q1.Enqueue(1);
      q1.Enqueue(2);
      q1.Enqueue(3);
      q1.Enqueue(4);
      q2.Enqueue(100);
      q2.Enqueue(200);
      q2.Enqueue(300);
      q2.Enqueue(400);
      var weavedQ = Weave.Run(q1, q2);
      Assert.AreEqual(weavedQ.Count, 8);
      Assert.AreEqual(weavedQ.Dequeue(), 1);
      Assert.AreEqual(weavedQ.Dequeue(), 100);
      Assert.AreEqual(weavedQ.Dequeue(), 2);
      Assert.AreEqual(weavedQ.Dequeue(), 200);
      Assert.AreEqual(weavedQ.Dequeue(), 3);
      Assert.AreEqual(weavedQ.Dequeue(), 300);
      Assert.AreEqual(weavedQ.Dequeue(), 4);
      Assert.AreEqual(weavedQ.Dequeue(), 400);
    }

    [TestMethod]
    public void TestWeaveTwoQueues2()
    {
      var q1 = new Queue<int>();
      var q2 = new Queue<int>();
      q1.Enqueue(1);
      q2.Enqueue(100);
      q2.Enqueue(200);
      q2.Enqueue(300);
      q2.Enqueue(400);
      var weavedQ = Weave.Run(q1, q2);
      Assert.AreEqual(weavedQ.Count, 5);
      Assert.AreEqual(weavedQ.Dequeue(), 1);
      Assert.AreEqual(weavedQ.Dequeue(), 100);
      Assert.AreEqual(weavedQ.Dequeue(), 200);
      Assert.AreEqual(weavedQ.Dequeue(), 300);
      Assert.AreEqual(weavedQ.Dequeue(), 400);
    }
  }
}