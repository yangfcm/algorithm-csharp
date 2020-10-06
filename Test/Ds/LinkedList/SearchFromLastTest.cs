using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.LinkedList;

namespace Test
{
  [TestClass]
  public class SearchFromLastTest
  {
    [TestMethod]
    public void TestSearchFromLast()
    {
      var list = new MyLinkedList<string>();
      list.AddLast("a");
      list.AddLast("b");
      list.AddLast("c");
      list.AddLast("d");
      list.AddLast("e");
      Assert.AreEqual(SearchFromLast<string>.Run(list, 0).Data, "e");
      Assert.AreEqual(SearchFromLast<string>.Run(list, 1).Data, "d");
      Assert.AreEqual(SearchFromLast<string>.Run(list, 2).Data, "c");
      Assert.AreEqual(SearchFromLast<string>.Run(list, list.Count - 1).Data, "a");
    }
  }
}