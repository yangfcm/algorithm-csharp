using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.LinkedList;

namespace Test.Ds.LinkedList
{
  [TestClass]
  public class RemoveDuplicateTest
  {
    MyLinkedList<dynamic> list;
    [TestInitialize]
    public void TestInitialize()
    {
      list = new MyLinkedList<dynamic>();

      list.AddLast('a');
      list.AddLast('b');
      list.AddLast('b');
      list.AddLast('b');
      list.AddLast('c');
      list.AddLast('c');
      list.AddLast('d');
      list.AddLast('d');
      list.AddLast('d');
      list.AddLast('d');
      list.AddLast('b');
      list.AddLast('c');
    }

    [TestMethod]
    public void TestRemoveDuplicate()
    {
      RemoveDuplicate.Run(list);
      Assert.AreEqual(list.Count, 4);
      Assert.AreEqual(list.Find(0).Data, 'a');
      Assert.AreEqual(list.Find(1).Data, 'b');
      Assert.AreEqual(list.Find(2).Data, 'c');
      Assert.AreEqual(list.Find(3).Data, 'd');
    }
  }
}