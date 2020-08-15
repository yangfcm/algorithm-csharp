using System;

namespace Algo.String
{

  /**
	 * Given a string, remove the vowels from the string
	 * and return the string without vowels
	 */
  public class RemoveVowels
  {
    static public string Run(string str)
    {
      string strWithoutVowel = "";
      char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
      for (int i = 0; i < str.Length; i++)
      {
        if (Array.IndexOf(vowels, str[i]) < 0)
        {
          strWithoutVowel += str[i];
        }
      }
      return strWithoutVowel;
    }
  }
}