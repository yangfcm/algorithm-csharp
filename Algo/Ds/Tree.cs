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

  public class Tree<T>
  {

  }
}