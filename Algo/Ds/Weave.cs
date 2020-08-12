using System;
using System.Collections.Generic;

/*
  * Weave: Receive two queues as arguments and combines the contents of each into a new, third queue.
 * The new queue should contain the alterating of the two queues.
 * The function should handle queues of different lengths without inserting 'undefined' into the new one
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