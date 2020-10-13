/**
 * Given a string, check if it is a permutation of a palindrome.
 * Check is case insensitive.
 * e.g. Test TactCoa should return true because it has permutations: "tacocat", "atcocta", which are palindromes.
 * Of course, it is impossible to generate all permutations of a string and test if it is a palindrome one by one.
 * To solve this, create a character map, with key is the characters of the string and value is the occurence of the character.
 * If the string is a permutation of a palindrome, it must have at most one character that has appeared in the string odd-number times.
 */
using System.Collections.Generic;

namespace Algo.String
{
  public class CheckPalindromePermutation
  {
    public static bool Run(string str)
    {
      var charMap = new Dictionary<char, int>();
      string lStr = str.ToLower();
      foreach (char ch in lStr)
      {
        if (ch == ' ') continue;
        if (charMap.ContainsKey(ch) == true)
        {
          charMap[ch]++;
        }
        else
        {
          charMap.Add(ch, 1);
        }
      }
      int countOddTimes = 0;
      foreach (KeyValuePair<char, int> kvp in charMap)
      {
        if (kvp.Value % 2 != 0)
        {
          countOddTimes++;
        }
        if (countOddTimes > 1)
        {
          return false;
        }
      }
      return true;
    }
  }
}