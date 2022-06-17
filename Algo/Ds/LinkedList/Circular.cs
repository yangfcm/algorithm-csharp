/**
 * Circular
 * Use MyLinkedList, return true if it is circular, false if it is not.
 * A Circular linked list is a linked list where every element's next property
 * points to the next element, ie. no empty node.next 
 * Example:
 *  const l = new List();
 *  const a = new Node('a');
 *  const b = new Node('b');
 *  const c = new Node('c');
 *  l.head = a;
 *  a.next = b;
 *  b.next = c;
 *  c.next = b;
 *  circular(l) // true
 */
namespace Algo.Ds.LinkedList
{
  public class Circular<T>
  {
    static public bool Run(MyLinkedList<T> list)
    {
      var slow = list.Head;
      var fast = list.Head;
      // Set two temporary variables, slow and fast
      // While iterating the list, slow advances with one step,
      // fast advaces with two steps. 
      // If slow === fast, it means they meet at some point of the list
      // so it is a circular list and returns true, otherwise return false.

      while (fast.Next != null && fast.Next.Next != null)
      {
        slow = slow.Next;
        fast = fast.Next.Next;
        if (slow == fast)
        {
          return true;
        }
      }
      return false;
    }
  }
}