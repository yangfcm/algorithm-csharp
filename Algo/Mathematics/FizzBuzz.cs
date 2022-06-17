using System;

namespace Algo.Mathematics
{
  /**
	Given a number N, print the numbers from 1 to N.
	But for multiples of 3 print 'fizz' instead of the number,
	for multiples of 5, print 'buzz',
	for numbers which are multiples of both 3 and 5, print 'fizzbuzz'
	Example: 
    fizzbuzz(5);
    1
    2
    fizz
    4
    buzz
	 */
  public class FizzBuzz
  {
    static public void Run(int n)
    {
      for (int i = 1; i <= n; i++)
      {
        if (i % 15 == 0)
        {
          Console.WriteLine("fizzbuzz");
        }
        else if (i % 3 == 0)
        {
          Console.WriteLine("fizz");
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine("buzz");
        }
        else
        {
          Console.WriteLine(i);
        }
      }
    }
  }
}