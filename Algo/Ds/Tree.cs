using System.Collections.Generic;

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
  /*****************
  **  Node class  **
  *****************/
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

  /*****************
  **  Tree class  **
  *****************/
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

    /* Return an array to show the width of each level of the tree.
    (How many elements are there on each level of a tree)
    * --- Example
    * Given:
    *     0
    *   / |  \
    * 1   2   3
    * |       |
    * 4       5
    * Should return: [1, 3, 2]
    */
    public List<int> levelWidth()
    {
      string STOP_SIGN = "this is a stop sign to indicate the end of a level of tree";
      List<int> widths = new List<int>(new int[] { 0 });
      // widths list is to hold the width of each level
      // It starts from a single element of 0.
      List<dynamic> treeList = new List<dynamic>();
      treeList.Add(Root);
      treeList.Add(new Node(STOP_SIGN));  // STOP_SIGN is an arbitary letter used as a stop sign to indicate the end of a level
      while (treeList.Count > 1)
      { // Traverse the tree using BFS.
        // If treeList has only one element, which should be STOP SIGN, it means the traversal of tree is finished 
        var node = treeList.ToArray()[0];
        treeList.RemoveAt(0);  // Get the first element and remove it from list
        if (node.Data == STOP_SIGN)
        { // If the node returned is STOP SIGN, it means it reaches the end of the level
          widths.Add(0);
          treeList.Add(new Node(STOP_SIGN)); // Put the STOP SIGN to the end of the array. 
        }
        else
        {
          foreach (Node childNode in node.Children)
          {
            treeList.Add(childNode);
          }
          widths[widths.Count - 1]++; // Increment the width number
        }
      }
      return widths;
    }
  }
}

