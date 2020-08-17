using System.Collections.Generic;
using System;

/**
 * Tree data structure
 * 1. Create a node class. 
 * The constructor should accept an argument that gets assigned to the data property
 * and initialize an empty array for sorting children.
 * The node class should have methods 'add' and 'remove'
 * 2. Create a tree class. 
 * The constructor should initialize a 'root' property to null.
 * 3. Implement 'traverseBFS' 广度优先搜索 and 'traverseDFS' 深度优先搜索 on the tree class.
 */
namespace Algo.Ds.Tree
{
  public class Node
  {
    public dynamic Data { get; set; }
    public List<dynamic> Children { get; set; }
    // To use dynamic data type, include Microsoft.CSharp package
    public Node(dynamic data)
    {
      Data = data;
      Children = new List<dynamic>();
    }

    public void Add(dynamic data)
    {
      var node = new Node(data);
      Children.Add(node);
    }

    public void Remove(dynamic data)
    {
      int index = Children.FindIndex(node => node.Data == data);
      if (index >= 0)
      {
        Children.RemoveAt(index);
      }
    }
  }

  public class Tree
  {
    public Node Root { get; set; }
    public delegate void Callback(Node node);
    public Tree()
    {
      Root = null;
    }

    // Traverse by BFS
    public void traverseBfs(Callback fn)
    {
      var treeList = new List<Node>();
      treeList.Add(Root);
      // treeList is used to store elements of the tree by BFS order
      // Below: implement BFS traversal
      while (treeList.Count > 0)
      {
        Node node = treeList.ToArray()[0]; // Take the first element out of the array
        treeList.RemoveAt(0);
        foreach (Node childNode in node.Children)
        {
          treeList.Add(childNode);
        }
        fn(node);
      }
    }

    public void traverseDfs(Callback fn)
    {
      var treeList = new List<Node>();
      treeList.Add(Root);
      while (treeList.Count > 0)
      {
        Node node = treeList.ToArray()[0];
        treeList.RemoveAt(0);
        // Very similar to BFS, but instead of put children's elements at the end of the array,
        // DFS put children's elements at the head. 

        node.Children.Reverse();
        foreach (Node childNode in node.Children)
        {
          treeList.Insert(0, childNode);
        }
        fn(node);
      }
    }
  }
}

