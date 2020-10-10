using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.Graph;

namespace Test.Ds.Graph_
{
  [TestClass]
  public class GraphTest
  {
    Graph dGraph;
    Graph uGraph;  // Test one undirected graph and one directed graph.

    [TestInitialize]
    public void TestInitiazlie()
    {
      uGraph = new Graph(new int[] { 1, 2, 3, 4, 5 }, true);
      uGraph.InsertEdge(0, 1);
      uGraph.InsertEdge(1, 3);
      uGraph.InsertEdge(2, 3);
      uGraph.InsertEdge(2, 4);
      uGraph.InsertEdge(0, 4);
      dGraph = new Graph(new int[] { 1, 2, 3, 4, 5 }, false);
      dGraph.InsertEdge(0, 1);
      dGraph.InsertEdge(1, 3);
      dGraph.InsertEdge(2, 3);
      dGraph.InsertEdge(2, 4);
      dGraph.InsertEdge(0, 4);
      dGraph.InsertEdge(4, 0);
    }

    [TestCleanup]
    public void Cleanup()
    {
      dGraph = null;
      uGraph = null;
    }

    [TestMethod]
    public void TestGetNumberOfVertexes()
    {
      Assert.AreEqual(uGraph.GetNumberOfVertexes(), 5);
      Assert.AreEqual(dGraph.GetNumberOfVertexes(), 5);
    }

    [TestMethod]
    public void TestGetNumberOfEdges()
    {

      Assert.AreEqual(uGraph.GetNumberOfEdges(), 5);
      Assert.AreEqual(dGraph.GetNumberOfEdges(), 6);
    }

    [TestMethod]
    public void TestGetValueByIndex()
    {
      Assert.AreEqual(uGraph.GetValueByIndex(0), 1);
      Assert.AreEqual(uGraph.GetValueByIndex(1), 2);
      Assert.AreEqual(uGraph.GetValueByIndex(2), 3);
      Assert.AreEqual(uGraph.GetValueByIndex(3), 4);
      Assert.AreEqual(uGraph.GetValueByIndex(4), 5);

      Assert.AreEqual(dGraph.GetValueByIndex(0), 1);
      Assert.AreEqual(dGraph.GetValueByIndex(1), 2);
      Assert.AreEqual(dGraph.GetValueByIndex(2), 3);
      Assert.AreEqual(dGraph.GetValueByIndex(3), 4);
      Assert.AreEqual(dGraph.GetValueByIndex(4), 5);
    }

    [TestMethod]
    public void TestInsertEdge()
    {
      uGraph.InsertEdge(1, 2);
      Assert.AreEqual(uGraph.GetNumberOfEdges(), 6);
      dGraph.InsertEdge(4, 2);
      Assert.AreEqual(dGraph.GetNumberOfEdges(), 7);
    }

    [TestMethod]
    public void TestRemoveEdge()
    {
      uGraph.RemoveEdge(0, 1);
      Assert.AreEqual(uGraph.GetNumberOfEdges(), 4);
      dGraph.RemoveEdge(0, 1);
      Assert.AreEqual(dGraph.GetNumberOfEdges(), 5);
    }

    [TestMethod]
    public void TestGetMatrix()
    {
      var uGraphMatrix = new int[,]{
        {0,1,0,0,1},
        {1,0,0,1,0},
        {0,0,0,1,1},
        {0,1,1,0,0},
        {1,0,1,0,0}
      };
      CollectionAssert.AreEqual(uGraph.GetMatrix(), uGraphMatrix);

      var dGraphMatrix = new int[,]{
        {0,1,0,0,1},
        {0,0,0,1,0},
        {0,0,0,1,1},
        {0,0,0,0,0},
        {1,0,0,0,0}
      };
      CollectionAssert.AreEqual(dGraph.GetMatrix(), dGraphMatrix);
    }

    [TestMethod]
    public void TestSearchDFS()
    {
      var uGraphSearch = uGraph.SearchDFS();
      var dGraphSearch = dGraph.SearchDFS();
      CollectionAssert.AreEqual(uGraphSearch.ToArray(), new int[] { 1, 2, 4, 3, 5 });
      CollectionAssert.AreEqual(dGraphSearch.ToArray(), new int[] { 1, 2, 4, 5, 3 });
    }

    [TestMethod]
    public void TestSearchBFS()
    {
      var uGraphSearch = uGraph.SearchBFS();
      var dGraphSearch = dGraph.SearchBFS();
      CollectionAssert.AreEqual(uGraphSearch.ToArray(), new int[] { 1, 2, 5, 4, 3 });
      CollectionAssert.AreEqual(dGraphSearch.ToArray(), new int[] { 1, 2, 5, 4, 3 });
    }
  }
}