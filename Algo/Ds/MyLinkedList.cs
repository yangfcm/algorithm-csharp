
/**
 * Implement LinkedList data structure
 * C# has built-in LinkedList class, don't use it.
 * Instead, implement your own LinkedList class from scratch.
 * Need to implement these properties/methods: Count, Add, AddFirst, AddLast, 
 * Find, FindFirst, FindLast, 
 * Remove, RemoveFirst, RemoveLast,
 * Find, FindLast and Clear
 */
namespace Algo
{
  public class Node<T>
  {
    public T Data { get; set; } // The data saved in the node
    public Node<T> Next { get; set; } // The next node

    public Node(T data, Node<T> next = null)
    {
      Data = data;
      Next = next;
    }
  }

  public class MyLinkedList<T>
  {
    public Node<T> Head { get; set; }
    public int Count
    {
      get { return CalculateCount(); }
    }
    public MyLinkedList()
    {
      Head = null;
    }

    public void AddFirst(T data)
    {
      var node = new Node<T>(data, Head);
      Head = node;
    }

    public void AddLast(T data)
    {
      var lastNode = FindLast();
      var newNode = new Node<T>(data);
      if (lastNode == null)
      { // Empty list
        Head = newNode;
      }
      else
      {
        lastNode.Next = newNode;
      }
    }

    public Node<T> FindFirst()
    {
      return Head;
    }

    public Node<T> FindLast()
    {
      var node = Head;
      if (node == null)
      {
        return null;
      }
      while (node.Next != null)
      {
        node = node.Next;
      }
      return node;
    }

    public void RemoveFirst()
    // After first node gets removed, the list's head should point to the second node
    {
      if (Head == null)
      {
        // If it's an empty linked list, nothing to remove, return directly
        return;
      }
      Head = Head.Next;
    }

    public void RemoveLast()
    {
      if (Head == null)
      // If it's an empty linked list, nothing to remove, return directly
      {
        return;
      }

      var node = Head;
      if (node.Next == null)
      {
        Head = null;
        return;
      }

      while (node.Next.Next != null)
      {
        node = node.Next;
      }
      node.Next = null;
    }

    public void Clear()
    {
      Head = null;
    }

    private int CalculateCount()
    {
      int count = 0;
      var node = Head;
      while (node != null)
      {
        count++;
        node = node.Next;
      }
      return count;
    }

  }
}