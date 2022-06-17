/**
  * Given a linked list and an integer x. 
  * Partition the linked list around x, such that
  * all nodes less than x comes before all nodes greater than or equal to x.
  * The partition element x can appear anywhere in the 'right partition';
  * it does not need to appear between the left and right partitions.
  * Example: 3 -> 5 -> 8 -> 5 -> 10 -> 2 -> 1 [partition = 5]
  * after partition: 3 -> 1 -> 2 -> 10 -> 5 -> 5 -> 8
*/
namespace Algo.Ds.LinkedList
{
  public class Partition
  {
    static public MyLinkedList<int> Run(MyLinkedList<int> list, int x)
    {
      var partitionList = new MyLinkedList<int>();
      var node = list.Head;
      while (node != null)
      {
        if (node.Data < x)
        {
          partitionList.AddFirst(node.Data);
        }
        else
        {
          partitionList.AddLast(node.Data);
        }
        node = node.Next;
      }
      return partitionList;
    }
  }
}