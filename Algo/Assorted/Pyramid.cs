using System;

namespace Algo.Assorted
{
/**
 * Write a function that accepts a position number and print a pyramid shape with N levels,
 * using # character and space(s) on both left and right side.
 * Example
 *   pyramid(1)
 *       '#'
 *   pyramid(2)
 *       ' # '
 *       '###'
 *   pyramid(3)
 *       '  #  '
 *       ' ### '
 *       '#####'
 */
  public class Pyramid
  {
    public static void Run(int n)
    {
      for (int i = 1; i <= n; i++)
      {
        var level = "";
        for (int j = 1; j <= (2 * n - 1); j++)
        {
          if (j >= (n - i + 1) && j <= (n + i - 1))
          {
            level += "#";
          }
          else
          {
            level += " ";
          }
        }
        Console.WriteLine(level);
      }
    }
  }
}