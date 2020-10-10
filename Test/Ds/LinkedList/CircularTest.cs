using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.LinkedList;

namespace Test.Ds.LinkedList
{
  [TestClass]
  public class CircularTest
  {
    MyLinkedList<string> list;
    Node<string> aNode, bNode, cNode, dNode;
    [TestInitialize]
    public void TestInitialize()
    { // Create a non-circular linked list
      list = new MyLinkedList<string>();
      aNode = new Node<string>("a");
      bNode = new Node<string>("b");
      cNode = new Node<string>("c");
      dNode = new Node<string>("d");
      list.Head = aNode;
      aNode.Next = bNode;
      bNode.Next = cNode;
      cNode.Next = dNode;
    }
    [TestMethod]
    public void TestCircularList()
    {
      dNode.Next = aNode; // Make the non-circular linked list circular
      Assert.IsTrue(Circular<string>.Run(list));
    }

    [TestMethod]
    public void TestNonCircularList()
    {
      Assert.IsFalse(Circular<string>.Run(list));
    }
  }
}