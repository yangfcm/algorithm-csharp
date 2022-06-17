using System;
using System.Collections.Generic;

namespace Algo.String
{
  /**  
   * Given two strings, str1 and str2, determine the minimum number of characters deletions
   * required to make str1 and str2 anagrams. The strings str1 and str2 consist of lowercase English letters [a-z].
   * Example: ('abcd','dcefg') -> 5
   * delete a, b from 'abcd' and delete e,f,g from 'dcefg' to make 'cd' and 'dc', which are anagrams. That is 5 deletions.
   */
  public class MakeAnagrams
  {
    private const string LETTERS = "abcdefghijklmnopqrstuvwxyz";

    static public int Solution(string str1, string str2)
    {
      var charMap1 = new Dictionary<char, int>();
      var charMap2 = new Dictionary<char, int>();
      int deletions = 0;
      foreach (char ch in str1)
      {
        if (charMap1.ContainsKey(ch) == true)
        {
          charMap1[ch]++;
        }
        else
        {
          charMap1.Add(ch, 1);
        }
      }
      foreach (char ch in str2)
      {
        if (charMap2.ContainsKey(ch) == true)
        {
          charMap2[ch]++;
        }
        else
        {
          charMap2.Add(ch, 1);
        }
      }
      foreach (char l in LETTERS)
      {
        int count1 = charMap1.ContainsKey(l) ? charMap1[l] : 0;
        int count2 = charMap2.ContainsKey(l) ? charMap2[l] : 0;
        deletions += Math.Abs(count1 - count2);
      }
      return deletions;
    }

  }
}