using System;
/**
 * Implement LinkedList data structure
 * C# has built-in LinkedList class, don't use it.
 * Instead, implement your own LinkedList class from scratch.
 * Need to implement these properties/methods: Count, Add, AddFirst, AddLast, 
 * Find, FindFirst, FindLast, 
 * Remove, RemoveFirst, RemoveLast,
 * Find, FindLast and Clear
 */
namespace Algo.Ds.LinkedList
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

    public void Add(T data, int index)
    { // Add a node at a given index
      if (Head == null)
      { // If the list is empty
        Head = new Node<T>(data);
        return;
      }

      Node<T> newNode;
      if (index == 0)
      { // Add the node at the head
        newNode = new Node<T>(data, Head);
        Head = newNode;
        return;
      }

      var prevNode = Find(index - 1) == null ? FindLast() : Find(index - 1);
      // If index is out of boundary, add the node at the tail of list
      newNode = new Node<T>(data, prevNode.Next);
      prevNode.Next = newNode;
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

    public Node<T> Find(int index)
    { // Find and return the node at provided index
      int counter = 0;
      var node = Head;
      while (node != null)
      {
        if (counter == index)
        {
          return node;
        }
        node = node.Next;
        counter++;
      }
      return null;  // The index is out of bound or list is empty
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

    public void Remove(int index)
    { // Remove the node with a given index
      if (Head == null)
      { // Do nothing if list is empty
        return;
      }
      if (index == 0)
      { // If it is to remove the first node...
        Head = Head.Next;
        return;
      }

      var node = Find(index);
      var prevNode = Find(index - 1);
      if (node == null)
      { // If the index is out of boundary... 
        return;
      }
      prevNode.Next = node.Next;

    }

    public void Clear()
    {
      Head = null;
    }

    public delegate void Callback(Node<T> node, int counter);
    public void ForEach(Callback callback)
    {
      var node = Head;
      int counter = 0;
      while (node != null)
      {
        callback(node, counter);
        node = node.Next;
        counter++;
      }
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