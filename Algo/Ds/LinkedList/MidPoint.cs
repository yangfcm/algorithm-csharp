/**
 * Make use of the MyLinkedList to find the middle node of a linked list.
 * If the list has an even number of elements, 
 * return the node at the end of the first half of the list.
 * DO NOT use a counter variable.
 * DO NOT retrieve the size of the list
 * Only iterate through the list one time 
*/
namespace Algo.Ds.LinkedList
{
  public class MidPoint<T>
  {
    static public Node<T> Run(MyLinkedList<T> list)
    {
      var slow = list.FindFirst();
      var fast = list.FindFirst();
      // Set two temporary variables, slow and fast
      // While iterating the list, slow advances with one step,
      // fast advaces with two steps. If fast.next OR fast.next.next is null,
      // slow is exactly the middle node of the list.
      while (fast.Next != null && fast.Next.Next != null)
      {
        slow = slow.Next;
        fast = fast.Next.Next;
      }
      return slow;
    }
  }
}