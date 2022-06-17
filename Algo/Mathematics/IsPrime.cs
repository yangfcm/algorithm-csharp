using System;

namespace Algo.Mathematics
{
  /**
	 * Return true or false, indicating whether a given number is a prime number.
	 */
  public class IsPrime
  {
    static public bool Run(int num)
    {
      if (num < 2)
      {
        return false;
      }
      var maxDivisor = Math.Ceiling(Math.Sqrt(num));
      for (int divisor = 2; divisor <= maxDivisor; divisor++)
      {
        if (num % divisor == 0 && num != divisor)
        {
          return false;
        }
      }
      return true;
    }
  }
}