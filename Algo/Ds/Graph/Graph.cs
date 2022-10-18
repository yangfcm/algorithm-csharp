using System.Collections.Generic;
/**
 * Graph data structure
 * Implement a Graph class.
 * Use a two-dimentaional array to represent a graph
 */
namespace Algo.Ds.Graph
{
  public class Graph
  {
    readonly bool Undirected;  // If the graph is directed or undirected
    readonly int[] VertexList; // The list of vertexes in the graph
    readonly int[,] Matrix; // A two-dementional array to represent a graph
    bool[] IsVisited; // The array to record if a vertex at index i is visited or not
    List<int> GraphArr; // The array to store the traverse result of a graph
    int NumberOfEdges;  // How many edges in the graph

    /**
     * Constructor - Initialize Graph class
     */
    public Graph(int[] vertexList, bool undirected = true)
    {
      NumberOfEdges = 0;
      VertexList = (int[])vertexList.Clone();
      Undirected = undirected;
      int numberOfVertex = VertexList.Length;
      Matrix = new int[numberOfVertex, numberOfVertex];
      IsVisited = new bool[numberOfVertex];
      GraphArr = new List<int>();
    }

    /**
     * Add an edge between two vertexes
     */
    public void InsertEdge(int startIndex, int endIndex, int weight = 1)
    {
      if (Matrix[startIndex, endIndex] == 0)
      {
        Matrix[startIndex, endIndex] = weight;
        if (Undirected == true)
        {
          Matrix[endIndex, startIndex] = weight;
        }
      }
      NumberOfEdges++;
    }

    /**
     * Remove an edge between two vertexes
     */
    public void RemoveEdge(int startIndex, int endIndex)
    {
      if (Matrix[startIndex, endIndex] != 0)
      {
        Matrix[startIndex, endIndex] = 0;
        if (Undirected == true)
        {
          Matrix[endIndex, startIndex] = 0;
        }
      }
      NumberOfEdges--;
    }

    public int GetNumberOfVertexes()
    {
      return VertexList.Length;
    }

    public int GetNumberOfEdges()
    {
      return NumberOfEdges;
    }

    /**
      * Get the value of the vertex based on its index
      */
    public int GetValueByIndex(int index)
    {
      return VertexList[index];
    }

    /**
      * Get the weight of the edge from one vertex to another
      */
    public int GetWeight(int startIndex, int endIndex)
    {
      return Matrix[startIndex, endIndex];
    }

    /**
     * Get the matrix that represents the graph
     */
    public int[,] GetMatrix()
    {
      return Matrix;
    }

    /**
      * Given the index of a vertex, get its adjacent vertex. 
      */
    public int GetFirstAdjacent(int index)
    {
      for (int k = 0; k < VertexList.Length; k++)
      {
        if (Matrix[index, k] > 0)
        {
          return k;
        }
      }
      return -1;
    }

    /**
      * Given the index of a vertex(v1), get its adjacent vertex starting from v2
      */
    public int GetNextAdjacent(int v1, int v2)
    {
      for (int k = v2 + 1; k < VertexList.Length; k++)
      {
        if (Matrix[v1, k] > 0)
        {
          return k;
        }
      }
      return -1;
    }

    /**
     * Search depth-first for a vertex at index
     */
    void SearchDFSVertex(int index)
    {
      GraphArr.Add(GetValueByIndex(index));
      IsVisited[index] = true;

      int w = GetFirstAdjacent(index);
      while (w != -1)
      {
        if (IsVisited[w] == false)
        {
          SearchDFSVertex(w);
        }
        w = GetNextAdjacent(index, w);
      }
    }

    /**
     * Do DFS searching for the whole graph
     */
    public List<int> SearchDFS()
    {
      GraphArr = new List<int>(); // Reset graph search list
      IsVisited = new bool[VertexList.Length];  // Reset IsVisited array
      for (int i = 0; i < GetNumberOfVertexes(); i++)
      {
        if (IsVisited[i] == false)
        {
          SearchDFSVertex(i);
        }
      }
      return GraphArr;
    }

    /**
     * Search broadth-first for a vertex at index
     */
    void SearchBFSVertex(int index)
    {
      var queue = new Queue<int>(); // Use a queue to record the sequence of visiting.
      int u;
      int adjacent;
      GraphArr.Add(GetValueByIndex(index));
      IsVisited[index] = true;
      queue.Enqueue(index);
      while (queue.Count > 0)
      {
        u = queue.Dequeue();
        adjacent = GetFirstAdjacent(u);
        while (adjacent != -1)
        {
          if (IsVisited[adjacent] == false)
          {
            GraphArr.Add(GetValueByIndex(adjacent));
            IsVisited[adjacent] = true;
            queue.Enqueue(adjacent);
          }
          adjacent = GetNextAdjacent(u, adjacent);
        }
      }
    }

    /**
     * Do BFS searching for the whole graph
     */
    public List<int> SearchBFS()
    {
      GraphArr = new List<int>(); // Reset graph search list
      IsVisited = new bool[VertexList.Length];
      for (int i = 0; i < GetNumberOfVertexes(); i++)
      {
        if (IsVisited[i] == false)
        {
          SearchBFSVertex(i);
        }
      }
      return GraphArr;
    }
  }
}