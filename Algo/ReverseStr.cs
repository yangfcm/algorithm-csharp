using System;

namespace Algo
{
	/**
	Reverse a string
	e.g.!-- "hello" => "olleh"
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