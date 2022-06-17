
using System;
using System.Collections.Generic;
using System.Linq;
/**
 * Given an array of numbers and a target number, return an array containing 
 * any (one) combination of elements that add up to exactly the target sum.
 * If there is no combination that adds up to the target sum, return null.
 * You may use an element of the array as many times as needed.
 * Assum all input numbers are non-negative.
 * It is a follow-up problem to CanSum.
 * Example
 * target = 7, numbers = [2, 3] ->[2, 3, 2]
 * target = 7, numbers = [5, 3, 4, 7] -> [4, 3] Although [7] is also the answer but we just need one.
 * target = 7, numbers = [2, 4] -> null
*/
namespace Algo.Dynamic
{
  public class HowSum
  {
    static public List<int> Solution1(int target, int[] numbers)
    {
      if (target == 0) return new List<int>();  // Empty list, i.e. no pick up from numbers to make 0.
      if (target < 0) return null;  // No combinations
      foreach (int num in numbers)
      {
        int remain = target - num;
        var sums = Solution1(remain, numbers);
        if (sums != null)
        {
          sums.Add(num);
          return sums;
        }
      }
      return null;
    }

    static public List<int> Solution2(int target, int[] numbers)
    {
      if (target == 0) return new List<int>();
      if (target < 0) return null;
      return Solution2(target, numbers, new Dictionary<int, List<int>>());
    }

    static public List<int> Solution2(int target, int[] numbers, Dictionary<int, List<int>> memo)
    {
      if (memo.ContainsKey(target)) return memo[target];
      if (target == 0) return new List<int>();
      if (target < 0) return null;
      foreach (int num in numbers)
      {
        int remain = target - num;
        var sums = Solution2(remain, numbers, memo);
        if (sums != null)
        {
          sums.Add(num);
          memo[target] = sums;
          return sums;
        }
      }
      memo[target] = null;
      return null;
    }

    static public List<int> Solution3(int target, int[] numbers)
    {
      var sumsArr = new List<int>[target + 1];
      for (int i = 0; i < sumsArr.Length; i++)
      {
        sumsArr[i] = null;
      }
      sumsArr[0] = new List<int>();
      for (int i = 0; i <= target; i++)
      {
        if (sumsArr[i] != null)
        {
          foreach (int num in numbers)
          {
            if (i + num <= target)
            {
              var newSums = new List<int>(sumsArr[i])
              {
                num
              };
              sumsArr[i + num] = newSums;
              // sumsArr[i].ForEach(Console.WriteLine);
            }
          }
        }
      }
      return sumsArr[target];
    }
  }
}