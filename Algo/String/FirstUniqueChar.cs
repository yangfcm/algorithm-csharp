using System.Collections.Generic;

namespace Algo.String;

/// <summary>
/// Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
/// </summary>
/// <example>
/// "leetcode" -> 0 (letter l is the first character, whose index is 0)
/// "loveleetcode" -> 2 (letter v)
/// "aabb" -> -1 (No unique character)
/// </example>
/// <source>
/// https://leetcode.com/problems/first-unique-character-in-a-string/description/
/// </source>
public class FirstUniqueChar
{
  /// <summary>
  /// Use a character map(object) to record the number of each character.
  /// Then iterate each character in the string, for the first character whose count is 1, return its index;
  /// otherwise return -1 (no unique character)
  /// </summary>
  /// <param name="str"></param>
  /// <returns>The index of first unique character in a string</returns>
  public static int Solution(string str)
  {
    var charMap = new Dictionary<char, int>();
    foreach (char ch in str)
    {
      if (charMap.ContainsKey(ch) == true)
      {
        charMap[ch]++;
      }
      else
      {
        charMap.Add(ch, 1);
      }
    }

    for (int i = 0; i < str.Length; i++)
    {
      if (charMap[str[i]] == 1) return i;
    }
    return -1;
  }
}