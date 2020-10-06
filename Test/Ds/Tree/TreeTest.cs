using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System;
using Algo.Ds.Tree;

namespace Test
{
  [TestClass]
  public class TreeNodeTest
  {
    Node node;
    Tree tree;
    List<dynamic> traverseResult;

    [TestInitialize]
    public void TestInitialize()
    {
      node = new Node("a");
      traverseResult = new List<dynamic>();
      tree = new Tree();
      tree.Root = new Node("a");
      tree.Root.Add("b");
      tree.Root.Add("c");
      tree.Root.Add("d");
      tree.Root.Children[0].Add("e");
      tree.Root.Children[0].Add("f");
      tree.Root.Children[2].Add("g");
    }

    [TestMethod]
    public void TestInitialNode()
    {
      Assert.AreEqual(node.Data, "a");
      Assert.AreEqual(node.Children.Count, 0);
    }

    [TestMethod]
    public void TestAddNode()
    {
      node.Add("new");
      Assert.AreEqual(node.Children.Count, 1);
      Assert.AreEqual(node.Children[0].Data, "new");
    }

    [TestMethod]
    public void TestRemoveNode()
    {
      node.Add("b");
      node.Add("c");
      node.Add("d");
      node.Remove("c");
      Assert.AreEqual(node.Children.Count, 2);
      Assert.AreEqual(node.Children.FindIndex(node => node.Data == "c"), -1);
    }

    [TestMethod]
    public void TestTraverseBfs()
    {
      tree.traverseBfs((Node node) =>
      {
        traverseResult.Add(node.Data);
      });
      var expected = new dynamic[] { "a", "b", "c", "d", "e", "f", "g" };
      Assert.IsTrue(expected.SequenceEqual(traverseResult.ToArray()));
    }

    [TestMethod]
    public void TestTraverseDfs()
    {
      tree.traverseDfs((Node node) =>
      {
        traverseResult.Add(node.Data);
      });
      var expected = new dynamic[] { "a", "b", "e", "f", "c", "d", "g" };
      Assert.IsTrue(expected.SequenceEqual(traverseResult.ToArray()));
    }

    [TestMethod]
    public void TestLevelWidth()
    {
      var expectedWidth = new int[] { 1, 3, 3 };
      Assert.IsTrue(expectedWidth.SequenceEqual(tree.levelWidth()));
    }
  }
}