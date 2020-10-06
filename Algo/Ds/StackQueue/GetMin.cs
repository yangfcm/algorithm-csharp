using System.Collections.Generic;
using System;

/**
 * Get the minimum element in a stack.
 * (All elements in stack are number) 
*/


namespace Algo.Ds.StackQueue
{
  /**
   * Solution: Use a temporary stack to save the items in original stack and compare each number.
   * The runtime for this solution is O(n) - n is the size of stack.
  */
  public class GetMin
  {
    static public int Run(Stack<int> stack)
    {
      if (stack.Count == 0)
      {
        throw new Exception("Stack is empty.");
      }
      var tempStack = new Stack<int>();
      int min = stack.Peek();
      while (stack.Count > 0)
      {
        var currentItem = stack.Peek();
        if (currentItem < min)
        {
          min = currentItem;
        }
        tempStack.Push(stack.Pop());
      }
      while (tempStack.Count > 0)
      {
        stack.Push(tempStack.Pop());
      }
      return min;
    }
  }
}