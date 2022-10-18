using System.Collections.Generic;

namespace Algo.Mathematics
/** 
 * Return the n-th number in the fibonacci series 
 */
{
  public class Fibonacci
  {
    static public long RunSolution1(int n)
    {
      if (n < 2)
      {
        return n;
      }
      return RunSolution1(n - 1) + RunSolution1(n - 2);
    }

    static public long RunSolution2(int n)
    {
      List<int> fiboArr = new() { 0, 1 };
      for (int i = 2; i <= n; i++)
      {
        int a = fiboArr[i - 1]; // The previous number
        int b = fiboArr[i - 2]; // The previous and previous number
        fiboArr.Add(a + b);
      }
      return fiboArr[n];
    }

    static public long RunSolution3(int n, long ac1 = 1, long ac2 = 1)
    {
      if (n <= 2)
      {
        return ac2;
      }
      return RunSolution3(n - 1, ac2, ac1 + ac2);
    }
  }
}