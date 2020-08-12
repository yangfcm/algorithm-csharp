using System;
using System.Collections.Generic;

/*
  * Weave: Receive two queues as arguments and combines the contents of each into a new, third queue.
 * The new queue should contain the alterating of the two queues.
 * The function should handle queues of different lengths without inserting 'undefined' into the new one
 * DO NOT access the array inside of any queue, only use 'add', 'remove' and 'peek' methods
 *  Example
    const queueOne = new Queue();
    queueOne.add(1);
    queueOne.add(2);
    const queueTwo = new Queue();
    queueTwo.add('Hi');
    queueTwo.add('There');
    const q = weave(queueOne, queueTwo);
    q.remove()  // 1
    q.remove()  // 'Hi'
    q.remove()  // 2
    q.remove() // 'There' 
*/
namespace Algo
{
  public class Weave
  {
    static public Queue<int> Run(Queue<int> queue1, Queue<int> queue2)
    {
      var weavedQueue = new Queue<int>();
      while (queue1.Count > 0 || queue2.Count > 0)
      {
        if (queue1.Count > 0)
        {
          weavedQueue.Enqueue(queue1.Dequeue());
        }
        if (queue2.Count > 0)
        {
          weavedQueue.Enqueue(queue2.Dequeue());
        }
      }
      return weavedQueue;
    }
  }
}