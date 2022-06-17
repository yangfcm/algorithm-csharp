
using System.Collections.Generic;
/**
 * Function countConstruct(target, strs) accepts a target string and an array of strings.
 * The function should return the number of ways that the target can be
 * constructed by concatenating elements of the strs array.
 * You may use elements in strs as many times as needed.
 * Example:
 *   target = 'purple', strs = ['purp', 'p', 'ur', 'le', 'purpl' ]) -> 2
 *   There are two ways of constructing purple: 'purp' + 'le', 'p'+'ur'+'p'+'le', so 2 is our answer.
 */
namespace Algo.Dynamic
{
  public class CountConstruct
  {
    static public int Solution1(string target, string[] strs)
    {
      if(target == "") return 1;
      int count = 0;
      foreach(string str in strs) {
        if(target.IndexOf(str) == 0)
        {
          int countForRest = Solution1(target[str.Length..], strs);
          count += countForRest;
        }
      }
      return count;
    }
    
    static public int Solution2(string target, string[] strs)
    {
      return Solution2(target, strs, new Dictionary<string, int>());
    }

    static public int Solution2(string target, string[] strs, Dictionary<string, int> memo) 
    {
      if(memo.ContainsKey(target)) return memo[target];
      if(target == "") return 1;
      int count = 0;
      foreach(string str in strs) 
      {
        if(target.IndexOf(str) == 0) {
          int countForRest = Solution2(target[str.Length..], strs, memo);
          count += countForRest;
        }
      }
      memo[target] = count;
      return count;
    }

    static public int Solution3(string target, string[] strs)
    {
      var table = new int[target.Length + 1];
      for(int i = 0; i < table.Length; i++) 
      {
        table[i] = 0;
      }
      table[0] = 1;
      for(int i = 0; i < target.Length; i++) 
      {
        foreach(string str in strs) 
        {
          if(i + str.Length <= target.Length && target.Substring(i, str.Length) == str)
          {
            table[i + str.Length] += table[i];
          }
        }
      }
      return table[target.Length];
    }
  }
}