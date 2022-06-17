using System;

namespace Algo.String
{
  /**
    * There are three types of edits that can be performed on a string:
    * insert a character, remove a character or replace a character.
    * Given two strings, check if they are one edit(or zero edit) away.
    * Example: pale, ple -> true(remove a character)
    * pale, pales -> true(add a character)
    * pale, bale -> true(replace a character)
    * pale, bake -> false
    */
  public class OneAway
  {
    public static bool Run(string str1, string str2)
    {
      int lengthDiff = Math.Abs(str1.Length - str2.Length);
      // If two strings lengths are different and their difference is bigger than one.
      // Return false early.
      if (lengthDiff > 1) return false;

      // If two strings have the same length,
      // return true if there is one or zero different characters; return false otherwise
      if (lengthDiff == 0)
      {
        int diffCount = 0;
        for (int i = 0; i < str1.Length; i++)
        {
          if (str1[i] != str2[i])
          {
            diffCount++;
          }
          if (diffCount > 1)
          {
            return false;
          }
        }
        return true;
      }

      // If two strings lengths are different and their difference is only one.
      // Remove the first different character from the longer string and check again.
      // If there is still different characters, return false. Otherwise, return true.
      if (lengthDiff == 1)
      {
        string longStr, shortStr, compareStr = "";
        longStr = str1.Length > str2.Length ? str1 : str2;
        shortStr = str1.Length < str2.Length ? str1 : str2;

        // Remove the first different character from longer string.
        for (int i = 0; i < longStr.Length; i++)
        {
          if (i == longStr.Length - 1)  // Consider i exceeds the long str's boundary.
          {
            compareStr = longStr.Remove(i, 1);
          }
          else if (longStr[i] != shortStr[i])
          {
            compareStr = longStr.Remove(i, 1);
            break;
          }
        }


        for (int i = 0; i < compareStr.Length; i++)
        {
          if (compareStr[i] != shortStr[i])
          {
            return false;
          }
        }
        return true;
      }
      return false;
    }
  }
}