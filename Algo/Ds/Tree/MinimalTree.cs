using System.Collections.Generic;

/**
 * Given a sorted, increasing order array/list with unique integer elements,
 * write a function to create a binary search tree with minimal height.
 * Note: A minimal bst has about the same number of nodes on the left of each node as on the right.
 * e.g. [1,2,3,4,5,6, 7] =>
 *      4
 *    /   \
 *   2     6
 *  / \   / \
 * 1  3  5  7
 * Solution: The middle of each subsection of the array becomes the root of the node.
 * The left half of the array will become the left subtree
 * and the right half of the array will become the right subtree.
 */
namespace Algo.Ds.Tree.Bst
{
  public class CreateMinimalBst
  {
    public static Node Run(int[] arr)
    {
      return CreateMinimalBstHelper(arr, 0, arr.Length - 1);
    }

    private static Node CreateMinimalBstHelper(int[] arr, int start, int end)
    {
      if (end < start)
      {
        return null;
      }
      int mid = (start + end) / 2;
      Node middleNode = new Node(arr[mid]);
      middleNode.Left = CreateMinimalBstHelper(arr, start, mid - 1);
      middleNode.Right = CreateMinimalBstHelper(arr, mid + 1, end);
      return middleNode;
    }
  }
}