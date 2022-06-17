using System.Collections.Generic;

/**
 * Given an array of numbers and a target number, return an array containing 
 * the shortest combination of numbers that add up to exactly the target sum.
 * If there is no combination that adds up to the target sum, return null.
 * You may use an element of the array as many times as needed.
 * Assum all input numbers are non-negative.
 * It is a follow-up problem to CanSum and HowSum.
 * Example
 * target = 7, numbers = [2, 3] ->[2, 3, 2]
 * target = 7, numbers = [5, 3, 4, 7] -> [7] There are two possible combinations: [3, 4] and [7] but [7] has only one element, which is the answer.
*/
namespace Algo.Dynamic 
{
  public class BestSum
  {
    static public List<int> Solution1(int target, int[] numbers)
    {
      if(target == 0 ) return new List<int>();
      if(target < 0) return null;
  
      List<int> shortestCombination = null;

      foreach (int num in numbers)
      {
        int remain = target - num;
        var sums = Solution1(remain, numbers);
        if (sums != null)
        {
          sums.Add(num);
          if(shortestCombination is null || sums.Count < shortestCombination.Count) {
            shortestCombination = sums;
          }
        }
      }
      return shortestCombination;
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
      
      List<int> shortestCombination = null;

      foreach (int num in numbers)
      {
        int remain = target - num;
        var sums = Solution2(remain, numbers, memo);
        if (sums != null)
        {
          sums.Add(num);
          if(shortestCombination is null || sums.Count < shortestCombination.Count) {
            shortestCombination = sums;
          } 
        }
      }
      memo[target] = shortestCombination;
      return shortestCombination;
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
              if(sumsArr[i + num] is null || newSums.Count < sumsArr[i+ num].Count) {
                sumsArr[i + num] = newSums;
              }
            }
          }
        }
      }
      return sumsArr[target];
    }
  }
}