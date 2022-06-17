
using System.Collections.Generic;

namespace Algo.String
{
  /**
    * Given a string, determine if it has all unique characters.
    * Solution: Create a character map(object) to record the count each character of the string.
    * Then iterate the object to see if there is a character with the count > 1
    */
  public class IsUnique
  {
    public static bool Run(string str)
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
      foreach (KeyValuePair<char, int> kvp in charMap)
      {
        if (kvp.Value > 1)
        {
          return false;
        }
      }
      return true;
    }
  }
}