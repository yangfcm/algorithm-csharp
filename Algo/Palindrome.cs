using System;

namespace Algo
{
	/**
	Return true if a given string is palindrome and false if not
	e.g.!-- "racecar" => true,  "hello" => false
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