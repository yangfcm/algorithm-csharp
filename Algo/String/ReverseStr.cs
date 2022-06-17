using System;

namespace Algo.String
{
  /**
	 * Reverse a string
	 * Example: "hello" => "olleh"
	 */
  public class ReverseStr
  {
    public static string Run(string str)
    {
      char[] charArray = str.ToCharArray();
      Array.Reverse(charArray);
      return new string(charArray);
    }
  }
}