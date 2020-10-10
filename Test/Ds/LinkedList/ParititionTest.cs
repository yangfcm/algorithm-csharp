using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.LinkedList;
using System;

namespace Test.Ds.LinkedList
{
  [TestClass]
  public class PartitionTest
  {
    MyLinkedList<int> list;
    [TestInitialize]
    public void TestInitialize()
    {
      list = new MyLinkedList<int>();
      list.AddLast(3);
      list.AddLast(5);
      list.AddLast(8);
      list.AddLast(10);
      list.AddLast(2);
      list.AddLast(1);
      list.AddLast(9);
    }

    [TestCleanup]
    public void TestCleanup()
    {
      list.Clear();
      list = null;
    }

    [TestMethod]
    public void TestPartitionWith5()
    {
      var partitionList = Partition.Run(list, 5);
      Assert.AreEqual(partitionList.Find(0).Data, 1);
      Assert.AreEqual(partitionList.Find(1).Data, 2);
      Assert.AreEqual(partitionList.Find(2).Data, 3);
      Assert.AreEqual(partitionList.Find(3).Data, 5);
      Assert.AreEqual(partitionList.Find(4).Data, 8);
      Assert.AreEqual(partitionList.Find(5).Data, 10);
      Assert.AreEqual(partitionList.Find(6).Data, 9);
    }

    [TestMethod]
    public void TestPartitionWith2()
    {
      var partitionList = Partition.Run(list, 2);
      Assert.AreEqual(partitionList.Find(0).Data, 1);
      Assert.AreEqual(partitionList.Find(1).Data, 3);
      Assert.AreEqual(partitionList.Find(2).Data, 5);
      Assert.AreEqual(partitionList.Find(3).Data, 8);
      Assert.AreEqual(partitionList.Find(4).Data, 10);
      Assert.AreEqual(partitionList.Find(5).Data, 2);
      Assert.AreEqual(partitionList.Find(6).Data, 9);
    }

    [TestMethod]
    public void TestPartitionWith10()
    {
      var partitionList = Partition.Run(list, 10);
      Assert.AreEqual(partitionList.Find(0).Data, 9);
      Assert.AreEqual(partitionList.Find(1).Data, 1);
      Assert.AreEqual(partitionList.Find(2).Data, 2);
      Assert.AreEqual(partitionList.Find(3).Data, 8);
      Assert.AreEqual(partitionList.Find(4).Data, 5);
      Assert.AreEqual(partitionList.Find(5).Data, 3);
      Assert.AreEqual(partitionList.Find(6).Data, 10);
    }
  }
}