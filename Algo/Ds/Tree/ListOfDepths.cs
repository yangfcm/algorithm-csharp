using System.Collections.Generic;

/**
 * Given a binary tree, create an array/list of all the nodes at each level.
 * If you have a tree with N levels, you'll have N arrays/lists.
 * --- Example
 * Given:
 *      0
 *    /   \
 *   1     3
 *  / \   /
 * 4  6  5
 * Answer: [[Node(0)], [Node(1), Node(3)], [Node(4), Node(6), Node(5)]]
 */
namespace Algo.Ds.Tree.Bst
{
  public class CreateLevelList
  {
    public static List<List<Node>> Run(Node root)
    {
      List<List<Node>> lists = new ();
      CreateLevelListHelper(root, lists, 0);
      return lists;
    }

    private static void CreateLevelListHelper(Node root, List<List<Node>> lists, int level)
    {
      if (root == null) return;
      List<Node> list;
      if (lists.Count == level)
      {
        list = new List<Node>();
        lists.Add(list);
      }
      else
      {
        list = lists[level];
      }
      list.Add(root);
      CreateLevelListHelper(root.Left, lists, level + 1);
      CreateLevelListHelper(root.Right, lists, level + 1);
    }

    /* Alternative solution to the problem */
    public static List<List<Node>> RunAlt(Node root)
    {
      List<List<Node>> lists = new ();
      List<Node> current = new ();
      if (root != null)
      {
        current.Add(root);
      }
      while (current.Count > 0)
      {
        lists.Add(current);
        var parents = current;  // Remember the current level
        current = new List<Node>();
        foreach (Node parent in parents)
        {
          if (parent.Left != null)
          {
            current.Add(parent.Left);
          }
          if (parent.Right != null)
          {
            current.Add(parent.Right);
          }
        }
      }
      return lists;
    }
  }
}