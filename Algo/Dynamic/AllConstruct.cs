
using System;
using System.Collections.Generic;
using System.Linq;
/**
 * Function allConstruct(target, strs) accepts a target string and an array of strings.
 * The function should return a list of arrays containing all of the ways that the target can be
 * constructed by concatenating elements of the strs array.
 * You may use elements in strs as many times as needed.
 * Example:
 *  target = 'purple' strs = ['purp', 'p', 'ur', 'le', 'purpl' ] ->  [['purp','le'], ['p','ur','p','le']
 */
namespace Algo.Dynamic 
{
  public class AllConstruct
  {
    static public List<List<string>> Solution1(string target, string[] strs)
    {
      if(target == "") {
        return new List<List<string>> { new List<string>() }; 
      }
      var result = new List<List<string>>();  
      foreach(string str in strs) 
      {
        if(target.IndexOf(str) == 0) 
        {
          var suffix = target[str.Length..];
          var suffixWays = Solution1(suffix, strs);
          foreach(List<string> way in suffixWays) {
            way.Insert(0, str);
            result.Add(way);
          }
        }
      }
      return result;
    }

    static public List<List<string>> Solution2(string target, string[] strs)
    {
      return Solution2(target, strs, new Dictionary<string, List<List<string>>>());
    }

    static public List<List<string>> Solution2(string target, string[] strs, Dictionary<string, List<List<string>>> memo)
    {
      if(memo.ContainsKey(target)) return memo[target];
      if(target == "") return new List<List<string>> { new List<string>() };
      var result = new List<List<string>>();
      foreach(string s in strs) 
      {
        if(target.IndexOf(s) == 0) 
        {
          var suffix = target[s.Length..];
          var suffixWays = Solution2(suffix, strs, memo);
          foreach(List<string> way in suffixWays) {
            way.Insert(0, s);
            result.Add(way);
          }
        }
      }

      // Here is how to deep clone the 2-D list result and assign its value to memo map(dictionary).
      // If you directly assign values using result, the change to result will also be reflected in memo dictionary
      // so that it will cause wrong memo and further cause wrong results.
      // It took me a whole night plus half day to debug it.
      var copyResult = result.Select(sub => new List<string>(sub)).ToList();
      memo[target] = copyResult;
      return result;
    }

    static public List<List<string>> Solution3(string target, string[] strs)
    {
      var table = new List<List<string>>[target.Length + 1];
      for (int i = 0; i < table.Length; i++) 
      {
        table[i] = new List<List<string>>();
      }
      table[0].Add(new List<string>());
      for (int i = 0; i <= target.Length; i++) 
      {
        foreach(string str in strs) 
        {
          if(i + str.Length <= target.Length && target.Substring(i, str.Length) == str) 
          {
            foreach(List<string> sub in table[i])
            {
              var newSub = new List<string>(sub)
              {
                str
              };
              table[i + str.Length].Add(newSub);
            }
          }
        }
      }
      return table[target.Length];
    }
  }
} 