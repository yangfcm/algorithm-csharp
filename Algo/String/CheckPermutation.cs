using System;
using System.Collections.Generic;

namespace Algo.String
{
  /**
  * Given two strings, check if one is a permutation of the other.
  */
  public class CheckPermutation
  {
    static public bool Run(string str1, string str2)
    {
      var charMapForStr1 = new Dictionary<char, int>();
      var charMapForStr2 = new Dictionary<char, int>();
      foreach (char ch in str1)
      {
        if (charMapForStr1.ContainsKey(ch) == true)
        {
          charMapForStr1[ch]++;
        }
        else
        {
          charMapForStr1.Add(ch, 0);
        }
      }
      foreach (char ch in str2)
      {
        if (charMapForStr2.ContainsKey(ch) == true)
        {
          charMapForStr2[ch]++;
        }
        else
        {
          charMapForStr2.Add(ch, 0);
        }
      }
      foreach (KeyValuePair<char, int> kvp in charMapForStr1)
      {
        if (charMapForStr2.ContainsKey(kvp.Key) == false || charMapForStr1[kvp.Key] != charMapForStr2[kvp.Key])
        {
          return false;
        }
      }
      return true;
    }
  }
}