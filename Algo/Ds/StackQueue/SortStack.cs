using System.Collections.Generic;

/**
 * Sort a stack such that the smallest item are on the top.
 * You can use an additional temporary stack, but you cannot copy the elements into any other data structure, such as array.
 */
namespace Algo.Ds.StackQueue
{
  public class SortStack
  {
    static public void Run(Stack<int> stack)
    {
      Stack<int> sortedStack = new ();
      while (stack.Count > 0)
      {
        int currentEl = stack.Pop();
        if (sortedStack.Count == 0)
        {
          sortedStack.Push(currentEl);
        }
        else
        {
          while (sortedStack.Count > 0 && sortedStack.Peek() > currentEl)
          {
            stack.Push(sortedStack.Pop());
          }
          sortedStack.Push(currentEl);
        }
      }
      while (sortedStack.Count > 0)
      {
        stack.Push(sortedStack.Pop());
      }
    }
  }
}