using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.StackQueue;

namespace Test
{
  [TestClass]
  public class QueueFromStackTest
  {


    QueueFromStack<int> queue;
    public QueueFromStackTest()
    {
      queue = this.SetEmptyQueue();
    }

    private QueueFromStack<int> SetEmptyQueue()
    {
      return new QueueFromStack<int>();
    }
    [TestMethod]
    public void TestEnqueueAndPeek()
    {
      queue.Enqueue(1);
      Assert.AreEqual(queue.Peek(), 1);
      queue.Enqueue(2);
      Assert.AreEqual(queue.Peek(), 1);
      queue.Enqueue(3);
      Assert.AreEqual(queue.Peek(), 1);
    }

    [TestMethod]
    public void TestDequeue()
    {
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);
      Assert.AreEqual(queue.Dequeue(), 1);
      Assert.AreEqual(queue.Dequeue(), 2);
      Assert.AreEqual(queue.Dequeue(), 3);
    }
  }
}