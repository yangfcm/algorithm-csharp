using System.Collections.Generic;

/**
* Given an array of numbers and a target number, return true or false to indicate 
* whether or not it is possible to generate the target sum using numbers from the array.
* You may use an element of the array as many times as needed.
* Assum all input numbers are non-negative.
*/
namespace Algo.Dynamic
{
  public class CanSum
  {
    static public bool Solution1(int target, int[] numbers)
    {
      if (target == 0) return true;
      if (target < 0) return false;
      foreach (int n in numbers)
      {
        int remain = target - n;
        if (Solution1(remain, numbers)) return true;
      }
      return false;
    }

    static public bool Solution2(int target, int[] numbers)
    {
      if (target == 0) return true;
      if (target < 0) return false;
      return Solution2(target, numbers, new Dictionary<int, bool>());
    }

    static public bool Solution2(int target, int[] numbers, Dictionary<int, bool> memo)
    {
      if (target == 0) return true;
      if (target < 0) return false;
      if (memo.ContainsKey(target)) return memo[target];
      foreach (int n in numbers)
      {
        int remain = target - n;
        if (Solution2(remain, numbers, memo))
        {
          memo[target] = true;
          return true;
        }
      }
      memo[target] = false;
      return false;
    }

    static public bool Solution3(int target, int[] numbers)
    {
      var targetArr = new bool[target + 1];
      targetArr[0] = true;
      for (int i = 0; i <= target; i++)
      {
        if (targetArr[i] == true)
        {
          foreach (int n in numbers)
          {
            if (i + n <= target)
            {
              targetArr[i + n] = true;
            }
          }
        }
      }
      return targetArr[target];
    }
  }
}