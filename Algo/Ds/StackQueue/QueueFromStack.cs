using System.Collections.Generic;

/**
 * Implement a Queue data structure using two Stacks instead of using the built-in Queue provided by C#.
 * Queue should implement the methods of Enqueue(), Dequeue() and Peek
 * --- Examples
 *     const q = new Queue();
 *     q.add(1);
 *     q.add(2);
 *     q.peek();  // returns 1
 *     q.remove(); // returns 1
 *     q.remove(); // returns 2
 */

namespace Algo.Ds.StackQueue
{
  public class QueueFromStack<T>
  {
    private Stack<T> _stack1;
    private Stack<T> _stack2;
    public QueueFromStack()
    {
      _stack1 = new Stack<T>();
      _stack2 = new Stack<T>();
    }

    public void Enqueue(T el)
    {
      _stack1.Push(el);
    }

    public T Dequeue()
    {
      while (_stack1.Count > 0)
      {
        // Move all the elements in stack1 to stack2
        _stack2.Push(_stack1.Pop());
      }
      // Move the top element in stack2, which is the first element in queue
      var elToDequeue = _stack2.Pop();
      while (_stack2.Count > 0)
      {
        // If there are elements left in stack2, move it back to stack1 for next operation
        _stack1.Push(_stack2.Pop());
      }
      return elToDequeue;
    }

    public T Peek()
    {
      while (_stack1.Count > 0)
      {
        // Move all the elements in stack1 to stack2
        _stack2.Push(_stack1.Pop());
      }
      // Peek the top element in stack2, which is the first element in queue
      var elToPeek = _stack2.Peek();
      while (_stack2.Count > 0)
      {
        // If there are elements left in stack2, move it back to stack1 for next operation
        _stack1.Push(_stack2.Pop());
      }
      return elToPeek;
    }

  }

}