using System;

namespace Algo.String
{
  /**
	Reverse an integer
	e.g.!-- 521 => 125, -521 => -125, 1200 => 21
	 */
  public class ReverseInt
  {
    public static int Run(int number)
    {
      char[] numberArr = Math.Abs(number).ToString().ToCharArray();
      Array.Reverse(numberArr);
      string reversedStr = new string(numberArr);
      return int.Parse(reversedStr) * Math.Sign(number);
    }
  }
}