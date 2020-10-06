/**
 * Give a linked list and integer n, return the element n spaces
 * from the last node in the list. 获取Linked list中倒数第n个节点
 */

namespace Algo.Ds.LinkedList
{
  public class SearchFromLast<T>
  {
    static public Node<T> Run(MyLinkedList<T> list, int n)
    {
      var slow = list.Head;
      var fast = list.Head;
      while (n > 0)
      { // Move fast advance by n steps
        fast = fast.Next;
        n--;
      }
      while (fast.Next != null)
      {
        slow = slow.Next;
        fast = fast.Next;
      }
      return slow;
    }
  }
}