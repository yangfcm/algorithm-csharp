

using System;
using System.Collections.Generic;
/**
* Write a function canConstruct(target, strs) that accepts a target string and an array of strings.
* The function should return a boolean indicating whether or not the target can be
* constructed by concatenating elements of the strs array.
* You may use elements in strs as many times as needed.
* e.g. You can use elements in ["ab", "abc", "cd", "def", "abcd"] to construct string "abcdef" ("abc" + "def"), so function returns true
* But there is no way to construct "abcef", so function returns false.
*/
namespace Algo.Dynamic
 {
    public class CanConstruct
    {
      static public bool Solution1(string target, string[] strs) {
        if(target == "") return true;
        foreach(string str in strs) 
        {
          if(target.IndexOf(str) == 0) {
            string suffix = target[str.Length..];
            if(Solution1(suffix, strs) == true) {
              return true;
            }
          }
        }
        return false;
      }

      static public bool Solution2(string target, string[] strs) 
      {
        return Solution2(target, strs, new Dictionary<string, bool>());
      }

      static public bool Solution2(string target, string[] strs, Dictionary<string, bool> memo) 
      {
        if(memo.ContainsKey(target)) return memo[target];
        if(target == "") return true;
        foreach(string str in strs) 
        {
          if(target.IndexOf(str) == 0) {
            string suffix = target[str.Length..];
            if(Solution2(suffix, strs, memo) == true) 
            {
              memo[target] = true;
              return true;
            }
          }
        }
        memo[target] = false;
        return false;
      }

      static public bool Solution3(string target, string[] strs) 
      {
        var table = new bool[target.Length + 1];
        table[0] = true;
        for(int i = 0; i < table.Length; i++) {
          if(table[i] == true) {
            foreach(string str in strs) {
              if(i + str.Length <= target.Length && target.Substring(i, str.Length) == str) {
                table[i+ str.Length] = true;
              }
            }
          }
        }
        return table[target.Length];
      }
   }
 }