using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System;
using Algo.Ds.Tree.Bst;

namespace Test.Ds.Tree.Bst
{
  [TestClass]
  public class MinimalTreeTest
  {
    [TestMethod]
    [DataRow(new int[] { 1 })]
    public void TestCreateMinimalBSTCase1(int[] arr)
    {
      Node node = CreateMinimalBst.Run(arr);
      Assert.AreEqual(node.Data, 1);
      Assert.AreEqual(node.Left, null);
      Assert.AreEqual(node.Right, null);
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2 })]
    public void TestCreateMinimalBSTCase2(int[] arr)
    {
      Node node = CreateMinimalBst.Run(arr);
      Assert.AreEqual(node.Data, 1);
      Assert.AreEqual(node.Left, null);
      Assert.AreEqual(node.Right.Data, 2);
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 })]
    public void TestCreateMinimalBSTCase3(int[] arr)
    {
      Node node = CreateMinimalBst.Run(arr);
      Assert.AreEqual(node.Data, 2);
      Assert.AreEqual(node.Left.Data, 1);
      Assert.AreEqual(node.Right.Data, 3);
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4 })]
    public void TestCreateMinimalBSTCase4(int[] arr)
    {
      Node node = CreateMinimalBst.Run(arr);
      Assert.AreEqual(node.Data, 2);
      Assert.AreEqual(node.Left.Data, 1);
      Assert.AreEqual(node.Right.Data, 3);
      Assert.AreEqual(node.Right.Right.Data, 4);
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5 })]
    public void TestCreateMinimalBSTCase5(int[] arr)
    {
      Node node = CreateMinimalBst.Run(arr);
      Assert.AreEqual(node.Data, 3);
      Assert.AreEqual(node.Left.Data, 1);
      Assert.AreEqual(node.Right.Data, 4);
      Assert.AreEqual(node.Left.Right.Data, 2);
      Assert.AreEqual(node.Right.Right.Data, 5);
    }


    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7 })]
    public void TestCreateMinimalBSTCase6(int[] arr)
    {
      Node node = CreateMinimalBst.Run(arr);
      Assert.AreEqual(node.Data, 4);
      Assert.AreEqual(node.Left.Data, 2);
      Assert.AreEqual(node.Right.Data, 6);
      Assert.AreEqual(node.Left.Left.Data, 1);
      Assert.AreEqual(node.Left.Right.Data, 3);
      Assert.AreEqual(node.Right.Left.Data, 5);
      Assert.AreEqual(node.Right.Right.Data, 7);
    }
  }
}