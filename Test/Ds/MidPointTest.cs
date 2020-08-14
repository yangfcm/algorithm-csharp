using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo;

namespace Test
{
  [TestClass]
  public class MidPointTest
  {
    MyLinkedList<string> list;
    [TestInitialize]
    public void TestInitialize()
    {
      list = new MyLinkedList<string>();
    }
    [TestMethod]
    public void TestMidPointForOddNumberList()
    {
      list.AddLast("a");
      Assert.AreEqual(MidPoint<string>.Run(list).Data, "a");
      list.AddLast("b");
      list.AddLast("c");
      Assert.AreEqual(MidPoint<string>.Run(list).Data, "b");
      list.AddLast("d");
      list.AddLast("e");
      Assert.AreEqual(MidPoint<string>.Run(list).Data, "c");
    }

    [TestMethod]
    public void TestMidPointForEvenNumberList()
    {
      list.AddLast("a");
      list.AddLast("b");
      Assert.AreEqual(MidPoint<string>.Run(list).Data, "a");
      list.AddLast("c");
      list.AddLast("d");
      Assert.AreEqual(MidPoint<string>.Run(list).Data, "b");
      list.AddLast("e");
      list.AddLast("f");
      Assert.AreEqual(MidPoint<string>.Run(list).Data, "c");

    }
  }
}