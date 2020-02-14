using System;

namespace Algo
{
	/**
	Return the number of vowels used in a string
	e.g.!-- "apple" => 2
	"why?" => 0
	 */
	public class Vowels
	{
		static public int Run(string str)
		{
			var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
			int countVowels = 0;
			for (int i = 0; i < str.Length; i++)
			{
				if (Array.IndexOf(vowels, str[i]) != -1)
				{
					countVowels++;
				}
			}
			return countVowels;
		}
	}
}