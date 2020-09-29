using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.Graph;

namespace Test
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