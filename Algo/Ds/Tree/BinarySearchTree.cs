/**
 * Binary Search Tree
 * 1. Implement the Node class to create a binary search tree.
 * The constructor should initialize values 'data', 'left' and 'right'
 * For BST: A node's *left* children's values are all less than the node itself, 
 * while its *right* children's values are bigger. 
 * 2. Implement the 'Add' method for the Node class.
 * Add should accept an argument 'data', 
 * then create a new node and add it at the appropriate location in the tree.
 * 3. Implement the 'Find' method for the Node class.
 * 'Find' should accept a 'data' argument and return the Node in the tree with the same value
 * If the value isn't in the tree, return null.
 * 4. Implement the 'IsBst' method for the Node class to examine if the tree is a *Binary Search Search*
 * If it is, return true; otherwise return false.
 */
namespace Algo.Ds.Tree.Bst
{
  /*****************
  **  Node class  **
  *****************/
  public class Node
  {
    public int Data { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
    public Node(int data)
    {
      Data = data;
      Left = null;
      Right = null;
    }

    /** Add an element to binary search tree */
    public void Add(int data)
    {
      if (data < Data && Left != null)
      {
        Left.Add(data);
      }
      else if (data < Data)
      {
        Left = new Node(data);
      }
      else if (data > Data && Right != null)
      {
        Right.Add(data);
      }
      else if (data > Data)
      {
        Right = new Node(data);
      }
    }

    /** Find a node in BST
      * If its value found in BST, return the node
      * Otherwise, return null
     */
    public Node Find(int data)
    {
      if (data == Data) // Found!
      {
        return this;
      }
      if (data < Data && Left != null)
      {
        // If the value to find is less than the node's value and the node's has left child,
        // Search its left children continuously
        return Left.Find(data);
      }
      else if (data > Data && Right != null)
      {
        // If the value to find is greater than the node's value and the node's has right child,
        // Search its right children continuously
        return Right.Find(data);
      }

      // Not found:
      return null;
    }

    /* Validate if the Node instance is a BST */
    public static bool IsBst(Node node, int? min, int? max)
    {
      if (max != null && node.Data > max)
      {
        return false;
      }
      if (min != null && node.Data < min)
      {
        return false;
      }

      if (node.Left != null && IsBst(node.Left, min, node.Data) == false)
      {
        return false;
      }
      if (node.Right != null && IsBst(node.Right, node.Data, max) == false)
      {
        return false;
      }
      return true;
    }
  }
}