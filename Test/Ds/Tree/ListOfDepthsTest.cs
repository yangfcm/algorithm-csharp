using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System;
using Algo.Ds.Tree.Bst;

namespace Test.Ds.Tree.Bst
{
  [TestClass]
  public class ListOfDepthsTest
  {
    Node root;

    [TestInitialize]
    public void TestInitialize()
    {
      root = new Node(0);
      root.Left = new Node(1);
      root.Right = new Node(3);
      root.Left.Left = new Node(4);
      root.Left.Right = new Node(6);
      root.Right.Left = new Node(5);
    }

    [TestCleanup]
    public void TestCleanup()
    {
      root = null;
    }

    [TestMethod]
    public void TestCreateLevelList()
    {
      var lists = CreateLevelList.Run(root);
      Assert.AreEqual(lists[0][0].Data, 0);
      Assert.AreEqual(lists[1][0].Data, 1);
      Assert.AreEqual(lists[1][1].Data, 3);
      Assert.AreEqual(lists[2][0].Data, 4);
      Assert.AreEqual(lists[2][1].Data, 6);
      Assert.AreEqual(lists[2][2].Data, 5);
    }

    [TestMethod]
    public void TestCreateLevelListAltSolution()
    {
      var lists = CreateLevelList.RunAlt(root);
      Assert.AreEqual(lists[0][0].Data, 0);
      Assert.AreEqual(lists[1][0].Data, 1);
      Assert.AreEqual(lists[1][1].Data, 3);
      Assert.AreEqual(lists[2][0].Data, 4);
      Assert.AreEqual(lists[2][1].Data, 6);
      Assert.AreEqual(lists[2][2].Data, 5);
    }
  }
}