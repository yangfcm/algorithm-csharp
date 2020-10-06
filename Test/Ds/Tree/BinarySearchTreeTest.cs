using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System;
using Algo.Ds.Tree.Bst;

namespace Test
{
  [TestClass]
  public class BinarySearchTreeTest
  {
    Node bstNode;

    [TestInitialize]
    public void TestInitialize()
    {
      bstNode = new Node(10);
      bstNode.Add(5);
      bstNode.Add(15);
      bstNode.Add(20);
      bstNode.Add(0);
      bstNode.Add(-5);
      bstNode.Add(3);
    }

    [TestMethod]
    public void TestAddNode()
    {
      var node = new Node(10);
      node.Add(5);
      node.Add(15);
      node.Add(17);
      Assert.AreEqual(node.Left.Data, 5);
      Assert.AreEqual(node.Right.Data, 15);
      Assert.AreEqual(node.Right.Right.Data, 17);
    }

    [TestMethod]
    public void TestFindWithExistingNumber()
    // Find method can return the node if its value exists
    {
      Assert.AreEqual(bstNode, bstNode.Find(10));
      Assert.AreEqual(bstNode.Left.Left.Right, bstNode.Find(3));
    }

    [TestMethod]
    public void TestFindWithNonExistingNumber()
    // Find method can return the node if its value exists
    {
      Assert.IsNull(bstNode.Find(999));
    }

    [TestMethod]
    public void TestIsBst()
    {
      // Assert true if the tree is BST
      Assert.IsTrue(Node.IsBst(bstNode, null, null));

      // Assert false if the tree is not BST
      var node = new Node(10);
      node.Left = new Node(5);
      node.Right = new Node(20);
      node.Left.Right = new Node(12);
      Assert.IsFalse(Node.IsBst(node, null, null));
    }
  }
}