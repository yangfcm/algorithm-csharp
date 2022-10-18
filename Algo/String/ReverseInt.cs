using System;

namespace Algo.String
{
  /**
	 * Reverse an integer
	 * Example: 521 => 125, -521 => -125, 1200 => 21
	 */
  public class ReverseInt
  {
    public static int Run(int number)
    {
      char[] numberArr = Math.Abs(number).ToString().ToCharArray();
      Array.Reverse(numberArr);
      string reversedStr = new (numberArr);
      return int.Parse(reversedStr) * Math.Sign(number);
    }
  }
}