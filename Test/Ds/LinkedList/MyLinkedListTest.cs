using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.LinkedList;

namespace Test.Ds.LinkedList
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

    private void PopulateList()
    { // Populate list with data "a", "b", "c", "d"
      if (list.Count > 0)
      {
        list.Clear();
      }
      list.AddLast("a");
      list.AddLast("b");
      list.AddLast("c");
      list.AddLast("d");
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
    public void TestAdd()
    {
      list.Add("first", 0);  // Test add node to an empty list
      Assert.AreEqual(list.FindFirst().Data, "first");
      list.Add("second", 0);  // Test add node at index 0 of a non-empty list
      Assert.AreEqual(list.Find(0).Data, "second");
      Assert.AreEqual(list.Find(1).Data, "first");
      list.Add("middle", 1); // Test add node in the middle of a non-empty list
      Assert.AreEqual(list.Find(0).Data, "second");
      Assert.AreEqual(list.Find(1).Data, "middle");
      Assert.AreEqual(list.Find(2).Data, "first");
      list.Add("last", 3);  // Test add node at the tail of list
      Assert.AreEqual(list.Find(3).Data, "last");
      list.Add("final", 99);  // Test add node at the tail of list if index is out of the boundary
      Assert.AreEqual(list.Find(4).Data, "final");
    }

    [TestMethod]
    public void TestCount()
    {
      // var list = new MyLinkedList<string>();
      PopulateList();
      Assert.AreEqual(list.Count, 4);
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
    public void TestFind()
    {
      Assert.AreEqual(list.Find(1), null);
      PopulateList();
      Assert.AreEqual(list.Find(0).Data, "a");
      Assert.AreEqual(list.Find(1).Data, "b");
      Assert.AreEqual(list.Find(2).Data, "c");
      Assert.AreEqual(list.Find(3).Data, "d");
      Assert.AreEqual(list.Find(99), null);
    }

    [TestMethod]
    public void TestClear()
    {
      // var list = new MyLinkedList<string>();
      PopulateList();
      Assert.AreEqual(list.Count, 4);
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

      PopulateList();
      list.RemoveLast();
      Assert.AreEqual(list.Count, 3);
      Assert.AreEqual(list.FindLast().Data, "c");
    }

    [TestMethod]
    public void TestRemove()
    {
      PopulateList();
      Assert.AreEqual(list.Find(1).Data, "b");
      list.Remove(1);
      Assert.AreEqual(list.Find(1).Data, "c");
      list.Remove(99);
      // Should do nothing if it attempts to remove a node beyond boundary
      Assert.AreEqual(list.Find(1).Data, "c");
    }

    [TestMethod]
    public void TestForEach()
    {
      PopulateList();
      list.ForEach((node, counter) => node.Data += "z");  // Add z to each element
      Assert.AreEqual(list.Find(0).Data, "az");
      Assert.AreEqual(list.Find(1).Data, "bz");
      Assert.AreEqual(list.Find(2).Data, "cz");
      Assert.AreEqual(list.Find(3).Data, "dz");
    }

  }
}