using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.LinkedList;
using System;

namespace Test.Ds.LinkedList
{
  [TestClass]
  public class SumListsTest
  {
    MyLinkedList<int> list1;
    MyLinkedList<int> list2;

    [TestInitialize]
    public void TestInitialize()
    {
      list1 = new MyLinkedList<int>();
      list2 = new MyLinkedList<int>();
      list1.AddLast(7);
      list1.AddLast(1);
      list1.AddLast(6);
      list2.AddLast(5);
      list2.AddLast(9);
      list2.AddLast(2);
    }

    [TestCleanup]
    public void TestCleanup()
    {
      list1 = null;
      list2 = null;
    }

    [TestMethod]
    public void TestSumRev()
    {
      var sumList = SumLists.SumRev(list1, list2);
      Assert.AreEqual(sumList.Find(0).Data, 2);
      Assert.AreEqual(sumList.Find(1).Data, 1);
      Assert.AreEqual(sumList.Find(2).Data, 9);
    }

    [TestMethod]
    public void TestSumFwd()
    {
      var sumList = SumLists.SumFwd(list1, list2);
      Assert.AreEqual(sumList.Find(0).Data, 1);
      Assert.AreEqual(sumList.Find(1).Data, 3);
      Assert.AreEqual(sumList.Find(2).Data, 0);
      Assert.AreEqual(sumList.Find(3).Data, 8);
    }
  }
}