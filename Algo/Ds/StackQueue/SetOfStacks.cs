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
  public class SetOfStacks<T>
  {
    readonly private int Capacity;
    readonly private List<Stack<T>> Stacks;
    public SetOfStacks(int capacity)
    {
      Capacity = capacity;
      Stacks = new List<Stack<T>>();
    }

    public void Push(T data)
    {
      if (Stacks.Count == 0)
      {
        Stacks.Add(new Stack<T>());
      }

      Stack<T> lastSubStack = Stacks[^1];
      if (lastSubStack.Count >= Capacity)
      {
        Stacks.Add(new Stack<T>(new[] { data }));
      }
      else
      {
        lastSubStack.Push(data);
      }
    }

    public T Pop()
    {
      if (Stacks.Count == 0)
      {
        return default;
      }
      Stack<T> lastSubStack = Stacks[^1];
      T popedEl = lastSubStack.Pop();
      if (lastSubStack.Count == 0)  // If the stack is empty, remove this stack.
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
    public T PopAt(int index)
    {
      Stack<T> subStack = Stacks[index];
      T popedEl = subStack.Pop();
      if (subStack.Count == 0)
      {
        Stacks.RemoveAt(index);
      }
      return popedEl;
    }
  }
}