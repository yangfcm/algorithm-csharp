using System;
using System.Text.RegularExpressions;

namespace Algo.String

/**
  Check to see if two provided strings are anagrams of each other.
  One string is an anagram of the other if it uses the same characters in the same quantity.
  Only conside characters, not spaces or punctuation.
  Conside capital letters to be the same as lower case
  Example: anagrams('rail safety', 'fairy tales') --> true
    anagrams('RAIL! SAFETY!', 'fairy tales')  --> true
    angagrams('Hi, there', 'Bye, there') --> false
 */
{
  public class Anagrams
  {
    static public bool Main(string str1, string str2)
    {
      string sortedStr1 = Alphabetize(CleanString(str1));
      string sortedStr2 = Alphabetize(CleanString(str2));
      return sortedStr1 == sortedStr2;
    }

    /**
			Remove spaces and punctuations of a string and convert it to lowercase
		*/
    private static string CleanString(string str)
    {
      string pattern = @"\W";
      string clearedStr = Regex.Replace(str, pattern, "");
      return clearedStr.ToLower();
    }

    /**
		 Sort a string on alphabetic order
		 e.g. 'sad' -> 'ads'
		 */
    private static string Alphabetize(string str)
    {
      char[] arr = str.ToCharArray();
      Array.Sort(arr);
      // Console.WriteLine(new string(arr));
      return new string(arr);
    }
  }
}