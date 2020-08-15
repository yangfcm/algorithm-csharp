using System.Collections.Generic;

namespace Algo.String
{
  /**
	Give a string, return the character that is most commonly used in the string
	e.g.!-- 'abccccdd' => 'c'
	 */
  public class MaxChar
  {
    static public char Run(string str)
    {
      var charMap = new Dictionary<char, int>();
      int max = 0; // The count of the most-frequently-used character of a string
      char maxChar = str[0];    // The character that frequently appears in a string.

      for (int i = 0; i < str.Length; i++)
      {
        if (charMap.ContainsKey(str[i]) == true)
        {
          charMap[str[i]]++;
        }
        else
        {
          charMap.Add(str[i], 0);
        }
      }

      foreach (KeyValuePair<char, int> kvp in charMap)
      {
        if (kvp.Value > max)
        {
          max = kvp.Value;
          maxChar = kvp.Key;
        }
      }
      return maxChar;
    }
  }
}