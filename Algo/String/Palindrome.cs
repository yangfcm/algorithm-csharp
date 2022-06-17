using System;

namespace Algo.String
{
  /**
   * Return true if a given string is palindrome and false if not
   * Example: "racecar" => true,  "hello" => false
	 */
  public class Palindrome
  {
    public static bool Run(string str)
    {
      char[] charArray = str.ToCharArray();
      Array.Reverse(charArray);
      var reversedStr = new string(charArray);
      return reversedStr == str;
    }
  }
}