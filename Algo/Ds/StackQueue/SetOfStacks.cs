using System.Collections.Generic;

/**
 * Imagine a (literal) stack of plates. If the stack goes too high, it might topple.
 * Therefore, in real life, we would start a new stack when the previous stack exceeds a threshold.
 * Implement a data structure SetOfStacks to mimic this.
 * SetOfStacks should be composed of several stacks and should create a new stack once the previous one exceeds capacity.
 * SetOfStacks.push() and SetOfStacks.pop() should behave identically to a single stack
 * Also implement a function popAt(index) to perform pop operation on a specific sub-stack.
 * Think about the sub-stack is not at full capacity when pop an element from it.
 */
namespace Algo.Ds.StackQueue
{
  public class SetOfStacks
  {
    private int Capacity;
    private List<Stack<dynamic>> Stacks;
    public SetOfStacks(int capacity)
    {
      Capacity = capacity;
      Stacks = new List<Stack<dynamic>>();
    }

    void Push(dynamic data)
    {
      if (Stacks.Count == 0)
      {
        Stacks.Add(new Stack<dynamic>());
      }

      Stack<dynamic> lastSubStack = Stacks[Stacks.Count - 1];
      if (lastSubStack.Count >= Capacity)
      {
        Stacks.Add(new Stack<dynamic>(new[] { data }));
      }
      else
      {
        lastSubStack.Push(data);
      }
    }

    dynamic Pop()
    {
      if (Stacks.Count == 0)
      {
        return null;
      }
      Stack<dynamic> lastSubStack = Stacks[Stacks.Count - 1];
      dynamic popedEl = lastSubStack.Pop();
      if (lastSubStack.Count == 0)
      {
        Stacks.RemoveAt(Stacks.Count - 1);
      }
      return popedEl;
    }

    /**
    * This is a bit trickier to implement, but we can imagine a "rollover" system. If we pop an element from stack
      1, we need to remove the bottom of stack 2 and push it onto stack 1. We then need to rollover from stack 3
      to stack 2, stack 4 to stack 3, etc.
      You could make an argument that, rather than "rolling over;' we should be okay with some stacks not
      being at full capacity. This would improve the time complexity (by a fair amount, with a large number of
      elements), but it might get us into tricky situations later on if someone assumes that all stacks (other than
      the last) operate at full capacity. There's no "right answer" here; you should discuss this trade-off with your
      interviewer.
      In my implementation, the sub-stack will be removed only when it gets empty.
    */
    dynamic PopAt(int index)
    {
      Stack<dynamic> subStack = Stacks[index];
      dynamic popedEl = subStack.Pop();
      if (subStack.Count == 0)
      {
        Stacks.RemoveAt(index);
      }
      return popedEl;
    }
  }
}