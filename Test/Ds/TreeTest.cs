using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.Tree;

namespace Test
{
  [TestClass]
  public class TreeNodeTest
  {
    Node node;
    [TestInitialize]
    public void TestInitialize()
    {
      node = new Node("a");
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
  }
}