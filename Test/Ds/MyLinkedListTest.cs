using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo;

namespace Test
{
  [TestClass]
  public class MyLinkedListTest
  {
    MyLinkedList<string> list;

    [TestInitialize]
    public void TestInitialize()
    {
      list = new MyLinkedList<string>();
    }

    [TestMethod]
    public void TestNodeConstructor()
    {
      var nodeData = "some data";
      var next = new Node<string>("nextData");
      var node = new Node<string>(nodeData, next);
      Assert.AreEqual(node.Data, nodeData);
      Assert.AreEqual(node.Next, next);
    }

    [TestMethod]
    public void TestLinkedListConstructor()
    {
      // var list = new MyLinkedList<string>();
      Assert.IsNull(list.Head);
    }

    [TestMethod]
    public void TestAddFirst()
    {
      // var list = new MyLinkedList<string>();
      list.AddFirst("abc");
      Assert.AreEqual(list.Head.Data, "abc");
      list.AddFirst("def");
      Assert.AreEqual(list.Head.Data, "def");
    }

    [TestMethod]
    public void TestAddLast()
    {
      list.AddLast("a");
      list.AddLast("b");
      Assert.AreEqual(list.FindLast().Data, "b");
      list.AddLast("c");
      Assert.AreEqual(list.FindLast().Data, "c");
    }

    [TestMethod]
    public void TestCount()
    {
      // var list = new MyLinkedList<string>();
      list.AddFirst("a");
      list.AddFirst("b");
      list.AddFirst("c");
      Assert.AreEqual(list.Count, 3);
    }

    [TestMethod]
    public void TestFindFirst()
    {
      // var list = new MyLinkedList<string>();
      Assert.AreEqual(list.FindFirst(), null);
      list.AddFirst("abc");
      Assert.AreEqual(list.FindFirst().Data, "abc");
      list.AddFirst("xyz");
      Assert.AreEqual(list.FindFirst().Data, "xyz");
    }

    [TestMethod]
    public void TestFindLast()
    {
      // var list = new MyLinkedList<string>();
      Assert.AreEqual(list.FindFirst(), null);
      list.AddFirst("abc");
      Assert.AreEqual(list.FindLast().Data, "abc");
      list.AddFirst("xyz");
      Assert.AreEqual(list.FindLast().Data, "abc");
    }

    [TestMethod]
    public void TestClear()
    {
      // var list = new MyLinkedList<string>();
      list.AddFirst("a");
      list.AddFirst("b");
      list.AddFirst("c");
      list.AddFirst("d");
      list.AddFirst("e");
      Assert.AreEqual(list.Count, 5);
      list.Clear();
      Assert.AreEqual(list.Count, 0);
    }

    [TestMethod]
    public void TestRemoveFirst1()
    {
      // Test RemoveFirst() if linked list has no or one element
      list.RemoveFirst();
      Assert.IsNull(list.Head);
      list.AddFirst("a");
      list.RemoveFirst();
      Assert.IsNull(list.Head);
    }

    [TestMethod]
    public void TestRemoveFirst2()
    {
      // Test RemoveFirst() if linked list has more than one elements
      list.AddFirst("a");
      list.AddFirst("b");
      list.AddFirst("c");
      list.AddFirst("d");
      list.RemoveFirst();
      Assert.AreEqual(list.Count, 3);
      Assert.AreEqual(list.Head.Data, "c");
      list.RemoveFirst();
      Assert.AreEqual(list.Count, 2);
      Assert.AreEqual(list.Head.Data, "b");
    }

    [TestMethod]
    public void TestRemoveLast1()
    {
      // Test RemoveLast() if linked list has zeri or one elements
      list.RemoveLast();
      Assert.IsNull(list.Head);
      list.AddFirst("a");
      list.RemoveLast();
      Assert.IsNull(list.Head);
    }

    [TestMethod]
    public void TestRemoveLast2()
    {
      // Test RemoveLast() if linked list has more than one elements

      list.AddFirst("a");
      list.AddFirst("b");
      list.AddFirst("c");
      list.AddFirst("d");
      list.RemoveLast();
      Assert.AreEqual(list.Count, 3);
      Assert.AreEqual(list.FindLast().Data, "b");
    }

  }
}