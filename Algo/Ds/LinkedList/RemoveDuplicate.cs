using System.Collections.Generic;

/**
 * Given a linked list, remove the duplicate node(s) from it.
 */
namespace Algo.Ds.LinkedList
{
  public class RemoveDuplicate
  {
    static public void Run(MyLinkedList<dynamic> list)
    {
      if (list.Head == null) return;
      var prev = list.Head;
      var node = prev.Next;
      List<dynamic> existingData = new () { prev.Data };
      // Use a list to store the data that appears in linked list
      while (node != null)
      {
        if (existingData.Contains(node.Data))
        {
          // If the current node's data appeared in existingData.
          prev.Next = node.Next ?? null;
        }
        else
        {
          existingData.Add(node.Data);
          prev = prev.Next;
        }
        node = node.Next;
      }
    }
  }
}